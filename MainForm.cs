using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdShapefile = new OpenFileDialog();
            if (ofdShapefile.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    OpenShapefile(ofdShapefile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error : " + ex.Message);
                }
            }
        }

        private void OpenShapefile(string path)
        {
            // clear any shapefiles the map is currently displaying
            this.sfMap1.ClearShapeFiles();

            // open the shapefile passing in the path, display name of the shapefile and
            // the field name to be used when rendering the shapes (we use an empty string
            // as the field name (3rd parameter) can not be null)
            this.sfMap1.AddShapeFile(path, "ShapeFile", "");

            // read the shapefile dbf field names and set the shapefiles's RenderSettings
            // to use the first field to label the shapes.
            EGIS.ShapeFileLib.ShapeFile sf = this.sfMap1[0];
            sf.RenderSettings.FieldName = sf.RenderSettings.DbfReader.GetFieldNames()[0];
            sf.RenderSettings.UseToolTip = true;
            sf.RenderSettings.ToolTipFieldName = sf.RenderSettings.FieldName;
            sf.RenderSettings.IsSelectable = true;

            //select the first record
            sf.SelectRecord(0, true);

        }

        private void sfMap1_MouseClick(object sender, MouseEventArgs e)
        {
            if (sfMap1.ShapeFileCount == 0) return;
            int recordIndex = sfMap1.GetShapeIndexAtPixelCoord(0, e.Location, 8);
            if (recordIndex >= 0)
            {
                string[] recordAttributes = sfMap1[0].GetAttributeFieldValues(recordIndex);
                string[] attributeNames = sfMap1[0].GetAttributeFieldNames();
                StringBuilder sb = new StringBuilder();
                for (int n = 0; n < attributeNames.Length; ++n)
                {
                    sb.Append(attributeNames[n]).Append(':').AppendLine(recordAttributes[n].Trim());
                }
                MessageBox.Show(this, sb.ToString(), "record attributes", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }

        private void sfMap1_Paint(object sender, PaintEventArgs e)
        {
            DrawCursorCrosshair(e.Graphics);
        }

        private void DrawCursorCrosshair(Graphics g)
        {
            if (currentMousePoint.IsEmpty) return;

            //Take a copy of the current transform because we want to reset it before we draw.
            //This is becuase if the mouse is down and the user drags the mouse (pans the map) a transform
            //is set on the graphics. 
            var transform = g.Transform;
            try
            {
                g.ResetTransform();

                using (Pen p = new Pen(Color.Red, 1))
                {
                    p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    //draw a cross centred on the current mouse position
                    g.DrawLine(p, currentMousePoint.X, 0, currentMousePoint.X, sfMap1.ClientSize.Height);
                    g.DrawLine(p, 0, currentMousePoint.Y, sfMap1.ClientSize.Width, currentMousePoint.Y);
                }
            }
            finally
            {
                g.Transform = transform;
            }

        }

        private Point currentMousePoint;

        private void sfMap1_MouseMove(object sender, MouseEventArgs e)
        {
            currentMousePoint = e.Location;
            sfMap1.Refresh();
        }

        private void sfMap1_MouseLeave(object sender, EventArgs e)
        {
            currentMousePoint = Point.Empty;
            sfMap1.Refresh();
        }
    }
}
