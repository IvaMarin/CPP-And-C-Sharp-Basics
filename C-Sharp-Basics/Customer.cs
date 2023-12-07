namespace C_Sharp_Basics
{
    internal class Customer : AUser
    {
        public Order? CreateOrder()
        {
            if (IsBlocked)
            {
                return null;
            }
            return new Order();
        }

        public override bool SendMessage(IUser user, string text)
        {
            if (user is Customer)
            {
                return false;
            }
            return true;
        }
    }
}
