namespace DateBases
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСТаблицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаЖурналПосещаемостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаЖурналУспеваемостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаРасписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаСтудентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаПредметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаПреподавательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСПроцедурамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСТаблицамиToolStripMenuItem,
            this.работаСПроцедурамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСТаблицамиToolStripMenuItem
            // 
            this.работаСТаблицамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаЖурналПосещаемостиToolStripMenuItem,
            this.таблицаЖурналУспеваемостиToolStripMenuItem,
            this.таблицаРасписаниеToolStripMenuItem,
            this.таблицаСтудентToolStripMenuItem,
            this.таблицаПредметToolStripMenuItem,
            this.таблицаПреподавательToolStripMenuItem});
            this.работаСТаблицамиToolStripMenuItem.Name = "работаСТаблицамиToolStripMenuItem";
            this.работаСТаблицамиToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.работаСТаблицамиToolStripMenuItem.Text = "Работа с таблицами";
            // 
            // таблицаЖурналПосещаемостиToolStripMenuItem
            // 
            this.таблицаЖурналПосещаемостиToolStripMenuItem.Name = "таблицаЖурналПосещаемостиToolStripMenuItem";
            this.таблицаЖурналПосещаемостиToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.таблицаЖурналПосещаемостиToolStripMenuItem.Text = "Таблица \"Журнал посещаемости\"";
            this.таблицаЖурналПосещаемостиToolStripMenuItem.Click += new System.EventHandler(this.таблицаЖурналПосещаемостиToolStripMenuItem_Click);
            // 
            // таблицаЖурналУспеваемостиToolStripMenuItem
            // 
            this.таблицаЖурналУспеваемостиToolStripMenuItem.Name = "таблицаЖурналУспеваемостиToolStripMenuItem";
            this.таблицаЖурналУспеваемостиToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.таблицаЖурналУспеваемостиToolStripMenuItem.Text = "Таблица \"Журнал успеваемости\"";
            this.таблицаЖурналУспеваемостиToolStripMenuItem.Click += new System.EventHandler(this.таблицаЖурналУспеваемостиToolStripMenuItem_Click);
            // 
            // таблицаРасписаниеToolStripMenuItem
            // 
            this.таблицаРасписаниеToolStripMenuItem.Name = "таблицаРасписаниеToolStripMenuItem";
            this.таблицаРасписаниеToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.таблицаРасписаниеToolStripMenuItem.Text = "Таблица \"Расписание\"";
            this.таблицаРасписаниеToolStripMenuItem.Click += new System.EventHandler(this.таблицаРасписаниеToolStripMenuItem_Click);
            // 
            // таблицаСтудентToolStripMenuItem
            // 
            this.таблицаСтудентToolStripMenuItem.Name = "таблицаСтудентToolStripMenuItem";
            this.таблицаСтудентToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.таблицаСтудентToolStripMenuItem.Text = "Таблица \"Студент\"";
            this.таблицаСтудентToolStripMenuItem.Click += new System.EventHandler(this.таблицаСтудентToolStripMenuItem_Click);
            // 
            // таблицаПредметToolStripMenuItem
            // 
            this.таблицаПредметToolStripMenuItem.Name = "таблицаПредметToolStripMenuItem";
            this.таблицаПредметToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.таблицаПредметToolStripMenuItem.Text = "Таблица \"Предмет\"";
            this.таблицаПредметToolStripMenuItem.Click += new System.EventHandler(this.таблицаПредметToolStripMenuItem_Click);
            // 
            // таблицаПреподавательToolStripMenuItem
            // 
            this.таблицаПреподавательToolStripMenuItem.Name = "таблицаПреподавательToolStripMenuItem";
            this.таблицаПреподавательToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.таблицаПреподавательToolStripMenuItem.Text = "Таблица \"Преподаватель\"";
            this.таблицаПреподавательToolStripMenuItem.Click += new System.EventHandler(this.таблицаПреподавательToolStripMenuItem_Click);
            // 
            // работаСПроцедурамиToolStripMenuItem
            // 
            this.работаСПроцедурамиToolStripMenuItem.Name = "работаСПроцедурамиToolStripMenuItem";
            this.работаСПроцедурамиToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.работаСПроцедурамиToolStripMenuItem.Text = "Работа с процедурами";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(660, 320);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Главная страница";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСТаблицамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаЖурналПосещаемостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаЖурналУспеваемостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаРасписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаСтудентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаПредметToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаПреподавательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСПроцедурамиToolStripMenuItem;
    }
}

