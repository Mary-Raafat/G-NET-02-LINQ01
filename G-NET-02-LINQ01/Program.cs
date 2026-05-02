using G_NET_02_LINQ01.DataSource;

#region Q1
//var result = Source.ProductList.Where(p => p.Category == "Seafood").Select(p => new
//{
//    p.ProductName,
//    p.UnitPrice
//});
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Q2
//var result=Source.ProductList.Select(p=>p.ProductName).ToList();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Q3
//var result = Source.ProductList.Select(p => new
//{
//    p.ProductName,
//    p.UnitPrice
//}).OrderBy(p => p.UnitPrice);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Q4
//var result = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


#endregion

#region Q5

//var result = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


#endregion

#region Q6

//var result = Source.ProductList.Select(p => new
//{
//   Name= p.ProductName,
//  Price=  p.UnitPrice,
//   StockStatus= p.UnitsInStock > 0 ? "Available" : "Out of Stock"
//});

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


#endregion

#region Q7
//var result = Source.ProductList.Select((p, i) => $"{i + 1}.{p.ProductName}");
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

#endregion

#region Q8

//var result = Source.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

#endregion

#region Q9

//var result = Source.ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock).Select(p => new
//{
//    name = p.ProductName,
//    stock = p.UnitsInStock
//});

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

#endregion

