using UrbanClapClone.Models;

namespace UrbanClapClone.DataManager.IDAL
{
    public interface IUrbanDAL
    {
        public List<UserRegistrationModel> GetUserList();
        public UserRegistrationModel AddUser(UserRegistrationModel umodel);

    }
}
