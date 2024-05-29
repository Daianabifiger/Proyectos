namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        ProductosConE productosconE;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productosconE = new ProductosConE();

            Producto[] productos =
            {
                new Producto(1,"Notebook Lenovo"),
                new Producto(2,"Mouse Genius"),
                new Producto(3,"Teclado Generico"),
                new Producto(4,"Monitor 20"),
                new Producto(4,"Monitor 25")
            };

            productosconE.InsertarEnLista(productos);
            dgProductosConE.AutoGenerateColumns = true;
            dgProductosConE.DataSource = productosconE.MostrarLista;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgProductosConE.DataSource = null;
            dgProductosConE.Refresh();
            productosconE.LimpiarLista();
        }
    }
}
