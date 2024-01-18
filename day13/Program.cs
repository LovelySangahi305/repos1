// See https://aka.ms/new-console-template for more information
using day13;
using System.Reflection;

//Console.WriteLine("_____OBSOLETE ATTRIBUTE_____");
//Obsoleteattr oa = new Obsoleteattr();
//oa.Function1();
//oa.Function2();
//Console.WriteLine("_____KERNEL BEEP_____");
//Kernel.Beep(500, 100);

//Console.WriteLine("_____CUSTOM ATTRIBUTE_______");
//Rectangle r = new Rectangle(4.5, 7.5);
//r.Display();
//Type type = typeof(Rectangle);
////iterating through the attribtues of the Rectangle class
//foreach (Object attributes in type.GetCustomAttributes(false))
//{
//    DeBugInfo dbi = (DeBugInfo)attributes;

//    if (null != dbi)
//    {
//        Console.WriteLine("Bug no: {0}", dbi.BugNo);
//        Console.WriteLine("Developer: {0}", dbi.Developer);
//        Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
//        Console.WriteLine("Remarks: {0}", dbi.Message);
//    }
//}
////iterating through the method attribtues
//foreach (MethodInfo m in type.GetMethods())
//{

//    foreach (Attribute a in m.GetCustomAttributes(true))
//    {
//        DeBugInfo dbi = a as DeBugInfo;

//        if (null != dbi)
//        {
//            Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
//            Console.WriteLine("Developer: {0}", dbi.Developer);
//            Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
//            Console.WriteLine("Remarks: {0}", dbi.Message);
//        }
//    }
//}

Console.WriteLine("________STRUCTURE ORDERDETAILS_________");
StructOrder s= new StructOrder();
s.GetDetails();
s.DisplayDetails();

Console.WriteLine("________ENUM CREATION_________");
EnumList e= new EnumList();
e.Display();