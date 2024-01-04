namespace GA___PP___ShoppingSpree
{
    internal class Program
    {
        static void Main()
        {
            ClothingItem shirt = new ClothingItem("T-skjorte", 50, 200, "Large", "Blå");
            var salePriceShirt = shirt.CalculateSalePrice();
            Console.WriteLine($"Salgsprisen på T-skjorte er: {salePriceShirt}");

            ElectronicItem phone = new ElectronicItem("iPhone X", 25, 3400, "1 year");
            var salePricePhone = phone.CalculateSalePrice();
            Console.WriteLine($"Salgsprisen på mobilen er: {salePricePhone}");
        
        }
    }
}
