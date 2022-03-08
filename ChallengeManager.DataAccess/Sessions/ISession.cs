using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeManager.DataAccess.Sessions
{
    public interface ISession : IDisposable
    {
        Task<IEnumerable<T>> QueryAsync<T>(string query);

        Task<IEnumerable<T>> QueryAsync<T>(string query, object parametrs);

        Task<int> ExecuteAsync(string query, object parametrs);
    }
}