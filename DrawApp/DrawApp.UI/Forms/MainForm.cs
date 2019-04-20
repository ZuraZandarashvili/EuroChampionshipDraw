using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            #region Old
            //var gr = new int[4][]
            //{
            //     new int[] { 1, 2, 3, 4 },
            //     new int[] { 10, 20, 30, 40 },
            //     new int[] { 100, 200, 300, 400 },
            //     new int[] { 1000, 2000, 3000, 4000 },
            //};
            //for (int i = 0; i < 4; i++)
            //    gr[i].Shuffle(); 
            #endregion

            var gr = new List<TeamModels>[4][]
            {
                 new List<TeamModels>[] { 1, 2, 3, 4 },
                 new TeamModels[] { 10, 20, 30, 40 },
                 new TeamModels[] { 100, 200, 300, 400 },
                 new TeamModels[] { 1000, 2000, 3000, 4000 },
            };
            for (int i = 0; i < 4; i++)
                gr[i].Shuffle();



        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
