using System;
using System.Security;
using System.Security.Permissions;

namespace Listing3_36_ImperativeCAS
{
    class Program
    {
        static void Main(string[] args)
        {
            FileIOPermission f = new FileIOPermission(PermissionState.None);

            f.AllLocalFiles = FileIOPermissionAccess.Read;

            try
            {
                f.Demand();
            }
            catch (SecurityException s)
            {
                Console.WriteLine(s.Message);
            }
        }
    }
}
