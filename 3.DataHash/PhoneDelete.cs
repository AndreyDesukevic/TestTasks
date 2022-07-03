using System;
using System.Collections.Generic;
using System.Text;

namespace _3.DataHash
{
    public class PhoneDelete
    {
        public static void DeleteUser()
        {
            Console.Clear();
            Console.WriteLine("Список:");
            foreach (var (key, User) in PhoneList.phoneList)
            {
                Console.WriteLine(User.LastName + " " + User.FirstName + " " + User.MiddleName + " " + User.PhoneNumber);
            }
            Console.Write("Ведите Фамилию удаляемого: ");
            string lastName = Console.ReadLine();
            Console.Write("Ведите Имя удаляемого: ");
            string firstName = Console.ReadLine();
            Console.Write("Ведите Отчество удаляемого: ");
            string middleName = Console.ReadLine();
            int keyUserWhichDelete = (firstName + lastName + middleName).GetHashCode();
            PhoneList.phoneList.Remove(keyUserWhichDelete);
            Console.Clear();
            Console.WriteLine("Удалено!");
            Console.ReadLine();
        }
    }
}
