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
            for (int i = 0; i < data.typeofRice.Count; i++)
            {
                Console.WriteLine(data.typeofRice[i].name);
                Console.WriteLine(data.typeofRice[i].weight);
                Console.WriteLine(data.typeofRice[i].price);
                int val = data.typeofRice[i].weight * data.typeofRice[i].price;
                Console.WriteLine("the price for {0}kg of type {1} is {2}", data.typeofRice[i].weight, data.typeofRice[i].name, val);
            }
            Console.WriteLine("types of wheat");
            for (int i = 0; i < data.typeofWheat.Count; i++)
            {
                Console.WriteLine(data.typeofWheat[i].name);
                Console.WriteLine(data.typeofWheat[i].weight);
                Console.WriteLine(data.typeofWheat[i].price);
                int val1 = data.typeofWheat[i].weight * data.typeofWheat[i].price;
                Console.WriteLine("the price for {0}kg of type {1} is {2}", data.typeofWheat[i].weight, data.typeofWheat[i].name, val1);
            }
            Console.WriteLine("types of pulse");
            for (int i = 0; i < data.typeofPulse.Count; i++)
            {
                Console.WriteLine(data.typeofPulse[i].name);
                Console.WriteLine(data.typeofPulse[i].weight);
                Console.WriteLine(data.typeofPulse[i].price);
                int val2 = data.typeofPulse[i].weight * data.typeofPulse[i].price;
                Console.WriteLine("the price for {0}kg of type {1} is {2}", data.typeofPulse[i].weight, data.typeofPulse[i].name, val2);
            }
        }
    } 
}


























