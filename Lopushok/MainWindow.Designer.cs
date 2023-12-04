namespace Lopushok
{
    partial class MainForm
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
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.pSort = new System.Windows.Forms.Panel();
            this.cmbFiltr = new System.Windows.Forms.ComboBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.lblPageNum = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.pSort.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProducts
            // 
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(37, 0);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.RowHeadersWidth = 51;
            this.dgProducts.RowTemplate.Height = 24;
            this.dgProducts.Size = new System.Drawing.Size(1146, 450);
            this.dgProducts.TabIndex = 0;
            // 
            // pSort
            // 
            this.pSort.Controls.Add(this.cmbFiltr);
            this.pSort.Controls.Add(this.cmbSort);
            this.pSort.Controls.Add(this.tbFind);
            this.pSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSort.Location = new System.Drawing.Point(0, 0);
            this.pSort.Name = "pSort";
            this.pSort.Size = new System.Drawing.Size(1230, 71);
            this.pSort.TabIndex = 1;
            // 
            // cmbFiltr
            // 
            this.cmbFiltr.FormattingEnabled = true;
            this.cmbFiltr.Location = new System.Drawing.Point(876, 26);
            this.cmbFiltr.Name = "cmbFiltr";
            this.cmbFiltr.Size = new System.Drawing.Size(307, 24);
            this.cmbFiltr.TabIndex = 2;
            this.cmbFiltr.Text = "Фильтрация";
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Наименование (по возрастанию)",
            "Наименование (по убыванию)",
            "Номер производственного цеха (по возрастанию)",
            "Номер производственного цеха (по убыванию)",
            "Минимальная стоимость для агента (по возрастанию)",
            "Минимальная стоимость для агента (по убыванию)"});
            this.cmbSort.Location = new System.Drawing.Point(440, 26);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(399, 24);
            this.cmbSort.TabIndex = 1;
            this.cmbSort.Text = "Сортировка";
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(37, 26);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(367, 22);
            this.tbFind.TabIndex = 0;
            this.tbFind.Text = "Введите для поиска";
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.lblPageNum);
            this.pMain.Controls.Add(this.btnNext);
            this.pMain.Controls.Add(this.btnPrevious);
            this.pMain.Controls.Add(this.dgProducts);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 71);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1230, 507);
            this.pMain.TabIndex = 2;
            // 
            // lblPageNum
            // 
            this.lblPageNum.AutoSize = true;
            this.lblPageNum.Location = new System.Drawing.Point(1112, 475);
            this.lblPageNum.Name = "lblPageNum";
            this.lblPageNum.Size = new System.Drawing.Size(44, 16);
            this.lblPageNum.TabIndex = 3;
            this.lblPageNum.Text = "label1";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1160, 472);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(1086, 472);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(23, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 578);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pSort);
            this.Name = "MainForm";
            this.Text = "Лопушок";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.pSort.ResumeLayout(false);
            this.pSort.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Panel pSort;
        private System.Windows.Forms.ComboBox cmbFiltr;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lblPageNum;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
    }
}

