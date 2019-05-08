using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Runtime;

namespace HelloAutoCAD
{
    public class HelloAutoCAD : IExtensionApplication
    {
        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }

        [CommandMethod("HelloAutoCAD")]
        public void HelloAutoCad()
        {
            
        }
    }
}
