namespace C_Sharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Программа выводит через метод GetAllKindOfUsers всех возможные типы юзеров
            foreach (var kindOfUser in AUser.GetAllKindOfUsers())
            {
                Console.WriteLine(kindOfUser);
            }

            Admin admin = new Admin();
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Order? order1 = customer1.CreateOrder(); // order = new Order();

            bool success = customer1.SendMessage(admin, "help me"); // success = true
            success = customer1.SendMessage(customer2, "hi"); // success = false

            success = admin.BlockUser(customer1); // success = true, customer1.IsBlocked = true
            Order? order2 = customer1.CreateOrder(); // order = null

            Order? order3 = customer2.CreateOrder(); // order = new Order();

            Console.WriteLine($"Всего было сделано: {Order.orderCount} заказа");
        }
    }
}