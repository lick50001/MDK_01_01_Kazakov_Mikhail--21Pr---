using System.Data;
using System.Data.OleDb;

namespace Documents_Kazakov.Classes.Common
{
    public static class DBConnection
    {
        public static readonly string Path = @"C:\путь\к\вашей\Database.accdb"; // <-- Укажите реальный путь!

        public static OleDbConnection Connection()
        {
            var conn = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path};");
            conn.Open();
            return conn;
        }

        public static OleDbDataReader Query(string query, OleDbConnection connection)
        {
            var command = new OleDbCommand(query, connection);
            return command.ExecuteReader();
        }

        public static void CloseConnection(OleDbConnection connection)
        {
            connection?.Close();
        }
    }
}