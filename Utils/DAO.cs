using MySql.Data.MySqlClient;

namespace Utils
{
    public class DAO
    {
        protected MySqlConnection conn;

        static readonly string CONN_STRING =
            "server=localhost;user id=root;persistsecurityinfo=True;database=gestion_biblio;";

        public DAO()
        {
            this.conn = createConnexion();
        }

        public MySqlConnection createConnexion()
        {
            return new MySqlConnection(CONN_STRING);
        }
    }
}