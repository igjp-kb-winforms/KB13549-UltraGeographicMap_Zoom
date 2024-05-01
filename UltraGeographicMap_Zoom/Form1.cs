using Infragistics.Graphics;
using Infragistics.Portable.Components.Data;
using Infragistics.Win.DataVisualization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraGeographicMap_Zoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ultraGeographicMap1.Zoomable = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double latitude = 35.681236;
            double longitude = 139.767125;
            double radius = 0.004;

            Infragistics.Win.DataVisualization.Rectangle geoRect = geographicFromCentered(latitude, longitude, radius);
            ultraGeographicMap1.ZoomToGeographic(geoRect);
        }

        private Infragistics.Win.DataVisualization.Rectangle geographicFromCentered(double latitude, double longitude, double radius)
        {
            Infragistics.Win.DataVisualization.Rectangle rect = new Infragistics.Win.DataVisualization.Rectangle()
            {
                X = longitude - radius,
                Y = latitude - radius,
                Width = radius * 2,
                Height = radius * 2,
            };

            return rect;
        }
    }
}
