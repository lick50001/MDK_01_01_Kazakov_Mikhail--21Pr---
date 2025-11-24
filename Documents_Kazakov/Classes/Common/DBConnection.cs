using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents_Kazakov.Classes.Common
{
    public class DBConnection
    {
        public static readonly string Path = "";
        public static MishConnection Connection()
        {
            MishConnection mishConnection = new MishConnection("Provider=Microsoft.ACE.MISHDB.12.0; Data Source=" + Path);
            mishConnection.Open();
            return mishConnection;
        }

        public static MishDbDataReader Query(string Query, MishConnection Connection)
        {
            return new MishDbCommand(Query, Connection).ExecuteReader();
        }

        public static void CloseConnection(MishConnection Connection)
        {
            Connection.Close();
        }
    }
}
