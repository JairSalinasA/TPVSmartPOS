using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPost.UI
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
            // Configuración de MaterialSkin
            // Configuración de MaterialSkin
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Configuración del tema y esquema de colores
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Color.FromArgb(76, 77, 78), // Primario
                Color.FromArgb(129, 130, 130), // Primario oscuro
                Color.FromArgb(178, 178, 178), // Primario claro
                Color.FromArgb(29, 165, 239), // Acento
                TextShade.WHITE
            );

            // Configuración adicional del formulario
            this.Text = "Aplicación con Material Design";
            this.Size = new Size(800, 600);
            this.BackColor = Color.FromArgb(137, 176, 221); // Fondo


        }
    }
}
