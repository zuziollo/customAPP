namespace AplikacjaPogodowa1
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TbCity = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_city = new System.Windows.Forms.Label();
            this.lab_date = new System.Windows.Forms.Label();
            this.lab_time = new System.Windows.Forms.Label();
            this.lab_temp = new System.Windows.Forms.Label();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.lab_pressure = new System.Windows.Forms.Label();
            this.lab_wind = new System.Windows.Forms.Label();
            this.lab_humidity = new System.Windows.Forms.Label();
            this.lab_conditions = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.wind = new System.Windows.Forms.Label();
            this.conditions = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab_temp1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lab_temp1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TbCity);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.lab_city);
            this.panel1.Controls.Add(this.lab_date);
            this.panel1.Controls.Add(this.lab_time);
            this.panel1.Controls.Add(this.lab_temp);
            this.panel1.Controls.Add(this.lab_sunrise);
            this.panel1.Controls.Add(this.lab_sunset);
            this.panel1.Controls.Add(this.lab_pressure);
            this.panel1.Controls.Add(this.lab_wind);
            this.panel1.Controls.Add(this.lab_humidity);
            this.panel1.Controls.Add(this.lab_conditions);
            this.panel1.Controls.Add(this.sunset);
            this.panel1.Controls.Add(this.sunrise);
            this.panel1.Controls.Add(this.pressure);
            this.panel1.Controls.Add(this.wind);
            this.panel1.Controls.Add(this.conditions);
            this.panel1.Controls.Add(this.humidity);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(79, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start entering city name:";
            // 
            // TbCity
            // 
            this.TbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.TbCity.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbCity.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbCity.Location = new System.Drawing.Point(79, 82);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(261, 20);
            this.TbCity.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Courier New", 7.5F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_search.Location = new System.Drawing.Point(334, 82);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(59, 20);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lab_city
            // 
            this.lab_city.AutoSize = true;
            this.lab_city.BackColor = System.Drawing.Color.Transparent;
            this.lab_city.Font = new System.Drawing.Font("Courier New", 14F);
            this.lab_city.ForeColor = System.Drawing.Color.White;
            this.lab_city.Location = new System.Drawing.Point(75, 263);
            this.lab_city.Name = "lab_city";
            this.lab_city.Size = new System.Drawing.Size(0, 21);
            this.lab_city.TabIndex = 19;
            // 
            // lab_date
            // 
            this.lab_date.AutoSize = true;
            this.lab_date.BackColor = System.Drawing.Color.Transparent;
            this.lab_date.Font = new System.Drawing.Font("Courier New", 14F);
            this.lab_date.ForeColor = System.Drawing.Color.White;
            this.lab_date.Location = new System.Drawing.Point(75, 231);
            this.lab_date.Name = "lab_date";
            this.lab_date.Size = new System.Drawing.Size(65, 21);
            this.lab_date.TabIndex = 18;
            this.lab_date.Text = "Date:";
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.BackColor = System.Drawing.Color.Transparent;
            this.lab_time.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_time.ForeColor = System.Drawing.Color.White;
            this.lab_time.Location = new System.Drawing.Point(67, 162);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(220, 69);
            this.lab_time.TabIndex = 17;
            this.lab_time.Text = "12:30";
            // 
            // lab_temp
            // 
            this.lab_temp.AutoSize = true;
            this.lab_temp.BackColor = System.Drawing.Color.Transparent;
            this.lab_temp.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_temp.ForeColor = System.Drawing.Color.White;
            this.lab_temp.Location = new System.Drawing.Point(23, -54);
            this.lab_temp.Name = "lab_temp";
            this.lab_temp.Size = new System.Drawing.Size(144, 69);
            this.lab_temp.TabIndex = 16;
            this.lab_temp.Text = "N/A";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunrise.Font = new System.Drawing.Font("Courier New", 14F);
            this.lab_sunrise.ForeColor = System.Drawing.Color.White;
            this.lab_sunrise.Location = new System.Drawing.Point(535, 290);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(43, 21);
            this.lab_sunrise.TabIndex = 15;
            this.lab_sunrise.Text = "N/A";
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunset.Font = new System.Drawing.Font("Courier New", 14F);
            this.lab_sunset.ForeColor = System.Drawing.Color.White;
            this.lab_sunset.Location = new System.Drawing.Point(520, 330);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(43, 21);
            this.lab_sunset.TabIndex = 14;
            this.lab_sunset.Text = "N/A";
            // 
            // lab_pressure
            // 
            this.lab_pressure.AutoSize = true;
            this.lab_pressure.BackColor = System.Drawing.Color.Transparent;
            this.lab_pressure.Font = new System.Drawing.Font("Courier New", 14F);
            this.lab_pressure.ForeColor = System.Drawing.Color.White;
            this.lab_pressure.Location = new System.Drawing.Point(545, 250);
            this.lab_pressure.Name = "lab_pressure";
            this.lab_pressure.Size = new System.Drawing.Size(43, 21);
            this.lab_pressure.TabIndex = 13;
            this.lab_pressure.Text = "N/A";
            // 
            // lab_wind
            // 
            this.lab_wind.AutoSize = true;
            this.lab_wind.BackColor = System.Drawing.Color.Transparent;
            this.lab_wind.Font = new System.Drawing.Font("Courier New", 14F);
            this.lab_wind.ForeColor = System.Drawing.Color.White;
            this.lab_wind.Location = new System.Drawing.Point(500, 210);
            this.lab_wind.Name = "lab_wind";
            this.lab_wind.Size = new System.Drawing.Size(43, 21);
            this.lab_wind.TabIndex = 12;
            this.lab_wind.Text = "N/A";
            // 
            // lab_humidity
            // 
            this.lab_humidity.AutoSize = true;
            this.lab_humidity.BackColor = System.Drawing.Color.Transparent;
            this.lab_humidity.Font = new System.Drawing.Font("Courier New", 14F);
            this.lab_humidity.ForeColor = System.Drawing.Color.White;
            this.lab_humidity.Location = new System.Drawing.Point(545, 170);
            this.lab_humidity.Name = "lab_humidity";
            this.lab_humidity.Size = new System.Drawing.Size(43, 21);
            this.lab_humidity.TabIndex = 11;
            this.lab_humidity.Text = "N/A";
            // 
            // lab_conditions
            // 
            this.lab_conditions.AutoSize = true;
            this.lab_conditions.BackColor = System.Drawing.Color.Transparent;
            this.lab_conditions.Font = new System.Drawing.Font("Courier New", 14F);
            this.lab_conditions.ForeColor = System.Drawing.Color.White;
            this.lab_conditions.Location = new System.Drawing.Point(565, 130);
            this.lab_conditions.Name = "lab_conditions";
            this.lab_conditions.Size = new System.Drawing.Size(43, 21);
            this.lab_conditions.TabIndex = 10;
            this.lab_conditions.Text = "N/A";
            // 
            // sunset
            // 
            this.sunset.AutoSize = true;
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            this.sunset.Font = new System.Drawing.Font("Courier New", 14F);
            this.sunset.ForeColor = System.Drawing.Color.White;
            this.sunset.Location = new System.Drawing.Point(440, 330);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(87, 21);
            this.sunset.TabIndex = 9;
            this.sunset.Text = "Sunset:";
            // 
            // sunrise
            // 
            this.sunrise.AutoSize = true;
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.Font = new System.Drawing.Font("Courier New", 14F);
            this.sunrise.ForeColor = System.Drawing.Color.White;
            this.sunrise.Location = new System.Drawing.Point(440, 290);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(98, 21);
            this.sunrise.TabIndex = 8;
            this.sunrise.Text = "Sunrise:";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.BackColor = System.Drawing.Color.Transparent;
            this.pressure.Font = new System.Drawing.Font("Courier New", 14F);
            this.pressure.ForeColor = System.Drawing.Color.White;
            this.pressure.Location = new System.Drawing.Point(440, 250);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(109, 21);
            this.pressure.TabIndex = 7;
            this.pressure.Text = "Pressure:";
            // 
            // wind
            // 
            this.wind.AutoSize = true;
            this.wind.BackColor = System.Drawing.Color.Transparent;
            this.wind.Font = new System.Drawing.Font("Courier New", 14F);
            this.wind.ForeColor = System.Drawing.Color.White;
            this.wind.Location = new System.Drawing.Point(440, 210);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(65, 21);
            this.wind.TabIndex = 6;
            this.wind.Text = "Wind:";
            // 
            // conditions
            // 
            this.conditions.AutoSize = true;
            this.conditions.BackColor = System.Drawing.Color.Transparent;
            this.conditions.Font = new System.Drawing.Font("Courier New", 14F);
            this.conditions.ForeColor = System.Drawing.Color.White;
            this.conditions.Location = new System.Drawing.Point(440, 130);
            this.conditions.Name = "conditions";
            this.conditions.Size = new System.Drawing.Size(131, 21);
            this.conditions.TabIndex = 5;
            this.conditions.Text = "Conditions:";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.BackColor = System.Drawing.Color.Transparent;
            this.humidity.Font = new System.Drawing.Font("Courier New", 14F);
            this.humidity.ForeColor = System.Drawing.Color.White;
            this.humidity.Location = new System.Drawing.Point(440, 170);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(109, 21);
            this.humidity.TabIndex = 4;
            this.humidity.Text = "Humidity:";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_close.Location = new System.Drawing.Point(771, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(26, 26);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lab_temp1
            // 
            this.lab_temp1.AutoSize = true;
            this.lab_temp1.BackColor = System.Drawing.Color.Transparent;
            this.lab_temp1.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_temp1.ForeColor = System.Drawing.Color.White;
            this.lab_temp1.Location = new System.Drawing.Point(67, 290);
            this.lab_temp1.Name = "lab_temp1";
            this.lab_temp1.Size = new System.Drawing.Size(144, 69);
            this.lab_temp1.TabIndex = 20;
            this.lab_temp1.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(265, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 69);
            this.label2.TabIndex = 21;
            this.label2.Text = "°C";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label wind;
        private System.Windows.Forms.Label conditions;
        private System.Windows.Forms.Label lab_humidity;
        private System.Windows.Forms.Label lab_conditions;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label lab_pressure;
        private System.Windows.Forms.Label lab_wind;
        private System.Windows.Forms.Label lab_temp;
        private System.Windows.Forms.Label lab_date;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_city;
        private System.Windows.Forms.Label lab_temp1;
        private System.Windows.Forms.Label label2;
    }
}

