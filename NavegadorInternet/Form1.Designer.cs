namespace NavegadorInternet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            atras = new ToolStripButton();
            adelante = new ToolStripButton();
            refresh = new ToolStripButton();
            Stop = new ToolStripButton();
            Home = new ToolStripButton();
            UrlNavegador = new ToolStripTextBox();
            Go = new ToolStripButton();
            navegador = new Microsoft.Web.WebView2.WinForms.WebView2();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)navegador).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { atras, adelante, refresh, Stop, Home, UrlNavegador, Go });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(778, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // atras
            // 
            atras.DisplayStyle = ToolStripItemDisplayStyle.Image;
            atras.Image = (Image)resources.GetObject("atras.Image");
            atras.ImageTransparentColor = Color.Magenta;
            atras.Name = "atras";
            atras.Size = new Size(34, 28);
            atras.Text = "toolStripButton1";
            atras.Click += atras_Click;
            // 
            // adelante
            // 
            adelante.DisplayStyle = ToolStripItemDisplayStyle.Image;
            adelante.Image = (Image)resources.GetObject("adelante.Image");
            adelante.ImageTransparentColor = Color.Magenta;
            adelante.Name = "adelante";
            adelante.Size = new Size(34, 28);
            adelante.Text = "toolStripButton1";
            adelante.Click += adelante_Click;
            // 
            // refresh
            // 
            refresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.ImageTransparentColor = Color.Magenta;
            refresh.Name = "refresh";
            refresh.Size = new Size(34, 28);
            refresh.Text = "toolStripButton1";
            refresh.Click += refresh_Click;
            // 
            // Stop
            // 
            Stop.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Stop.Image = (Image)resources.GetObject("Stop.Image");
            Stop.ImageTransparentColor = Color.Magenta;
            Stop.Name = "Stop";
            Stop.Size = new Size(34, 28);
            Stop.Text = "toolStripButton1";
            Stop.Click += Stop_Click;
            // 
            // Home
            // 
            Home.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Home.Image = (Image)resources.GetObject("Home.Image");
            Home.ImageTransparentColor = Color.Magenta;
            Home.Name = "Home";
            Home.Size = new Size(34, 28);
            Home.Text = "toolStripButton1";
            Home.Click += Home_Click;
            // 
            // UrlNavegador
            // 
            UrlNavegador.BackColor = SystemColors.InactiveCaption;
            UrlNavegador.Name = "UrlNavegador";
            UrlNavegador.Size = new Size(500, 33);
            UrlNavegador.Click += UrlNavegador_Click;
            // 
            // Go
            // 
            Go.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Go.Image = (Image)resources.GetObject("Go.Image");
            Go.ImageTransparentColor = Color.Magenta;
            Go.Name = "Go";
            Go.Size = new Size(34, 28);
            Go.Text = "toolStripButton1";
            Go.Click += Go_Click;
            // 
            // navegador
            // 
            navegador.AllowExternalDrop = true;
            navegador.CreationProperties = null;
            navegador.DefaultBackgroundColor = Color.White;
            navegador.Location = new Point(0, 36);
            navegador.Name = "navegador";
            navegador.Size = new Size(778, 509);
            navegador.TabIndex = 1;
            navegador.ZoomFactor = 1D;
            navegador.Click += navegador_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(navegador);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Mi Navegador";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)navegador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton atras;
        private ToolStripButton adelante;
        private ToolStripButton refresh;
        private ToolStripButton Stop;
        private ToolStripButton Home;
        private ToolStripTextBox UrlNavegador;
        private ToolStripButton Go;
        private Microsoft.Web.WebView2.WinForms.WebView2 navegador;
    }
}
