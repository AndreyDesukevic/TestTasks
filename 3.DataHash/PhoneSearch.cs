using System;
using System.Collections.Generic;
using System.Text;

namespace _3.DataHash
{
    public class PhoneSearch
    {
        public static void Search()
        {
            Console.Clear();
            Console.WriteLine("Поиск");
            Console.Write("Ведите Фамилию: ");
            string lastName = Console.ReadLine();
            Console.Write("Ведите Имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Ведите Отчество: ");
            string middleName = Console.ReadLine();
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                MiddleName = middleName
            };
            int key = user.GetHashCode();
            if (PhoneList.phoneList.ContainsKey(key))
            {
                var userSearch = PhoneList.phoneList[key];
                Console.WriteLine(
                    userSearch.LastName + " " +
                    userSearch.FirstName + " " +
                    userSearch.MiddleName + " " +
                    userSearch.PhoneNumber);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Нет такого контакта!");
                Console.ReadLine();
            }

        }
    }
}
