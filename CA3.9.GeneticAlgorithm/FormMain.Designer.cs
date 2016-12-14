namespace CA3._9.GeneticAlgorithm
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_set = new System.Windows.Forms.TextBox();
            this.tbSoulution25 = new System.Windows.Forms.TextBox();
            this.tbSolution10 = new System.Windows.Forms.TextBox();
            this.tbSolution5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.btnTask = new System.Windows.Forms.Button();
            this.buttonShowTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Решение 1 (25% от N):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сгенерированное множество: ";
            // 
            // tb_set
            // 
            this.tb_set.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_set.Location = new System.Drawing.Point(12, 25);
            this.tb_set.Multiline = true;
            this.tb_set.Name = "tb_set";
            this.tb_set.ReadOnly = true;
            this.tb_set.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_set.Size = new System.Drawing.Size(690, 150);
            this.tb_set.TabIndex = 4;
            // 
            // tbSoulution25
            // 
            this.tbSoulution25.Location = new System.Drawing.Point(12, 194);
            this.tbSoulution25.Multiline = true;
            this.tbSoulution25.Name = "tbSoulution25";
            this.tbSoulution25.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSoulution25.Size = new System.Drawing.Size(220, 86);
            this.tbSoulution25.TabIndex = 5;
            // 
            // tbSolution10
            // 
            this.tbSolution10.Location = new System.Drawing.Point(12, 299);
            this.tbSolution10.Multiline = true;
            this.tbSolution10.Name = "tbSolution10";
            this.tbSolution10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSolution10.Size = new System.Drawing.Size(220, 95);
            this.tbSolution10.TabIndex = 6;
            // 
            // tbSolution5
            // 
            this.tbSolution5.Location = new System.Drawing.Point(12, 413);
            this.tbSolution5.Multiline = true;
            this.tbSolution5.Name = "tbSolution5";
            this.tbSolution5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSolution5.Size = new System.Drawing.Size(220, 83);
            this.tbSolution5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Решение 2 (10% от N):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Решение 3 (5% от N):";
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(276, 194);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(425, 302);
            this.chart.TabIndex = 10;
            this.chart.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "График:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Количество чисел:";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(119, 520);
            this.nudCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(113, 20);
            this.nudCount.TabIndex = 13;
            this.nudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(369, 512);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(84, 32);
            this.btnTask.TabIndex = 14;
            this.btnTask.Text = "Выполнить";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // buttonShowTask
            // 
            this.buttonShowTask.Location = new System.Drawing.Point(520, 512);
            this.buttonShowTask.Name = "buttonShowTask";
            this.buttonShowTask.Size = new System.Drawing.Size(84, 32);
            this.buttonShowTask.TabIndex = 15;
            this.buttonShowTask.Text = "Условие";
            this.buttonShowTask.UseVisualStyleBackColor = true;
            this.buttonShowTask.Click += new System.EventHandler(this.buttonShowTask_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 561);
            this.Controls.Add(this.buttonShowTask);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSolution5);
            this.Controls.Add(this.tbSolution10);
            this.Controls.Add(this.tbSoulution25);
            this.Controls.Add(this.tb_set);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.Text = "Генетический алгоритм для задачи о сумме подмножества";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_set;
        private System.Windows.Forms.TextBox tbSoulution25;
        private System.Windows.Forms.TextBox tbSolution10;
        private System.Windows.Forms.TextBox tbSolution5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button buttonShowTask;
    }
}

