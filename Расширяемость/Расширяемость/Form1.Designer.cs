
namespace Расширяемость
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
            this.label1 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DESCOBJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LINK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SIZE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ROT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.RUNAME = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DESCPLACE = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.itemsList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.Button();
            this.показатьскрытьЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя (латинские буквы):";
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(147, 25);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(128, 20);
            this.NAME.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Описание объекта:";
            // 
            // DESCOBJ
            // 
            this.DESCOBJ.Location = new System.Drawing.Point(147, 93);
            this.DESCOBJ.Name = "DESCOBJ";
            this.DESCOBJ.Size = new System.Drawing.Size(128, 20);
            this.DESCOBJ.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ссылка на AssetBundle:";
            // 
            // LINK
            // 
            this.LINK.Location = new System.Drawing.Point(147, 151);
            this.LINK.Name = "LINK";
            this.LINK.Size = new System.Drawing.Size(128, 20);
            this.LINK.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Размер (число):";
            // 
            // SIZE
            // 
            this.SIZE.Location = new System.Drawing.Point(147, 189);
            this.SIZE.Name = "SIZE";
            this.SIZE.Size = new System.Drawing.Size(128, 20);
            this.SIZE.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Поворот (число):";
            // 
            // ROT
            // 
            this.ROT.Location = new System.Drawing.Point(147, 229);
            this.ROT.Name = "ROT";
            this.ROT.Size = new System.Drawing.Size(128, 20);
            this.ROT.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "x";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(147, 266);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(128, 20);
            this.X.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "y";
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(147, 301);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(128, 20);
            this.Y.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Название (русское):";
            // 
            // RUNAME
            // 
            this.RUNAME.Location = new System.Drawing.Point(147, 59);
            this.RUNAME.Name = "RUNAME";
            this.RUNAME.Size = new System.Drawing.Size(128, 20);
            this.RUNAME.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Описания места:";
            // 
            // DESCPLACE
            // 
            this.DESCPLACE.Location = new System.Drawing.Point(147, 121);
            this.DESCPLACE.Name = "DESCPLACE";
            this.DESCPLACE.Size = new System.Drawing.Size(128, 20);
            this.DESCPLACE.TabIndex = 1;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Filter = "JSON|*.json";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Записи в файле:";
            // 
            // itemsList
            // 
            this.itemsList.FormattingEnabled = true;
            this.itemsList.Location = new System.Drawing.Point(290, 49);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(200, 277);
            this.itemsList.TabIndex = 5;
            this.itemsList.SelectedIndexChanged += new System.EventHandler(this.itemsList_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.показатьскрытьЗаписиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.очиститьToolStripMenuItem.Text = " Очистить файл";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Location = new System.Drawing.Point(290, 332);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(200, 46);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // показатьскрытьЗаписиToolStripMenuItem
            // 
            this.показатьскрытьЗаписиToolStripMenuItem.Name = "показатьскрытьЗаписиToolStripMenuItem";
            this.показатьскрытьЗаписиToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.показатьскрытьЗаписиToolStripMenuItem.Text = "Показать записи";
            this.показатьскрытьЗаписиToolStripMenuItem.Click += new System.EventHandler(this.показатьскрытьЗаписиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 390);
            this.Controls.Add(this.itemsList);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.ROT);
            this.Controls.Add(this.SIZE);
            this.Controls.Add(this.DESCPLACE);
            this.Controls.Add(this.LINK);
            this.Controls.Add(this.RUNAME);
            this.Controls.Add(this.DESCOBJ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(518, 429);
            this.MinimumSize = new System.Drawing.Size(518, 429);
            this.Name = "Form1";
            this.Text = "Расширяемость";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DESCOBJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LINK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SIZE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ROT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RUNAME;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DESCPLACE;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox itemsList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ToolStripMenuItem показатьскрытьЗаписиToolStripMenuItem;
    }
}

