using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Exceptions
{
    public partial class ExeptionForm : Form
    {
        public ExeptionForm()
        {
            InitializeComponent();
        }

        private void btDelen_Click(object sender, EventArgs e)
        {
            try
            {
                int getal1 = Convert.ToInt32(tbGetal1.Text);
                int getal2 = Convert.ToInt32(tbGetal2.Text);

                if (getal1 > 200)
                {
                    throw new MyException("Input getal is groter dan 200!");
                }

                int resultaat = getal1 / getal2;
                lblBericht.Text = resultaat.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
            catch (DivideByZeroException dZe)
            {
                MessageBox.Show(dZe.Message);
            }
            catch (MyException mex)
            {
                MessageBox.Show(mex.Message);
            }
            finally
            {
                //wordt vaak gebruikt om bijvoorbeeld een database connection of filestream te sluiten.
            }
        }

    }
}
