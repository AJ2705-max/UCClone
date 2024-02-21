namespace UrbanClapClone.Models
{
    public class UserLoginModel
    {
        public int GetId { get; set; }

        public int GetRole { get; set; }

        public string GetPassword { get; set; }
       
        public string ExistingPassword { get; set; }
        
        public bool NameExist { get; set; }
    }
}
