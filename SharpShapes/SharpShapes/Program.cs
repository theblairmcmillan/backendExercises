using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    class Program
    {
        static void Main()
        {

            var list = new List<KeyValuePair<int, string>>();
            list.Add(new KeyValuePair<int, string>(1, "square"));
            list.Add(new KeyValuePair<int, string>(2, "circle"));
            list.Add(new KeyValuePair<int, string>(3, "rectangle"));

            foreach (var List in list)
            {
                Console.WriteLine(List);
               
            }
            Console.ReadLine();
        }
      
    }
    
}
