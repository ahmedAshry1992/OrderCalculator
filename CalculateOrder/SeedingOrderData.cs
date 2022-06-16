

namespace CalculateOrder
{
    public static class SeedingOrderData
    {
        public static List<Order> GetOrdersList()=> new List<Order> {
                new Order { Id = 1, Name = "item1", Price = 10, WeightInKg = 5 },
                new Order { Id = 2, Name = "item2", Price = 15, WeightInKg = 15 },
                new Order { Id = 3, Name = "item3", Price = 30, WeightInKg = 25 },
                new Order { Id = 4, Name = "item4", Price = 11, WeightInKg = 35 },
                new Order { Id = 5, Name = "item5", Price = 120, WeightInKg = 55 }
            };
    }
}

    
    
    
    