using SmartStock.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.WinForms.People
{
    public partial class frmListPeople : Form
    {
        public frmListPeople()
        {
            InitializeComponent();
        }

        private DataTable _dtPeople = new DataTable();

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            _dtPeople = ClsPerson.GetAllPeople();
            dgvPeople.DataSource = _dtPeople;
            labelRecordsResult.Text = dgvPeople.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if(dgvPeople.Rows.Count > 0 )
            {
                dgvPeople.Columns[0].HeaderText = "رقم الشخص ";
                dgvPeople.Columns[0].Width = 100;

                dgvPeople.Columns[1].HeaderText = " ألاسم ألكامل";
                dgvPeople.Columns[1].Width = 300;

                dgvPeople.Columns[2].HeaderText = "تاريخ الميلاد";
                dgvPeople.Columns[2].Width = 250;

                dgvPeople.Columns[3].HeaderText = "ألبريد الالكتروني";
                dgvPeople.Columns[3].Width = 300;

                dgvPeople.Columns[4].HeaderText = "الجوال";
                dgvPeople.Columns[4].Width = 250;

                dgvPeople.Columns[5].HeaderText = "البلد";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "الجنس";
                dgvPeople.Columns[6].Width = 100;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterCoulmn = " ";
            switch(cbFilter.Text)
            {
                case "فارغ":
                    FilterCoulmn = "None";
                    break;

                case "ألاسم الكامل":
                    FilterCoulmn = "FullName";
                    break;

                case "ألبريد الالكتروني":
                    FilterCoulmn = "Email";
                    break;

                case "البلد":
                    FilterCoulmn = "Country";
                    break;

                case "الهاتف":
                    FilterCoulmn = "Phone";
                    break;

                case "رقم الشخص":
                    FilterCoulmn = "PersonID";
                    break;

                default:
                    FilterCoulmn = "None";
                    break;
            }

            if (txtFilter.Text.Trim() == "" || FilterCoulmn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                labelRecordsResult.Text = dgvPeople.Rows.Count.ToString();
                return;
            }

            if(FilterCoulmn == "PersonID")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterCoulmn, txtFilter.Text.Trim());
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterCoulmn, txtFilter.Text.Trim());
            }
            labelRecordsResult.Text = dgvPeople.Rows.Count.ToString();
        }
    }
}
