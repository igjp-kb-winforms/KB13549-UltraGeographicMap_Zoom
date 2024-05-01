
namespace UltraGeographicMap_Zoom
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ultraGeographicMap1 = new Infragistics.Win.DataVisualization.UltraGeographicMap();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGeographicMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGeographicMap1
            // 
            this.ultraGeographicMap1.BackColor = System.Drawing.Color.White;
            this.ultraGeographicMap1.CrosshairPoint = new Infragistics.Win.DataVisualization.Point(double.NaN, double.NaN);
            this.ultraGeographicMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGeographicMap1.HorizontalViewScrollbarCornerRadius = double.NaN;
            this.ultraGeographicMap1.HorizontalViewScrollbarHeight = double.NaN;
            this.ultraGeographicMap1.HorizontalViewScrollbarInset = double.NaN;
            this.ultraGeographicMap1.HorizontalViewScrollbarMaxOpacity = double.NaN;
            this.ultraGeographicMap1.HorizontalViewScrollbarShouldAddAutoTrackInsets = true;
            this.ultraGeographicMap1.HorizontalViewScrollbarStrokeThickness = double.NaN;
            this.ultraGeographicMap1.HorizontalViewScrollbarTrackEndInset = double.NaN;
            this.ultraGeographicMap1.HorizontalViewScrollbarTrackStartInset = double.NaN;
            this.ultraGeographicMap1.Location = new System.Drawing.Point(0, 0);
            this.ultraGeographicMap1.Name = "ultraGeographicMap1";
            this.ultraGeographicMap1.ScrollbarsAnimationDuration = 300;
            this.ultraGeographicMap1.Size = new System.Drawing.Size(800, 486);
            this.ultraGeographicMap1.TabIndex = 0;
            this.ultraGeographicMap1.Text = "ultraGeographicMap1";
            this.ultraGeographicMap1.VerticalViewScrollbarCornerRadius = double.NaN;
            this.ultraGeographicMap1.VerticalViewScrollbarInset = double.NaN;
            this.ultraGeographicMap1.VerticalViewScrollbarMaxOpacity = double.NaN;
            this.ultraGeographicMap1.VerticalViewScrollbarShouldAddAutoTrackInsets = true;
            this.ultraGeographicMap1.VerticalViewScrollbarStrokeThickness = double.NaN;
            this.ultraGeographicMap1.VerticalViewScrollbarTrackEndInset = double.NaN;
            this.ultraGeographicMap1.VerticalViewScrollbarTrackStartInset = double.NaN;
            this.ultraGeographicMap1.VerticalViewScrollbarWidth = double.NaN;
            this.ultraGeographicMap1.WindowRectMinWidth = 5E-06D;
            this.ultraGeographicMap1.WorldRect = new Infragistics.Win.DataVisualization.Rectangle(-180D, -85.05112878D, 360D, 170.10225756D);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.ultraGeographicMap1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGeographicMap1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.DataVisualization.UltraGeographicMap ultraGeographicMap1;
    }
}

