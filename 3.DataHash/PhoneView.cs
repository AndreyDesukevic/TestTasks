using System;
using System.Collections.Generic;
using System.Text;

namespace _3.DataHash
{
    public class PhoneView
    {
        public static void View()
        {
            Console.Clear();
            foreach (var (key, User) in PhoneList.phoneList)
            {
                Console.WriteLine(User.LastName + " " + User.FirstName + " " + User.MiddleName + " " + User.PhoneNumber);
            }
            Console.ReadLine();
        }
    }
}
