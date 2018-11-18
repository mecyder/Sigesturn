using System.Data.SqlClient;
using System.Web.Http;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            SqlDependency.Start(@"data source=.\SqlExpress;initial catalog=DB_Gestion_Turnos;persist security info=True;user id=sa;password=P@$$w0rd;MultipleActiveResultSets=True;");
        }

        private void Application_End()
        {
            SqlDependency.Stop(@"data source=.\SqlExpress;initial catalog=DB_Gestion_Turnos;persist security info=True;user id=sa;password=P@$$w0rd;MultipleActiveResultSets=True;");
        }
    }
}