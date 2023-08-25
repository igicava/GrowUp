using System;

namespace GrowUp
{
    class Vegetable
    {
        public string? _plant;
        public int _water;
        public int _agro;
        public int _light;

        public Vegetable(string? plant, int water, int agro, int light)
        {
            this._plant = plant;
            this._water = water;
            this._agro = agro;
            this._light = light;
        }

        public void printVegetableInfo()
        {
            Console.WriteLine("Имя объекта: " + this._plant);
            Console.WriteLine("Насыщенность водой: " + this._water);
            Console.WriteLine("Насыщенность питательными веществами: " + this._agro);
            Console.WriteLine("Насыщенность светом: " + this._light);
        }
    }
}