using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Tiger_2._0;

namespace TestProjectTiger
{
    [TestClass]
    public class TestProjectTiger
    {
        [TestMethod]
        [TestCategory("CreateNewBankAccount Method")]
        [Description("The purpose of this test is to see if a bank account can be created.")]
        [Owner("Daniel")]
        public void Create_Bank_Account_And_Test_If_Bank_Account_Now_Exists()
        {
            // Arrange
            Customer testCus = new Customer()
            {
            };

            testCus.CreateNewBankAccount("TEST", 0, "GBP");

            // Act
            var expected = true;
            var actual = testCus.listOfBankAccounts.Exists(x => x.AccountName == "TEST");

            // Assert
            Assert.AreEqual(expected, actual);

            if (expected == true && actual == true)
            {
                System.Console.WriteLine("Test successful! A bank account was successfully created!");
            }
        }

        [TestMethod]
        [TestCategory("LoginMenu Method")]
        [Description("The purpose of this test is to see if an administrator can log into the system.")]
        [Owner("Daniel")]
        public void Create_An_Admin_Try_To_Log_Into_The_System()
        {
            // Arrange
            LoggingIntoBankSystem testAdmin = new LoggingIntoBankSystem()
            {
            };

            // Act
            var expected = true;
            var actual = testAdmin.LoginMenu("TEST", 5, true, 5, "TEST");

            // Assert
            Assert.AreEqual(expected, actual);

            if (expected == true && actual == true)
            {
                System.Console.WriteLine("Test successful! An admin was created and was able to log into the system!");
            }
        }

        [TestMethod]
        [TestCategory("TransferMoneyToAnotherAccount Method")]
        [Description("The purpose of this test is to see if money is successfully transferred from the first account to the second account.")]
        [Owner("Daniel")]
        public void Create_2_Bank_Accounts_And_Then_Transfer_100_SEK_From_One_Account_To_The_Other_Account()
        {
            // Arrange
            Customer testCus = new Customer()
            {
            };

            testCus.CreateNewBankAccount("TEST1", 100, "SEK");
            testCus.CreateNewBankAccount("TEST2", 200, "SEK");

            testCus.TransferMoneyToAnotherAccount(0, 1, 100);

            // Act
            var expected = true;
            var actual = testCus.listOfBankAccounts[0].AccountBalance == 0 && testCus.listOfBankAccounts[1].AccountBalance == 300;

            // Assert
            Assert.AreEqual(expected, actual);

            if (expected == true && actual == true)
            {
                System.Console.WriteLine("Test successful! 100 SEK was successfully transferred from the first account to the second account!");
            }
        }
    }
}
