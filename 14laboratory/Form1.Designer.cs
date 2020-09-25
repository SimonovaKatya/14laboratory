namespace _14laboratory
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_Average1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Varience1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Average_Error1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Varience_Error1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Chi_Squared1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Chi_Squared2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Varience_Error2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Average_Error2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Varience2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Average2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Chi_Squared3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Varience_Error3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Average_Error3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_Varience3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_Average3 = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button_Generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(754, 3);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(405, 300);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart1";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(182, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(385, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(754, 320);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(405, 300);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // textBox_Average1
            // 
            this.textBox_Average1.Location = new System.Drawing.Point(76, 52);
            this.textBox_Average1.Name = "textBox_Average1";
            this.textBox_Average1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Average1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Average";
            // 
            // textBox_Varience1
            // 
            this.textBox_Varience1.Location = new System.Drawing.Point(76, 96);
            this.textBox_Varience1.Name = "textBox_Varience1";
            this.textBox_Varience1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Varience1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Variance";
      
            // 
            // textBox_Average_Error1
            // 
            this.textBox_Average_Error1.Location = new System.Drawing.Point(76, 141);
            this.textBox_Average_Error1.Name = "textBox_Average_Error1";
            this.textBox_Average_Error1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Average_Error1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ErrorAverage";
            // 
            // textBox_Varience_Error1
            // 
            this.textBox_Varience_Error1.Location = new System.Drawing.Point(76, 191);
            this.textBox_Varience_Error1.Name = "textBox_Varience_Error1";
            this.textBox_Varience_Error1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Varience_Error1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ErrorVariance";
            // 
            // textBox_Chi_Squared1
            // 
            this.textBox_Chi_Squared1.Location = new System.Drawing.Point(43, 255);
            this.textBox_Chi_Squared1.Name = "textBox_Chi_Squared1";
            this.textBox_Chi_Squared1.Size = new System.Drawing.Size(133, 20);
            this.textBox_Chi_Squared1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chi-squ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Chi-squ";
            // 
            // textBox_Chi_Squared2
            // 
            this.textBox_Chi_Squared2.Location = new System.Drawing.Point(615, 255);
            this.textBox_Chi_Squared2.Name = "textBox_Chi_Squared2";
            this.textBox_Chi_Squared2.Size = new System.Drawing.Size(133, 20);
            this.textBox_Chi_Squared2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ErrorVariance";
            // 
            // textBox_Varience_Error2
            // 
            this.textBox_Varience_Error2.Location = new System.Drawing.Point(648, 191);
            this.textBox_Varience_Error2.Name = "textBox_Varience_Error2";
            this.textBox_Varience_Error2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Varience_Error2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ErrorAverage";
            // 
            // textBox_Average_Error2
            // 
            this.textBox_Average_Error2.Location = new System.Drawing.Point(648, 141);
            this.textBox_Average_Error2.Name = "textBox_Average_Error2";
            this.textBox_Average_Error2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Average_Error2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Variance";
            // 
            // textBox_Varience2
            // 
            this.textBox_Varience2.Location = new System.Drawing.Point(648, 96);
            this.textBox_Varience2.Name = "textBox_Varience2";
            this.textBox_Varience2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Varience2.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(586, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Average";
            // 
            // textBox_Average2
            // 
            this.textBox_Average2.Location = new System.Drawing.Point(648, 52);
            this.textBox_Average2.Name = "textBox_Average2";
            this.textBox_Average2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Average2.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(573, 569);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Chi-squ";
            // 
            // textBox_Chi_Squared3
            // 
            this.textBox_Chi_Squared3.Location = new System.Drawing.Point(615, 566);
            this.textBox_Chi_Squared3.Name = "textBox_Chi_Squared3";
            this.textBox_Chi_Squared3.Size = new System.Drawing.Size(133, 20);
            this.textBox_Chi_Squared3.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(573, 505);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "ErrorVariance";
            // 
            // textBox_Varience_Error3
            // 
            this.textBox_Varience_Error3.Location = new System.Drawing.Point(648, 502);
            this.textBox_Varience_Error3.Name = "textBox_Varience_Error3";
            this.textBox_Varience_Error3.Size = new System.Drawing.Size(100, 20);
            this.textBox_Varience_Error3.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(573, 455);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "ErrorAverage";
            // 
            // textBox_Average_Error3
            // 
            this.textBox_Average_Error3.Location = new System.Drawing.Point(648, 452);
            this.textBox_Average_Error3.Name = "textBox_Average_Error3";
            this.textBox_Average_Error3.Size = new System.Drawing.Size(100, 20);
            this.textBox_Average_Error3.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(584, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Variance";
            // 
            // textBox_Varience3
            // 
            this.textBox_Varience3.Location = new System.Drawing.Point(648, 407);
            this.textBox_Varience3.Name = "textBox_Varience3";
            this.textBox_Varience3.Size = new System.Drawing.Size(100, 20);
            this.textBox_Varience3.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(586, 366);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Average";
            // 
            // textBox_Average3
            // 
            this.textBox_Average3.Location = new System.Drawing.Point(648, 363);
            this.textBox_Average3.Name = "textBox_Average3";
            this.textBox_Average3.Size = new System.Drawing.Size(100, 20);
            this.textBox_Average3.TabIndex = 23;
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(94, 450);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 26);
            this.time.TabIndex = 33;
            this.time.Text = "1000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(23, 453);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Number";
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(17, 526);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(260, 75);
            this.button_Generate.TabIndex = 35;
            this.button_Generate.Text = "Click";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 632);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_Chi_Squared3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_Varience_Error3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_Average_Error3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_Varience3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox_Average3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Chi_Squared2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Varience_Error2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Average_Error2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Varience2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_Average2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Chi_Squared1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Varience_Error1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Average_Error1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Varience1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Average1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TextBox textBox_Average1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Varience1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Average_Error1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Varience_Error1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Chi_Squared1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Chi_Squared2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Varience_Error2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Average_Error2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Varience2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Average2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Chi_Squared3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Varience_Error3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Average_Error3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Varience3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_Average3;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_Generate;
    }
}

