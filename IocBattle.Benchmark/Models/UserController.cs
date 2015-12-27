namespace IocBattle.Benchmark.Models
{
    public class UserController
    {
        private IAuthenticationService authService;
        private IRepository repository;

        //[Inject]
        public UserController(IRepository repository, IAuthenticationService authService)
        {
            this.repository = repository;
            this.authService = authService;
        }
    }
}