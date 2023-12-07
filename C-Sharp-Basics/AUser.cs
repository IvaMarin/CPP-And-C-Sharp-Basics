namespace C_Sharp_Basics
{
    internal abstract class AUser : IUser
    {
        public bool IsBlocked { get; set; }

        public void Login()
        {
            Console.WriteLine("Logged in");
        }

        public void Logout()
        {
            Console.WriteLine("Logged out");
        }

        public virtual bool SendMessage(IUser user, string text)
        {
            return true;
        }

        public static Type[] GetAllKindOfUsers()
        {
            return new Type[] { typeof(Admin), typeof(Customer) };
        }

    }
}
