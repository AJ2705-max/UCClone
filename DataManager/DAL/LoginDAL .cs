using System.Data;
using UrbanClapClone.CommonCode;
using UrbanClapClone.DataManager.IDAL;

namespace UrbanClapClone.DataManager.DAL
{
    public class LoginDAL : ILoginDAL
    {
        readonly IDBManager _dBManager;

        public LoginDAL(IDBManager dbManager)
        {
            _dBManager = dbManager;
        }

        public string LoginUser(string UserName)
        {
            string existingPassword = null;

            _dBManager.InitDbCommand("GetUserPassword", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("@p_UserName", UserName);

            DataSet ds = _dBManager.ExecuteDataSet();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                existingPassword = item["Password"].ConvertDBNullToString();
            }

            return existingPassword;
        }

        public int GetId(string UserName) 
        {
            _dBManager.InitDbCommand("GetId", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("@IUserName", UserName);

            var result = _dBManager.ExecuteScalar();

            int id = Convert.ToInt32(result);

            return id;
        }

        public bool CheckNameExist(string UserName) 
        {
            _dBManager.InitDbCommand("CheckNameExist", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("@newUserName", UserName);
           // _dBManager.AddCMDParam("Id", Id);

            var result = _dBManager.ExecuteScalar();

            bool nameExists = Convert.ToBoolean(result);

            return nameExists;
        }

        public string GetPassword(string pass) 
        {
            pass = pass + _dBManager.getSalt();

            _dBManager.InitDbCommand("GetPassword" , CommandType.StoredProcedure);
            
            _dBManager.AddCMDParam("@user_pass", pass);
            
            var result = _dBManager.ExecuteScalar();

            string getpassword = Convert.ToString(result);

            return getpassword;
        }

    }
}

