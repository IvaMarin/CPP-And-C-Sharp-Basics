namespace C_Sharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrivilegeMaster master = new PrivilegeMaster();
            Customer customer = new Customer();

            Privilege privilege = master.GetPrivilege(customer);
            customer.Autorization(privilege);
            customer.DeleteOrder(); // В консоль вывод "No Access"

            Seller seller = new Seller();
            privilege = master.GetPrivilege(seller);
            seller.Autorization(privilege);
            seller.SendOrder(); // В консоль вывод "SendOrder is Successed""
        }
    }
}