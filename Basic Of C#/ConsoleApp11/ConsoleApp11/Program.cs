using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp11
{
    public class Program : AccessMOdifier
    {
        

        public static void Main(string[] args)
        {
            try
            {
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("\nFinally!"); }

            Console.ReadKey();
        }

        public void AccessModifierEncapsulation()
        {
            Encapsulations obj = new Encapsulations();
            //obj.Data_ = "Test";
            //Console.WriteLine(obj.Data_);

            //obj.Read_ = "vfdfzd";
            //Console.WriteLine(obj.Read_);
        }

        public void PatternWithOnlyTwoLoop()
        {
            for (int i = 1; i <= 10; i++)
            {

                for (int j = i <= 5 ? 1 : 10; i <= 5 ? j <= i : j >= i; j += i <= 5 ? 1 : -1)
                { Console.Write("*"); }

                Console.WriteLine();
            }
        }

        public void ListDic()
        {
            List<string> data = new List<string>();
            data.Add("dsds");
            data.Add("ssfsfv");
            data.Add("dss");

            Console.WriteLine(data.Count);
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("2", "Peter");
            names.Add("3", "James");
            names.Add("4", "Ratan");
            names.Add("5", "Irfan");

            Console.WriteLine(names["3"]);
        }


    }

    public class Encapsulations
    {
        private string data;
        private string read = "Dataaaa";

        public string Data_
        {
            set { data = value; }
        }
        public string Read_
        { get { return read; } }
    }

    public class AccessMOdifier
    {
        protected void sum(int a)
        {
            Console.WriteLine(a);
        }

        public (int, string) test__(string a) { return (Convert.ToInt32(a), a); }

        public void summm()
        {
            sum(12);
        }
    }


    //Interface
    public interface _interfaceOne
    {
        void _classoneMethod();
    }

    public interface _interfaceTwo
    {
        void _classoneMethod();
    }
    public class _clsOne : _interfaceOne, _interfaceTwo
    {
        public void _classoneMethod()
        { Console.WriteLine("1"); }
    }

    public class _classTwo
    {
        public void _classTwoMethod()
        { Console.WriteLine("2"); }
    }



    public abstract class _Abstract1
    {
        public int a = 2;
        public abstract void _method();
    }

    public class _abstract2 : _Abstract1
    {
        public override void _method()
        {
            Console.WriteLine("Abstraction 1...");
        }
    }

    public class _abstract3 : _Abstract1
    {
        public override void _method()
        {
            Console.WriteLine("Abstraction 2...");
        }
    }

    public class _ParentCls
    {
        public string _FirstName;

        public virtual void _ghh() { Console.WriteLine("Parent Class"); }
    }

    public class _ChildCls : _ParentCls
    {
        public string _lastName;
        public override void _ghh() { Console.WriteLine("Base Class"); }
    }

    static class StaticCls
    {
        public static string _var;
    }

    class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("Constructor Object Created");
        }
        ~DestructorDemo()
        {
            string type = GetType().Name;
            Console.WriteLine($"Object {type} is Destroyed");
        }

    }

    class ClsTestDemo
    {
        public void _clsmethod(int val) { val += val; Console.WriteLine(val); }

        ~ClsTestDemo() { Console.WriteLine("sfzssfbv"); }

    }
}
