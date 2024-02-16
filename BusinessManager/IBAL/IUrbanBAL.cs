using Microsoft.AspNetCore.Mvc;
using UrbanClapClone.Models;

namespace UrbanClapClone.BusinessManager.IBAL
{
    public interface IUrbanBAL
    {
       // public List<UserLoginModel> GetUserList();

        public List<UserRegistrationModel> GetUserList();

        public UserRegistrationModel Register(UserRegistrationModel sign);

        
    }
}
