using DAL;
using Entities;

namespace BLL
{
    public class Security
    {
        public tbl_User login(string user, string password)
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                return repository.retrieve<tbl_User>(x => x.userUsername == user && x.userPassword == password);
            }
        }
    }
}