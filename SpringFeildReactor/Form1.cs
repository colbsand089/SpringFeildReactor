using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace SpringFeildReactor
{
    public partial class SpringFeildReactor : Form
    {
        public SpringFeildReactor()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            player.Play();
            titleLabel.Text = "BOOM";
            OutputLabel.Text = "MELTDOWN";
            reactor2StateLable.BackColor = Color.Red;
            reactor1StateLable.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            reactor2StateLable.BackColor = Color.White;
            reactor1StateLable.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            reactor2StateLable.BackColor = Color.Red;
            reactor1StateLable.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            reactor2StateLable.BackColor = Color.White;
            reactor1StateLable.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            reactor2StateLable.BackColor = Color.Red;
            reactor1StateLable.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
