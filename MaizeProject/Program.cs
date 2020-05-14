using System;

namespace MaizeProject
{
    class Program
    {
        public static int Inventory;
        public static decimal TotalSales;
        public static decimal Sell;
        public static int bags;
        public static decimal Price;
        public static decimal TotalAmount;
        public static decimal TotalPurchases;
        static void Main(string[] args)
        {
           Program p = new Program();
           Console.WriteLine("The Total Amount Purchased is:" + p.Purchases(ref Inventory, ref TotalAmount));
           Console.WriteLine("The Total Amount Purchased is:" + p.Purchases(ref Inventory, ref TotalAmount));
           Console.WriteLine("The Total Amount Sold is:" + p.Sales(ref Inventory, ref TotalSales));
           Console.WriteLine("The Total Amount Sold is:" + p.Sales(ref Inventory, ref TotalSales));
           Console.WriteLine("The Profit is:" + p.Profit(ref TotalSales, ref TotalAmount));
           Console.WriteLine("The Inventory is:" + Inventory);
        }
        public decimal Purchases(ref int Inventory ,ref decimal TotalAmount)
        {
            Console.WriteLine("Enter the Number of Bags to Purchase:");
            bags = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Buying Price Per Bag:");
            Price = Convert.ToInt32(Console.ReadLine());

            Inventory += bags;
            TotalAmount += bags * Price;
            return TotalAmount;
        }
        public decimal Sales(ref int Inventory, ref decimal TotalSales)
        {
            Console.WriteLine("Enter the Number of Bags to Sale:");
            bags = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Selling Price Per Bag:");
            Price = Convert.ToInt32(Console.ReadLine());

            Inventory -= bags;
            return TotalSales += bags * Price;
        }
        public decimal Profit(ref decimal TotalSales, ref decimal TotalAmount)
        {
            return TotalSales - TotalAmount;
        }
    }
}
