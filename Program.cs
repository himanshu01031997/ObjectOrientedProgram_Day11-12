namespace InventoryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "D:\\RFP-208\\InventoryManagement\\InventoryMan\\Inventory.json";
            FetchingInventoryDetails fetchingInventoryDetails = new FetchingInventoryDetails();
            Inventory data = fetchingInventoryDetails.Read(path);
            Console.WriteLine("types of rice");
            Console.WriteLine(data.typeofRice.name);
            Console.WriteLine(data.typeofRice.weight);
            Console.WriteLine(data.typeofRice.price);
            Console.WriteLine("types of Wheat");
            Console.WriteLine(data.typeofWheat.name);
            Console.WriteLine(data.typeofWheat.weight);
            Console.WriteLine(data.typeofWheat.price);
            Console.WriteLine("types of Pulse");
            Console.WriteLine(data.typeofPulse.name);
            Console.WriteLine(data.typeofPulse.weight);
            Console.WriteLine(data.typeofPulse.price);


        }
    }
}