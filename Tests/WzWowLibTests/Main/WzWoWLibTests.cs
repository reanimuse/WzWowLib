using WzWoWLib;
using Xunit;

namespace Tests.WzWowLib
{
    public class WzWoWLibTests : TestBase
    {
        [Fact]
        public void WzWoWLib_BadParams()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var main = new WzWoWLibMain(null);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var main = new WzWoWLibMain("");
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var main = new WzWoWLibMain("     ");
            });

            Assert.Throws<DirectoryNotFoundException>(() =>
            {
                var main = new WzWoWLibMain(_testPath.PathDoesNotExist);
            });


            Assert.Throws<DirectoryNotFoundException>(() =>
            {
                var main = new WzWoWLibMain(_testPath.EmptyFolder);
            });


            Assert.Throws<FileNotFoundException>(() =>
            {
                var main = new WzWoWLibMain(_testPath.ValidPathsNoEXE);
            });

            Assert.Throws<FileNotFoundException>(() =>
            {
                var main = new WzWoWLibMain(_testPath.ValidPathsNoEXE);
            });
        }


        [Fact]
        public void WzWoWLib_validFolder()
        {
            var main = new WzWoWLibMain(_testPath.ValidPath);
            Assert.NotNull(main);

            Assert.NotNull(main.WoWFolder);
            Assert.True(main.WoWFolder.Exists, "WoWFolder is specified but does not exist");

            Assert.NotNull(main.InstalledWoWVersion);

            Assert.True(main.InstalledWoWVersion.Major > 0, "Major version must be greater than zero");
            Assert.True(main.InstalledWoWVersion.Minor >= 0, "Minor version must be greater or equal to zero");
            Assert.True(main.InstalledWoWVersion.Revision >= 0, "Revision version must be greater or equal to zero");
            Assert.True(main.InstalledWoWVersion.Build >= 0, "Build version must be greater or equal to zero");
        }
    }
}
