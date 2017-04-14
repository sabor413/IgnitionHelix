namespace DI_MVC5.Core
{
    public class AnyHandler : IUserHandler
    {
        public string GetCurrentUser()
        {
            return "currentuser";
        }
    }
}