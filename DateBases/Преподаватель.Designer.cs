namespace DateBases
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.преподавательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.костюк_Дмитрий_2Ж_06_12DataSet = new DateBases.Костюк_Дмитрий_2Ж_06_12DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.преподавательTableAdapter = new DateBases.Костюк_Дмитрий_2Ж_06_12DataSetTableAdapters.ПреподавательTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.преподавательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.костюк_Дмитрий_2Ж_06_12DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.преподавательBindingSource, "Кафедра", true));
            this.textBox2.Location = new System.Drawing.Point(320, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 20);
            this.textBox2.TabIndex = 19;
            // 
            // преподавательBindingSource
            // 
            this.преподавательBindingSource.DataMember = "Преподаватель";
            this.преподавательBindingSource.DataSource = this.костюк_Дмитрий_2Ж_06_12DataSet;
            // 
            // костюк_Дмитрий_2Ж_06_12DataSet
            // 
            this.костюк_Дмитрий_2Ж_06_12DataSet.DataSetName = "Костюк_Дмитрий_2Ж_06_12DataSet";
            this.костюк_Дмитрий_2Ж_06_12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(156, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Кафедра";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.преподавательBindingSource, "ФИО", true));
            this.textBox1.Location = new System.Drawing.Point(320, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "ФИО";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.преподавательBindingSource, "Электронная почта", true));
            this.textBox3.Location = new System.Drawing.Point(320, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 20);
            this.textBox3.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(156, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Электронный адрес";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.преподавательBindingSource, "Контактный телефон", true));
            this.textBox4.Location = new System.Drawing.Point(320, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(235, 20);
            this.textBox4.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(156, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Номер телефона";
            // 
            // преподавательTableAdapter
            // 
            this.преподавательTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 22);
            this.button2.TabIndex = 25;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 24;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Преподаватель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 320);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Преподаватель";
            this.Text = "Преподаватель";
            this.Load += new System.EventHandler(this.Преподаватель_Load);
            ((System.ComponentModel.ISupportInitialize)(this.преподавательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.костюк_Дмитрий_2Ж_06_12DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private Костюк_Дмитрий_2Ж_06_12DataSet костюк_Дмитрий_2Ж_06_12DataSet;
        private System.Windows.Forms.BindingSource преподавательBindingSource;
        private Костюк_Дмитрий_2Ж_06_12DataSetTableAdapters.ПреподавательTableAdapter преподавательTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}