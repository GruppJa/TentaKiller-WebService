﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace TentaKillerWebApplication
{
    public class DatabaseConnection
    {
        public static string ConnectionString
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            }
        }
    }
}