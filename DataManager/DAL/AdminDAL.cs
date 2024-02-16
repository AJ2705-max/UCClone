using System.Data;
using UrbanClapClone.DataManager.IDAL;
using UrbanClapClone.Models;

namespace UrbanClapClone.DataManager.DAL
{
    public class AdminDAL : IAdminDAL
    {
        readonly IDBManager _dBManager; 

        public AdminDAL(IDBManager dBManager)
        {
            _dBManager = dBManager;
        }

        public AdminRegistrationModel AddAdmin(AdminRegistrationModel umodel)
        {
           //model.Password = umodel.Password + _dBManager.getSalt();

            _dBManager.InitDbCommand("InsertAdmin", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("@AdminName", umodel.AdminName);
            _dBManager.AddCMDParam("@Password", umodel.Password);

            _dBManager.ExecuteNonQuery();

            return umodel;
        }
    }
}
