using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business
{
    public class DataManager
    {
        public bool AddUser(string name,string tel,string email)
        {
            if (name.Length < 4) return false;
            if (!Regex.IsMatch(tel, "[0-9]")) return false;
            if (!email.Contains("@")) return false;

            return true;
        }
        public int Addition(int s1, int s2) => s1 + s2;
    }
}
