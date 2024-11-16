using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public void PrintMemberInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Phone: {Phone}");
        }
    }
}
