using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba37
{
    public partial class Kafedra : Form
    {
        public Kafedra()
        {
            InitializeComponent();
        }

        private void Kafedra_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "unverDataSet.кафедра". При необходимости она может быть перемещена или удалена.
            this.кафедраTableAdapter.Fill(this.unverDataSet.кафедра);

        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = new Disciplina();
            disciplina.Show();
        }

        private void преподавательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Преподаватель prepod = new Преподаватель();
            prepod.Show();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspisaniye raspisaniye = new Raspisaniye();
            raspisaniye.Show();
        }

        private void Kafedra_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.кафедраTableAdapter.Update(this.unverDataSet.кафедра);
        }
    }
}
