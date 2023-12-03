namespace C_Sharp_Basics
{
    internal class User
    {
        private bool _hasRights = false;

        public void DeleteOrder()
        {
            if (_hasRights)
            {
                Console.WriteLine("DeleteOrder is Successed");
            }
            else
            {
                Console.WriteLine("No Access");
            }
        }
        public void CreateOrder() { }
        public void SendOrder()
        {
            if (_hasRights)
            {
                Console.WriteLine("SendOrder is Successed");
            }
            else
            {
                Console.WriteLine("No Access");
            }
        }

        public void Autorization(Privilege previlege)
        {
            if (previlege.Code == 3)
            {
                _hasRights = true;
            }
        }
    }
}
