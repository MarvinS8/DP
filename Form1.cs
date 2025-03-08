using DP.Controller;
using DP.Model;
using System.Net;


namespace DP

{
    public partial class Form1 : Form
    {
        private IControllerDanyPhantom controller = new ControllerDanyPhantom();
        private List<PhantomModel> personajes = new List<PhantomModel>();
        public Form1()
        {
            InitializeComponent();
            CargarPersonajes();
        }


        private void CargarComboBox()
        {
            try
            {
                personajes = controller.ObtenerPersonajes(); // Obtener los personajes desde el controlador

                cmbPersonajes.DisplayMember = "Nombre";  // Mostrar el nombre en el ComboBox
                cmbPersonajes.ValueMember = "ImagenURL"; // Guardar la URL de la imagen
                cmbPersonajes.DataSource = personajes;   // Asignar la lista al ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los personajes: " + ex.Message);
            }
        }

        private async Task CargarImagen(string url)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(url) || !Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    throw new Exception("URL de imagen no válida.");
                }

                using (HttpClient client = new HttpClient())
                {
                    // Simular un navegador para evitar bloqueos
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception($"Error al obtener la imagen. Código HTTP: {response.StatusCode}");
                    }

                    byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();

                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        picturePersonaje.Image = Image.FromStream(ms);
                        picturePersonaje.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
                picturePersonaje.Image = null;
            }
        }


        private void CargarPersonajes()
        {
            //MessageBox.Show("Entrando en CargarPersonajes()"); // Verifica si se ejecuta
            try
            {
                personajes = controller.ObtenerPersonajes();

                //MessageBox.Show("Personajes obtenidos: " + personajes.Count); // <-- Verifica si hay datos

                if (personajes.Count == 0)
                {
                    MessageBox.Show("No se encontraron personajes.");
                }

                dgvPersonajes.DataSource = personajes;
                dgvPersonajes.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            CargarPersonajes();
            //MessageBox.Show(dgvPersonajes.Rows.Count.ToString());
            CargarComboBox();
        }


        private void picturePersonaje_Click(object sender, EventArgs e)
        {

        }

        private async void cmbPersonajes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string? imageUrl = cmbPersonajes.SelectedValue as string;

            if (!string.IsNullOrEmpty(imageUrl))
            {
                await CargarImagen(imageUrl);
            }
            else
            {
                picturePersonaje.Image = null;
            }

        }
    }
}
