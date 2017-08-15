pragma solidity ^0.4.0;


contract PayableContract {
    function PayableContract(){

    }

    function receiveFunds() payable{

    }

    function getter() constant returns(uint256){
        return this.balance;
    }
}
