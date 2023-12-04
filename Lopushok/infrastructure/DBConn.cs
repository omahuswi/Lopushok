using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lopushok.infrastructure
{
    internal class DBConn
    {
        public static String ConnString = $"Host=localhost;Port=5432;Username=postgres;Password=11111111;Database=lapushok";
        public static NpgsqlConnection db = new NpgsqlConnection(ConnString);
    }
}
