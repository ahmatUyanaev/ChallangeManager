namespace ChallengeManager.DataAccess.Sessions
{
    public interface ISessionFactory
    {
        ISession CreateSession();
    }
}