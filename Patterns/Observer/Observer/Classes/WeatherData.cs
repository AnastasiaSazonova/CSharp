using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Observer
{
    public class WeatherData : Subject
    {
        private List<object> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        private float heatIndex;

        public WeatherData() 
        {
            observers = new List<object>();
        }

        public void registerObserver(Observer o) 
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o) 
        {
            int i = observers.IndexOf(o);
            if (i >= 0) 
            {
                observers.Remove(i);
            }
        }

        public void notifyObservers() 
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged() 
        {
            notifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.heatIndex = HeatIndex.computeHeatIndex(temperature, humidity);
            MeasurementsChanged();
        }
    }
}
