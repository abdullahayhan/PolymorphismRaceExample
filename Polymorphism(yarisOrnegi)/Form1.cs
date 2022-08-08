using Polymorphism_yarisOrnegi_.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism_yarisOrnegi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tm.Start();
        }
        Human human = new Human();
        Elf elf = new Elf();
        Orc orc = new Orc();
        private void tm_Tick(object sender, EventArgs e)
        {
            lblHuman.Left += human.GetSpeed();
            lblElf.Left += elf.GetSpeed();
            lblOrc.Left += orc.GetSpeed();
            if (lblHuman.Right>=lblFinish.Left)
            {
                tm.Stop();
                MessageBox.Show("insan kazandı");
            }
            else if (lblOrc.Right>=lblFinish.Left)
            {
                tm.Stop();
                MessageBox.Show("Orc kazandı.");
            }
            else if (lblElf.Right>=lblFinish.Left)
            {
                tm.Stop();
                MessageBox.Show("Elf kazandı.");
            }
        }
    }
}
