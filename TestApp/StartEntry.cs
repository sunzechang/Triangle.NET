using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: ExtensionApplication(typeof(MeshExplorer.StartEntry))]
[assembly: CommandClass(typeof(MeshExplorer.CADCommand))]
namespace MeshExplorer
{
    /// <summary>
    /// CAD插件启动入口
    /// </summary>
    public class StartEntry : IExtensionApplication
    {
        void IExtensionApplication.Initialize()
        {
            ;
        }

        void IExtensionApplication.Terminate()
        {
            throw new NotImplementedException();
        }
    }

}
