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
            if (double.Parse(tBox_Prob_Pluie.Text) > 1)
            {
                MessageBox.Show("La probabilit� de la pluie doit �tre en decimal!");
                return;
            }
            if (DateTime.Now >= dateTimePicker.Value)
            {
                MessageBox.Show("Vous ne pouvez par faire de pr�vision pour aujourd'hui ou dans le pass�");
                return;
            }
            lb_prevision.Items.Add("Pr�vision : " + date.Date.ToShortDateString());
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {

        }
    }
}