namespace UrbanClapClone.Models
{
    public class UserRegistrationModel
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public int Role { get; set; }
    }
}
