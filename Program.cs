using DesignPatternsImplementation.Factory;
using DesignPatternsImplementation.Singleton;
using DesignPatternsImplementation.Observer;

namespace DesignPatternsImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton Pattern
            Console.WriteLine("=== Singleton Pattern ===");
            var logger1 = Logger.Instance;
            logger1.Log("Starting application...");
            var logger2 = Logger.Instance;
            logger2.Log("Using the same Logger instance.");
            Console.WriteLine($"Logger instances are the same: {object.ReferenceEquals(logger1, logger2)}\n");

            //Factory Pattern
            Console.WriteLine("=== Factory Pattern ===");
            IDocument pdfDoc = DocumentFactory.CreateDocument("pdf");
            pdfDoc.print();

            IDocument wordDoc = DocumentFactory.CreateDocument("word");
            wordDoc.print();
            Console.WriteLine();

            //Observer Pattern
            Console.WriteLine("=== Observer Pattern ===");
            WeatherStation station = new WeatherStation();

            WeatherDisplay display1 = new WeatherDisplay("Display 1");
            WeatherDisplay display2 = new WeatherDisplay("Display 2");

            station.RegisterObserver(display1);
            station.RegisterObserver(display2);

            station.SetMeasurements(32.5f, 70.0f);
            station.SetMeasurements(30.0f, 65.0f);

            station.RemoveObserver(display1);

            station.SetMeasurements(29.5f, 60.0f);
        }
    }
}