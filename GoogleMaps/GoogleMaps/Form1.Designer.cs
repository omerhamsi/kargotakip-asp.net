
namespace GoogleMaps
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.textLat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadIntoMap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textLong = new System.Windows.Forms.TextBox();
            this.lblkm = new System.Windows.Forms.Label();
            this.btnRoute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(958, 433);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // textLat
            // 
            this.textLat.Location = new System.Drawing.Point(25, 501);
            this.textLat.Name = "textLat";
            this.textLat.Size = new System.Drawing.Size(100, 20);
            this.textLat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latitude";
            // 
            // btnLoadIntoMap
            // 
            this.btnLoadIntoMap.Location = new System.Drawing.Point(394, 486);
            this.btnLoadIntoMap.Name = "btnLoadIntoMap";
            this.btnLoadIntoMap.Size = new System.Drawing.Size(75, 23);
            this.btnLoadIntoMap.TabIndex = 3;
            this.btnLoadIntoMap.Text = "Load Map";
            this.btnLoadIntoMap.UseVisualStyleBackColor = true;
            this.btnLoadIntoMap.Click += new System.EventHandler(this.btnLoadIntoMap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Longitute";
            // 
            // textLong
            // 
            this.textLong.Location = new System.Drawing.Point(152, 501);
            this.textLong.Name = "textLong";
            this.textLong.Size = new System.Drawing.Size(100, 20);
            this.textLong.TabIndex = 4;
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.Location = new System.Drawing.Point(90, 539);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(33, 13);
            this.lblkm.TabIndex = 6;
            this.lblkm.Text = "0  km";
            // 
            // btnRoute
            // 
            this.btnRoute.Location = new System.Drawing.Point(394, 515);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(75, 23);
            this.btnRoute.TabIndex = 7;
            this.btnRoute.Text = "Route";
            this.btnRoute.UseVisualStyleBackColor = true;
            this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(485, 515);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear List";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textStart
            // 
            this.textStart.Location = new System.Drawing.Point(276, 501);
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(100, 20);
            this.textStart.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Starting Point";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textStart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRoute);
            this.Controls.Add(this.lblkm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLong);
            this.Controls.Add(this.btnLoadIntoMap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLat);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.TextBox textLat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadIntoMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLong;
        private System.Windows.Forms.Label lblkm;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

