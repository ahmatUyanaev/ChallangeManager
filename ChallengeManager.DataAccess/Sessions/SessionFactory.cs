using System.Data.SqlClient;

namespace ChallengeManager.DataAccess.Sessions
{
    public class SessionFactory : ISessionFactory
    {
        public ISession CreateSession()
        {
            var connString = @"Data Source=DESKTOP-29CFBJD\SQLEXPRESS;Initial Catalog=ChallengeDB;Integrated Security=True";
            var connection = new SqlConnection(connString);
            connection.Open();

            return new Session(connection);
        }
    }
}