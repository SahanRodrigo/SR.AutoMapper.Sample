using AutoMapper;
using SR.AutoMapper.Sample.Domain.Repositories;
using SR.AutoMapper.Sample.Services;
using SR.AutoMapper.Sample.Services.Configurations.AutoMapper;
using Xunit;

namespace SR.AutoMapper.Sample.UnitTests
{
    public class UserServiceTests
    {
        [Fact]
        public void ShouldGetListOfUsers()
        {
            var userAutoMapperProfile = new UserDomainDtoProfile();
            var autoMapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile(userAutoMapperProfile));
            var mapper = new Mapper(autoMapperConfiguration);

            var userRepository = new UserRepository();
            var sut = new UserService(mapper, userRepository);

            var users = sut.GetUsers();

            Assert.Equal(3, users.Count);
        }
    }
}