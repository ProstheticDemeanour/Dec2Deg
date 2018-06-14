using System;


namespace Dec2Deg
{
    class Degrees
    {

        public double pdecimal;
        public int whole;
        public double result;


        public void convert(int degrees, double minutes, double seconds)
        {
            whole = degrees;
            pdecimal = seconds / 60;

            minutes = minutes + pdecimal;
            pdecimal = minutes / 60;

            result = whole + pdecimal;

         }

       

    }


    class Program
    {
        static void Main(string[] args)
        {
            int degrees;
            double minutes;
            double seconds;

            Degrees location = new Degrees();

            degrees = int.Parse(args[0]);
            minutes = double.Parse(args[1]);
            seconds = double.Parse(args[2]);

            location.convert(degrees, minutes, seconds);

            Console.WriteLine("Conversion Complete....Decimal Location: {0}", location.result);
            

        }
    }
}
