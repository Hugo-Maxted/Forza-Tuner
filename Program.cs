using System;

namespace Forza_Tuner {
    class Program {
        static public int front = 0;
        static public string type = "race";

        static float Percentage(float max, float min) {
            return (((max - min) * ((float) front / 100)) + min);
        }

        static void Main(string[] args) {
            Console.Write("Front (%): ");
            front = Convert.ToInt32(Console.ReadLine());

            Console.Write("Car Type (rally, race, offroad): ");
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
            Console.WriteLine("  Position: " + front + "%");
            Console.WriteLine("  Force: 100%");

            Console.WriteLine("Aero:");
            Console.WriteLine("  Front Spliter: Max");
            Console.WriteLine("  Rear Wing: Max");

            Console.WriteLine("Damping:");
            Console.Write("Max Front: ");
            float dampingMax = float.Parse(Console.ReadLine());
            Console.Write("Min Front: ");
            float dampingMin = float.Parse(Console.ReadLine());
            Console.WriteLine("  Front: " + Percentage(dampingMax, dampingMin));
            Console.WriteLine("  Rear: " + Percentage(dampingMax, dampingMin));
            Console.WriteLine("  Front: " + Percentage(dampingMax, dampingMin) * 0.7);
            Console.WriteLine("  Rear: " + Percentage(dampingMax, dampingMin) * 0.7);

            Console.WriteLine("Springs:");
            Console.Write("Max Front: ");
            float springsMax = float.Parse(Console.ReadLine());
            Console.Write("Min Front: ");
            float springMin = float.Parse(Console.ReadLine());
            Console.WriteLine("  Front: " + Percentage(springsMax, springMin));
            Console.WriteLine("  Rear: " + Percentage(springsMax, springMin));
            if (type == "offroad") {
                Console.WriteLine("  Front: Max");
                Console.WriteLine("  Rear: Max");
            } else {
                Console.WriteLine("  Front: Min");
                Console.WriteLine("  Rear: Min");
            }

            Console.WriteLine("Anti Rollbars:");
            Console.WriteLine("  Front: " + Percentage(65, 1));
            Console.WriteLine("  Front: " + Percentage(65, 1));

            Console.WriteLine("Alignment: Stock");

            Console.WriteLine("Gearing: Adjust final drive till all gears just fit on graph");

            Console.WriteLine("Tires: Stock");
        }
    }
}