namespace meteo
{
    public partial class Form1 : Form
    {
        List<Prevision> previsions = new List<Prevision>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Prevision nouvellePrevision = new Prevision();
            nouvellePrevision.Date = dateTimePicker.Value;
            

            if (int.TryParse(tBox_Min.Text, out int result) == false)
            {
                MessageBox.Show("Le format de la température minimale n'est pas valide!");
                return;
            }
            else
            {
                nouvellePrevision.TemperatureMin = int.Parse(tBox_Min.Text);
            }

            if (int.TryParse(tBox_Max.Text, out int result1) == false)
            {
                MessageBox.Show("Le format de la température maximale n'est pas valide!");
                return;
            }
            else
            {
                nouvellePrevision.TemperatureMax = int.Parse(tBox_Max.Text);
            }

            nouvellePrevision.Ciel = tBox_Ciel.Text;

            if (double.TryParse(tBox_Prob_Pluie.Text, out double result2) == false)
            {
                MessageBox.Show("Le format de la probabilité de pluie n'est pas valide!");
                return;
            }
            else
            {
                nouvellePrevision.ProbabilitePluie = double.Parse(tBox_Prob_Pluie.Text) * 100;
            }

            if (int.TryParse(tBox_Quantite_Pluie.Text, out int result3) == false)
            {
                MessageBox.Show("Le format de la quantité de pluie n'est pas valide!");
                return;
            }
            else
            {
                nouvellePrevision.QuantitePluie = int.Parse(tBox_Quantite_Pluie.Text);
            }

            if (int.TryParse(tBox_Vent.Text, out int result4) == false)
            {
                MessageBox.Show("Le format de la vitesse du vent n'est pas valide!");
                return;
            }
            else
            {
                nouvellePrevision.VitesseVent = int.Parse(tBox_Vent.Text);
            }

            if (double.Parse(tBox_Prob_Pluie.Text) > 1 | double.Parse(tBox_Prob_Pluie.Text) < 0)
            {
                MessageBox.Show("La probabilitée de la pluie doit �tre en decimal ou positif!");
                return;
            }
            if (DateTime.Now >= dateTimePicker.Value)
            {
                MessageBox.Show("Vous ne pouvez par faire de prévision pour aujourd'hui ou dans le passé");
                return;
            }
            lb_prevision.Items.Add(nouvellePrevision);
        }
        
        private void btn_afficher_Click(object sender, EventArgs e)
        {
            Prevision nouvellePrevision = (Prevision)lb_prevision.SelectedItem;
            if (nouvellePrevision != null)
            {
                MessageBox.Show("Le " + nouvellePrevision.Date.ToShortDateString() + ", la temperature sera entre " + nouvellePrevision.TemperatureMin.ToString() + " et " + nouvellePrevision.TemperatureMax.ToString() + "�C. Le ciel sera " + nouvellePrevision.Ciel + " et la probablilit�e de pluie est de " + nouvellePrevision.ProbabilitePluie.ToString() + "%. On attend environ " + nouvellePrevision.QuantitePluie.ToString() + "mm et des vent de " + nouvellePrevision.VitesseVent.ToString() + "Km/H.");
            }
        }
    }
}