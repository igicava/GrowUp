using System;

namespace GrowUp
{
    class Assistant
    {
        private string? _name;
        private string? _description;
        private bool _r1;
        private bool _r2;
        private bool _r3;

        public Assistant(string? name, string? description)
        {
            this._name = name;
            this._description  =  description;
        }
        public void printInfo()
        {
            Console.WriteLine("Имя лаборанта: " + this._name);
            Console.WriteLine("Должность лаборанта: " + this._description);
        }
        public void printWater(Vegetable plant)
        {
            plant._water += 1;
            Console.WriteLine("Лаборант " + this._name + " успешно полил " + plant._plant);
        }
        public void printAgro(Vegetable plant)
        {
            plant._agro += 1;
            Console.WriteLine("Лаборант " + this._name + " успешно удобрил " + plant._plant);
        }
        public void printLight(Vegetable plant)
        {
            plant._light += 1;
            Console.WriteLine("Лаборант " + this._name + " успешно увеличил освещение для " + plant._plant);
        }
        public void printResult(bool r1, bool r2, bool r3)
        {
            this._r1 = r1;
            this._r2 = r2;
            this._r3 = r3;
            if(this._r1 == true && this._r2 == true && this._r3 == true)
            {
                printInfo();
                Console.WriteLine("Прошёл аттестацию и допущен до работы с настоящими опытными образцами.");
            }
            else
            {
                printInfo();
                Console.WriteLine("Не прошёл аттестацию. Отправляется на пересдачу.");
            }
        }
    }
}