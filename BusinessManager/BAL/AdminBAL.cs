using UrbanClapClone.BusinessManager.IBAL;
using UrbanClapClone.DataManager.DAL;
using UrbanClapClone.DataManager.IDAL;
using UrbanClapClone.Models;

namespace UrbanClapClone.BusinessManager.BAL
{
    public class AdminBAL : IAdminBAL
    {
        IAdminDAL _IAdminDAL;

        public AdminBAL(IDBManager dBManager) 
        {
            _IAdminDAL = new AdminDAL(dBManager);
        }

        public AdminRegistrationModel Register(AdminRegistrationModel umodel)
        {

            return _IAdminDAL.AddAdmin(umodel);
        }
    }
}
