using System;

namespace GrowUp
{
    class Tomato : Vegetable
    {
        public Tomato(string? plant, int water, int agro, int light) : base(plant, water, agro, light)
        {
            this._plant = plant;
            this._water = water;
            this._agro = agro;
            this._light = light;
        }

        public bool checkTomato()
        {
            if(this._water >= 1 && this._agro > 0 && this._light >= 2)
            {
                Console.WriteLine("Результат:\nОбразец выжил\n");
                return true;
            }
            else
            {
                Console.WriteLine("Результат:\nОбразец погиб\n");
                return false;
            }
        }
    }
}
