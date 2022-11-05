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
    public partial class Преподаватель : Form
    {
        public Преподаватель()
        {
            InitializeComponent();
        }

        private void Преподаватель_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "костюк_Дмитрий_2Ж_06_12DataSet.Преподаватель". При необходимости она может быть перемещена или удалена.
            this.преподавательTableAdapter.Fill(this.костюк_Дмитрий_2Ж_06_12DataSet.Преподаватель);

        }
    }
}
