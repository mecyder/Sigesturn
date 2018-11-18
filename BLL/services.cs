using DAL;
using Entities;
using System.Collections.Generic;

namespace BLL
{
    public class services
    {
        public IEnumerable<Tbl_Services> getAllServices()
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                return repository.GetAll<Tbl_Services>();
            }
        }
    }
}