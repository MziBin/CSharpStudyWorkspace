using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration.Ini;

namespace CourseManageDAL.Helper
{
    public class NewIniConfigHelper
    {
        public void ReadIniData()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .AddIniFile("config.ini")
           .Build();

            string username = configuration["Settings:Username"];
            string password = configuration["Settings:Password"];

            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Password: {password}");
        }

        public void WriteIniData()
        {
            var config1 = new ConfigurationBuilder()
           .AddInMemoryCollection()
           .Build();

            config1["Settings:Username"] = "newuser";
            config1["Settings:Password"] = "newpassword";
        }
    }
}
