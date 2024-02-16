using System.Data;
using UrbanClapClone.CommonCode;
using UrbanClapClone.DataManager.IDAL;
using UrbanClapClone.Models;

namespace UrbanClapClone.DataManager.DAL
{
    public class UrbanDAL : IUrbanDAL
    {
        readonly  IDBManager _dBManager;

        public UrbanDAL(IDBManager dBManager)
        {
            _dBManager = dBManager;
        }

        public List<UserRegistrationModel> GetUserList()
        {
            List<UserRegistrationModel> userlist = new List<UserRegistrationModel>();

            _dBManager.InitDbCommand("GetAllUser", CommandType.StoredProcedure);

            DataSet ds = _dBManager.ExecuteDataSet();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                UserRegistrationModel model = new UserRegistrationModel();

                model.Id = item["Id"].ConvertDBNullToInt();
                model.UserName = item["UserName"].ConvertDBNullToString();
                model.Password = item["Password"].ConvertDBNullToString();

                userlist.Add(model);
            }
            return userlist;
        }

        public UserRegistrationModel AddUser(UserRegistrationModel umodel) 
        {
            umodel.Password = umodel.Password + _dBManager.getSalt();

            _dBManager.InitDbCommand("InsertUser", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("@p_UserName", umodel.UserName);
            _dBManager.AddCMDParam("@p_Password", umodel.Password);

            _dBManager.ExecuteNonQuery();

            return umodel;
        }
    }
}
