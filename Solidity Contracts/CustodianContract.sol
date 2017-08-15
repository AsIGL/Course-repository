pragma solidity ^0.4.0;


contract CustodianContract {

    address client;
    // address receiver;
    bool public _switch = false;


    function CustodianContract(){
        client=msg.sender;
    }

    modifier ifClient() {
        if(msg.sender != client){
            throw;
        }
        _;
    }

    function depositFunds() payable{

    }

    function windrawFunds(uint amount) ifClient{
        if(client.send(amount)){
            _switch = true;
        }
        else
        {
            _switch = false;
        }
    }

    function getter() constant returns(uint){
        return this.balance;
    }

    //function returnSender() constant returns(address){
    //    return client;
    //}
}
