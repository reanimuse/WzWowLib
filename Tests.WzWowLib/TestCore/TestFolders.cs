using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tests.WzWowLib
{
    public class TestFolders
    {
        private static TestFolders _paths = null;

        private string _testPathBase = @"{0}\TestPaths\";

        public string BasePath { get; protected set; }

        public string PathDoesNotExist { get; protected set; }
        public string EmptyFolder { get; protected set; }
        public string ValidPathsNoEXE { get; protected set; }
        public string ValidPath { get; protected set; }
        

        protected TestFolders()
        {
            var asm = System.Reflection.Assembly.GetExecutingAssembly();

            var name = asm.GetName().Name;

            var pos = asm.Location.IndexOf(name, StringComparison.InvariantCultureIgnoreCase);

            var relPath = asm.Location.Substring(0, pos);

            this.BasePath = string.Format(_testPathBase, relPath.Trim('\\'));

            this.PathDoesNotExist = Path.Combine(this.BasePath, "DOES__NOT__EXISTZZZ");
            this.EmptyFolder = Path.Combine(this.BasePath, "WoWNoData");
            this.ValidPathsNoEXE = Path.Combine(this.BasePath, "WoWPathsNoEXE");
            this.ValidPath = Path.Combine(this.BasePath, "WoWPathsValid");
        }


        public static TestFolders Paths
        {
            get
            {
                if (_paths == null) _paths = new TestFolders();

                return _paths;
            }
        }
    }
}
