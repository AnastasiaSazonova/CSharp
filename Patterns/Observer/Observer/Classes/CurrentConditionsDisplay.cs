using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float heatIndex;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure) 
        {         
            this.temperature = temperature;
            this.humidity = humidity;
            this.heatIndex = HeatIndex.computeHeatIndex(temperature, humidity);
            Display();       
        }

        public void Display() 
        {
            Console.WriteLine("Current conditions: " + temperature + " F degrees and " + humidity + " % humidity and heat index = " + heatIndex);
        }
    }
}
