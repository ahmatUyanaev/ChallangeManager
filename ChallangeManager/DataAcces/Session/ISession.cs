using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallangeManager.DataAcces.Session
{
    public interface ISession : IDisposable
    {
        Task<IEnumerable<T>> QueryAsync<T>(string query);

        Task<IEnumerable<T>> QueryAsync<T>(string query, object parametrs);

        Task<int> ExecuteAsync(string query, object parametrs);
    }
}
