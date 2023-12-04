using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lopushok.infrastructure;
using Npgsql;
using PagedList;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lopushok
{
    public partial class MainForm : Form
    {
        // static String ConnString = $"Host=localhost;Port=5432;Username=postgres;Password=151912;Database=lopushok";
        // static String ConnString = $"Host=localhost;Port=5432;Username=postgres;Password=134340;Database=lapushok";
        static String ConnString = $"Host=localhost;Port=5432;Username=postgres;Password=1234567890;Database='lapushok'";
        public static NpgsqlConnection db = new NpgsqlConnection(ConnString); 
        private int _pagesCount = 20;
        private int _currentPageIndex = 1;
        private int _totalPage = 0;


        public String sortColumn;
        public String sortType;

        public int PagesCount { get => _pagesCount; set => _pagesCount = value; }
        public int CurrentPageIndex { get => _currentPageIndex; set => _currentPageIndex = value; }
        public int TotalPage { get => _totalPage; set => _totalPage = value; }

        public enum SortTypes
        { 
            ASC, 
            DESC 
        }

        public enum SortColumns
        {            
            product_name,
            product_min_price,
            product_department
        }

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Получение списка продуктов с определенной страницы
        /// </summary>
        /// <param name="page"> Индекс страницы</param>
        /// <param name="sortColumn">Поле для сортировки</param>
        /// <param name="sortType"></param>
        /// <returns></returns>
        /// 
        
        private DataTable GetCurrentRecords(int page, String sortColumn, String sortType)
        {
            db.Open();
            NpgsqlCommand cmd2 = null;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            if (page == 1)
            {
                cmd2 = new NpgsqlCommand($"Select product_article, product_name, product_min_price from products ORDER BY {sortColumn} {sortType} LIMIT {PagesCount}");
            }
            else
            {
                int PreviousPageOffSet = (page - 1) * PagesCount;

                cmd2 = new NpgsqlCommand($"Select product_article, product_name, product_min_price from products WHERE product_article NOT IN (Select product_article from products ORDER BY {sortColumn} {sortType} LIMIT {PreviousPageOffSet}) ORDER BY {sortColumn} {sortType} LIMIT {PagesCount}");
            }
            try
            {                
                NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(cmd2);                
                cmd2.Connection = db;
                adp1.Fill(ds);
                
            }
            finally { db.Close(); }          
               
            
            return ds.Tables[0];
        }

        /// <summary>
        /// Подсчет количества страниц
        /// </summary>
        private void CalculateTotalPages(String sortColumn, String sortType)
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"Select product_article from products ORDER BY {sortColumn} {sortType}");
            db.Open();
            NpgsqlDataAdapter adp1 = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Connection = db;
            adp1.Fill(ds);
            int rowCount = ds.Tables[0].Rows.Count;
            TotalPage = rowCount / PagesCount;
            // if any row left after calculated pages, add one more page 
            if (rowCount % PagesCount > 0)
                TotalPage += 1;
            db.Close();
        }

        /// <summary>
        /// Загрузка окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1358, 716);
            cmbSort.SelectedIndex = 0;
            //cmbFiltr.SelectedIndex = 0;
            //CalculateTotalPages(sortColumn, sortType);            
            //this.dgProducts.DataSource = GetCurrentRecords(this.CurrentPageIndex, sortColumn, sortType);
            lblPageNum.Text = this.CurrentPageIndex.ToString();          
           
        }

        /// <summary>
        /// Переход на следующую страницу товаров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {            
            if (this.CurrentPageIndex < this.TotalPage)
            {
                this.CurrentPageIndex++;
                this.dgProducts.DataSource = GetCurrentRecords(this.CurrentPageIndex, sortColumn, sortType);
                lblPageNum.Text = this.CurrentPageIndex.ToString();
            }
        }

        /// <summary>
        /// Переход на предыдущую страницу товаров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                this.dgProducts.DataSource = GetCurrentRecords(this.CurrentPageIndex, sortColumn, sortType);
                lblPageNum.Text = this.CurrentPageIndex.ToString(); 
            }
        }

        /// <summary>
        /// Изменение поля для сортировки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPageIndex = 1;

            switch (cmbSort.SelectedIndex)
            {
                case 0:
                    sortColumn = SortColumns.product_name.ToString();
                    sortType = SortTypes.ASC.ToString();
                    break;
                case 1:
                    sortColumn = SortColumns.product_name.ToString();
                    sortType = SortTypes.DESC.ToString();
                    break;
                case 2:
                    sortColumn = SortColumns.product_department.ToString();
                    sortType = SortTypes.ASC.ToString();
                    break;
                case 3:
                    sortColumn = SortColumns.product_department.ToString();
                    sortType = SortTypes.DESC.ToString();
                    break;

                case 4:
                    sortColumn = SortColumns.product_min_price.ToString();
                    sortType = SortTypes.ASC.ToString();
                    break;
                case 5:
                    sortColumn = SortColumns.product_min_price.ToString();
                    sortType = SortTypes.DESC.ToString();
                    break; 
            }
            CalculateTotalPages(sortColumn, sortType);
            this.dgProducts.DataSource = GetCurrentRecords(this.CurrentPageIndex, sortColumn, sortType);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
