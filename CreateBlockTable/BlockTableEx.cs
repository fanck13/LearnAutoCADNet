using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
namespace CreateBlockTable
{
    public class BlockTableEx
    {
        [CommandMethod("AddBlockTable")]
        public void AddBlockTableRecord()
        {
            Database db = HostApplicationServices.WorkingDatabase;
            BlockTableRecord btr = new BlockTableRecord();
            btr.Name = "new Added";
            Line line = new Line(Point3d.Origin, new Point3d(10, 15, 0));
            Circle circle = new Circle(Point3d.Origin, Vector3d.ZAxis, 15);
            btr.AppendEntity(line);
            btr.AppendEntity(circle);

            ObjectId objectId = new ObjectId();
            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                BlockTable bt = transaction.GetObject(db.BlockTableId, OpenMode.ForWrite) as BlockTable;
                objectId = bt.Add(btr);
                transaction.AddNewlyCreatedDBObject(btr, true);
                transaction.Commit();
            }
        }
    }
}
