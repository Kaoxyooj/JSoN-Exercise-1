using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace JSoN_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            String JSONstring = File.ReadAllText("json1.json");

            JavaScriptSerializer ser = new JavaScriptSerializer();
            Person p1 = ser.Deserialize<Person>(JSONstring);
            Console.WriteLine(p1);



            Person p2 = new Person() { name = "Kong", age = 31 };
            string outputJson = ser.Serialize(p2);
            File.WriteAllText("json1.json", outputJson);

            Console.Read();
        }
    }
}
