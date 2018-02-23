using CrossFinance.Database;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CrossFinance
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            CrossFinanceDBContext crossFinanceDBContext = new CrossFinanceDBContext();
        }
    }
}
