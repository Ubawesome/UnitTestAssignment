using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankLib;

namespace UnitTestAssignment
{

    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void testDefaultCon()
        {
            BankAccount account = new BankAccount();

            Assert.AreEqual(0, account.getBalance());
        }

        [TestMethod]
        public void testConstructor()
        {
            BankAccount account = new BankAccount(500);

            Assert.AreEqual(500, account.getBalance());
        }

        [TestMethod]
        public void testDeposit()
        {
            BankAccount account = new BankAccount();

            Assert.AreEqual(true, account.deposit(500));

            Assert.AreEqual(500, account.getBalance());

            Assert.AreEqual(false, account.deposit(-500));

            Assert.AreEqual(false, account.deposit(0));

            Assert.AreEqual(500, account.getBalance());
        }

        [TestMethod]
        public void testWithdraw()
        {
            BankAccount account = new BankAccount(500);

            Assert.AreEqual(true, account.withdraw(500));

            Assert.AreEqual(0, account.getBalance());

            Assert.AreEqual(false, account.withdraw(500));

            Assert.AreEqual(false, account.withdraw(-500));

            Assert.AreEqual(false, account.withdraw(0));

            Assert.AreEqual(0, account.getBalance());

        }
    }
}
