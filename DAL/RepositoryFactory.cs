namespace DAL
{
    public class RepositoryFactory
    {
        public static IRepository CreateRepository()
        {
            var cntx = new DB_Gestion_TurnosEntities();
            cntx.Configuration.ProxyCreationEnabled = false;
            return new Repository(cntx);
        }
    }
}