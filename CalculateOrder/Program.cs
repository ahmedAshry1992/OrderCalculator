using CalculateOrder;

var orderlist = SeedingOrderData.GetOrdersList();

orderlist.ForEach(order => Console.WriteLine(order.ToString()));

Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine($"NET List Total Coast: {orderlist.Sum(o => o.TotalCoast)}$");





