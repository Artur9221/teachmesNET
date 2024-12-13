using System;

namespace workone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=========================================================================================
            Console.WriteLine("Введите ваше ФИО:");
            string fulName = Console.ReadLine();
            Console.WriteLine("Введите дату рождения (дд.мм.гггг):");
            string dateofBirth = Console.ReadLine();
            Console.WriteLine($"Ваши данные: {fulName}\nдата рождения: {dateofBirth}");

            //=========================================================================================
            Console.WriteLine("Генератор стихов");

            List<string> list = new List<string>() { "День", "ночь", "белая", "Ветер", "цель", "мечта" };
            for (int i = 0; i < list.Count; i++)
            {
                if (char.IsUpper(list[i][0]))
                {
                    Console.Write($"{list[i]} ");
                    continue;
                }
                else
                {
                    Console.WriteLine($"{list[i]} ");
                    continue;
                }
            }
            //=========================================================================================
            Console.WriteLine();
            Console.WriteLine("Задание 3: Текстовый квест");

            Console.WriteLine("Вы находитесь в лесу. Перед вами два пути: налево и направо.Введите ваш выбор");
            Console.WriteLine("Введите куда вы пойдете, налево или направо");
            string inputСhoice = Console.ReadLine();
            if (inputСhoice.ToLower()== "налево")
            {
                Console.WriteLine("Там нет медведя ");
                Console.WriteLine("Можешь идти дальше, но без меня уже");
            }
            if (inputСhoice.ToLower() == "направо")
            {
                Console.WriteLine("Вы встретили медведя и убежали.");
                Console.WriteLine("Конец игры.");
            }


            //=========================================================================================
            Console.WriteLine();
            Console.WriteLine("Задание 4: Симулятор магазина Покупатель-продавец");

            double amountMoney = 450.00;

            double packСhips = 50.5;
            double pasta = 70.5;
            double soap = 20;
            double buckwheat = 50;
            bool Flag = true;
            List<string> goods = new List<string>()
            {
                "packСhips = 50.5 руб; номер товара 1",
                "pasta = 70.5 руб; номер товара 2",
                "soap = 20 руб; номер товара 3",
                "buckwheat = 50 руб; номер товара 4"
            };
            Console.WriteLine($"Добро пожаловать в магазин!  У вас на счету: {amountMoney}");
            foreach (var item in goods)
            {
                Console.WriteLine($"Вы можете купить товар {item} ");
            }


            while (amountMoney>0 && Flag==true) 
            {
                    Console.WriteLine("Выберете, что хотите купить");

                    uint number =Convert.ToUInt32( Console.ReadLine());

                    switch (number)
                    {
                        case 1: Console.WriteLine($"Вы купили товар под номером 1: {amountMoney-= packСhips}"); break;
                        case 2: Console.WriteLine($"Вы купили товар под номером 2: {amountMoney-= pasta}"); break;
                        case 3: Console.WriteLine($"Вы купили товар под номером 3: {amountMoney-= soap}"); break;
                        case 4: Console.WriteLine($"Вы купили товар под номером 4: {amountMoney-= buckwheat}"); break;
                        case 0: Console.WriteLine($"Всего доброго"); Flag = false;  break;

                    default: Console.WriteLine("Not 0"); break;
                    }
                    if (amountMoney>0)
                    Console.WriteLine($"У вас осталось на счету {amountMoney}");
                    else
                    Console.WriteLine($"Недостаточно средств {amountMoney}");
            }

        }
    }                                          
}
