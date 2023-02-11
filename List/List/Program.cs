using List;
using System;
namespace ListUse
{
    public class ListExample
    {
        public static void Main(string[] args)
        {
            var studentData = new List<student>();
            for (int i = 1; i <= 2; i++) {
                Console.WriteLine("Enter Name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Emal");
                var email = Console.ReadLine();
                Console.WriteLine("Enter Phone");
                var phone = Console.ReadLine();
                studentData.Add(new student()
                {
                    Name = name,
                    Email = email,
                    Phone = phone,
                    Id = i

                });
             }
            foreach(var sD in studentData)
            {
                Console.WriteLine("Name:{0}",sD.Name);
                Console.WriteLine("Email:{0}", sD.Email);
                Console.WriteLine("Phone:{0}", sD.Phone);
                Console.WriteLine("");
            }
            Console.ReadLine();        }
    }
}