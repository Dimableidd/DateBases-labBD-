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
    public partial class Журнал_посещаемости : Form
    {
        public Журнал_посещаемости()
        {
            InitializeComponent();
        }

        private void Журнал_посещаемости_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "костюк_Дмитрий_2Ж_06_12DataSet.Журнал_посещаемости". При необходимости она может быть перемещена или удалена.
            this.журнал_посещаемостиTableAdapter.Fill(this.костюк_Дмитрий_2Ж_06_12DataSet.Журнал_посещаемости);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_Filter1_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < dataGridView1.Rows.Count - 1; r++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[r].Visible = false;
                for (int c = 0; c < dataGridView1.Columns.Count; c++)
                {
                    if (dataGridView1[c, r].Value.ToString() == textBox1.Text)
                    {
                        dataGridView1.Rows[r].Visible = true;
                        break;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Сброс_фильтров_Click(object sender, EventArgs e)
        {
         
        }
    }
}
