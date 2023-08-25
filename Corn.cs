using System;

namespace GrowUp
{
    class Corn : Vegetable
    {
        public Corn(string? plant, int water, int agro, int light) : base(plant, water, agro, light)
        {
            this._plant = plant;
            this._water = water;
            this._agro = agro;
            this._light = light;
        }
        public bool checkCorn()
        {
            if(this._water >= 2 && this._agro == 1 && this._light >= 1)
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
