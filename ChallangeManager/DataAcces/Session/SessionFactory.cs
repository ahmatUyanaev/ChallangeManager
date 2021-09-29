using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ChallangeManager.DataAcces.Session
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
