using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._3
{
    class Satelite
    {
        public string sateliteName = " ";

        public double _weight = 1;
        public double weight
        {
            get { return _weight; }
            set
            {
                if (value <= 0) throw new Exception("Масса спутника не может быть меньше или равна 0");
                else _weight = value;
            }
        }

        public double _heightOrbit = 1;
        public double heightOrbit
        {
            get { return _heightOrbit; }
            set
            {
                if (value < 160 || value > 36000) throw new Exception("Высота орбиты спутника не может быть меньше 160 км и больше 36000км");
                else _heightOrbit = value;
            }
        }

        public double _speed = 1;
        public double speed
        {
            get { return _speed; }
            set
            {
                if (value < 0 || value > 300000000) throw new Exception("Скорость орбиты спутника не может быть меньше нуля и больше скорости света(3*10^9 км/ч)");
                else _speed = value;
            }
        }

        public const int earthWidth = 40000;


        public void printInfo ()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Название спутника: {this.sateliteName}\tМасса спутника: {this.weight}\tВысота орбиты: {this.heightOrbit}\tСкорость: {this.speed}\tДлина окружности Земли: {earthWidth}");
            //Console.WriteLine("Название спутника: " + this.sateliteName + "\tМасса спутника: " + this.weight + "\tВысота орбиты: " + this.heightOrbit + "\tСкорость: " +  this.speed + "\tДлина окружности Земли: " + earthWeight);
            
        }
    }
}
