using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHotel
{
    public partial class reserva : Form
    {
        public reserva()
        {
            InitializeComponent();
        }

        private void calcularbttn_Click(object sender, EventArgs e)
        {
            DateTime oldDate = dateTimePicker1.Value;
            DateTime newDate = dateTimePicker2.Value;
            // Diferencia de dias.
            TimeSpan ts = newDate - oldDate;
            // numero de dias.
            int differenceInDays = ts.Days;
            int dias = differenceInDays + 1;
            int numclient=int.Parse(textBox3.Text);
            int montopagar = dias * 35;
            label5.Text = differenceInDays.ToString();
            label6.Text = montopagar.ToString();
        }
    }
}
