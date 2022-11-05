using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBases
{
    public partial class Журнал_успеваемости : Form
    {
        public Журнал_успеваемости()
        {
            InitializeComponent();
        }

        private void Журнал_успеваемости_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "костюк_Дмитрий_2Ж_06_12DataSet.Журнал_успеваемости". При необходимости она может быть перемещена или удалена.
            this.журнал_успеваемостиTableAdapter.Fill(this.костюк_Дмитрий_2Ж_06_12DataSet.Журнал_успеваемости);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
