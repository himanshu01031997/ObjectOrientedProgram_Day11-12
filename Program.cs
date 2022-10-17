namespace InventoryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "D:\\RFP-208\\InventoryManagement\\InventoryMan\\Inventory.json";
            FetchingInventoryDetails fetchingInventoryDetails = new FetchingInventoryDetails();
            Inventory data = fetchingInventoryDetails.Read(path);
            Console.WriteLine("Stock Account Management");
            int totalStockValue = 0;
            for (int i = 0; i < data.stockAccount.Count; i++)
            {
                Console.WriteLine("Share Name:" + data.stockAccount[i].stockname);
                Console.WriteLine("Share Number:" + data.stockAccount[i].ShareNo);
                Console.WriteLine("Share Price:" + data.stockAccount[i].Shareprice);
                int stockvalue = data.stockAccount[i].ShareNo * data.stockAccount[i].Shareprice;
                Console.WriteLine("Total Stock Value of {0} is :{1}",data.stockAccount[i].stockname, stockvalue);
                totalStockValue+=stockvalue;
                Console.WriteLine("Total value of all Stocks are:{0}",totalStockValue);
            }

        }
    } 
}


























