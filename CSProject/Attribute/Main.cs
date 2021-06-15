using System;
using System.Reflection;

namespace CSProject.Attribute
{
    public class Main
    {
        public static void Run(string[] args)
        {
            var r = new Rectangle(4.5, 7.5);
            // r.Display();
            Type type = typeof(Rectangle);
            r.Display();

            // 遍历 Rectangle 类的特性
            Console.WriteLine("-----------------------------遍历 Rectangle 类的Attribute -----------------------------");
            foreach (Object attributes in type.GetCustomAttributes(false))
            {
                DebugInfo debugInfo = (DebugInfo) attributes;
                if (null != debugInfo)
                {
                    Console.WriteLine("Bug no: {0}", debugInfo.BugNo);
                    Console.WriteLine("Developer: {0}", debugInfo.Developer);
                    Console.WriteLine("Last Reviewed: {0}", debugInfo.LastReview);
                    Console.WriteLine("Remarks: {0}", debugInfo.Message);
                }
            }
            
            Console.WriteLine("-----------------------------遍历 Rectangle 类的Field-----------------------------");
            foreach (FieldInfo fieldInfo in type.GetFields())
            {
                Console.WriteLine(fieldInfo.Name + ":" + fieldInfo.GetValue(r));
            }
            
            r.Display();
            
            Console.WriteLine("---------------GetProperties--------------");
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                Console.WriteLine(propertyInfo.Name);
            }
            
            Console.WriteLine("---------------GetMethods--------------");
            foreach (MethodInfo methodInfo in type.GetMethods())
            {
                Console.WriteLine(methodInfo.Name);
            }
        }
    }
}