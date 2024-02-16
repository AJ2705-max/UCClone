using System.Data;
using UrbanClapClone.DataManager.DAL;


namespace UrbanClapClone.DataManager.IDAL
{
    public interface IDBManager
    {
        DBManager InitDbCommand(string cmd);
        DBManager InitDbCommandText(string cmd);
        DBManager InitDbCommand(string cmd, CommandType cmdtype);
        DBManager AddCMDParam(string parametername, object value);
        DBManager AddCMDParam(string parametername, object value, DbType dbtype);
        DBManager AddCMDOutParam(string parametername, DbType dbtype, int iSize = 0);

        T GetOutParam<T>(string paramname);
        DataTable ExecuteDataTable();
        DataSet ExecuteDataSet();

        object? ExecuteScalar();

        Task<object?> ExecuteScalarAsync();
        int ExecuteNonQuery();
        Task<int> ExecuteNonQueryAsync();

        public string getSalt();

    }
}
