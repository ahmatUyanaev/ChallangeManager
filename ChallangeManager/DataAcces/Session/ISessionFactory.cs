using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallangeManager.DataAcces.Session
{
    public interface ISessionFactory
    {
        ISession CreateSession();
    }
}
