using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_CSharp_Specflow
{
    public static class SearchPage
    {
        public static string URL = "https://www.gmail.com.br";

        public static string FirstNameField = "firstName";

        public static string LastNameField = "lastName";

        public static string UserNameField = "//body/div/div/div[2]/div/div[2]/form/div[2]/div/div/div[2]/div/div/div/div/div/input";

        public static string PasswdField = "//body/div/div/div[2]/div/div[2]/form/div[2]/div/div/div[3]/div/div/div/div/div/div/div/input";

        public static string ConfPasswdField = "//body/div/div/div[2]/div/div[2]/form/div[2]/div/div/div[3]/div/div[3]/div/div/div/div/div/input";

        public static string PhoneField = "//body/div/div/div[2]/div/div[2]/form/div[2]/div/div/div/div[2]/div/div/div/input";

    }
}
