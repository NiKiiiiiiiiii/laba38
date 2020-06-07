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
    public partial class Disciplina : Form
    {
        public Disciplina()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "unverDataSet.дисциплины". При необходимости она может быть перемещена или удалена.
            this.дисциплиныTableAdapter.Fill(this.unverDataSet.дисциплины);
        }

        private void кафедраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kafedra kafedra = new Kafedra();
            kafedra.Show();
        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void преподовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Преподаватель prepod = new Преподаватель();
            prepod.Show();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspisaniye raspisaniye = new Raspisaniye();
            raspisaniye.Show();
        }

        private void Disciplina_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.дисциплиныTableAdapter.Update(this.unverDataSet.дисциплины);
        }
    }
}
