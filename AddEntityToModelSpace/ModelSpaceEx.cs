using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace AddEntityToModelSpace
{
    public class ModelSpaceEx
    {
        [CommandMethod("AddEntityToModelSpace")]
        public void AddEntityToModelSpaceFunc()
        {
            Database db = HostApplicationServices.WorkingDatabase;

            DBText text = new DBText();
            text.Position = new Point3d();
            text.TextString = "fck13";

            ObjectId objectId;
            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                BlockTable bt = (BlockTable)transaction.GetObject(db.BlockTableId, OpenMode.ForWrite);
                BlockTableRecord btr = (BlockTableRecord)transaction.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite);
                objectId = btr.AppendEntity(text);
                transaction.AddNewlyCreatedDBObject(text, true);
                transaction.Commit();
            }

        }
    }
}
