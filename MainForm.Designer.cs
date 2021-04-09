
namespace Simulador
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdShapefile = new System.Windows.Forms.OpenFileDialog();
            this.sfMap1 = new EGIS.Controls.SFMap();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(180, 22);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // ofdShapefile
            // 
            this.ofdShapefile.Filter = "ESRI ShapeFile|*.shp";
            this.ofdShapefile.InitialDirectory = ".";
            // 
            // sfMap1
            // 
            this.sfMap1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfMap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sfMap1.CentrePoint2D = ((EGIS.ShapeFileLib.PointD)(resources.GetObject("sfMap1.CentrePoint2D")));
            this.sfMap1.Cursor = System.Windows.Forms.Cursors.Default;
            this.sfMap1.DefaultMapCursor = System.Windows.Forms.Cursors.Default;
            this.sfMap1.DefaultSelectionCursor = System.Windows.Forms.Cursors.Hand;
            this.sfMap1.Location = new System.Drawing.Point(12, 35);
            this.sfMap1.MapBackColor = System.Drawing.SystemColors.Control;
            this.sfMap1.Margin = new System.Windows.Forms.Padding(4);
            this.sfMap1.Name = "sfMap1";
            this.sfMap1.PanSelectMode = EGIS.Controls.PanSelectMode.Pan;
            this.sfMap1.RenderQuality = EGIS.ShapeFileLib.RenderQuality.Auto;
            this.sfMap1.Size = new System.Drawing.Size(704, 332);
            this.sfMap1.TabIndex = 0;
            this.sfMap1.UseMemoryStreams = false;
            this.sfMap1.UseMercatorProjection = false;
            this.sfMap1.ZoomLevel = 1D;
            this.sfMap1.ZoomToSelectedExtentWhenCtrlKeydown = false;
            this.sfMap1.Paint += new System.Windows.Forms.PaintEventHandler(this.sfMap1_Paint);
            this.sfMap1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sfMap1_MouseClick);
            this.sfMap1.MouseLeave += new System.EventHandler(this.sfMap1_MouseLeave);
            this.sfMap1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sfMap1_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 379);
            this.Controls.Add(this.sfMap1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Example 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private EGIS.Controls.SFMap sfMap1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miOpen;
		private System.Windows.Forms.OpenFileDialog ofdShapefile;
    }
}