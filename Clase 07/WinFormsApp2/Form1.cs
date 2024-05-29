namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, Dictionary<string, double>> catalogoPetshop = new Dictionary<string, Dictionary<string, double>>();
            catalogoPetshop.Add("Alimento para gatos adultos",
                                new Dictionary<string, double> { { "Cat Chow", 900 }, { "Wiskats", 1200 }, { "Pedigree", 1800 } });

            catalogoPetshop.Add("Alimento para perros cachorros",
                                new Dictionary<string, double> { { "Dog Chow", 1500 }, { "ProPlan", 2500 }, { "Pedigree", 5800 } });

            lstAlimentos.Items.Add("Seccion\t\t\t\tProducto\t\t\t\tPrecio");

            foreach (KeyValuePair<string, Dictionary<string, double>> seccion
                in catalogoPetshop)
            {
                lstAlimentos.Items.Add(seccion.Key);

                foreach (KeyValuePair<string, double> productoPrecio in seccion.Value)
                {
                    lstAlimentos.Items.Add("\t\t\t\t" + productoPrecio.Key + "\t\t" + productoPrecio.Value);

                }
            }
        }
    }
}
