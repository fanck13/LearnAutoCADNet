using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
[assembly:CommandClass(typeof(AddNod.AddNodClass))]

namespace AddNod
{
    public class AddNodClass
    {
        [CommandMethod("AddNod")]
        public void AddNod()
        {
            Database db = HostApplicationServices.WorkingDatabase;
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Table";
            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                DBDictionary dictionary = transaction.GetObject(db.NamedObjectsDictionaryId, OpenMode.ForWrite) as DBDictionary;
                dictionary.SetAt("DataTable", dataTable);
                transaction.Commit();
            }
        }
    }
}
