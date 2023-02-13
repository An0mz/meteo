namespace meteo
{
    public partial class Form1 : Form
    {
        Pr�vision min = new Pr�vision();
        Pr�vision max = new Pr�vision();
        Pr�vision ciel = new Pr�vision();
        Pr�vision probPluie = new Pr�vision();
        Pr�vision quantPluie = new Pr�vision();
        Pr�vision vent = new Pr�vision();
        Pr�vision date = new Pr�vision();
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tBox_Min.Text, out int result) == false)
            {
                MessageBox.Show("Le format de la temp�rature minimale n'est pas valide!");
                return;
            }
            else
            {
                min.TemperatureMin = int.Parse(tBox_Min.Text);
            }

            if (int.TryParse(tBox_Max.Text, out int result1) == false)
            {
                MessageBox.Show("Le format de la temp�rature maximale n'est pas valide!");
                return;
            }
            else
            {
                max.TemperatureMax = int.Parse(tBox_Max.Text);
            }

            ciel.Ciel = tBox_Ciel.Text;

            if (double.TryParse(tBox_Prob_Pluie.Text, out double result2) == false)
            {
                MessageBox.Show("Le format de la probabilit� de pluie n'est pas valide!");
                return;
            }
            else
            {
                probPluie.Probabilit�Pluie = double.Parse(tBox_Prob_Pluie.Text) * 100;
            }

            if (int.TryParse(tBox_Quantit�_Pluie.Text, out int result3) == false)
            {
                MessageBox.Show("Le format de la quantit� de pluie n'est pas valide!");
                return;
            }
            else
            {
                quantPluie.Quantit�Pluie = int.Parse(tBox_Quantit�_Pluie.Text);
            }

            if (int.TryParse(tBox_Vent.Text, out int result4) == false)
            {
                MessageBox.Show("Le format de la vitesse du vent n'est pas valide!");
                return;
            }
            else
            {
                vent.VitesseVent = int.Parse(tBox_Vent.Text);
            }

            date.Date = dateTimePicker.Value;

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
            if (lb_prevision.Items.Contains("Pr�vision : " + date.Date.ToShortDateString()))
            {
                MessageBox.Show("Vous ne pouvez pas faire plusieur pr�vision pour la m�me journ�e!");
            }
            else
            {
                lb_prevision.Items.Add(Name = "Pr�vision : " + date.Date.ToShortDateString());
            }
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {

        }
    }
}