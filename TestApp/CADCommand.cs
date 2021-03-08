using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshExplorer
{
    class CADCommand
    {

        [CommandMethod("CreateTIN")]
        public void Export2GeoMDB()
        {
            new FormMain().ShowDialog();
        }
    }
}
