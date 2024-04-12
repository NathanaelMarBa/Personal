using HTTPupt;

namespace Personal
   
{
    public partial class MainPage : ContentPage
    {
        PeticionHTTP peticion = new PeticionHTTP("https://Devnath.bsite.net/cliente/");
        public MainPage()
        {
            InitializeComponent();
        }

        private void Listar_Clicked (object sender, EventArgs e)
        {
            peticion.PedirComunicacion("listar", MetodoHTTP.GET, TipoContenido.JSON);
            string respuestaJSON = peticion.ObtenerJson();
            lblLista.Text = respuestaJSON;


        }



    }

}
