using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

namespace ChooseEntityCollection
{
    public class ChooseEntityCollectionClass
    {
        [CommandMethod("ChooseEntityCollection")]
        public void ChooseEntityCollection()
        {
            Database db = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Database;
            Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
            Entity entity = null;
            DBObjectCollection EntityCollection = new DBObjectCollection();
            PromptSelectionResult ents = ed.GetSelection();
            if (ents.Status == PromptStatus.OK)
            {
                using (Transaction transaction = db.TransactionManager.StartTransaction())
                {
                    SelectionSet SS = ents.Value;
                    foreach (ObjectId id in SS.GetObjectIds())
                    {
                        entity = (Entity)transaction.GetObject(id, OpenMode.ForWrite, true);
                        if (entity != null)
                        {
                            EntityCollection.Add(entity);
                        }
                    }
                    transaction.Commit();
                }
            }
        }
    }
}
