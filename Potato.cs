using System;

namespace GrowUp
{
    internal class Potato : Vegetable
    {
        public Potato(string? plant, int water, int agro, int light) : base(plant, water, agro, light)
        {
            this._plant = plant;
            this._water = water;
            this._agro = agro;
            this._light = light;
        }
        public bool checkPotato()
        {
            if(this._water == 1 && this._agro >= 1 && this._light >= 1)
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
