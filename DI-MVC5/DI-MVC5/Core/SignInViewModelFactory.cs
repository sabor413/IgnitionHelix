namespace DI_MVC5.Core
{
    public class SignInViewModelFactory : IViewModelFactory
    {
        private readonly IUserHandler userHandler;
        private readonly ILogger logger;

        public SignInViewModel Create(bool input)
        {
            logger.Info("UserDetailsViewModelFactory: Entering Create");
            var user = userHandler.GetCurrentUser();
            return new SignInViewModel
            {
                ShowSignIn = input,
                IsSignedIn = user != null
            };
        }
    }
}