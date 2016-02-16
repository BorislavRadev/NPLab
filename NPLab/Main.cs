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
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonForAdd_Click(object sender, EventArgs e)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NPLabDbContext, Configuration>());

            var db = new NPLabDbContext();

            var el_1 = new EL_1
            {
                NameOfEngineer = EngineeerName.ToString(),
                Date = DateTime.Now,
                SourceVoltage = Convert.ToInt32(Naprejenie.Value),
                Min = Convert.ToInt32(Norm.Value),
            };

            db.EL_1.Add(el_1);
            db.SaveChanges();
        }

    }
}
