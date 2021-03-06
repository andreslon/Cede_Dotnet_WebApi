﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cede_Dotnet_WebApi.ADOSample
{
    public interface IConnection
    {
        DataTable GetInfo(string query);

        bool ExecuteQuery(string query);

        bool ExecuteSP(string nameSP, Dictionary<string, object> parameters);

        DataTable GetInfoConected(string query);
    }
}
