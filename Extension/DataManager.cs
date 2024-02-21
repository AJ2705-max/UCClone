using MySql.Data.MySqlClient;
using System.Data.Common;
using UrbanClapClone.BusinessManager.BAL;
using UrbanClapClone.BusinessManager.IBAL;
using UrbanClapClone.DataManager.DAL;
using UrbanClapClone.DataManager.IDAL;

namespace UrbanClapClone.Extension
{
    public static class DataManager
    {
        public static IServiceCollection AddAppSetting(this IServiceCollection services)
        {
            services.AddScoped<IDBManager>(AddDBManager);
            services.AddScoped<IUrbanBAL, UrbanBAL>();
            services.AddScoped<ILoginBAL, LoginBAL>();
          
            return services;
        }

        internal static IDBManager AddDBManager(IServiceProvider serviceProvider)
        {
            IConfiguration Configuration = serviceProvider.GetRequiredService<IConfiguration>();

            string dbconstr = Configuration.GetConnectionString("DefaultConnection");
            string salt = Configuration.GetValue<string>("salt");

            return GetDBManager(dbconstr, salt);
        }

        public static IDBManager GetDBManager(string connectionString,string salt)
        {
            DbConnection dbconn = new MySqlConnection(connectionString);

            return new DBManager(dbconn, salt);
        }
    }
}
