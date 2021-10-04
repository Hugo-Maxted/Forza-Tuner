using System;

namespace Forza_Tuner {
    class Program {
        static public int front = 0;
        static public string type = "race";

        static double Percentage(float max, float min, bool inverse) {
            return Math.Round((((max - min) * (inverse ? (1 - ((float) front / 100)) : ((float) front / 100))) + min), 1);
        }

        static void Main(string[] args) {
            Console.Write("Front (%): ");
            front = Convert.ToInt32(Console.ReadLine());

            Console.Write("Car use (road, dirt, offroad): ");
            type = Console.ReadLine();

            Console.WriteLine("Differential Settings:");
            Console.WriteLine("  Front:");
            Console.WriteLine("    Acceleration: 25%");
            Console.WriteLine("    Deceleration: 0%");
            Console.WriteLine("  Rear:");
            Console.WriteLine("    Acceleration: 50%");
            Console.WriteLine("    Deceleration: 0%");
            Console.WriteLine("  Center: 70%");

            Console.WriteLine("Brake:");
            Console.WriteLine("  Balance: " + front + "%");
            Console.WriteLine("  Pressure: 100%");

            Console.WriteLine("Aero:");
            Console.WriteLine("  Front Spliter: Max");
            Console.WriteLine("  Rear Wing: Max");

            Console.WriteLine("Damping:");
            Console.WriteLine("  Rebound:");
            Console.Write("    Front Maximum: ");
            float maxReboundFront = float.Parse(Console.ReadLine());
            Console.Write("    Front Minimum: ");
            float minReboundFront = float.Parse(Console.ReadLine());
            Console.WriteLine("    Front: " + Percentage(maxReboundFront, minReboundFront, false));
            Console.Write("    Rear Maximum: ");
            float maxReboundRear = float.Parse(Console.ReadLine());
            Console.Write("    Rear Minimum: ");
            float minReboundRear = float.Parse(Console.ReadLine());
            Console.WriteLine("    Rear: " + Percentage(maxReboundRear, minReboundRear, true));
            Console.WriteLine("  Bump:");
            Console.WriteLine("    Front: " + Percentage(maxReboundFront, minReboundFront, false) * 0.7);
            Console.WriteLine("    Rear: " + Percentage(maxReboundRear, minReboundRear, true) * 0.7);

            Console.WriteLine("Springs:");
            Console.WriteLine("  Springs:");
            Console.Write("    Front Maximum: ");
            float maxSpringsFront = float.Parse(Console.ReadLine());
            Console.Write("    Front Minimum: ");
            float minSpringsFront = float.Parse(Console.ReadLine());
            Console.WriteLine("    Front: " + Percentage(maxSpringsFront, minSpringsFront, false));
            Console.Write("    Rear Maximum: ");
            float maxSpringsRear = float.Parse(Console.ReadLine());
            Console.Write("    Rear Minimum: ");
            float minSpringsRear = float.Parse(Console.ReadLine());
            Console.WriteLine("    Rear: " + Percentage(maxSpringsRear, minSpringsRear, true));
            Console.WriteLine("  Height:");
            Console.WriteLine("    Front: " + (type == "offroad" ? "Max" : "Min"));
            Console.WriteLine("    Rear: " + (type == "offroad" ? "Max" : "Min"));

            Console.WriteLine("Anti Rollbars:");
            Console.WriteLine("  Front: " + Percentage(65, 1, false));
            Console.WriteLine("  Front: " + Percentage(65, 1, true));

            Console.WriteLine("Alignment: Stock");

            Console.WriteLine("Gearing: Adjust final drive till all gears just fit on graph");

            Console.WriteLine("Tires: Stock");

            Console.ReadLine();
        }
    }
}