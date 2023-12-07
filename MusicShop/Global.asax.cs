using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace MusicShop
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

        }
    }
    // declaring the connString here for easier access to switch 
    public static class MyStaticValues
    {
        public static string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\parke\\Documents\\MusicShopDB.mdf;Integrated Security=True;Connect Timeout=30";

    }
}

