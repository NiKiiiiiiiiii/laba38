namespace Laba37
{
    partial class Преподаватель
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисциплиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кафедраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерпреподавателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номеркафедрыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.портретпреподавателяDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.преподавательBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unverDataSet = new Laba37.unverDataSet();
            this.преподавательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.преподавательTableAdapter = new Laba37.unverDataSetTableAdapters.преподавательTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавательBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unverDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавательBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дисциплиныToolStripMenuItem,
            this.кафедраToolStripMenuItem,
            this.преподавательToolStripMenuItem,
            this.расписаниеToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // дисциплиныToolStripMenuItem
            // 
            this.дисциплиныToolStripMenuItem.Name = "дисциплиныToolStripMenuItem";
            this.дисциплиныToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.дисциплиныToolStripMenuItem.Text = "Дисциплины ";
            this.дисциплиныToolStripMenuItem.Click += new System.EventHandler(this.дисциплиныToolStripMenuItem_Click);
            // 
            // кафедраToolStripMenuItem
            // 
            this.кафедраToolStripMenuItem.Name = "кафедраToolStripMenuItem";
            this.кафедраToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.кафедраToolStripMenuItem.Text = "Кафедра ";
            this.кафедраToolStripMenuItem.Click += new System.EventHandler(this.кафедраToolStripMenuItem_Click);
            // 
            // преподавательToolStripMenuItem
            // 
            this.преподавательToolStripMenuItem.Name = "преподавательToolStripMenuItem";
            this.преподавательToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.преподавательToolStripMenuItem.Text = "Преподаватель ";
            this.преподавательToolStripMenuItem.Click += new System.EventHandler(this.преподавательToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.расписаниеToolStripMenuItem.Text = "Расписание ";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.номерпреподавателяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.номеркафедрыDataGridViewTextBoxColumn,
            this.портретпреподавателяDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.преподавательBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // номерпреподавателяDataGridViewTextBoxColumn
            // 
            this.номерпреподавателяDataGridViewTextBoxColumn.DataPropertyName = "Номер_преподавателя";
            this.номерпреподавателяDataGridViewTextBoxColumn.HeaderText = "Номер_преподавателя";
            this.номерпреподавателяDataGridViewTextBoxColumn.Name = "номерпреподавателяDataGridViewTextBoxColumn";
            this.номерпреподавателяDataGridViewTextBoxColumn.Width = 150;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 150;
            // 
            // номеркафедрыDataGridViewTextBoxColumn
            // 
            this.номеркафедрыDataGridViewTextBoxColumn.DataPropertyName = "Номер_кафедры";
            this.номеркафедрыDataGridViewTextBoxColumn.HeaderText = "Номер_кафедры";
            this.номеркафедрыDataGridViewTextBoxColumn.Name = "номеркафедрыDataGridViewTextBoxColumn";
            this.номеркафедрыDataGridViewTextBoxColumn.Width = 150;
            // 
            // портретпреподавателяDataGridViewImageColumn
            // 
            this.портретпреподавателяDataGridViewImageColumn.DataPropertyName = "Портрет_преподавателя";
            this.портретпреподавателяDataGridViewImageColumn.HeaderText = "Портрет_преподавателя";
            this.портретпреподавателяDataGridViewImageColumn.Name = "портретпреподавателяDataGridViewImageColumn";
            this.портретпреподавателяDataGridViewImageColumn.Width = 200;
            // 
            // преподавательBindingSource1
            // 
            this.преподавательBindingSource1.DataMember = "преподаватель";
            this.преподавательBindingSource1.DataSource = this.unverDataSet;
            // 
            // unverDataSet
            // 
            this.unverDataSet.DataSetName = "unverDataSet";
            this.unverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // преподавательBindingSource
            // 
            this.преподавательBindingSource.DataMember = "преподаватель";
            this.преподавательBindingSource.DataSource = this.unverDataSet;
            // 
            // преподавательTableAdapter
            // 
            this.преподавательTableAdapter.ClearBeforeFill = true;
            // 
            // Преподаватель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 176);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Преподаватель";
            this.Text = "Преподаватель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Преподаватель_FormClosing);
            this.Load += new System.EventHandler(this.Преподаватель_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавательBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unverDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавательBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дисциплиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кафедраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private unverDataSet unverDataSet;
        private System.Windows.Forms.BindingSource преподавательBindingSource;
        private unverDataSetTableAdapters.преподавательTableAdapter преподавательTableAdapter;
        private System.Windows.Forms.BindingSource преподавательBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпреподавателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеркафедрыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn портретпреподавателяDataGridViewImageColumn;
    }
}