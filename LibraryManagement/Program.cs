using LibraryManagement;
using System;
namespace LibrearyManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                Title = "Write It Down, Make It Happen",
                Author = "Henriette Ann Klauser",
                Year = 2020,
                ISBN = "987-600-6235-86-8"
            };
            Member member = new Member
            {
                MemberID = 1,
                Name = "Parnia Jaafari",
                Phone = "09396078496"
            };
            book.PrintInfo();
            Console.WriteLine();
            member.PrintMemberInfo();
        }
    }
}
