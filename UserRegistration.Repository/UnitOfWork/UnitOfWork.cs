using System;
using UserRegistration.Repository.Interfaces;
using UserRegistration.Repository.Repositories;

namespace UserRegistration.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserRepository _user = new();

        public IUserRepository User { get { return _user; } }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
