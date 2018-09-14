using System;

namespace SR.AutoMapper.Sample.UI.ViewModels
{
    public class UserViewModel : IViewModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }
    }
}