using Microsoft.CSharp;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;

namespace Listing2_75_GeneratingASourceFileFromACodeCompileUnit
{
    class Program
    {
        static void Main(string[] args)
        {
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

            CSharpCodeProvider provider = new CSharpCodeProvider();

            using(StreamWriter sw = new StreamWriter("HellowWorld.cs", false))
            {
                IndentedTextWriter tw = new IndentedTextWriter(sw, " ");
                provider.GenerateCodeFromCompileUnit(compileUnit, tw, new System.CodeDom.Compiler.CodeGeneratorOptions());
                tw.Close();
            }
        }
    }
}
