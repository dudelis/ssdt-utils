using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dac;

namespace SqlServer.Dac.Helper
{
    public class DacServicesUtil
    {
        private DacServices ds;
        SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();

        public DacServicesUtil(string servername)
        {
            sb.IntegratedSecurity = true;
            sb.DataSource = servername;
            sb.Pooling= false;
            ds = new DacServices(sb.ConnectionString);
        }

        public void Deploy(string dbname, string dacpacpath, DacDeployOptions options)
        {
            var dp = DacPackage.Load(dacpacpath);
            ds.Deploy(dp, dbname, true, options);
        }
    }
}
