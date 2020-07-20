namespace WindowsFormsApp4
{
    partial class Form_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.типБанкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаДенежныхАктивовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вБанкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вКассеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вТалонахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаНеденежныхАктивовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.большиеАктивыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.небольшиеАктивыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типБанкToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1330, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // типБанкToolStripMenuItem
            // 
            this.типБанкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаДенежныхАктивовToolStripMenuItem,
            this.таблицаНеденежныхАктивовToolStripMenuItem});
            this.типБанкToolStripMenuItem.Name = "типБанкToolStripMenuItem";
            this.типБанкToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.типБанкToolStripMenuItem.Text = "Таблицы активов";
            // 
            // таблицаДенежныхАктивовToolStripMenuItem
            // 
            this.таблицаДенежныхАктивовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вБанкеToolStripMenuItem,
            this.вКассеToolStripMenuItem,
            this.вТалонахToolStripMenuItem});
            this.таблицаДенежныхАктивовToolStripMenuItem.Name = "таблицаДенежныхАктивовToolStripMenuItem";
            this.таблицаДенежныхАктивовToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.таблицаДенежныхАктивовToolStripMenuItem.Text = "Таблица денежных активов";
            // 
            // вБанкеToolStripMenuItem
            // 
            this.вБанкеToolStripMenuItem.Name = "вБанкеToolStripMenuItem";
            this.вБанкеToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.вБанкеToolStripMenuItem.Text = "В банке";
            this.вБанкеToolStripMenuItem.Click += new System.EventHandler(this.вБанкеToolStripMenuItem_Click);
            // 
            // вКассеToolStripMenuItem
            // 
            this.вКассеToolStripMenuItem.Name = "вКассеToolStripMenuItem";
            this.вКассеToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.вКассеToolStripMenuItem.Text = "В кассе";
            this.вКассеToolStripMenuItem.Click += new System.EventHandler(this.вКассеToolStripMenuItem_Click);
            // 
            // вТалонахToolStripMenuItem
            // 
            this.вТалонахToolStripMenuItem.Name = "вТалонахToolStripMenuItem";
            this.вТалонахToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.вТалонахToolStripMenuItem.Text = "В талонах";
            this.вТалонахToolStripMenuItem.Click += new System.EventHandler(this.вТалонахToolStripMenuItem_Click);
            // 
            // таблицаНеденежныхАктивовToolStripMenuItem
            // 
            this.таблицаНеденежныхАктивовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.большиеАктивыToolStripMenuItem,
            this.небольшиеАктивыToolStripMenuItem});
            this.таблицаНеденежныхАктивовToolStripMenuItem.Name = "таблицаНеденежныхАктивовToolStripMenuItem";
            this.таблицаНеденежныхАктивовToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.таблицаНеденежныхАктивовToolStripMenuItem.Text = "Таблица неденежных активов";
            // 
            // большиеАктивыToolStripMenuItem
            // 
            this.большиеАктивыToolStripMenuItem.Name = "большиеАктивыToolStripMenuItem";
            this.большиеАктивыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.большиеАктивыToolStripMenuItem.Text = "Основные фонды";
            this.большиеАктивыToolStripMenuItem.Click += new System.EventHandler(this.большиеАктивыToolStripMenuItem_Click);
            // 
            // небольшиеАктивыToolStripMenuItem
            // 
            this.небольшиеАктивыToolStripMenuItem.Name = "небольшиеАктивыToolStripMenuItem";
            this.небольшиеАктивыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.небольшиеАктивыToolStripMenuItem.Text = "Материалы";
            this.небольшиеАктивыToolStripMenuItem.Click += new System.EventHandler(this.небольшиеАктивыToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 376);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Список активов";
            this.Column2.Name = "Column2";
            this.Column2.Width = 1000;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 501);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(111, 33);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(154, 503);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(111, 31);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(302, 501);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(111, 33);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 588);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "Все активы";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem типБанкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаДенежныхАктивовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вБанкеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вКассеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вТалонахToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ToolStripMenuItem таблицаНеденежныхАктивовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem большиеАктивыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem небольшиеАктивыToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

