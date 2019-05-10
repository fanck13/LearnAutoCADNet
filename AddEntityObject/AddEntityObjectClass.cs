using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace AddEntityObject
{
    public class AddEntityObjectClass
    {
        [CommandMethod("AddEntityObject")]
        public void AddEntityObject()
        {
            AddToModelSpace(DbText(new Point3d(-10, 20, 0),"fck13", 5));//创建一个基点为(0, 50, 0)，文字高度为20的文字，添加到模型空间 
            Line L=new Line(new Point3d(40, 0, 0), new Point3d(60, 15, 0));
            //创建直线 
            OrdinateDimension ODX = OrdinateDimensionX(L.StartPoint,L.EndPoint,10,true);
            //创建X增量标注 
            AddToModelSpace(L);
            AddToModelSpace(ODX);
            Circle C = new Circle(Point3d.Origin, Vector3d.ZAxis, 15);//创建圆 
            RadialDimension RD = RadialDimension(C, 3*Math.PI / 4, 10);//创建半径标注 
            AddToModelSpace(C);
            AddToModelSpace(RD);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public ObjectId AddToModelSpace(Entity entity)
        {
            ObjectId objectId;
            Database db = HostApplicationServices.WorkingDatabase;

            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                BlockTable blockTable = transaction.GetObject(db.BlockTableId, OpenMode.ForWrite) as BlockTable;
                BlockTableRecord blockTableRecord = transaction.GetObject(blockTable[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;
                objectId = blockTableRecord.AppendEntity(entity);
                transaction.AddNewlyCreatedDBObject(entity, true);
                transaction.Commit();
            }
            return objectId;
        }

        public DBText DbText(Point3d position, string textString, double height)
        {
            DBText text = new DBText();
            text.Position = position;
            text.TextString = textString;
            text.Height = height;
            return text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cir"></param>
        /// <param name="angle"></param>
        /// <param name="leaderLength"></param>
        /// <returns></returns>
        public RadialDimension RadialDimension(Circle cir, double angle, double leaderLength)
        {
            Point3d cenPt = new Point3d(cir.Center.X, cir.Center.Y, 0);
            Point3d pt1 = new Point3d(cenPt.X + cir.Radius * Math.Cos(angle), cenPt.Y + cir.Radius * Math.Sin(angle), cenPt.Z);
            Database db = HostApplicationServices.WorkingDatabase;
            ObjectId style = db.Dimstyle;
            RadialDimension ent = new RadialDimension(cenPt, pt1, leaderLength, "<>", style);
            return ent;
        }


        public OrdinateDimension OrdinateDimensionX(Point3d stratPoint, Point3d ordPt, double lenght, bool bo)
        {
            Database db = HostApplicationServices.WorkingDatabase;
            ObjectId style = db.Dimstyle;
            Point3d pt1 = new Point3d(ordPt.X + lenght * Math.Cos(bo ? 3 * Math.PI / 2 : Math.PI / 2), ordPt.Y + lenght * Math.Sin(bo ? 3 * Math.PI / 2 : Math.PI / 2), ordPt.Z);
            OrdinateDimension entX = new OrdinateDimension(true, ordPt, pt1, "<>", style);
            entX.Origin = stratPoint;
            return entX;
        }
    }
}
