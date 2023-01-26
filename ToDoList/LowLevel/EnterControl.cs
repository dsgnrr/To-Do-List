using System;
using System.Text.RegularExpressions;


namespace LowLevel
{
    static class EnterControl
    {
        static Regex regex = null;
        static public bool CheckPass(string password)
        {
            regex = new Regex("^(?=.{10,}$)(?=(?:.*?[A-Z]){2})(?=.*?[a-z])(?=(?:.*?[0-9]){2}).*$");
            if (regex.IsMatch(password))
                return true;
            else return false;
        }
        static public bool CheckLogin(string login)
        {
            regex = new Regex("^[A-Za-z]{1,6}$");
            if (regex.IsMatch(login))
                return true;
            else return false;
        }
        static public bool CheckAge(int age)
        {
            if (age <= 18 || age <= 90)
                return true;
            else return false;
        }
    }
}
