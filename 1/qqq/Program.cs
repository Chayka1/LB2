using System;

namespace ConsoleApp1
{
    class Address
    {
        private string Index { get; set; }
        private string Country { get; set; }
        private string City { get; set; }
        private string Street { get; set; }
        private string House { get; set; }
        private string Apartment { get; set; }

        public Address(string Index, string Country, string City, string Street, string House, string Apartment)
        {
            this.Index = Index;
            this.Country = Country;
            this.City = City;
            this.Street = Street;
            this.House = House;
            this.Apartment = Apartment;
        }
        
        public void Print()
        {
            Console.WriteLine($"Iндекс: {Index}\nСтрана: {Country}\nГород: {City}\nУлица: {Street}\nДом: {House}\nАпартаменты: {Apartment}");
        }
    }
    class Program
    {
        static void Main()
        {
            Address address = new Address("07402", "Ukraine", "Brovary", "Hetmanska Street", "32/a", "1");            
            address.Print();
            Console.ReadKey();
        }
    }
}