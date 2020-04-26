using System;

namespace LearnCSharp.HelloWorld
{
    class HelloWorld
    {
        static void Main()
        {
            var microwave = new Microwave<int>();
            var themostat = new Themostat();
            microwave.OnTemperatureChanged += themostat.TemperatureChangeHandler;
            microwave.OnTemperatureChanged += (int temp) =>
            {
                Console.WriteLine("Stopping heater temperature by lamda expression");
            };

            //microwave.OnTemperatureChanged(100);

            Console.Read();
        }
    }

    public class Themostat
    {
        public void TemperatureChangeHandler(int temperature)
        {
            Console.WriteLine($"Stopping heater temperature is at {temperature} degrees by themostat.");
        }
    }

    public class Microwave<T>
    {
        public event TemperatureChanged<T> OnTemperatureChanged;
    }

    public delegate void TemperatureChanged<T>(T temperature);
}
