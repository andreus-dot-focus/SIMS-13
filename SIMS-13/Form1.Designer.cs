
namespace SIMS_13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p5TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chiLabel = new System.Windows.Forms.Label();
            this.variLabel = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.nTB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.p5TB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 495);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(106, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nTB
            // 
            this.nTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nTB.Location = new System.Drawing.Point(178, 362);
            this.nTB.Name = "nTB";
            this.nTB.Size = new System.Drawing.Size(105, 22);
            this.nTB.TabIndex = 11;
            this.nTB.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(125, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "N";
            // 
            // p5TB
            // 
            this.p5TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p5TB.Location = new System.Drawing.Point(178, 272);
            this.p5TB.Name = "p5TB";
            this.p5TB.Size = new System.Drawing.Size(105, 22);
            this.p5TB.TabIndex = 9;
            this.p5TB.Text = "0.5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(90, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Param";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chiLabel);
            this.panel2.Controls.Add(this.variLabel);
            this.panel2.Controls.Add(this.meanLabel);
            this.panel2.Location = new System.Drawing.Point(440, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 135);
            this.panel2.TabIndex = 4;
            // 
            // chiLabel
            // 
            this.chiLabel.AutoSize = true;
            this.chiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chiLabel.Location = new System.Drawing.Point(92, 105);
            this.chiLabel.Name = "chiLabel";
            this.chiLabel.Size = new System.Drawing.Size(102, 20);
            this.chiLabel.TabIndex = 2;
            this.chiLabel.Text = "Chi-Squared:";
            // 
            // variLabel
            // 
            this.variLabel.AutoSize = true;
            this.variLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.variLabel.Location = new System.Drawing.Point(38, 56);
            this.variLabel.Name = "variLabel";
            this.variLabel.Size = new System.Drawing.Size(71, 20);
            this.variLabel.TabIndex = 1;
            this.variLabel.Text = "Variable:";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.meanLabel.Location = new System.Drawing.Point(38, 25);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(72, 20);
            this.meanLabel.TabIndex = 0;
            this.meanLabel.Text = "Average:";
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.Location = new System.Drawing.Point(440, 0);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(802, 354);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 498);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Геометрическое распределение";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p5TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label chiLabel;
        private System.Windows.Forms.Label variLabel;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

