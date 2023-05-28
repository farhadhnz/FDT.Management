using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDT.Management.Core.Helpers
{
    public static class AssemblyLoadingHelper
    {
        public static Type GetTypeinAssmblies(string typeName)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Select(x => x.FullName).Where(x => x.StartsWith("FDT")).ToList();

            Type digitalTwinType = Type.GetType(
            typeName,
            (name) =>
            {
                return AppDomain.CurrentDomain.GetAssemblies().Where(z => z.FullName == name.FullName).FirstOrDefault();
            },
            null,
            true);

            return digitalTwinType;
        }
    }
}
