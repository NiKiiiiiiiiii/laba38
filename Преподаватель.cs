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
    public partial class Преподаватель : Form
    {
        public Преподаватель()
        {
            InitializeComponent();
        }

        private void Преподаватель_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "unverDataSet.преподаватель". При необходимости она может быть перемещена или удалена.
            this.преподавательTableAdapter.Fill(this.unverDataSet.преподаватель);
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspisaniye raspisaniye = new Raspisaniye();
            raspisaniye.Show();
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
            
        }
    }
}
