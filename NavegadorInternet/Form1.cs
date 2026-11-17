namespace NavegadorInternet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await navegador.EnsureCoreWebView2Async();
            UrlNavegador.KeyDown += UrlNavegador_KeyDown;
            atras.Click += (_, _) =>
            {
                if (navegador.CanGoBack)
                    navegador.GoBack();
            };
            adelante.Click += (_, _) =>
            {
                if (navegador.CanGoForward)
                    navegador.GoForward();
            };
            refresh.Click += (_, _) => navegador.Reload();
            Stop.Click += (_, _) => navegador.Stop();
            Home.Click += (_, _) => Navegar("https://www.google.com");
            Navegar("https://www.google.com");
        }

        private void Go_Click(object sender, EventArgs e)
        {
            Navegar(UrlNavegador.Text);
        }

        private void UrlNavegador_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navegar(UrlNavegador.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void Navegar(string texto)
        {
            texto = texto.Trim();
            if (string.IsNullOrWhiteSpace(texto))
                return;

            if (!texto.Contains("://"))
                texto = $"https://{texto}";

            if (Uri.TryCreate(texto, UriKind.Absolute, out Uri? uri) &&
                (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
            {
                UrlNavegador.Text = uri.ToString();
                navegador.CoreWebView2?.Navigate(uri.ToString());
            }
        }

        private void navegador_Click(object sender, EventArgs e)
        {

        }

        private void atras_Click(object sender, EventArgs e)
        {
            navegador.GoBack();
        }

        private void adelante_Click(object sender, EventArgs e)
        {
            navegador.GoForward();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            navegador.Refresh();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            navegador.Stop();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Navegar("https://www.google.com");
        }

       
    }
}
