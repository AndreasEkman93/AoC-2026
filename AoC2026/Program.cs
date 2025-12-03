namespace AoC2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var input = File.ReadAllLines("input.txt");
            var dialPosition = 50;
            var dialMaxValue = 99;
            var dialMinValue = 0;
            var timesHit0 = 0;

            foreach (var line in input)
            {
                string direction = line.Substring(0, 1);
                int value = int.Parse(line.Substring(1));
                value = value % 100; // Normalize value to be within 0-99

                if (direction == "L")
                {
                    Console.Write(dialPosition + " - " + value + " = ");

                    dialPosition = (dialPosition - value + 100) % 100; // Wrap around using modulo

                    Console.Write(dialPosition + "\n");

                    if (dialPosition == 0)
                    {
                        timesHit0++;
                    }
                }
                else if (direction == "R")
                {
                    Console.Write(dialPosition + " + " + value + " = ");

                    dialPosition = (dialPosition + value) % 100; // Wrap around using modulo

                    Console.Write(dialPosition + "\n");
                    if (dialPosition == 0)
                    {
                        timesHit0++;
                    }
                }
                else
                {
                    Console.WriteLine("Error, the line was neither L nor R");
                }

            }
            Console.WriteLine($"The loop is finished, times i hit 0 is {timesHit0}.");
        }
    }
}
