using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;

namespace Yoda.Net.Common
{
    public class CodeDomTest
    {
        public CodeDomTest()
        {


        }

        public static void CreateTest()
        {
            List<Member> memberList = new List<Member>();

            memberList.Add(new Member("test", typeof(string)));

            memberList.Add(new Member("sex1", typeof(string)));



            memberList.Add(new Member("sex2", typeof(string)));

            memberList.Add(new Member("sex3", typeof(string)));
            memberList.Add(new Member("sex4", typeof(string)));
            CodeCompileUnit compileUnit = new CodeCompileUnit();
            CodeNamespace name = new CodeNamespace("Yoda.Net.Networking.Packet.Info");

            CodeTypeDeclaration targetClass = new CodeTypeDeclaration("TestCommandData");
            targetClass.BaseTypes.Add(typeof(Yoda.Net.Networking.Packet.IPacket));


            CodeConstructor constructor = new CodeConstructor();
            constructor.Attributes = MemberAttributes.Public;

            targetClass.Members.Add(constructor);
            name.Types.Add(targetClass);
            compileUnit.Namespaces.Add(name);

            foreach (Member member in memberList)
            {
              
                var targetField = new CodeMemberField(type: member.type, name: member.name)
                {
                    Attributes = MemberAttributes.Private // private
                };

                targetClass.Members.Add(targetField);

            }



            ProcessWriteData(memberList, targetClass);


            CodeMethodReturnStatement returnStatement =
    new CodeMethodReturnStatement();


            CSharpCodeProvider provider = new CSharpCodeProvider();
            CodeGeneratorOptions option = new CodeGeneratorOptions();
            CompilerParameters param = new CompilerParameters();
            CodeCompileUnit[] units = { compileUnit };

            param.GenerateExecutable = true;
            param.OutputAssembly = "output.exe";

            provider.GenerateCodeFromCompileUnit(compileUnit,
             Console.Out, option);
            CompilerResults result = provider.CompileAssemblyFromDom
            (param, units);

            foreach (string t in result.Output) Console.WriteLine(t);

        }



        public static void ProcessWriteData(List<Member> memberList, CodeTypeDeclaration targetClass)
        {

            CodeMemberMethod writeDataMethod = new CodeMemberMethod();
            writeDataMethod.Attributes =
                MemberAttributes.Public;
            writeDataMethod.Name = "writeData";
            writeDataMethod.ReturnType =
                new CodeTypeReference(typeof(void));

            writeDataMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeof(AmebaStream), "In"));


            foreach (Member member in memberList)
            {



                var priceFieldReference = new CodeFieldReferenceExpression(
             targetObject: new CodeThisReferenceExpression(), 
             fieldName: member.name                           
         );



                var Statements = new CodeMethodInvokeExpression( 
               targetObject: new CodeSnippetExpression("In"), 
               methodName: ToType(member.type));

                writeDataMethod.Statements.Add(
             new CodeAssignStatement(                  

                     priceFieldReference
                     , Statements

                 ));
            }
            targetClass.Members.Add(writeDataMethod);
        }

        private static string ToType(Type code)
        {
            switch (Type.GetTypeCode(code))
            {
                case TypeCode.Boolean:
                    return "readBoolean";

                case TypeCode.Byte:
                    return "readByte";



                case TypeCode.DateTime:
                    return "readDate";


                case TypeCode.String:
                    return "readString";
            }

            return null;
        }


        public class Member
        {
            public string name;
            public Type type;
            public Member(string name, Type type)
            {
                this.name = name;
                this.type = type;
            }
        }


    }
}
