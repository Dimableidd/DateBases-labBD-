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
    public partial class Расписание : Form
    {
        public Расписание()
        {
            InitializeComponent();
        }

        private void Расписание_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "костюк_Дмитрий_2Ж_06_12DataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.костюк_Дмитрий_2Ж_06_12DataSet.Расписание);

        }
    }
}
