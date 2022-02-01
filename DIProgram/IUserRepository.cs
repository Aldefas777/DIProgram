namespace DIProgram
{
    public interface IUserRepository
    {
        IEnumerable<User> GetOrderedUser(string connectionString);

        void AddUser(int id, string name, string connconnectionString);

        User GetUser(int idGet, string connectionString);
    }
}
