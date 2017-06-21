using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_74_GeneratingHelloWorldWithTheCodeDOM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compilation Unit only
            // See Listing 2_75 for the source file

            CodeCompileUnit compileUnit = new CodeCompileUnit();
            CodeNamespace myNamespace = new CodeNamespace("MyNamespace");
            myNamespace.Imports.Add(new CodeNamespaceImport("System"));
            CodeTypeDeclaration myClass = new CodeTypeDeclaration("MyClass");
            CodeEntryPointMethod start = new CodeEntryPointMethod();
            CodeMethodInvokeExpression csl = new CodeMethodInvokeExpression(
                new CodeTypeReferenceExpression("Console"),
                "WritLine", new CodePrimitiveExpression("Hello World"));

            compileUnit.Namespaces.Add(myNamespace);
            myNamespace.Types.Add(myClass);
            myClass.Members.Add(start);
            start.Statements.Add(csl);
        }
    }
}
