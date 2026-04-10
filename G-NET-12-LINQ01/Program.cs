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

            #region 2. Get a list of only the product names from ProductList. Print
                    each name.


            //    var result2 = ProductList.Select(p => p.ProductName);

            //foreach (var name in result2)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region 3. Sort all products by UnitPrice (ascending). Print each
                        product's name and price

            //    var result3 = ProductList.OrderBy(p => p.UnitPrice);

            //foreach (var item in result3)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}
            #endregion

            #region 4. Get all products where UnitPrice is between 10 and 30

            //            var result4 = ProductList
            //.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //        foreach (var item in result4)
            //        {
            //            Console.WriteLine(item.ProductName);
            //        }
            #endregion
        }

    }
}
