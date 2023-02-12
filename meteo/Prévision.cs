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
        private string ciel;
        private int probabilitéPluie;
        private int quantitéPluie;
        private int vitesseVent;
        private int date;

        public int TemperatureMin { get => temperatureMin; set => temperatureMin = value; }
        public int TemperatureMax { get => temperatureMax; set => temperatureMax = value; }
        public string Ciel { get => ciel; set => ciel = value; }
        public int ProbabilitéPluie { get => probabilitéPluie; set => probabilitéPluie = value; }
        public int QuantitéPluie { get => quantitéPluie; set => quantitéPluie = value; }
        public int VitesseVent { get => vitesseVent; set => vitesseVent = value; }
        public int Date { get => date; set => date = value; }
    }
}
