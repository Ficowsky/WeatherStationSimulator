namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-20, 55);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }
            Console.WriteLine($"Average temperature: {CalculateAverage(temperature)}");
            Console.WriteLine($"The min temp was: {temperature.Max()}");
            Console.WriteLine($"The min temp was: {temperature.Min()}");
            Console.WriteLine($"The most common condition was: {MostCommonCondiditon(weatherConditions)}");
            Console.ReadKey();
        }

        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }
            return sum / temperature.Length;

        }
        static string MostCommonCondiditon(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];
                for (int i = 0; i < conditions.Length; i++)
                 {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[i] == conditions[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
                
                }
            return mostCommon;

        }
    }
}
