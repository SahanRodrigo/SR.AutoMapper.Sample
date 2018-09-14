using System;
using System.Collections.Generic;
using System.Linq;
using SR.AutoMapper.Sample.Domain.Infrastructure.Entities;

namespace SR.AutoMapper.Sample.Domain.Repositories
{
    public interface IUserRepository
    {
        User GetUseById(Guid id);
        IEnumerable<User> GetUsers();
    }

    public class UserRepository : IUserRepository
    {
        public User GetUseById(Guid id)
        {
            return ListOfUsers.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return this.ListOfUsers;
        }

        private IEnumerable<User> ListOfUsers => new List<User>
            {
                new User
                {
                    Id = new Guid("9D300A16-A8D3-4302-B373-0CF51E6A725C"),
                    CreatedDate = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Deleted = false,
                    FirstName = "Sahan",
                    LastName = "Rodrigo",
                    Email = "sahan.rodrigo@techwhizin.com",
                    DateOfBirth = new DateTime(1972, 10, 08)

                },
                new User
                {
                    Id = new Guid("E08D1F9C-7707-43F5-9ACA-3A484ED4C7BB"),
                    CreatedDate = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Deleted = false,
                    FirstName = "Mark",
                    LastName = "Reed",
                    Email = "mark.reed@techwhizin.com",
                    DateOfBirth = new DateTime(1968, 07, 22)
                },
                new User
                {
                    Id = new Guid("A86167C1-21FC-485F-92D2-C4F17F905547"),
                    CreatedDate = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Deleted = false,
                    FirstName = "Kevin",
                    LastName = "White",
                    Email = "kevin.white@techwhizin.com",
                    DateOfBirth = new DateTime(1990, 06, 16)
                }
            };
    }
}