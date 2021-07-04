namespace UserRegistration.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        void Save();
    }
}
