using System.Security.Permissions;

namespace Listing3_25_DeclarativeCAS
{
    class Program
    {
        static void Main(string[] args)
        {
            // CAS is used by the .NET Framework to protect computers from malicious code

            
        }
    }

    [FileIOPermission(SecurityAction.Demand, AllLocalFiles = FileIOPermissionAccess.Read)]
    public void DeclarativeCAS()
    {
        // Method Body
    }
}
