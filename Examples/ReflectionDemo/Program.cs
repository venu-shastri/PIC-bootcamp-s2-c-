
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class A {

        private void Fun() { }
        public void Foo() { }

        public string Concat(int x,string y) { return x + y; }
    }
    public class B { }
    public interface I { }
    class Program
    {
        static void Main(string[] args)
        {
            //Reflection
            //Reflect Type

            //typeDef 
            System.Type _typeDef = typeof(ReflectionDemo.A);
           
           
            //Check Flags
            System.Reflection.MethodInfo[] methods = _typeDef.GetMethods();
          System.Reflection.ParameterInfo[] parameters  =methods[0].GetParameters();
           System.Reflection.FieldInfo[] feilds = _typeDef.GetFields();
            System.Reflection.ConstructorInfo[] constructors = _typeDef.GetConstructors();
            //for (int i = 0; i < methods.Length; i++)
            //{
            //    Console.WriteLine(methods[i].Name);
            //}

            System.Reflection.MethodInfo _funMethodMetadata = 
                _typeDef.GetMethod("Fun",
                System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance);
            //Dynamic Invoke
            _funMethodMetadata.Invoke(new A(), null);

            Object obj = new A();
           System.Type _typeADef= obj.GetType();//returns metadata reference of object type
            _typeADef.GetMethod("Foo").Invoke(obj, null);

          System.Reflection.MethodInfo _concatMetadataRef=  _typeADef.GetMethod("Concat");
           object result= _concatMetadataRef.Invoke(obj, new object[] { 10, "Hello" });
            
        }
    }
}
