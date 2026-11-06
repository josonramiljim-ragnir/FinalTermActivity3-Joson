using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace ACTIVITY3_JOSONN
{
    internal class Database
    {
        public static readonly String DBpATH =
            Path.GetFullPath(
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\sampledb.accdb"
                 )
             );

        // Fixed: Changed "Persists Security Info" to "Persist Security Info"
        private static readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBpATH + ";Persist Security Info=False;";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }
    }
}