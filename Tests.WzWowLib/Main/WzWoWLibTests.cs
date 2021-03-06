﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WzWoWLib;

namespace Tests.WzWowLib
{
    [TestClass]
    public class WzWoWLibTests : TestBase
    {
        [TestMethod]
        [TestCategory("Library Initialization")]
        public void WzWoWLib_BadParams()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var main = new WzWoWLibMain(null);
            }, "Failed with Null");

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var main = new WzWoWLibMain("");
            }, "Failed with empty string");

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var main = new WzWoWLibMain("     ");
            }, "Failed with whitespace");

            Assert.ThrowsException<DirectoryNotFoundException>(() =>
            {
                var main = new WzWoWLibMain(_testPath.PathDoesNotExist);
            }, "Failed with invalid directory");


            Assert.ThrowsException<DirectoryNotFoundException>(() =>
            {
                var main = new WzWoWLibMain(_testPath.EmptyFolder);
            }, "Failed with no Addons directory");


            Assert.ThrowsException<FileNotFoundException>(() =>
            {
                var main = new WzWoWLibMain(_testPath.ValidPathsNoEXE);
            }, "Failed with valid directory no EXE");

            Assert.ThrowsException<FileNotFoundException>(() =>
            {
                var main = new WzWoWLibMain(_testPath.ValidPathsNoEXE);
            }, "Failed with valid directory no EXE trailing slash");



        }


        [TestMethod]
        [TestCategory("Library Initialization")]
        public void WzWoWLib_validFolder()
        {
            var main = new WzWoWLibMain(_testPath.ValidPath);
            Assert.IsNotNull(main, "Object was unexpectedly null");

            Assert.IsNotNull(main.WoWFolder, "WoWFolder should not be null");
            Assert.IsTrue(main.WoWFolder.Exists, "WoWFolder is specified but does not exist");

            Assert.IsNotNull(main.InstalledWoWVersion, "WoW Version should not be null");

            Assert.IsTrue(main.InstalledWoWVersion.Major > 0, "Major version must be greater than zero");
            Assert.IsTrue(main.InstalledWoWVersion.Minor >= 0, "Minor version must be greater or equal to zero");
            Assert.IsTrue(main.InstalledWoWVersion.Revision >= 0, "Revision version must be greater or equal to zero");
            Assert.IsTrue(main.InstalledWoWVersion.Build >= 0, "Build version must be greater or equal to zero");
        }
    }
}
