namespace GameOfLIfe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.b_openfail = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.b_save = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.b_step = new System.Windows.Forms.Button();
            this.nUD_interval = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b_clear = new System.Windows.Forms.Button();
            this.b_create = new System.Windows.Forms.Button();
            this.b_stop = new System.Windows.Forms.Button();
            this.b_start = new System.Windows.Forms.Button();
            this.nUD_dens = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nUD_width = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nUD_height = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_dens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer1.Panel1.Controls.Add(this.b_openfail);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.b_save);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.b_step);
            this.splitContainer1.Panel1.Controls.Add(this.nUD_interval);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.b_clear);
            this.splitContainer1.Panel1.Controls.Add(this.b_create);
            this.splitContainer1.Panel1.Controls.Add(this.b_stop);
            this.splitContainer1.Panel1.Controls.Add(this.b_start);
            this.splitContainer1.Panel1.Controls.Add(this.nUD_dens);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.nUD_width);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nUD_height);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(958, 626);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 0;
            // 
            // b_openfail
            // 
            this.b_openfail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.b_openfail.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.b_openfail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_openfail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_openfail.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_openfail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_openfail.Location = new System.Drawing.Point(28, 86);
            this.b_openfail.Name = "b_openfail";
            this.b_openfail.Size = new System.Drawing.Size(226, 41);
            this.b_openfail.TabIndex = 22;
            this.b_openfail.Text = "Выбрать файл";
            this.b_openfail.UseVisualStyleBackColor = false;
            this.b_openfail.Click += new System.EventHandler(this.b_openfail_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Поле";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ограниченное поле",
            "Цилиндр ",
            "Тор"});
            this.comboBox2.Location = new System.Drawing.Point(28, 154);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(226, 24);
            this.comboBox2.TabIndex = 20;
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.b_save.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.b_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_save.Location = new System.Drawing.Point(144, 491);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(110, 50);
            this.b_save.TabIndex = 19;
            this.b_save.Text = "Cохранить";
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(80, 586);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 17);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "О разработчике";
            this.linkLabel1.DoubleClick += new System.EventHandler(this.linkLabel1_DoubleClick);
            // 
            // b_step
            // 
            this.b_step.BackColor = System.Drawing.Color.LightSkyBlue;
            this.b_step.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.b_step.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_step.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_step.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_step.Location = new System.Drawing.Point(28, 491);
            this.b_step.Name = "b_step";
            this.b_step.Size = new System.Drawing.Size(110, 50);
            this.b_step.TabIndex = 17;
            this.b_step.Text = "Шаг";
            this.b_step.UseVisualStyleBackColor = false;
            this.b_step.Click += new System.EventHandler(this.b_step_Click);
            // 
            // nUD_interval
            // 
            this.nUD_interval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nUD_interval.Location = new System.Drawing.Point(28, 340);
            this.nUD_interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUD_interval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUD_interval.Name = "nUD_interval";
            this.nUD_interval.Size = new System.Drawing.Size(226, 18);
            this.nUD_interval.TabIndex = 16;
            this.nUD_interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUD_interval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Интервал смены поколения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 42);
            this.label5.TabIndex = 14;
            this.label5.Text = "Как будет создаваться\r\nпервое поколение клеток";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Случайная генерация",
            "Создать первую конфигурацию",
            "Из файла"});
            this.comboBox1.Location = new System.Drawing.Point(28, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 12;
            // 
            // b_clear
            // 
            this.b_clear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.b_clear.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.b_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_clear.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_clear.Location = new System.Drawing.Point(28, 435);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(110, 50);
            this.b_clear.TabIndex = 11;
            this.b_clear.Text = "Очистить";
            this.b_clear.UseVisualStyleBackColor = false;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // b_create
            // 
            this.b_create.BackColor = System.Drawing.Color.LightSkyBlue;
            this.b_create.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.b_create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_create.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_create.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_create.Location = new System.Drawing.Point(28, 379);
            this.b_create.Name = "b_create";
            this.b_create.Size = new System.Drawing.Size(110, 50);
            this.b_create.TabIndex = 10;
            this.b_create.Text = "Создать";
            this.b_create.UseVisualStyleBackColor = false;
            this.b_create.Click += new System.EventHandler(this.b_create_Click);
            // 
            // b_stop
            // 
            this.b_stop.BackColor = System.Drawing.Color.LightSkyBlue;
            this.b_stop.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.b_stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_stop.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_stop.Location = new System.Drawing.Point(145, 435);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(110, 50);
            this.b_stop.TabIndex = 7;
            this.b_stop.Text = "Стоп";
            this.b_stop.UseVisualStyleBackColor = false;
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // b_start
            // 
            this.b_start.BackColor = System.Drawing.Color.LightSkyBlue;
            this.b_start.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.b_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_start.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_start.Location = new System.Drawing.Point(145, 379);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(110, 50);
            this.b_start.TabIndex = 6;
            this.b_start.Text = "Старт";
            this.b_start.UseVisualStyleBackColor = false;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // nUD_dens
            // 
            this.nUD_dens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nUD_dens.Location = new System.Drawing.Point(28, 295);
            this.nUD_dens.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nUD_dens.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_dens.Name = "nUD_dens";
            this.nUD_dens.Size = new System.Drawing.Size(226, 18);
            this.nUD_dens.TabIndex = 5;
            this.nUD_dens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUD_dens.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Плотность";
            // 
            // nUD_width
            // 
            this.nUD_width.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nUD_width.Location = new System.Drawing.Point(28, 250);
            this.nUD_width.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_width.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUD_width.Name = "nUD_width";
            this.nUD_width.Size = new System.Drawing.Size(226, 18);
            this.nUD_width.TabIndex = 3;
            this.nUD_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUD_width.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина";
            // 
            // nUD_height
            // 
            this.nUD_height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nUD_height.Location = new System.Drawing.Point(28, 205);
            this.nUD_height.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_height.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUD_height.Name = "nUD_height";
            this.nUD_height.Size = new System.Drawing.Size(226, 18);
            this.nUD_height.TabIndex = 1;
            this.nUD_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUD_height.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 626);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 626);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Игра Жизнь";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_dens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nUD_width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUD_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUD_dens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_stop;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button b_create;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUD_interval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_step;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button b_openfail;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.OpenFileDialog saveFileDialog;
    }
}

