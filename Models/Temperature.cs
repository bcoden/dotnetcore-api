using System;

namespace Api.Models
{
    public class Temperature {
        private scales _scale = scales.Celcius;
        private int _unit = 0; // absolute 0

        public enum scales
        {
            Fahrenheight,
            Celcius
        }

        public int unit { 
            get {
                return _unit;
            } 
            set {
                _unit = value;
            }
        }

        public Temperature toCelcius() {
            _scale = scales.Celcius;
            _unit = (unit-32)*(9/5); 
            return this;
        }
        
        public Temperature toFahrenheit() {
            _scale = scales.Fahrenheight;
            _unit = (unit * 9/5)+32;
            return this;
        }

        public string toString() {
            string _format = "{0} °C";
            if (_scale == scales.Fahrenheight) {
                _format = "{0} °F";
            } 
            return String.Format(_format, unit);
        }
    }
}