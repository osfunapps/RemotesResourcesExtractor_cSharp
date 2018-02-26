using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemotesResourcesExtractor_cSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExtractorCoordinator extractorCoordinator = new ExtractorCoordinator();
            extractorCoordinator.Coordinate(remotesRootPathTB.Text.ToString(), remotesDestTB.Text.ToString(), appsPrefixTB.Text.ToString(), removeCommentsCB.Checked);
        }


    }
}
