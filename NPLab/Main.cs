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
using System.Data.Entity.Migrations;
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
            /*
            var inst = new Installations
            {
                ...
                ...
              Item = " ";
                ...
                ...
            };
             var instItem = new InstallatinItem
              {
              type = (0,1 ili 2)
              };
            */
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

            ComboBox cabel = new ComboBox();
            cabel.Size = TypeCabel.Size;
            cabel.Left = TypeCabel.Left;
            cabel.Top = TypeCabs[TypeCabs.Count - 1].Top + TypeCabs[TypeCabs.Count - 1].Height + 10;
            //string itemsText = "СВТ,ПВВМБ1";
            //itemsText = itemsText.Replace(",", "," + System.Environment.NewLine);
            //cabel.Items = itemsText;
            //cabel.Items = TypeCabel.Items;
            cabel.Name = "ComboBox" + TypeCabs.Count.ToString();
            TypeCabs.Add(cabel);
            Isolation.Controls.Add(TypeCabs[TypeCabs.Count - 1]);
            TypeCabs[TypeCabs.Count - 1].Visible = true;


        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nPLabDataSet.Engineers' table. You can move, or remove it, as needed.
            this.engineersTableAdapter.Fill(this.nPLabDataSet.Engineers);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NPLabDbContext, Configuration>());

            var db = new NPLabDbContext();

//            var names = NPLabDbContext.Engineers.ToList();
           // string names;
            //foreach (string name in names) EngineerName.Items.Add(name);
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
        public Engineers GetById(string NameOfEngineer, NPLabDbContext context)
        {
            return context.Engineers.Find(NameOfEngineer);
        }
        public ICollection<Engineers> GetAll(NPLabDbContext context)
        {
            return context.Engineers.ToList();
        }
         private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
