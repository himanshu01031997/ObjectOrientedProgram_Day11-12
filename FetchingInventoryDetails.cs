using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryManagement
{
    public class FetchingInventoryDetails
    {
        public Inventory Read(string Path)
        {
            using(StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Inventory>(json);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    return null;
                }

            }
        }
    }
}
