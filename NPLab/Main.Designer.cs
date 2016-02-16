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
            this.Norm = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Norm_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Project.SuspendLayout();
            this.ObjectData.SuspendLayout();
            this.Isolation.SuspendLayout();
            this.Impedance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coefficient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Norm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.Isolation.Controls.Add(this.tableLayoutPanel1);
            this.Isolation.Controls.Add(this.label7);
            this.Isolation.Controls.Add(this.Norm_Label);
            this.Isolation.Controls.Add(this.label6);
            this.Isolation.Controls.Add(this.numericUpDown2);
            this.Isolation.Controls.Add(this.Norm);
            this.Isolation.Location = new System.Drawing.Point(4, 22);
            this.Isolation.Name = "Isolation";
            this.Isolation.Padding = new System.Windows.Forms.Padding(3);
            this.Isolation.Size = new System.Drawing.Size(838, 608);
            this.Isolation.TabIndex = 1;
            this.Isolation.Text = "Изолация";
            this.Isolation.UseVisualStyleBackColor = true;
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
            // Norm
            // 
            this.Norm.Location = new System.Drawing.Point(173, 65);
            this.Norm.Name = "Norm";
            this.Norm.Size = new System.Drawing.Size(59, 20);
            this.Norm.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(466, 70);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Номинално напрежение на източника:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 376F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 455);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 686);
            this.Controls.Add(this.Project);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Project.ResumeLayout(false);
            this.ObjectData.ResumeLayout(false);
            this.ObjectData.PerformLayout();
            this.Isolation.ResumeLayout(false);
            this.Isolation.PerformLayout();
            this.Impedance.ResumeLayout(false);
            this.Impedance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coefficient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Norm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown Norm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}

