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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            min.TemperatureMin = int.Parse(tBox_Min.Text);
            max.TemperatureMax = int.Parse(tBox_Max.Text);
            ciel.Ciel = tBox_Ciel.Text;
            probPluie.Probabilit�Pluie = double.Parse(tBox_Prob_Pluie.Text) * 100;
            quantPluie.Quantit�Pluie = int.Parse(tBox_Quantit�_Pluie.Text);
            vent.VitesseVent = int.Parse(tBox_Vent.Text);
            date.Date = dateTimePicker.Value;
            MessageBox.Show(min.TemperatureMin.ToString());
            MessageBox.Show(max.TemperatureMin.ToString());
            MessageBox.Show(ciel.Ciel.ToString());
            if (double.Parse(tBox_Prob_Pluie.Text) > 1)
            {
                MessageBox.Show("La probabilit� de la pluie doit �tre en decimal!");
            }
            else
            {
                MessageBox.Show(probPluie.Probabilit�Pluie.ToString() + "%");
            }
            MessageBox.Show(quantPluie.Quantit�Pluie.ToString() + "mm");
            MessageBox.Show(vent.VitesseVent.ToString() + "Km/H");
            MessageBox.Show(date.Date.ToShortDateString());
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {

        }
    }
}