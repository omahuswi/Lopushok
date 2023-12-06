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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pInfo = new System.Windows.Forms.Panel();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblPageNum = new System.Windows.Forms.Label();
            this.pSort = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltr = new System.Windows.Forms.ComboBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.pButtons.SuspendLayout();
            this.pInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.Color.White;
            this.pButtons.Controls.Add(this.btnUpdateProduct);
            this.pButtons.Controls.Add(this.btnDeleteProduct);
            this.pButtons.Controls.Add(this.btnAddProduct);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.Location = new System.Drawing.Point(0, 459);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(407, 210);
            this.pButtons.TabIndex = 1;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.btnUpdateProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.btnUpdateProduct.FlatAppearance.BorderSize = 2;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Location = new System.Drawing.Point(21, 78);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(351, 44);
            this.btnUpdateProduct.TabIndex = 2;
            this.btnUpdateProduct.Text = "Редактировать";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.btnDeleteProduct.FlatAppearance.BorderSize = 2;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Location = new System.Drawing.Point(199, 28);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(173, 44);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "Удалить";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 2;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Location = new System.Drawing.Point(21, 28);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(173, 44);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Добавить";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // pInfo
            // 
            this.pInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pInfo.Controls.Add(this.pButtons);
            this.pInfo.Controls.Add(this.rtbInfo);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pInfo.Location = new System.Drawing.Point(933, 0);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(407, 669);
            this.pInfo.TabIndex = 0;
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(67, 55);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(282, 310);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pInfo);
            this.panel1.Controls.Add(this.pMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 669);
            this.panel1.TabIndex = 5;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pMain.Controls.Add(this.panel2);
            this.pMain.Controls.Add(this.pSort);
            this.pMain.Controls.Add(this.dgProducts);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1340, 669);
            this.pMain.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.lblPageNum);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 607);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1340, 62);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(489, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 36);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(365, 13);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(36, 36);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblPageNum
            // 
            this.lblPageNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageNum.AutoSize = true;
            this.lblPageNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPageNum.Location = new System.Drawing.Point(435, 17);
            this.lblPageNum.Name = "lblPageNum";
            this.lblPageNum.Size = new System.Drawing.Size(26, 29);
            this.lblPageNum.TabIndex = 3;
            this.lblPageNum.Text = "1";
            // 
            // pSort
            // 
            this.pSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.pSort.Controls.Add(this.pictureBox1);
            this.pSort.Controls.Add(this.label1);
            this.pSort.Controls.Add(this.cmbFiltr);
            this.pSort.Controls.Add(this.cmbSort);
            this.pSort.Controls.Add(this.tbFind);
            this.pSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSort.Location = new System.Drawing.Point(0, 0);
            this.pSort.Name = "pSort";
            this.pSort.Size = new System.Drawing.Size(1340, 116);
            this.pSort.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(157, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск:";
            // 
            // cmbFiltr
            // 
            this.cmbFiltr.FormattingEnabled = true;
            this.cmbFiltr.Items.AddRange(new object[] {
            "Все типы"});
            this.cmbFiltr.Location = new System.Drawing.Point(553, 76);
            this.cmbFiltr.Name = "cmbFiltr";
            this.cmbFiltr.Size = new System.Drawing.Size(318, 24);
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
            this.cmbSort.Location = new System.Drawing.Point(553, 46);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(318, 24);
            this.cmbSort.TabIndex = 1;
            this.cmbSort.Text = "Сортировка";
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(157, 70);
            this.tbFind.Multiline = true;
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(344, 30);
            this.tbFind.TabIndex = 0;
            this.tbFind.Text = "Введите для поиска";
            // 
            // dgProducts
            // 
            this.dgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(18, 140);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.RowHeadersWidth = 51;
            this.dgProducts.RowTemplate.Height = 24;
            this.dgProducts.Size = new System.Drawing.Size(898, 443);
            this.dgProducts.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 669);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Лопушок";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pButtons.ResumeLayout(false);
            this.pInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pSort.ResumeLayout(false);
            this.pSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

