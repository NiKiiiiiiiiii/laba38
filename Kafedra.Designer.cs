namespace Laba37
{
    partial class Kafedra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номеркафедрыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиекафедрыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заведующийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.портретзаведующегоDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.кафедраBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unverDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unverDataSet = new Laba37.unverDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисциплиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кафедраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кафедраTableAdapter = new Laba37.unverDataSetTableAdapters.кафедраTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кафедраBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unverDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unverDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.номеркафедрыDataGridViewTextBoxColumn,
            this.названиекафедрыDataGridViewTextBoxColumn,
            this.заведующийDataGridViewTextBoxColumn,
            this.портретзаведующегоDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.кафедраBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // номеркафедрыDataGridViewTextBoxColumn
            // 
            this.номеркафедрыDataGridViewTextBoxColumn.DataPropertyName = "Номер_кафедры";
            this.номеркафедрыDataGridViewTextBoxColumn.HeaderText = "Номер_кафедры";
            this.номеркафедрыDataGridViewTextBoxColumn.Name = "номеркафедрыDataGridViewTextBoxColumn";
            this.номеркафедрыDataGridViewTextBoxColumn.Width = 150;
            // 
            // названиекафедрыDataGridViewTextBoxColumn
            // 
            this.названиекафедрыDataGridViewTextBoxColumn.DataPropertyName = "Название_кафедры";
            this.названиекафедрыDataGridViewTextBoxColumn.HeaderText = "Название_кафедры";
            this.названиекафедрыDataGridViewTextBoxColumn.Name = "названиекафедрыDataGridViewTextBoxColumn";
            this.названиекафедрыDataGridViewTextBoxColumn.Width = 150;
            // 
            // заведующийDataGridViewTextBoxColumn
            // 
            this.заведующийDataGridViewTextBoxColumn.DataPropertyName = "Заведующий";
            this.заведующийDataGridViewTextBoxColumn.HeaderText = "Заведующий";
            this.заведующийDataGridViewTextBoxColumn.Name = "заведующийDataGridViewTextBoxColumn";
            this.заведующийDataGridViewTextBoxColumn.Width = 150;
            // 
            // портретзаведующегоDataGridViewImageColumn
            // 
            this.портретзаведующегоDataGridViewImageColumn.DataPropertyName = "Портрет_заведующего";
            this.портретзаведующегоDataGridViewImageColumn.HeaderText = "Портрет_заведующего";
            this.портретзаведующегоDataGridViewImageColumn.Name = "портретзаведующегоDataGridViewImageColumn";
            this.портретзаведующегоDataGridViewImageColumn.Width = 200;
            // 
            // кафедраBindingSource
            // 
            this.кафедраBindingSource.DataMember = "кафедра";
            this.кафедраBindingSource.DataSource = this.unverDataSetBindingSource;
            // 
            // unverDataSetBindingSource
            // 
            this.unverDataSetBindingSource.DataSource = this.unverDataSet;
            this.unverDataSetBindingSource.Position = 0;
            // 
            // unverDataSet
            // 
            this.unverDataSet.DataSetName = "unverDataSet";
            this.unverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.дисциплиныToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.дисциплиныToolStripMenuItem.Text = "Дисциплины";
            this.дисциплиныToolStripMenuItem.Click += new System.EventHandler(this.дисциплиныToolStripMenuItem_Click);
            // 
            // кафедраToolStripMenuItem
            // 
            this.кафедраToolStripMenuItem.Name = "кафедраToolStripMenuItem";
            this.кафедраToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кафедраToolStripMenuItem.Text = "Кафедра ";
            // 
            // преподавательToolStripMenuItem
            // 
            this.преподавательToolStripMenuItem.Name = "преподавательToolStripMenuItem";
            this.преподавательToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.преподавательToolStripMenuItem.Text = "Преподаватель ";
            this.преподавательToolStripMenuItem.Click += new System.EventHandler(this.преподавательToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.расписаниеToolStripMenuItem.Text = "Расписание ";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // кафедраTableAdapter
            // 
            this.кафедраTableAdapter.ClearBeforeFill = true;
            // 
            // Kafedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 234);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Kafedra";
            this.Text = "Kafedra";
            this.Load += new System.EventHandler(this.Kafedra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кафедраBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unverDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unverDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дисциплиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кафедраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.BindingSource unverDataSetBindingSource;
        private unverDataSet unverDataSet;
        private System.Windows.Forms.BindingSource кафедраBindingSource;
        private unverDataSetTableAdapters.кафедраTableAdapter кафедраTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеркафедрыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиекафедрыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заведующийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn портретзаведующегоDataGridViewImageColumn;
    }
}