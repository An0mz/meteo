namespace meteo
{
    public partial class Form1 : Form
    {
        List<Pr�vision> previsions = new List<Pr�vision>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Pr�vision nouvellePrevision = new Pr�vision();
            nouvellePrevision.Date = dateTimePicker.Value;
            

            if (int.TryParse(tBox_Min.Text, out int result) == false)
            {
                MessageBox.Show("Le format de la temp�rature minimale n'est pas valide!");
                return;
            }
            else
            {
                nouvellePrevision.TemperatureMin = int.Parse(tBox_Min.Text);
            }

            if (int.TryParse(tBox_Max.Text, out int result1) == false)
            {
                MessageBox.Show("Le format de la temp�rature maximale n'est pas valide!");
                return;
            }
            else
            {
                nouvellePrevision.TemperatureMax = int.Parse(tBox_Max.Text);
            }

            nouvellePrevision.Ciel = tBox_Ciel.Text;

            if (double.TryParse(tBox_Prob_Pluie.Text, out double result2) == false)
            {
                MessageBox.Show("Le format de la probabilit� de pluie n'est pas valide!");
                return;
            }
            else
            {
                nouvellePrevision.Probabilit�Pluie = double.Parse(tBox_Prob_Pluie.Text) * 100;
            }

            if (int.TryParse(tBox_Quantit�_Pluie.Text, out int result3) == false)
            {
                MessageBox.Show("Le format de la quantit� de pluie n'est pas valide!");
                return;
            }
            else
            {
                nouvellePrevision.Quantit�Pluie = int.Parse(tBox_Quantit�_Pluie.Text);
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
                MessageBox.Show("La probabilit� de la pluie doit �tre en decimal ou positif!");
                return;
            }
            if (DateTime.Now >= dateTimePicker.Value)
            {
                MessageBox.Show("Vous ne pouvez par faire de pr�vision pour aujourd'hui ou dans le pass�");
                return;
            }
            lb_prevision.Items.Add(nouvellePrevision);
            //if (lb_prevision.Items.Contains("Pr�vision : " + date.Date.ToShortDateString()))
            //{
            //    MessageBox.Show("Vous ne pouvez pas faire plusieur pr�vision pour la m�me journ�e!");
            //}
            //else
            //{
            //    lb_prevision.Items.Add("Pr�vision : " + date.Date.ToShortDateString());
            //}
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {

        }
    }
}