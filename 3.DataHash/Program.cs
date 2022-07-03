using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.DataHash
{
    public class Program
    {
        public static Dictionary<int, User> phoneList = new Dictionary<int, User>();

        static void Main(string[] args)
        {
            PhoneList.AddUsers();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Создать запись" +
                    "\n2.Удалить запись" +
                    "\n3.Вывести на экран все записи телефонной книги" +
                    "\n4.Поиск записи" +
                    "\n5.Редактировать" +
                    "\n6.Выход");
                Console.Write("Ведите команду: ");

                string com = Console.ReadLine();

                switch (com)
                {
                    case "1":
                        PhoneNew.AddPhone();
                        break;
                    case "2":
                        PhoneDelete.DeleteUser();
                        break;
                    case "3":
                        PhoneView.View();
                        break;
                    case "4":
                        PhoneSearch.Search();
                        break;
                    case "5":
                        PhoneEdit.Edit();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Не верная команда. Попробуйте еще раз.\n");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
