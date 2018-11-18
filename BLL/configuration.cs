using DAL;
using Entities;

namespace BLL
{
    public class configuration
    {
        public Tbl_Configuration retrieveConfiguration()
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                return repository.retrieve<Tbl_Configuration>(x => x.configurationID == 1);
            }
        }
    }
}