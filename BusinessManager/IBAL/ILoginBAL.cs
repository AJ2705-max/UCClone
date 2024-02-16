using UrbanClapClone.Models;

namespace UrbanClapClone.BusinessManager.IBAL
{
    public interface ILoginBAL
    {
        public UserLoginModel LoginUser(string UserName, string Password);
    }
}
