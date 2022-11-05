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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void таблицаЖурналПосещаемостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Журнал_посещаемости таблицаЖурналПосещаемости = new Журнал_посещаемости();
            таблицаЖурналПосещаемости.ShowDialog();
            Close();

        }

        private void таблицаЖурналУспеваемостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Журнал_успеваемости таблицаЖурналУспеваемости = new Журнал_успеваемости();
            таблицаЖурналУспеваемости.ShowDialog();
            Close();
        }

        private void таблицаРасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Расписание таблицаРасписание = new Расписание();
            таблицаРасписание.ShowDialog();
            Close();
        }

        private void таблицаСтудентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Студент таблицаСтудент = new Студент();
            таблицаСтудент.ShowDialog();
            Close();
        }

        private void таблицаПредметToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Предмет таблицаПредмет = new Предмет();
            таблицаПредмет.ShowDialog();
            Close();
        }

        private void таблицаПреподавательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Преподаватель таблицаПреподаватель = new Преподаватель();
            таблицаПреподаватель.ShowDialog();
            Close();
        }
    }