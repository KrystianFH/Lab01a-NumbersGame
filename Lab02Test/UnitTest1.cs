using System;
using Xunit;
using UnitTesting;

namespace Lab02Test
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalanceTest()
        {
            int balance = 5000;

            decimal output = Program.ViewBalance();

            Assert.Equal(balance, output);
        }

        [Fact]

        public void WithdrawTest()
        {

            int balance = 5000;
            int withdrawAmt = 500;
            int newBalance = 4500;

            decimal output = Program.Withdraw();
            Assert.Equal(newBalance, output);

        }

        [Fact]

        public void DepositTest()
        {
            int balance = 5000;
            int depositAmt = 500;
            int newBalance = 5500;

            decimal output = Program.Deposit();
            Assert.Equal(newBalance, output);

        }
    }
}
