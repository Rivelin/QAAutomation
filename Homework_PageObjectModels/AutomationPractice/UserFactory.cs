using System;

namespace AutomationPractice
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                FirstName = "Ivelin",
                LastName = "Ironman",
                Year = "2016",
                Month = "4",
                Date = "30",
                Password = "123456",
                PostCode = "80000",
                Address = "Moon",
                City = "Burgas",
                State = "Arizona",
                Phone = "825886",
                Alias = "SweetHome",
                RealFirstName = "Ivelin",
                RealLastName = "Ironman"
            };
        }
    }
}
