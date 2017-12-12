using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dac;
using Mono.Options;

namespace SqlServer.Dac.Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlserver = string.Empty;
            var dacpacpath = string.Empty;
            var dbname = string.Empty;
            var method = string.Empty;
            bool help = false;
            var p = new OptionSet()
            {
                { "h|?|help", "show this message and exit.", v=> help = v != null},
                {"m|method=", "the method to call on the helper method. Available options: create, deploy, remove, ", v=> method = v },
                {"s|sqlserver=", "the FQDN/Alias of the SQL Server Instance.", v=> sqlserver = v },
                {"p|path:", "the path to the DacPac File.", v=> dacpacpath = v },
                {"d|database:", "the name of the database for deployment.", v=> dbname = v }
            };
            p.Parse(args);

            


            if (help)
                p.WriteOptionDescriptions(Console.Out);
        }
    }
}
