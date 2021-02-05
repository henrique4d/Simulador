using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Components
{
    [DefaultEvent("Click")]
    public partial class NavbarItem : UserControl
    {
        // Texto dentro do componente
        private String _textItem = ""; // field
        public string TextItem
        {
            get => _textItem;
            set { _textItem = value; label1.Text = _textItem; }
        }

        // Saber se está ativo ou não
        private bool _active = false; // field
        public bool Active
        {
            get => _active;
            set
            {
                _active = value;
                if (_active)
                {
                    this.pnl_active.BackColor = Color.FromArgb(14, 92, 47);
                }
                else
                {
                    this.pnl_active.BackColor = Color.Transparent;
                }
            }
        }

        private void NavbarItem_ForeColorChanged(object sender, EventArgs e)
        {
            label1.ForeColor = ForeColor;
        }

        public NavbarItem()
        {
            InitializeComponent();
            this.pnl_main.Click += (s, e) => base.OnClick(e);
            this.pnl_active.Click += (s, e) => base.OnClick(e);
            this.label1.Click += (s, e) => base.OnClick(e);

            this.label1.ForeColor = base.ForeColor;
        }
    }
}
