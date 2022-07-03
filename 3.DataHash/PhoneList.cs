using System;
using System.Collections.Generic;
using System.Text;

namespace _3.DataHash
{
    public class PhoneList
    {
        public static Dictionary<int, User> phoneList = new Dictionary<int, User>();
        public static void AddUsers()
        {
            var user1= new User { FirstName = "Илья", LastName = "Антонов", MiddleName = "Дмитриевич", PhoneNumber = "80253340716" };
            var user2 = new User { FirstName = "Максим", LastName = "Кисилев", MiddleName = "Сергеевич", PhoneNumber = "80297765617" };
            var user3 = new User { FirstName = "Артур", LastName = "Попов", MiddleName = "Владимирович", PhoneNumber = "80253340333" };
            var user4 = new User { FirstName = "Олег", LastName = "Сидоров", MiddleName = "Александрович", PhoneNumber = "80253340234" };
            var user5 = new User { FirstName = "Василий", LastName = "Антонов", MiddleName = "Дмитриевич", PhoneNumber = "80283323716" };
            var user6 = new User { FirstName = "Александр", LastName = "Иванов", MiddleName = "Дмитриевич", PhoneNumber = "80254344716" };
            var user7 = new User { FirstName = "Сергей", LastName = "Потапов", MiddleName = "Александрович", PhoneNumber = "80253389716" };
            var user8 = new User { FirstName = "Андрей", LastName = "Пинчук", MiddleName = "Алексеевич", PhoneNumber = "80253349124" };
            var user9 = new User { FirstName = "Илья", LastName = "Попов", MiddleName = "Дмитриевич", PhoneNumber = "80323340716" };
            var user10 = new User { FirstName = "Андрей", LastName = "Михаленя", MiddleName = "Андреевич", PhoneNumber = "80271140716" };
            var user11 = new User { FirstName = "Иван", LastName = "Жук", MiddleName = "Олегович", PhoneNumber = "80252345716" };
            var user12 = new User { FirstName = "Алексей", LastName = "Антонов", MiddleName = "Русланович", PhoneNumber = "80253234560" };
            var user13 = new User { FirstName = "Владислав", LastName = "Веремейчик", MiddleName = "Артурович", PhoneNumber = "80253340000" };
            var user14 = new User { FirstName = "Дмитрий", LastName = "Бризинский", MiddleName = "Магомедович", PhoneNumber = "80259999999" };
            var user15 = new User { FirstName = "Илья", LastName = "Андрейчиков", MiddleName = "Олегович", PhoneNumber = "80295555555" };
            var user16 = new User { FirstName = "Магомед", LastName = "Бекетов", MiddleName = "Артурович", PhoneNumber = "80253346666" };
            var user17 = new User { FirstName = "Илья", LastName = "Богданец", MiddleName = "Максимович", PhoneNumber = "80258321112" };
            var user18 = new User { FirstName = "Владислав", LastName = "Ларионов", MiddleName = "Дмитриевич", PhoneNumber = "80252222222" };
            var user19 = new User { FirstName = "Дмитрий", LastName = "Антонов", MiddleName = "Андреевич", PhoneNumber = "80250000000" };
            var user20 = new User { FirstName = "Максим", LastName = "Михаленя", MiddleName = "Сергеевич", PhoneNumber = "80253672123" };
            var user21 = new User { FirstName = "Василий", LastName = "Акулич", MiddleName = "Ибрагимович", PhoneNumber = "80253399999" };
            var user22 = new User { FirstName = "Артур", LastName = "Ибрагимов", MiddleName = "Сергеевич", PhoneNumber = "80253340716" };

            phoneList.Add(user1.GetHashCode(), user1);
            phoneList.Add(user2.GetHashCode(), user2);
            phoneList.Add(user3.GetHashCode(), user3);
            phoneList.Add(user4.GetHashCode(), user4);
            phoneList.Add(user5.GetHashCode(), user5);
            phoneList.Add(user6.GetHashCode(), user6);
            phoneList.Add(user7.GetHashCode(), user7);
            phoneList.Add(user8.GetHashCode(), user8);
            phoneList.Add(user9.GetHashCode(), user9);
            phoneList.Add(user10.GetHashCode(), user10);
            phoneList.Add(user11.GetHashCode(), user11);
            phoneList.Add(user12.GetHashCode(), user12);
            phoneList.Add(user13.GetHashCode(), user13);
            phoneList.Add(user14.GetHashCode(), user14);
            phoneList.Add(user15.GetHashCode(), user15);
            phoneList.Add(user16.GetHashCode(), user16);
            phoneList.Add(user17.GetHashCode(), user17);
            phoneList.Add(user18.GetHashCode(), user18);
            phoneList.Add(user19.GetHashCode(), user19);
            phoneList.Add(user20.GetHashCode(), user20);
            phoneList.Add(user21.GetHashCode(), user21);
            phoneList.Add(user22.GetHashCode(), user22);
        }
    }
}
