namespace DotNetTrainingBatch2.MiddlewareApp.Models
{
    public class LoginRequestModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class LoginResponseModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
