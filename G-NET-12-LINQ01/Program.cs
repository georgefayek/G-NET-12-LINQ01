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

            #region 5. Get all products that are in stock (UnitsInStock > 0) and


            //            var result5 = ProductList
            //.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //        foreach (var item in result5)
            //        {
            //            Console.WriteLine(item.ProductName);
            //        }
            #endregion

            #region 6. Create a new anonymous type with three properties

            //    var result6 = ProductList.Select(p => new
            //    {
            //        Name = p.ProductName,
            //        Price = p.UnitPrice,
            //        StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //    });

            //foreach (var item in result6)
            //{
            //    Console.WriteLine($"{item.Name} - {item.Price} - {item.StockStatus}");
            //}
            #endregion

            #region 7. Print each product's name along with its position (1-based)

            //     var result7 = ProductList.Select((p, index) => new
            //     {
            //         Index = index + 1,
            //         Name = p.ProductName
            //     });

            //foreach (var item in result7)
            //{
            //    Console.WriteLine($"{item.Index}. {item.Name}");
            //}
            #endregion

            #region 8. Sort ProductList by Category ascending

            //            var result8 = ProductList
            //.OrderBy(p => p.Category)
            //.ThenByDescending(p => p.UnitPrice);

            //        foreach (var item in result8)
            //        {
            //            Console.WriteLine($"{item.Category} - {item.ProductName} - {item.UnitPrice}");
            //        }
            #endregion

            #region 9. Get all products from the "Beverages

            //            var result9 = ProductList
            //.Where(p => p.Category == "Beverages")
            //.OrderByDescending(p => p.UnitsInStock);

            //        foreach (var item in result9)
            //        {
            //            Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            //        }
            #endregion

            #region 10. Using QUERY SYNTAX with a compound from clause

            //                List<Order> Orders = new List<Order>()
            //{
            //                new Order{ CustomerID="ALFKI", OrderDate=new DateTime(1998,1,1)},
            //                new Order{ CustomerID="ANATR", OrderDate=new DateTime(1996,5,1)}
            //};

            //                                var result10 =
            //                    from o in Orders
            //                    where o.OrderDate.Year >= 1997
            //                    select new
            //                    {
            //                    o.CustomerID,
            //                    o.OrderDate
            //                    };

            //                                foreach (var item in result10)
            //                                {
            //                                    Console.WriteLine($"{item.CustomerID} - {item.OrderDate}");
            //                                }
            #endregion

            #region 11. Show position number alongside ProductName

            //    var result11 = ProductList.Select((p, i) => new
            //    {
            //        Position = i + 1,
            //        Name = p.ProductName
            //    });

            //foreach (var item in result11)
            //{
            //    Console.WriteLine($"{item.Position} - {item.Name}");
            //}
            #endregion


        }

    }
}
