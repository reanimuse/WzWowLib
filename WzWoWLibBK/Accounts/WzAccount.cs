using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzWoWLib.interfaces;
using WzWoWLib.Main;

namespace WzWoWLib.Accounts
{
    public class WzAccount : WzFolderInfo
    {
        private WzMacroCollection _macros = null;

        public WzAccount(IWzFolderInfo path) : base(path.FullName)
        {

        }
        public WzAccount(string path) : base(path)
        {

        }

        public bool IsValid()
        {
            if (!this.Exists) return false;
            if (this.Name == "SavedVariables") return false;

            var checkFiles = new string[] { "bindings-cache.wtf", "config-cache.wtf", "macros-cache.txt" };

            // make sure it contains at least one of the known files
            var valid = false;
            foreach (var filename in checkFiles)
            {
                var fileInfo = this.GetFile(filename);
                if (fileInfo != null && fileInfo.Exists)
                {
                    valid = true;
                }
            }

            return valid;
        }

        public WzMacroCollection Macros
        {
            get
            {
                if (_macros == null)
                {
                    _macros = new WzMacroCollection(this);
                }
                return _macros;
            }
        }
    }


    public class WzAccountCollection : List<WzAccount>
    {
        public WzAccountCollection(IWzFolderInfo accountBasePath)
        {
            Init(accountBasePath);
        }
        public WzAccountCollection(string accountBasePath)
        {
            var baseFolder = new WzFolderInfo(accountBasePath, false);

            Init(baseFolder);
        }

        protected void Init(IWzFolderInfo baseFolder)
        {
            if (baseFolder != null && baseFolder.Exists)
            {
                var folders = baseFolder.GetFolders();

                foreach (var folder in folders)
                {
                    var acct = new WzAccount(folder);
                    if (acct.IsValid()) this.Add(acct);
                }
            }
        }
    }
}
