using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PruebaKODE
{
    class Program
    {
        static void Main(string[] args)
        {

            //StringBuilder x;
            //x = new StringBuilder("Hola");
            //StringBuilder y = x;
            //x = null;
            //y.Append(" que tal");
            //Console.WriteLine(y);
            //foreach(int i in DoSecuence(10))
            //{
            //    Console.WriteLine("{0}", i);
            //}
            //Parent parent = new Child();
            //String s = "123";
            //s.Substring(1);
            //Console.WriteLine(s);
            var city = new XElement("city", "Seattle");
            var customer1 = new XElement("customer", city);
            var customer2 = new XElement("customer", city);
            city.SetValue("London");
            Console.WriteLine(customer2.Element("city").Value);
        }
        public void Change(string cadena)
        {
            cadena.ToUpper();
        }
        public static IEnumerable DoSecuence(int values)
        {
            int value1 = 1;
            int value2 = 0;
            int values3 = 0;
            int counter = 0;
            while (counter++ < values)
            {
                if (counter == 7)
                {
                    yield break;
                }
                else
                {
                    values3 = value1 + value2;
                    value1 = value2;
                    value2 = values3;
                    yield return values3;
                }
            }
        }
        class Parent
        {
            ~Parent()
            {
                Console.WriteLine("Parent");
            }
        }
        class Child:Parent
        {
            ~Child()
            {
                Console.WriteLine("Child");
            }
        }

    }
}
