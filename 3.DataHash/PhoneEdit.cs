using System;
using System.Collections.Generic;
using System.Text;

namespace _3.DataHash
{
    public class PhoneEdit
    {
        public static void Edit()
        {
            Console.Clear();
            Console.Write("Ведите Фамилию изменяемого: ");
            string lastName = Console.ReadLine();
            Console.Write("Ведите Имя изменяемого: ");
            string firstName = Console.ReadLine();
            Console.Write("Ведите Отчество изменяемого: ");
            string middleName = Console.ReadLine();

            int keyUserWhichEdit = (firstName + lastName + middleName).GetHashCode();
            if (PhoneList.phoneList.ContainsKey(keyUserWhichEdit))
            {
                var UserWhichEdit = PhoneList.phoneList[keyUserWhichEdit];
                Console.Clear();
                Console.WriteLine(UserWhichEdit.LastName + " " + UserWhichEdit.FirstName + " " + UserWhichEdit.MiddleName + " " + UserWhichEdit.PhoneNumber);
                Console.WriteLine("1.Редактировать Имя" +
                       "\n2.Редактировать Фамилию" +
                       "\n3.Редактировать Отчество" +
                       "\n4.Редактировать Номер Телефона");

                Console.Write("Ведите команду: ");

                string com = Console.ReadLine();

                switch (com)
                {
                    case "1":
                        Console.WriteLine("Введите новое Имя: ");
                        string newFirstName = Console.ReadLine();
                        var newUser1 = new User()
                        {
                            FirstName = newFirstName,
                            LastName = UserWhichEdit.LastName,
                            MiddleName = UserWhichEdit.MiddleName,
                            PhoneNumber = UserWhichEdit.PhoneNumber
                        };
                        PhoneList.phoneList.Add(newUser1.GetHashCode(), newUser1);
                        PhoneList.phoneList.Remove(keyUserWhichEdit);
                        Console.WriteLine("Имя изменено!");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Введите новую Фамилию: ");
                        string newLastName = Console.ReadLine();
                        var newUser2 = new User()
                        {
                            FirstName = UserWhichEdit.FirstName,
                            LastName = newLastName,
                            MiddleName = UserWhichEdit.MiddleName,
                            PhoneNumber = UserWhichEdit.PhoneNumber
                        };
                        PhoneList.phoneList.Add(newUser2.GetHashCode(), newUser2);
                        PhoneList.phoneList.Remove(keyUserWhichEdit);
                        Console.WriteLine("Фамилия изменена!");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Введите новое Отчество: ");
                        string newMiddleName = Console.ReadLine();
                        var newUser3 = new User()
                        {
                            FirstName = UserWhichEdit.FirstName,
                            LastName = UserWhichEdit.LastName,
                            MiddleName = newMiddleName,
                            PhoneNumber = UserWhichEdit.PhoneNumber
                        };
                        PhoneList.phoneList.Add(newUser3.GetHashCode(), newUser3);
                        PhoneList.phoneList.Remove(keyUserWhichEdit);
                        Console.WriteLine("Отчество изменено!");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Введите новый номер телефона: ");
                        string newPhoneNumber = Console.ReadLine();
                        UserWhichEdit.PhoneNumber = newPhoneNumber;
                        Console.WriteLine("Номер телефона изменен!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Не верная команда. Попробуйте еще раз.\n");
                        break;
                }


            }
            else
            {
                Console.WriteLine("Нет такого контакта!");
                Console.ReadLine();
            }

        }
    }
}
