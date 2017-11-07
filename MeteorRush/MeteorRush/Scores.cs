using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeteorRush
{
    public partial class Scores : Form
    {
        public Scores(List<string> Scoruri)
        {
            InitializeComponent();

            CenterToParent();

            string[] Scor;

            ScorDataGridView.Rows.Clear();

            for (int i = 0; i < Scoruri.Count; i++)
            {
                Scor = Scoruri[i].Split(',');
                ScorDataGridView.Rows.Add();
                ScorDataGridView.Rows[i].Cells[0].Value = (i + 1).ToString();

                for (int j = 0; j < Scor.Length; j++)
                    ScorDataGridView.Rows[i].Cells[j+1].Value = Scor[j].ToString();
            }
        }

    }
}
