
namespace Simulador.Components
{
    partial class NavbarItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_active = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_active
            // 
            this.pnl_active.BackColor = System.Drawing.Color.Green;
            this.pnl_active.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_active.Location = new System.Drawing.Point(0, 46);
            this.pnl_active.Name = "pnl_active";
            this.pnl_active.Size = new System.Drawing.Size(134, 5);
            this.pnl_active.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maximização";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_main
            // 
            this.pnl_main.AutoSize = true;
            this.pnl_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_main.BackColor = System.Drawing.Color.Transparent;
            this.pnl_main.Controls.Add(this.label1);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.pnl_main.Size = new System.Drawing.Size(134, 46);
            this.pnl_main.TabIndex = 3;
            // 
            // NavbarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_active);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "NavbarItem";
            this.Size = new System.Drawing.Size(134, 51);
            this.ForeColorChanged += new System.EventHandler(this.NavbarItem_ForeColorChanged);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_active;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_main;
    }
}
