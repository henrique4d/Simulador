using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Simulador.Components
{
    public sealed partial class SidebarItem : Button
    {
        public SidebarItem()
        {
            InitializeComponent();

            // Cor da Letra
            ForeColor = Color.White;
            Font = new Font("Microsoft Sans Serif", 13.25f);

            // Removendo Borda
            TabStop = false;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }

        public SidebarItem(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}