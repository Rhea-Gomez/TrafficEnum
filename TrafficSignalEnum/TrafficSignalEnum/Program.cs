namespace TrafficSignalEnum
{
    internal class Program
    {
        public enum TrafficLight
        {
            RED,
            YELLOW,
            GREEN
        }

        public static void Action(TrafficLight signal)
        {
           
            if(signal == TrafficLight.RED)
            {
                Console.WriteLine("Signal: RED -> Stop");
            } else if(signal == TrafficLight.YELLOW)
            {
                Console.WriteLine("Signal: YELLOW -> Get Ready");
            } else if (signal == TrafficLight.GREEN)
            {
                Console.WriteLine("Signal: GREEN -> Go");
            }
            else
            {
                Console.WriteLine("Invalid Signal");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic Signal");
            Console.WriteLine("RED \nYELLOW \nGREEN");
            Console.Write("Enter your choice: ");
            string signal = Console.ReadLine();

            bool isValid = Enum.TryParse<TrafficLight>(signal, true, out TrafficLight light);

            if (isValid)
            {
                Action(light);
            }
            else
            {
                Console.WriteLine("Invalid Signal");
            }

        }
    }
}
