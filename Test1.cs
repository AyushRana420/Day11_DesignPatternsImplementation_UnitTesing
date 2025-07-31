using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsImplementation.Singleton;
using DesignPatternsImplementation.Factory;
using DesignPatternsImplementation.Observer;

namespace Assignment2_Tesing
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Logger_ShouldReturnSameInstance()
        {
            var logger1 = Logger.Instance;
            var logger2 = Logger.Instance;

            Assert.AreSame(logger1, logger2);
        }

    }
    [TestClass]
    public class FactoryTests
    {
        [TestMethod]
        public void DocumentFactory_ShouldReturnPDFDocument()
        {
            var doc = DocumentFactory.CreateDocument("pdf");
            Assert.IsInstanceOfType(doc, typeof(PDFDocument));
        }

        [TestMethod]
        public void DocumentFactory_ShouldReturnWordDocument()
        {
            var doc = DocumentFactory.CreateDocument("word");
            Assert.IsInstanceOfType(doc, typeof(WordDocument));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DocumentFactory_ShouldThrowOnInvalidType()
        {
            DocumentFactory.CreateDocument("excel");
        }
    }

    [TestClass]
    public class ObserverTests
    {
        private class TestObserver : IObserver
        {
            public float LastTemperature { get; private set; }
            public float LastHumidity { get; private set; }

            public void Update(float temperature, float humidity)
            {
                LastTemperature = temperature;
                LastHumidity = humidity;
            }
        }

        [TestMethod]
        public void WeatherStation_ShouldNotifyObservers()
        {
            var station = new WeatherStation();
            var observer = new TestObserver();
            station.RegisterObserver(observer);

            station.SetMeasurements(25.5f, 60.0f);

            Assert.AreEqual(25.5f, observer.LastTemperature);
            Assert.AreEqual(60.0f, observer.LastHumidity);
        }

        [TestMethod]
        public void WeatherStation_ShouldNotNotifyUnregisteredObservers()
        {
            var station = new WeatherStation();
            var observer = new TestObserver();
            station.RegisterObserver(observer);
            station.RemoveObserver(observer);

            station.SetMeasurements(28.0f, 70.0f);

            Assert.AreEqual(0, observer.LastTemperature);
            Assert.AreEqual(0, observer.LastHumidity);
        }
    }
}
