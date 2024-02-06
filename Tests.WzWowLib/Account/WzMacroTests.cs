using WzWoWLib.Accounts;
using Xunit;

namespace Tests.WzWowLib.Account
{
    public class WzMacroTests
    {
        [Fact]
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

            Assert.NotNull(macro);

            Assert.True(!string.IsNullOrWhiteSpace(macro.Name), "Macro name is missing");
            Assert.True(macro.Name == "Horde Mount", "Macro name is incorrect");

            Assert.True(!string.IsNullOrWhiteSpace(macro.IconName), "Macro icon name is missing");
            Assert.True(macro.IconName == "INV_MISC_QUESTIONMARK", "Macro icon name is incorrect");

            Assert.True(macro.Lines.Length == 3, "incorrect number of macro lines");
        }
    }
}
