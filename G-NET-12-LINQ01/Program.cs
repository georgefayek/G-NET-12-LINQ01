namespace G_NET_12_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Product> ProductList = new List<Product>()
{
            new Product{ ProductName="Chai", Category="Beverages", UnitPrice=18, UnitsInStock=39 },
            new Product{ ProductName="Chang", Category="Beverages", UnitPrice=19, UnitsInStock=17 },
            new Product{ ProductName="Aniseed Syrup", Category="Condiments", UnitPrice=10, UnitsInStock=13 },
            new Product{ ProductName="Chef Anton", Category="Condiments", UnitPrice=22, UnitsInStock=0 },
            new Product{ ProductName="Ikura", Category="Seafood", UnitPrice=31, UnitsInStock=20 },
            new Product{ ProductName="Konbu", Category="Seafood", UnitPrice=6, UnitsInStock=0 }
};



            #region  1. Get all products from the "Seafood" category. Print each
            product's name and price.


            //    var result1 = ProductList.Where(p => p.Category == "Seafood");

            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}


            #endregion

        }
    }
}
