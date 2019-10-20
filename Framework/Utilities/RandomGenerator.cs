using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Framework.Utilities
{
    public class RandomGenerator
    {
        public static string GenerateMail()
        {
            return $"{Guid.NewGuid().ToString().Substring(0, 6)}@gmail.com";

            //var fixture = new Fixture();
            //fixture.Customize<MyClass>(c => c.With(x => x.EmailAddresses, fixture.CreateMany<MailAddress>().Select(x => x.Address)));

            //return fixture.Create<MyClass>();
            
        }
    }
}
