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
    public partial class Raspisaniye : Form
    {
        public Raspisaniye()
        {
            InitializeComponent();
        }

        private void memueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Raspisaniye_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "unverDataSet.расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.unverDataSet.расписание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "unverDataSet.дисциплины". При необходимости она может быть перемещена или удалена.
            this.дисциплиныTableAdapter.Fill(this.unverDataSet.дисциплины);

        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = new Disciplina();
            disciplina.Show();
        }

        private void кафедраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kafedra kafedra = new Kafedra();
            kafedra.Show();
        }

        private void преподавательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Преподаватель prepod = new Преподаватель();
            prepod.Show();
        }

        private void расписаинеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
