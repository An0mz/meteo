using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meteo
{
    public class Prevision
    {
        private int temperatureMin;
        private int temperatureMax;
        private string ciel = "";
        private double probabilitePluie;
        private int quantitePluie;
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
                if (value > 101)
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
        public double ProbabilitePluie { get => probabilitePluie;
            set
            {
                if (value < 0)
                {
                    probabilitePluie = 0;
                }
                else
                {
                    probabilitePluie = value;
                }
            }
        }
        public int QuantitePluie { get => quantitePluie;
            set
            {
                if (value < 0)
                {
                    quantitePluie = 0;
                }
                else
                {
                    quantitePluie = value;
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

        public override string? ToString()
        {
            return Date.ToShortDateString();
        }
    }
}
