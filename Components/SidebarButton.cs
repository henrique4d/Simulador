using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Components
{
    public partial class SidebarButton : Button
    {
        public SidebarButton()
        {
            InitializeComponent();
            // Cor da Letra
            ForeColor = Color.White;
            Font = new Font("Microsoft Sans Serif", 13.25f);

            // Removendo Borda
            TabStop = false;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            TextAlign = ContentAlignment.MiddleLeft;

        }

        public SidebarButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
