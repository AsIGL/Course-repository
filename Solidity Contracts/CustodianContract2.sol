pragma solidity ^0.4.0;


contract CustodianContractUp {

    address client;
    // address receiver;
    bool public _switch = false;

    event updateStatus(string _msg, uint _amount);
    event userStatus(string _msg, address user, uint amount);

    function CustodianContractUp(){
        client=msg.sender;
    }

    modifier ifClient() {
        if(msg.sender != client){
            throw;
        }
        _;
    }

    function depositFunds() payable{
        updateStatus('User Deposited some money', msg.value);
        userStatus('User Status is ', msg.sender, msg.value);
    }

    function windrawFunds(uint amount) ifClient{
        userStatus('Ether withdrawn', msg.sender, amount);

        if(client.send(amount)){
            _switch = true;
        }
        else
        {
            _switch = false;
        }
    }

    function getter() constant returns(uint, address){
        return (this.balance, client);
    }

}
