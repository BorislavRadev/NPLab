namespace NPLab
{
    partial class Main
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
            this.Project = new System.Windows.Forms.TabControl();
            this.ObjectData = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Object = new System.Windows.Forms.TextBox();
            this.Client = new System.Windows.Forms.TextBox();
            this.Isolation = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PE = new System.Windows.Forms.CheckBox();
            this.L1 = new System.Windows.Forms.CheckBox();
            this.L2 = new System.Windows.Forms.CheckBox();
            this.L3 = new System.Windows.Forms.CheckBox();
            this.N = new System.Windows.Forms.CheckBox();
            this.PEN = new System.Windows.Forms.CheckBox();
            this.EngineerName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ButtonForAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CabelArea = new System.Windows.Forms.NumericUpDown();
            this.Label8 = new System.Windows.Forms.Label();
            this.TypeCabel = new System.Windows.Forms.ComboBox();
            this.numberOfCabels = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.NameOfCabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Norm_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Naprejenie = new System.Windows.Forms.NumericUpDown();
            this.Norm = new System.Windows.Forms.NumericUpDown();
            this.Impedance = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CurrentInformation = new System.Windows.Forms.TableLayoutPanel();
            this.NewRoom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Maximum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Minimum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Coefficient = new System.Windows.Forms.NumericUpDown();
            this.Grounding = new System.Windows.Forms.TabPage();
            this.LightningProtection = new System.Windows.Forms.TabPage();
            this.DefectiveProtection = new System.Windows.Forms.TabPage();
            this.Project.SuspendLayout();
            this.ObjectData.SuspendLayout();
            this.Isolation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CabelArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Naprejenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Norm)).BeginInit();
            this.Impedance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coefficient)).BeginInit();
            this.SuspendLayout();
            // 
            // Project
            // 
            this.Project.Controls.Add(this.ObjectData);
            this.Project.Controls.Add(this.Isolation);
            this.Project.Controls.Add(this.Impedance);
            this.Project.Controls.Add(this.Grounding);
            this.Project.Controls.Add(this.LightningProtection);
            this.Project.Controls.Add(this.DefectiveProtection);
            this.Project.Location = new System.Drawing.Point(29, 34);
            this.Project.Name = "Project";
            this.Project.SelectedIndex = 0;
            this.Project.Size = new System.Drawing.Size(846, 634);
            this.Project.TabIndex = 1;
            // 
            // ObjectData
            // 
            this.ObjectData.Controls.Add(this.label2);
            this.ObjectData.Controls.Add(this.label1);
            this.ObjectData.Controls.Add(this.Object);
            this.ObjectData.Controls.Add(this.Client);
            this.ObjectData.Location = new System.Drawing.Point(4, 22);
            this.ObjectData.Name = "ObjectData";
            this.ObjectData.Padding = new System.Windows.Forms.Padding(3);
            this.ObjectData.Size = new System.Drawing.Size(838, 608);
            this.ObjectData.TabIndex = 0;
            this.ObjectData.Text = "Информация за обекта";
            this.ObjectData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Обект";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Клиент";
            // 
            // Object
            // 
            this.Object.Location = new System.Drawing.Point(107, 132);
            this.Object.Multiline = true;
            this.Object.Name = "Object";
            this.Object.Size = new System.Drawing.Size(420, 48);
            this.Object.TabIndex = 1;
            // 
            // Client
            // 
            this.Client.Location = new System.Drawing.Point(107, 49);
            this.Client.Multiline = true;
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(420, 46);
            this.Client.TabIndex = 0;
            // 
            // Isolation
            // 
            this.Isolation.BackColor = System.Drawing.Color.SteelBlue;
            this.Isolation.Controls.Add(this.groupBox1);
            this.Isolation.Controls.Add(this.EngineerName);
            this.Isolation.Controls.Add(this.label12);
            this.Isolation.Controls.Add(this.ButtonForAdd);
            this.Isolation.Controls.Add(this.label11);
            this.Isolation.Controls.Add(this.numericUpDown1);
            this.Isolation.Controls.Add(this.label10);
            this.Isolation.Controls.Add(this.label9);
            this.Isolation.Controls.Add(this.CabelArea);
            this.Isolation.Controls.Add(this.Label8);
            this.Isolation.Controls.Add(this.TypeCabel);
            this.Isolation.Controls.Add(this.numberOfCabels);
            this.Isolation.Controls.Add(this.Number);
            this.Isolation.Controls.Add(this.textBoxName);
            this.Isolation.Controls.Add(this.NameOfCabel);
            this.Isolation.Controls.Add(this.label7);
            this.Isolation.Controls.Add(this.Norm_Label);
            this.Isolation.Controls.Add(this.label6);
            this.Isolation.Controls.Add(this.Naprejenie);
            this.Isolation.Controls.Add(this.Norm);
            this.Isolation.Location = new System.Drawing.Point(4, 22);
            this.Isolation.Name = "Isolation";
            this.Isolation.Padding = new System.Windows.Forms.Padding(3);
            this.Isolation.Size = new System.Drawing.Size(838, 608);
            this.Isolation.TabIndex = 1;
            this.Isolation.Text = "Изолация";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PE);
            this.groupBox1.Controls.Add(this.L1);
            this.groupBox1.Controls.Add(this.L2);
            this.groupBox1.Controls.Add(this.L3);
            this.groupBox1.Controls.Add(this.N);
            this.groupBox1.Controls.Add(this.PEN);
            this.groupBox1.Location = new System.Drawing.Point(518, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 78);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Проводници";
            // 
            // PE
            // 
            this.PE.AutoSize = true;
            this.PE.Location = new System.Drawing.Point(94, 19);
            this.PE.Name = "PE";
            this.PE.Size = new System.Drawing.Size(40, 17);
            this.PE.TabIndex = 19;
            this.PE.Text = "PE";
            this.PE.UseVisualStyleBackColor = true;
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(10, 19);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(38, 17);
            this.L1.TabIndex = 14;
            this.L1.Text = "L1";
            this.L1.UseVisualStyleBackColor = true;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(10, 51);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(38, 17);
            this.L2.TabIndex = 15;
            this.L2.Text = "L2";
            this.L2.UseVisualStyleBackColor = true;
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Location = new System.Drawing.Point(50, 19);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(38, 17);
            this.L3.TabIndex = 16;
            this.L3.Text = "L3";
            this.L3.UseVisualStyleBackColor = true;
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(54, 51);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(34, 17);
            this.N.TabIndex = 17;
            this.N.Text = "N";
            this.N.UseVisualStyleBackColor = true;
            // 
            // PEN
            // 
            this.PEN.AutoSize = true;
            this.PEN.Location = new System.Drawing.Point(94, 51);
            this.PEN.Name = "PEN";
            this.PEN.Size = new System.Drawing.Size(48, 17);
            this.PEN.TabIndex = 20;
            this.PEN.Text = "PEN";
            this.PEN.UseVisualStyleBackColor = true;
            // 
            // EngineerName
            // 
            this.EngineerName.FormattingEnabled = true;
            this.EngineerName.Location = new System.Drawing.Point(120, 22);
            this.EngineerName.Name = "EngineerName";
            this.EngineerName.Size = new System.Drawing.Size(74, 21);
            this.EngineerName.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Име инж. :";
            // 
            // ButtonForAdd
            // 
            this.ButtonForAdd.Location = new System.Drawing.Point(573, 65);
            this.ButtonForAdd.Name = "ButtonForAdd";
            this.ButtonForAdd.Size = new System.Drawing.Size(112, 26);
            this.ButtonForAdd.TabIndex = 23;
            this.ButtonForAdd.Text = "Добави кабел";
            this.ButtonForAdd.UseVisualStyleBackColor = true;
            this.ButtonForAdd.Click += new System.EventHandler(this.ButtonForAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(693, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Измерено";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(696, 151);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "x";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Сечение";
            // 
            // CabelArea
            // 
            this.CabelArea.DecimalPlaces = 1;
            this.CabelArea.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.CabelArea.Location = new System.Drawing.Point(417, 151);
            this.CabelArea.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.CabelArea.Name = "CabelArea";
            this.CabelArea.Size = new System.Drawing.Size(70, 20);
            this.CabelArea.TabIndex = 11;
            this.CabelArea.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(216, 122);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(59, 13);
            this.Label8.TabIndex = 10;
            this.Label8.Text = "Тип кабел";
            // 
            // TypeCabel
            // 
            this.TypeCabel.FormattingEnabled = true;
            this.TypeCabel.Items.AddRange(new object[] {
            "СВТ",
            " ПВВМБ1"});
            this.TypeCabel.Location = new System.Drawing.Point(219, 150);
            this.TypeCabel.Name = "TypeCabel";
            this.TypeCabel.Size = new System.Drawing.Size(86, 21);
            this.TypeCabel.TabIndex = 9;
            // 
            // numberOfCabels
            // 
            this.numberOfCabels.AutoSize = true;
            this.numberOfCabels.Location = new System.Drawing.Point(320, 122);
            this.numberOfCabels.Name = "numberOfCabels";
            this.numberOfCabels.Size = new System.Drawing.Size(35, 13);
            this.numberOfCabels.TabIndex = 8;
            this.numberOfCabels.Text = "Брой ";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(323, 151);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(70, 20);
            this.Number.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(48, 150);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(146, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // NameOfCabel
            // 
            this.NameOfCabel.AutoSize = true;
            this.NameOfCabel.Location = new System.Drawing.Point(45, 121);
            this.NameOfCabel.Name = "NameOfCabel";
            this.NameOfCabel.Size = new System.Drawing.Size(29, 13);
            this.NameOfCabel.TabIndex = 5;
            this.NameOfCabel.Text = "Име";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Номинално напрежение на източника:";
            // 
            // Norm_Label
            // 
            this.Norm_Label.AutoSize = true;
            this.Norm_Label.Location = new System.Drawing.Point(45, 72);
            this.Norm_Label.Name = "Norm_Label";
            this.Norm_Label.Size = new System.Drawing.Size(122, 13);
            this.Norm_Label.TabIndex = 3;
            this.Norm_Label.Text = "Минимално измерено:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
            // 
            // Naprejenie
            // 
            this.Naprejenie.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Naprejenie.Location = new System.Drawing.Point(466, 65);
            this.Naprejenie.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.Naprejenie.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Naprejenie.Name = "Naprejenie";
            this.Naprejenie.Size = new System.Drawing.Size(59, 20);
            this.Naprejenie.TabIndex = 1;
            this.Naprejenie.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // Norm
            // 
            this.Norm.DecimalPlaces = 1;
            this.Norm.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Norm.Location = new System.Drawing.Point(173, 65);
            this.Norm.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Norm.Name = "Norm";
            this.Norm.Size = new System.Drawing.Size(59, 20);
            this.Norm.TabIndex = 0;
            // 
            // Impedance
            // 
            this.Impedance.Controls.Add(this.dataGridView1);
            this.Impedance.Controls.Add(this.CurrentInformation);
            this.Impedance.Controls.Add(this.NewRoom);
            this.Impedance.Controls.Add(this.label5);
            this.Impedance.Controls.Add(this.Maximum);
            this.Impedance.Controls.Add(this.label4);
            this.Impedance.Controls.Add(this.Minimum);
            this.Impedance.Controls.Add(this.label3);
            this.Impedance.Controls.Add(this.Coefficient);
            this.Impedance.Location = new System.Drawing.Point(4, 22);
            this.Impedance.Name = "Impedance";
            this.Impedance.Padding = new System.Windows.Forms.Padding(3);
            this.Impedance.Size = new System.Drawing.Size(838, 608);
            this.Impedance.TabIndex = 2;
            this.Impedance.Text = "Импеданс";
            this.Impedance.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 204);
            this.dataGridView1.TabIndex = 9;
            // 
            // CurrentInformation
            // 
            this.CurrentInformation.ColumnCount = 2;
            this.CurrentInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CurrentInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CurrentInformation.Location = new System.Drawing.Point(18, 68);
            this.CurrentInformation.Name = "CurrentInformation";
            this.CurrentInformation.RowCount = 2;
            this.CurrentInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CurrentInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CurrentInformation.Size = new System.Drawing.Size(763, 45);
            this.CurrentInformation.TabIndex = 8;
            // 
            // NewRoom
            // 
            this.NewRoom.Location = new System.Drawing.Point(605, 30);
            this.NewRoom.Name = "NewRoom";
            this.NewRoom.Size = new System.Drawing.Size(177, 32);
            this.NewRoom.TabIndex = 7;
            this.NewRoom.Text = "Добави ново помещение";
            this.NewRoom.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Максимално измерено:";
            // 
            // Maximum
            // 
            this.Maximum.DecimalPlaces = 2;
            this.Maximum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Maximum.Location = new System.Drawing.Point(538, 38);
            this.Maximum.Name = "Maximum";
            this.Maximum.Size = new System.Drawing.Size(45, 20);
            this.Maximum.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Минимално измерено:";
            // 
            // Minimum
            // 
            this.Minimum.DecimalPlaces = 2;
            this.Minimum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Minimum.Location = new System.Drawing.Point(352, 38);
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(45, 20);
            this.Minimum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Коефициент на задействане:";
            // 
            // Coefficient
            // 
            this.Coefficient.Location = new System.Drawing.Point(173, 38);
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.Size = new System.Drawing.Size(45, 20);
            this.Coefficient.TabIndex = 1;
            // 
            // Grounding
            // 
            this.Grounding.Location = new System.Drawing.Point(4, 22);
            this.Grounding.Name = "Grounding";
            this.Grounding.Padding = new System.Windows.Forms.Padding(3);
            this.Grounding.Size = new System.Drawing.Size(838, 608);
            this.Grounding.TabIndex = 3;
            this.Grounding.Text = "Заземление";
            this.Grounding.UseVisualStyleBackColor = true;
            // 
            // LightningProtection
            // 
            this.LightningProtection.Location = new System.Drawing.Point(4, 22);
            this.LightningProtection.Name = "LightningProtection";
            this.LightningProtection.Padding = new System.Windows.Forms.Padding(3);
            this.LightningProtection.Size = new System.Drawing.Size(838, 608);
            this.LightningProtection.TabIndex = 4;
            this.LightningProtection.Text = "Мълниезащита";
            this.LightningProtection.UseVisualStyleBackColor = true;
            // 
            // DefectiveProtection
            // 
            this.DefectiveProtection.Location = new System.Drawing.Point(4, 22);
            this.DefectiveProtection.Name = "DefectiveProtection";
            this.DefectiveProtection.Padding = new System.Windows.Forms.Padding(3);
            this.DefectiveProtection.Size = new System.Drawing.Size(838, 608);
            this.DefectiveProtection.TabIndex = 5;
            this.DefectiveProtection.Text = "Дефектнотокова защита";
            this.DefectiveProtection.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 686);
            this.Controls.Add(this.Project);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Project.ResumeLayout(false);
            this.ObjectData.ResumeLayout(false);
            this.ObjectData.PerformLayout();
            this.Isolation.ResumeLayout(false);
            this.Isolation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CabelArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Naprejenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Norm)).EndInit();
            this.Impedance.ResumeLayout(false);
            this.Impedance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coefficient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Project;
        private System.Windows.Forms.TabPage ObjectData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Object;
        private System.Windows.Forms.TextBox Client;
        private System.Windows.Forms.TabPage Isolation;
        private System.Windows.Forms.TabPage Impedance;
        private System.Windows.Forms.TabPage Grounding;
        private System.Windows.Forms.TabPage LightningProtection;
        private System.Windows.Forms.TabPage DefectiveProtection;
        private System.Windows.Forms.NumericUpDown Coefficient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Minimum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel CurrentInformation;
        private System.Windows.Forms.Button NewRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Maximum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Norm_Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Naprejenie;
        private System.Windows.Forms.NumericUpDown Norm;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label NameOfCabel;
        private System.Windows.Forms.Label numberOfCabels;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.ComboBox TypeCabel;
        private System.Windows.Forms.CheckBox PE;
        private System.Windows.Forms.CheckBox N;
        private System.Windows.Forms.CheckBox L3;
        private System.Windows.Forms.CheckBox L2;
        private System.Windows.Forms.CheckBox L1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown CabelArea;
        private System.Windows.Forms.CheckBox PEN;
        private System.Windows.Forms.Button ButtonForAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox EngineerName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}

