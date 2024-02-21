namespace UrbanClapClone.DataManager.IDAL
{
    public interface ILoginDAL
    {
        public string LoginUser(string UserName);

        public bool CheckNameExist(string UserName);

        public int GetId(string UserName);

        public int GetRole(string UserName);

        public string GetPassword(string pass);
    }
}
