using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WzWoWLib;
using WzWoWLib.Accounts;
using System.Linq;

namespace Tests.WzWowLib.Account
{
    [TestClass]
    public class WzAccountTests : TestBase
    {
        [TestMethod]
        [TestCategory("Accounts")]
        public void WzAccount_KnownAccount()
        {
            var main = new WzWoWLibMain(_testPath.ValidPath);
            Assert.IsNotNull(main, "library object was unexpectedly null");

            var accounts = main.GetAccounts();
            Assert.IsNotNull(accounts, "accounts should not be null");

            Assert.IsTrue(accounts.Count > 0, "Accounts should always contain at least one account");

            WzAccount known = accounts.FirstOrDefault(x => x.Name == "BOBSACCT");
            Assert.IsNotNull(known, "known account 'BOBSACCT' was not found");
        }
    }
}
