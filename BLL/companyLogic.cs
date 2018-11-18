using DAL;
using Entities;

namespace BLL
{
    public class companyLogic
    {
        #region Construtor

        public companyLogic()
        {
        }

        #endregion Construtor

        #region Methods

        /// <summary>
        /// get 1 company
        /// </summary>
        /// <param name="_companyID"></param>
        /// <returns>bool</returns>
        public Tbl_Company retrieveCompanyObject(int _companyID)
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                return repository.retrieve<Tbl_Company>(x => x.companyID == _companyID);
            }
        }

        /// <summary>
        /// create company
        /// </summary>
        /// <param name="companytoCreate"></param>
        /// <returns>bool</returns>
        public bool createCompany(Tbl_Company companytoCreate)
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                return repository.create<Tbl_Company>(companytoCreate);
            }
        }

        /// <summary>
        /// update company
        /// </summary>
        /// <param name="companytoUpdate"></param>
        /// <returns>bool</returns>
        public bool updateCompany(Tbl_Company companytoUpdate)
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                return repository.update<Tbl_Company>(companytoUpdate);
            }
        }

        /// <summary>
        /// delete to company
        /// </summary>
        /// <param name="companytoDelete"></param>
        /// <returns>bool</returns>
        public bool deleteCompany(Tbl_Company companytoDelete)
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                return repository.delete<Tbl_Company>(companytoDelete);
            }
        }

        #endregion Methods
    }
}