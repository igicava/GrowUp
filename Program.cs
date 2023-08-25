using System;

namespace GrowUp
{
    internal class Program
    {
        static void Main()
        {
            var assistant = new Assistant("Александр", "студент");
            var corn = new Corn("Кукуруза", 0, 0, 0);
            var tomato = new Tomato("Помидор", 0, 0, 0);
            var potato = new Potato("Картофель", 0, 0, 0);
            string? plant;
            string? reg;

            Console.WriteLine("Начало симуляции...");
            for(byte i = 8; i <= 19; i++)
            {
                Console.WriteLine("\nВремя: " + i + ":00. Вы зашли в кабинет с опытными образцами. Выберете образец:\nКукуруза - 1\nПомидор - 2\nКартофель - 3\n");
                plant = Console.ReadLine();
                Console.WriteLine("\nВыберете действие:\n1 - Полить\n2 - Добавить удабрение\n3 - Прибавить света\n");
                reg = Console.ReadLine();
                if(plant == "1" && reg == "1")
                {
                    assistant.printWater(corn);
                }
                else if(plant == "1" && reg == "2")
                {
                    assistant.printAgro(corn);
                }
                else if(plant == "1" && reg == "3")
                {
                    assistant.printLight(corn);
                }
                else if(plant == "2" && reg == "1")
                {
                    assistant.printWater(tomato);
                }
                else if(plant == "2" && reg == "2")
                {
                    assistant.printAgro(tomato);
                }
                else if(plant == "2" && reg == "3")
                {
                    assistant.printLight(tomato);
                }
                else if(plant == "3" && reg == "1")
                {
                    assistant.printWater(potato);
                }
                else if(plant == "3" && reg == "2")
                {
                    assistant.printAgro(potato);
                }
                else if(plant == "3" && reg == "3")
                {
                    assistant.printLight(potato);
                }
                else
                {
                    Console.WriteLine("Не корректно введённые данные!");
                }
            }
            assistant.printInfo();

            corn.printVegetableInfo();
            bool r1 = corn.checkCorn();

            tomato.printVegetableInfo();
            bool r2 = tomato.checkTomato();

            potato.printVegetableInfo();
            bool r3 = potato.checkPotato();

            assistant.printResult(r1, r2, r3);
        }
    }
}
