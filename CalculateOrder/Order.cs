

namespace CalculateOrder
{
    public class Order
    {
        /// <summary>
        /// Get or set Id property
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Get or set Name property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or set Price property
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Get or set WeightInKg property
        /// </summary>
        public double WeightInKg { get; set; }

        /// <summary>
        /// Get private set ShippingCoast property
        /// </summary>
        public decimal ShippingCoast => GetWeightShippingCoast(WeightInKg);

        /// <summary>
        /// Get private set TotalCoast property
        /// </summary>
        public decimal TotalCoast => ShippingCoast + Price;


        decimal GetWeightShippingCoast(double weight)
        {
            switch (weight)
            {
                case double weigtRange1 when weigtRange1 >= 1 && weigtRange1 <= 10: return 2;
                case double weigtRange2 when weigtRange2 > 10 && weigtRange2 <= 20: return 3;
                case double weigtRange3 when weigtRange3 > 20 && weigtRange3 <= 30: return 4;
                default: return 10;
            }

        }



        /// <summary>
        /// Return order as string
        /// </summary>
        public override string ToString()=> $"ID: {Id}   |   Name: {Name}    |   Price: {Price}$  |   Weight: {WeightInKg}Kg  |   Shipping Coast: {ShippingCoast}$    |   TotalCoast: {TotalCoast}$";
        
    }
}
