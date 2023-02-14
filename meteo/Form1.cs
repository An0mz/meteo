namespace meteo
{
    public partial class Form1 : Form
    {
        List<Prevision> previsions = new List<Prevision>();
        public Form1()
        {
            InitializeComponent();
        }
     
        private void btn_afficher_Click(object sender, EventArgs e)
        {
            Prevision nouvellePrevision = (Prevision)lb_prevision.SelectedItem;
            if (nouvellePrevision != null)
            {
                MessageBox.Show("Le " + nouvellePrevision.Date.ToShortDateString() + ", la température sera entre " + nouvellePrevision.TemperatureMin.ToString() + " et " + nouvellePrevision.TemperatureMax.ToString() + "°C. Le ciel sera " + nouvellePrevision.Ciel + " et la probabilitée de pluie est de " + nouvellePrevision.ProbabilitePluie.ToString() + "%. On attend environ " + nouvellePrevision.QuantitePluie.ToString() + "mm de pluie avec des vent d'une vitesse de " + nouvellePrevision.VitesseVent.ToString() + "Km/H.");
            }
        }
    }
}