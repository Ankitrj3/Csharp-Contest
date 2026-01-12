using System.Collections.Generic;
namespace OnlineOrderProcess
{

    public static class DataRepository
    {
        public static Dictionary<int, Product> Products { get; private set; } = new();
        public static List<Customer> Customers { get; private set; } = new();
        public static List<Order> Orders { get; private set; } = new();

        static DataRepository()
        {
            LoadProducts();
            LoadCustomers();
            LoadOrders();
        }

        private static void LoadProducts()
        {
            Products = new Dictionary<int, Product>()
        {
            {1, new Product{Id=1, Name="Laptop", Price=50000}},
            {2, new Product{Id=2, Name="Mouse", Price=500}},
            {3, new Product{Id=3, Name="Keyboard", Price=1500}},
            {4, new Product{Id=4, Name="Monitor", Price=12000}},
            {5, new Product{Id=5, Name="USB Cable", Price=300}}
        };
        }

        private static void LoadCustomers()
        {
            Customers = new List<Customer>()
        {
            new Customer{Id=1, Name="Ankit"},
            new Customer{Id=2, Name="Rohit"},
            new Customer{Id=3, Name="Priya"}
        };
        }

        private static void LoadOrders()
        {
            Orders = new List<Order>();

            Order o1 = new Order { OrderId = 101, Customer = Customers[0] };
            o1.Items.Add(new OrderItem { Product = Products[1], Quantity = 1 });
            o1.Items.Add(new OrderItem { Product = Products[2], Quantity = 2 });

            Order o2 = new Order { OrderId = 102, Customer = Customers[1] };
            o2.Items.Add(new OrderItem { Product = Products[3], Quantity = 1 });
            o2.Items.Add(new OrderItem { Product = Products[5], Quantity = 3 });

            Orders.Add(o1);
            Orders.Add(o2);
        }
    }

}