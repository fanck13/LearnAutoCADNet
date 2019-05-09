using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Colors;

namespace CreateLayer
{
    public class CreateLayerClass
    {
        [CommandMethod("CreateLayer")]
        public void CreateLayer()
        {
            Database db = HostApplicationServices.WorkingDatabase;

            //short colorIndex = (short)(ColorIndex % 256);
            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                LayerTable layerTable = (LayerTable)transaction.GetObject(db.LayerTableId, OpenMode.ForWrite);
                ObjectId objectId = ObjectId.Null;
                string layerName = "fck13";
                if (!layerTable.Has(layerName))
                {
                    LayerTableRecord layerTableRecord = new LayerTableRecord();
                    layerTableRecord.Name = layerName;
                    layerTableRecord.Color = Color.FromColorIndex(ColorMethod.ByColor, 22);
                    objectId = layerTable.Add(layerTableRecord);
                    transaction.AddNewlyCreatedDBObject(layerTableRecord, true);
                    transaction.Commit();
                }
            }
        }
    }
}
