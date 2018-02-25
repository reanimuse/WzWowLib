using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WzWoWLib.Accounts;

namespace Tests.WzWowLib.Account
{
    [TestClass]
    public class WzMacroTests
    {
        [TestMethod]
        [TestCategory("Macro")]
        public void macroTest_FixedStrings()
        {
            var lines = new string[] {
                "VER 3 0000000000000034 \"Horde Mount\" \"INV_MISC_QUESTIONMARK\"",
                "#showtooltip",
                "/dismount [mounted]",
                "/cast [mod:alt] Grand Expedition Yak; [mod:ctrl][swimming] Azure Water Strider;  [flyable,mod,noswimming] X-53 Touring Rocket; [mod:shift] Core Hound;  [flyable,nomod] Sandstone Drak; Warlord's Deathwheel",
                "END"
                };

            var macro = WzMacro.Parse(lines, 0);

            Assert.IsNotNull(macro, "macro should not be null");

            Assert.IsTrue(!string.IsNullOrWhiteSpace(macro.Name), "Macro name is missing");
            Assert.IsTrue(macro.Name == "Horde Mount", "Macro name is incorrect");

            Assert.IsTrue(!string.IsNullOrWhiteSpace(macro.IconName), "Macro icon name is missing");
            Assert.IsTrue(macro.IconName == "INV_MISC_QUESTIONMARK", "Macro icon name is incorrect");

            Assert.IsTrue(macro.Lines.Length == 3, "incorrect number of macro lines");
        }
    }
}
