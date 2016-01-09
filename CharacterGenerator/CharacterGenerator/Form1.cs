using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterGenerator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            //super efficient way to calculate stats, yep.
            Random random = new Random();
            int a, b, c, d = 0;
            int mod = 0;
            for (int i = 0; i < 6; i++)
            {
                a = random.Next(6) + 1;
                b = random.Next(6) + 1;
                c = random.Next(6) + 1;
                d = a + b + c;
                switch (i)
                {
                    case 0:
                        txtBaseStr.Text = d.ToString();
                        mod = StatTotal(d);
                        txtModStr.Text = mod.ToString();
                        break;
                    case 1:
                        txtBaseDex.Text = d.ToString();
                        mod = StatTotal(d);
                        txtModDex.Text = mod.ToString();
                        break;
                    case 2:
                        txtBaseCon.Text = d.ToString();
                        mod = StatTotal(d);
                        txtModCon.Text = mod.ToString();
                        break;
                    case 3:
                        txtBaseInt.Text = d.ToString();
                        mod = StatTotal(d);
                        txtModInt.Text = mod.ToString();
                        break;
                    case 4:
                        txtBaseWis.Text = d.ToString();
                        mod = StatTotal(d);
                        txtModWis.Text = mod.ToString();
                        break;
                    case 5:
                        txtBaseCha.Text = d.ToString();
                        mod = StatTotal(d);
                        txtModCha.Text = mod.ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        #region methods
        private int StatTotal(int modifier)
        {

            return (modifier / 2) - 5;
        }
        #endregion
    }
}
