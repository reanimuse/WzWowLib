using WzWoWLib;
using WzWoWLib.Accounts;
using Xunit;

namespace Tests.WzWowLib.Account
{
    public class WzAccountTests : TestBase
    {
        [Fact]
        public void WzAccount_KnownAccount()
        {
            var main = new WzWoWLibMain(_testPath.ValidPath);
            Assert.NotNull(main);

            var accounts = main.GetAccounts();
            Assert.NotNull(accounts);

            Assert.True(accounts.Count > 0, "Accounts should always contain at least one account");

            WzAccount known = accounts.FirstOrDefault(x => x.Name == "BOBSACCT");
            Assert.NotNull(known);
        }
    }
}
