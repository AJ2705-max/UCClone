using UrbanClapClone.BusinessManager.IBAL;
using UrbanClapClone.DataManager.DAL;
using UrbanClapClone.DataManager.IDAL;
using UrbanClapClone.Models;

namespace UrbanClapClone.BusinessManager.BAL
{
    public class LoginBAL : ILoginBAL
    {
        ILoginDAL _ILoginDAL;

        public LoginBAL(IDBManager dBManager)
        {
            _ILoginDAL = new LoginDAL(dBManager);
        }

        public UserLoginModel LoginUser(string UserName, string pass, int Id)
        {
            UserLoginModel login = new UserLoginModel();

            login.NameExist = _ILoginDAL.CheckNameExist(UserName);

            login.GetPassword = _ILoginDAL.GetPassword(pass);
            
            login.ExistingPassword = _ILoginDAL.LoginUser(UserName);

            login.GetRole = _ILoginDAL.GetRole(UserName);
            
            login.GetId = _ILoginDAL.GetId(UserName);


            //login.Password = _ILoginDAL.LoginUser(UserName);
            //  return _ILoginDAL.LoginUser(UserName);
            return login;
        }
    }
}
