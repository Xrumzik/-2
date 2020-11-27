namespace _22_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазработчикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudKol = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rez = new System.Windows.Forms.Button();
            this.crear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKol)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(622, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчетToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.заполнитьToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // расчетToolStripMenuItem
            // 
            this.расчетToolStripMenuItem.Name = "расчетToolStripMenuItem";
            this.расчетToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.расчетToolStripMenuItem.Text = "Расчет";
            this.расчетToolStripMenuItem.Click += new System.EventHandler(this.rez_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.crear_Click);
            // 
            // заполнитьToolStripMenuItem
            // 
            this.заполнитьToolStripMenuItem.Name = "заполнитьToolStripMenuItem";
            this.заполнитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.заполнитьToolStripMenuItem.Text = "Заполнить";
            this.заполнитьToolStripMenuItem.Click += new System.EventHandler(this.fill_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оРазработчикеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // оРазработчикеToolStripMenuItem
            // 
            this.оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
            this.оРазработчикеToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.оРазработчикеToolStripMenuItem.Text = "О разработчике";
            this.оРазработчикеToolStripMenuItem.Click += new System.EventHandler(this.оРазработчикеToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(204, 26);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.table.Location = new System.Drawing.Point(13, 28);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.Size = new System.Drawing.Size(597, 78);
            this.table.TabIndex = 1;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fill);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudKol);
            this.groupBox1.Location = new System.Drawing.Point(13, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблица";
            // 
            // fill
            // 
            this.fill.Location = new System.Drawing.Point(6, 109);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(265, 30);
            this.fill.TabIndex = 4;
            this.fill.Text = "Заполнить";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "- диапазон";
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(6, 69);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(80, 30);
            this.nudValue.TabIndex = 2;
            this.nudValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudValue.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "- кол-во колонок";
            // 
            // nudKol
            // 
            this.nudKol.Location = new System.Drawing.Point(7, 26);
            this.nudKol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKol.Name = "nudKol";
            this.nudKol.Size = new System.Drawing.Size(80, 30);
            this.nudKol.TabIndex = 0;
            this.nudKol.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudKol.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.rez);
            this.groupBox2.Location = new System.Drawing.Point(296, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Решение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Произведение чисел";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 30);
            this.textBox1.TabIndex = 1;
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(6, 63);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(138, 26);
            this.rez.TabIndex = 0;
            this.rez.Text = "Расчет";
            this.rez.UseVisualStyleBackColor = true;
            this.rez.Click += new System.EventHandler(this.rez_Click);
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(296, 235);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(144, 30);
            this.crear.TabIndex = 5;
            this.crear.Text = "Очистить";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(465, 235);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(145, 30);
            this.exit.TabIndex = 6;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 365);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Практическая работа 22-1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKol)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudKol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button rez;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заполнитьToolStripMenuItem;
    }
}

