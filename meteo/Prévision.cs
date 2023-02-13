using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meteo
{
    public class Prévision
    {
        private int temperatureMin;
        private int temperatureMax;
        private string ciel = "Couvert";
        private double probabilitéPluie;
        private int quantitéPluie;
        private int vitesseVent;
        private DateTime date;
        private int fahrenheit;

        public int TemperatureMin { get => temperatureMin; 
            set
            {
                if (value < -274)
                {
                    temperatureMin = -273;
                }
                else
                {
                    temperatureMin = value;
                }
            }
        }
        public int TemperatureMax { get => temperatureMax; 
            set
            {
                if (value > 100)
                {
                    temperatureMax = 100;
                }
                else
                {
                    temperatureMax = value;
                }
            }
        }
        public string Ciel { get => ciel; set => ciel = value; }
        public double ProbabilitéPluie { get => probabilitéPluie;
            set
            {
                if (value < 0)
                {
                    probabilitéPluie = 0;
                }
                else
                {
                    probabilitéPluie = value;
                }
            }
        }
        public int QuantitéPluie { get => quantitéPluie;
            set
            {
                if (value < 0)
                {
                    quantitéPluie = 0;
                }
                else
                {
                    quantitéPluie = value;
                }
            }
        }
        public int VitesseVent { get => vitesseVent;
            set
            {
                if (value < 0)
                {
                    vitesseVent = 0;
                }
                else
                {
                    vitesseVent = value;
                }
            }
        }
        public DateTime Date { get => date; set => date = value; }
    }
}
