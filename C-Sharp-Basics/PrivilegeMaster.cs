namespace C_Sharp_Basics
{
    internal class PrivilegeMaster
    {
        public Privilege GetPrivilege(User user)
        {
            Privilege privilege = null;
            switch (user)
            {
                case Admin:
                    privilege = new Privilege(3);
                    break;
                case Customer:
                    privilege = new Privilege(2);
                    break;
                case Seller:
                    privilege = new Privilege(3);
                    break;
                default:
                    Console.WriteLine("Error: unknown user type");
                    break;
            }
            return privilege;
        }
    }
}
