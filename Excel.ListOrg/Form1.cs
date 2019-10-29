using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Office.Interop.Excel;
using Excel.ListOrg.Model;

namespace Excel.ListOrg
{
    public partial class Form1 : Form
    {
        private List<Organization> _allOrgs;
        private NotifyIcon m_notifyicon;
        private ContextMenu m_menu;

        public Form1()
        {
            InitializeComponent();

            m_notifyicon = new NotifyIcon
            {
                Text = "Hello my friend!",
                Visible = true,
                Icon = new System.Drawing.Icon(GetType(), "Icon.ico")
            };
            m_menu = new ContextMenu();
            m_menu.MenuItems.Add(0,
                new System.Windows.Forms.MenuItem("Show", new System.EventHandler(Show_Click)));
            m_menu.MenuItems.Add(1,
                new System.Windows.Forms.MenuItem("Hide", new System.EventHandler(Hide_Click)));
            m_menu.MenuItems.Add(2,
                new System.Windows.Forms.MenuItem("Exit", new System.EventHandler(Exit_Click)));
            m_notifyicon.ContextMenu = m_menu;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkRed;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.LightGoldenrodYellow;

            string ExcelPath = ConfigurationManager.AppSettings["excelDefaultPath"];
            string ExcelTab = ConfigurationManager.AppSettings["excelDefaultTab"];
            openFileExcel.FileName = ExcelPath;
            ExcelRootLink.Text = ExcelPath;

            reloadExcelData(ExcelPath, ExcelTab);
        }

        private void reloadExcelData(string ExcelPath, string ExcelTab)
        {
            if (System.IO.File.Exists(ExcelPath))
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    Workbook excelWorkbook = excelApp.Workbooks.Open(System.IO.Path.GetFullPath(ExcelPath), ReadOnly: true);
                    Worksheet excelWorksheet = (Worksheet)excelWorkbook.Sheets[ExcelTab];
                    Range orgData = excelWorksheet.UsedRange;

                    reloadAppGridData(orgData);

                    excelWorkbook.Close();
                    excelApp.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Excel App:\n" + ex.Message);
                }
            }
            else ExcelRootLink.Text = "Error finding file!";
        }

        private void reloadAppGridData(Range data)
        {
            try
            {
                dataGridView1.DataSource = null;

                getOrgList(data);
                FilterData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Excel file:\n" + ex.Message);
            }
        }

        private void getOrgList(Range excelRange)
        {
            _allOrgs = new List<Organization>();

            var rangeData = excelRange.Value;
            for (int i = 2; i <= excelRange.Rows.Count; i++)
            {
                _allOrgs.Add(new Organization()
                {
                    OrgName = TxtRight("0000" + rangeData[i, 1].ToString(), 4),
                    Description = rangeData[i, 2].ToString(),
                    Status = rangeData[i, 3].ToString(),
                    Environment = rangeData[i, 4].ToString()
                });
            }
        }

        private void TextVKORG_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void TextDescription_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void TextEnv_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void CheckActive_CheckedChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            var displayData = (from d in _allOrgs
                               where (d.Description.ToLower().Contains(TextDescription.Text.ToLower()) || TextDescription.Text == "") &&
                                     (d.OrgName.ToLower().Contains(TextORG.Text.ToLower()) || TextORG.Text == "") &&
                                     (d.Environment.ToLower().Contains(TextEnv.Text.ToLower()) || TextEnv.Text == "") &&
                                     (d.Status == "Active" || CheckActive.Checked != true)
                               orderby d.Environment, d.OrgName
                               select d).ToList<Organization>();

            dataGridView1.DataSource = displayData;
            dataGridView1.Update();
        }

        private string TxtRight(string text, int n)
        {
            return text.Substring(text.Length - n);
        }

        private void ExcelRootLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileExcel.ShowDialog();
            string ExcelPath = openFileExcel.FileName;
            string ExcelTab = ConfigurationManager.AppSettings["excelDefaultTab"];
            ExcelRootLink.Text = ExcelPath;

            reloadExcelData(ExcelPath, ExcelTab);
        }
    }
}
