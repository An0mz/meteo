namespace meteo
{
    public partial class Form1 : Form
    {
        Prévision min = new Prévision();
        Prévision max = new Prévision();
        Prévision ciel = new Prévision();
        Prévision probPluie = new Prévision();
        Prévision quantPluie = new Prévision();
        Prévision vent = new Prévision();
        Prévision date = new Prévision();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            min.TemperatureMin = int.Parse(tBox_Min.Text);
            max.TemperatureMax = int.Parse(tBox_Max.Text);
            ciel.Ciel = tBox_Ciel.Text;
            probPluie.ProbabilitéPluie = double.Parse(tBox_Prob_Pluie.Text) * 100;
            quantPluie.QuantitéPluie = int.Parse(tBox_Quantité_Pluie.Text);
            vent.VitesseVent = int.Parse(tBox_Vent.Text);
            date.Date = dateTimePicker.Value;
            MessageBox.Show(min.TemperatureMin.ToString());
            MessageBox.Show(max.TemperatureMin.ToString());
            MessageBox.Show(ciel.Ciel.ToString());
            if (double.Parse(tBox_Prob_Pluie.Text) > 1)
            {
                MessageBox.Show("La probabilité de la pluie doit être en decimal!");
            }
            else
            {
                MessageBox.Show(probPluie.ProbabilitéPluie.ToString() + "%");
            }
            MessageBox.Show(quantPluie.QuantitéPluie.ToString() + "mm");
            MessageBox.Show(vent.VitesseVent.ToString() + "Km/H");
            MessageBox.Show(date.Date.ToShortDateString());
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {

        }
    }
}