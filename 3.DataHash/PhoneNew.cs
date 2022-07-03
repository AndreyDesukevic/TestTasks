using System;
using System.Collections.Generic;
using System.Text;

namespace _3.DataHash
{
    public class PhoneNew
    {
        public static void AddPhone()
        {
            Console.Clear();
            Console.Write("Ведите Фамилию: ");
            string lastName = Console.ReadLine();
            Console.Write("Ведите Имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Ведите Отчество: ");
            string middleName = Console.ReadLine();
            Console.Write("Ведите номер телефона: ");
            string phoneNumber = Console.ReadLine();

            var userWhichAdd = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                MiddleName = middleName,
                PhoneNumber = phoneNumber
            };
            int keyUserWhichAdd = userWhichAdd.GetHashCode();

            if (!PhoneList.phoneList.ContainsKey(keyUserWhichAdd))
            {
                PhoneList.phoneList.Add(keyUserWhichAdd, userWhichAdd);
                Console.WriteLine("Записанно!");
            }
            else
            {
                Console.WriteLine("Такая запись существует!");
            }
            Console.ReadLine();
        }

    }
}
