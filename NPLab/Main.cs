using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPLab.Data;
using NPLab.Models;
using System.Data.Entity;
using NPLab.Data.Migrations;

namespace NPLab
{
    public partial class Main : Form
    {

        List<TextBox> Names = new List<TextBox>(); 
        List<ComboBox> TypeCabs = new List<ComboBox>();
        List<NumericUpDown> Count = new List<NumericUpDown>();
        List<NumericUpDown> Surface = new List<NumericUpDown>();
        List<NumericUpDown> MeasuredForm = new List<NumericUpDown>();
        List<CheckBox> L1s = new List<CheckBox>();
        List<CheckBox> L2s = new List<CheckBox>();
        List<CheckBox> L3s = new List<CheckBox>();
        List<CheckBox> Ns = new List<CheckBox>();
        List<CheckBox> PEs = new List<CheckBox>();
        List<CheckBox> PENs = new List<CheckBox>();
        List<GroupBox> Conductors = new List<GroupBox>();

        public Main()
        {
            InitializeComponent();
        }
        private void ButtonForAdd_Click(object sender, EventArgs e)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NPLabDbContext, Configuration>());

            var db = new NPLabDbContext();

            var el_1 = new EL_1
            {
                NameOfEngineer = EngineerName.ToString(),
                Date = DateTime.Now,
                SourceVoltage = Convert.ToInt32(Naprejenie.Value),
                Min = Convert.ToInt32(Norm.Value),
            };

            db.EL_1.Add(el_1);
            db.SaveChanges();

            TextBox name = new TextBox();
            name.Size = textBoxName.Size;
            name.Left = textBoxName.Left;
            name.Top = Names[Names.Count - 1].Top + Names[Names.Count - 1].Height + 10;
            name.Name = "textBox" + Names.Count.ToString();
            Names.Add(name);
            Names[Names.Count-1].TextChanged += new EventHandler(textBoxName_TextChanged);
            Isolation.Controls.Add(Names[Names.Count - 1]);
            Names[Names.Count - 1].Visible = true;

        }

        private void Main_Load(object sender, EventArgs e)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NPLabDbContext, Configuration>());

            var db = new NPLabDbContext();
            //string engi = db.Engineers.Select();
            Engineers table = new Engineers();
    
            foreach (string eng in table.NameOfEngineer) EngineerName.Items.Add(eng);
           
            Names.Add(textBoxName);
            
            TypeCabs.Add(TypeCabel);
            Count.Add(Number);
            Surface.Add(CabelArea);
            MeasuredForm.Add(numericUpDown1); 
            L1s.Add(L1);
            L2s.Add(L2); 
            L3s.Add(L3);
            Ns.Add(N); 
            PEs.Add(PE);
            PENs.Add(PEN);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
