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
        private double probabilitéPluie;
        private int quantitéPluie;
        private int vitesseVent;
        private DateTime date;

        public int TemperatureMin { get => temperatureMin; set => temperatureMin = value; }
        public int TemperatureMax { get => temperatureMax; set => temperatureMax = value; }
        public string Ciel { get => ciel; set => ciel = value; }
        public double ProbabilitéPluie { get => probabilitéPluie; set => probabilitéPluie = value; }
        public int QuantitéPluie { get => quantitéPluie; set => quantitéPluie = value; }
        public int VitesseVent { get => vitesseVent; set => vitesseVent = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
