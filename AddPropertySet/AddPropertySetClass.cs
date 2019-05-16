using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.DatabaseServices;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;
using Autodesk.Aec.PropertyData.DatabaseServices;

namespace AddPropertySet
{
    public class AddPropertySetClass
    {
        [CommandMethod("AddPropertySet")]
        public void AddPropertySet()
        {
            Database db = HostApplicationServices.WorkingDatabase;
            ObjectId layoutId = SymbolUtilityServices.GetBlockModelSpaceId(db);
            using (var tr = db.TransactionManager.StartTransaction())
            {
                var bt = tr.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                var btr = tr.GetObject(layoutId, OpenMode.ForRead) as BlockTableRecord;

                btr.Name = "bimcad";
                Line line = new Line(Point3d.Origin, new Point3d(10, 15, 0));

                PropertySetDefinition psDef = new PropertySetDefinition();

                PropertyDefinition propertyDef = new PropertyDefinition();
                propertyDef.DataType = Autodesk.Aec.PropertyData.DataType.Text;
                propertyDef.Id = 1;

                psDef.Definitions.Add(propertyDef);
                PropertySet ps = new PropertySet();
                ps.PropertySetDefinition = psDef.Id;

                ps.SetAt(propertyDef.Id, "hello World");

                PropertyDataServices.AddPropertySet(line, ps.Id);
                Circle circle = new Circle(Point3d.Origin, Vector3d.ZAxis, 10);

                btr.AppendEntity(line);
                btr.AppendEntity(circle);

                ObjectId id = bt.Add(btr);
                tr.AddNewlyCreatedDBObject(btr, true);
                tr.Commit();
            }
        }

            /*var propSetIds = PropertyDataServices.GetPropertySets(ent);
            foreach (ObjectId psId in propSetIds)
            {
                var ps = tr.GetObject(psId, OpenMode.ForWrite) as PropertySet;
                var psDefId = ps.PropertySetDefinition;
                var psDef = tr.GetObject(psDefId, OpenMode.ForRead) as PropertySetDefinition;
                foreach (PropertyDefinition propertyDef in psDef.Definitions)
                {
                    if (propertyDef.DataType == Autodesk.Aec.PropertyData.DataType.Text)
                    {
                        var text = ps.GetAt(propertyDef.Id) as String;
                        if (IsTargetString(text))
                        {
                            findResult.Add(new ListItems("model space", "Text", text, ""));
                            objectIdList.Add(psDefId); //To be modified
                                                       //Console.WriteLine(text);
                        }
                    }
                }
            }*/
    }
}
