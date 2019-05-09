using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

[assembly:CommandClass(typeof(DeleteLayer.DeleteLayerClass))]
namespace DeleteLayer
{
    public class DeleteLayerClass
    {
        [CommandMethod("DeleteLayer")]
        public void DeleteLayer()
        {
            Database db = HostApplicationServices.WorkingDatabase;

            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            string nameNeedDelete = "fck13";
            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                LayerTable layerTable = (LayerTable)transaction.GetObject(db.LayerTableId, OpenMode.ForWrite);
                LayerTableRecord currentLayer = (LayerTableRecord)transaction.GetObject(db.Clayer, OpenMode.ForWrite);

                if (currentLayer.Name.ToLower() == nameNeedDelete.ToLower())
                {
                    ed.WriteMessage("\nCan't delete current layer!");
                }
                else
                {
                    LayerTableRecord layerTableRecord = new LayerTableRecord();
                    if (layerTable.Has(nameNeedDelete))
                    {
                        layerTableRecord = (LayerTableRecord)transaction.GetObject(layerTable[nameNeedDelete], OpenMode.ForWrite);
                        if (layerTableRecord.IsErased)
                        {
                            ed.WriteMessage("\nThe Layer has been deleted!");
                        }
                        else
                        {
                            ObjectIdCollection idCol = new ObjectIdCollection();
                            idCol.Add(layerTableRecord.ObjectId);
                            db.Purge(idCol);
                            if (idCol.Count == 0)
                            {
                                ed.WriteMessage("\nCan't delete layer with object");
                            }
                            else
                            {
                                layerTableRecord.Erase();
                            }
                        }
                    }
                    else
                    {
                        ed.WriteMessage("\nNo layer found!");
                    }
                }
                transaction.Commit();
            }
        }
    }
}
