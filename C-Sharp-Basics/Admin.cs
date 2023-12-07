namespace C_Sharp_Basics
{
    internal class Admin : AUser
    {
        public bool BlockUser(IUser user)
        {
            AUser? auser = user as AUser;
            if (auser != null)
            {
                auser.IsBlocked = true;
                return true;
            }

            return false;
        }
    }
}
