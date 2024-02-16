using UrbanClapClone.BusinessManager.IBAL;
using UrbanClapClone.DataManager.DAL;
using UrbanClapClone.DataManager.IDAL;
using UrbanClapClone.Models;


namespace UrbanClapClone.BusinessManager.BAL
{
    public class UrbanBAL : IUrbanBAL
    {
        IUrbanDAL _IUrbanDAL;

        public UrbanBAL(IDBManager dBManager) 
        {
            _IUrbanDAL = new UrbanDAL(dBManager);
        }
        
        public List<UserRegistrationModel> GetUserList() 
        {
            return _IUrbanDAL.GetUserList();
        }

        public UserRegistrationModel Register(UserRegistrationModel umodel) 
        {

            return _IUrbanDAL.AddUser(umodel);
        }
    }
}
