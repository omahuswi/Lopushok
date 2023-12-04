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
            this.pMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pMain = new System.Windows.Forms.Panel();
            this.lblPageNum = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.pSort = new System.Windows.Forms.Panel();
            this.cmbFiltr = new System.Windows.Forms.ComboBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.pInfo = new System.Windows.Forms.Panel();
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.pMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.pSort.SuspendLayout();
            this.pInfo.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.pButtons);
            this.pMenu.Controls.Add(this.pInfo);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pMenu.Location = new System.Drawing.Point(897, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(333, 578);
            this.pMenu.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 578);
            this.panel1.TabIndex = 5;
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.pSort);
            this.pMain.Controls.Add(this.lblPageNum);
            this.pMain.Controls.Add(this.btnNext);
            this.pMain.Controls.Add(this.btnPrevious);
            this.pMain.Controls.Add(this.dgProducts);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(897, 578);
            this.pMain.TabIndex = 6;
            // 
            // lblPageNum
            // 
            this.lblPageNum.AutoSize = true;
            this.lblPageNum.Location = new System.Drawing.Point(413, 546);
            this.lblPageNum.Name = "lblPageNum";
            this.lblPageNum.Size = new System.Drawing.Size(44, 16);
            this.lblPageNum.TabIndex = 3;
            this.lblPageNum.Text = "label1";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(461, 543);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(387, 543);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(23, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // dgProducts
            // 
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(26, 77);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.RowHeadersWidth = 51;
            this.dgProducts.RowTemplate.Height = 24;
            this.dgProducts.Size = new System.Drawing.Size(846, 443);
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
            this.pSort.Size = new System.Drawing.Size(897, 71);
            this.pSort.TabIndex = 4;
            // 
            // cmbFiltr
            // 
            this.cmbFiltr.FormattingEnabled = true;
            this.cmbFiltr.Location = new System.Drawing.Point(632, 24);
            this.cmbFiltr.Name = "cmbFiltr";
            this.cmbFiltr.Size = new System.Drawing.Size(231, 24);
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
            this.cmbSort.Location = new System.Drawing.Point(365, 24);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(231, 24);
            this.cmbSort.TabIndex = 1;
            this.cmbSort.Text = "Сортировка";
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(37, 26);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(280, 22);
            this.tbFind.TabIndex = 0;
            this.tbFind.Text = "Введите для поиска";
            // 
            // pInfo
            // 
            this.pInfo.Controls.Add(this.rtbInfo);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfo.Location = new System.Drawing.Point(0, 0);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(333, 578);
            this.pInfo.TabIndex = 0;
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.btnUpdateProduct);
            this.pButtons.Controls.Add(this.btnDeleteProduct);
            this.pButtons.Controls.Add(this.btnAddProduct);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.Location = new System.Drawing.Point(0, 446);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(333, 132);
            this.pButtons.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(25, 31);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(113, 23);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Добавить";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(194, 31);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "Удалить";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(25, 82);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(282, 23);
            this.btnUpdateProduct.TabIndex = 2;
            this.btnUpdateProduct.Text = "Редактировать";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(25, 61);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(282, 310);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pMenu);
            this.Name = "MainForm";
            this.Text = "Лопушок";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.pSort.ResumeLayout(false);
            this.pSort.PerformLayout();
            this.pInfo.ResumeLayout(false);
            this.pButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pSort;
        private System.Windows.Forms.ComboBox cmbFiltr;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label lblPageNum;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.DataGridView dgProducts;
    }
}

