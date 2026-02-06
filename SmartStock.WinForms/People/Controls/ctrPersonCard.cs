using SmartStock.BusinessLayer;
using SmartStock.WinForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.WinForms.People.Controls
{
    public partial class ctrPersonCard : UserControl
    {
        public ctrPersonCard()
        {
            InitializeComponent();
        }

       public void Reset()
        {
            txtFullName.Text = "????";
            txtDateOfBirth.Text = "????";
            txtEmail.Text = "????";
            txtGender.Text = "????";
            txtPhone.Text = "????";
            txtCountry.Text = "????";
            picPersonImage.Image = Resources.Male_512;
            labelWarningMessage.Visible = true;
        }

        public void LoadPersonInfo(int PersonID)
        {
            ClsPerson Person = ClsPerson.FindPersonByID(PersonID);
            if(Person != null )
            {
                txtFullName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
                txtDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
                txtEmail.Text = Person.Email;
                txtGender.Text = (Person.Gender == 0) ? "Male" : "Female";
                txtPhone.Text = Person.Phone;
                txtCountry.Text = Person.CountryInfo.CountryName;
            }
            else
            {
                MessageBox.Show($" لم يتم العثور على شخص برقم {PersonID}","No Result Found",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Reset();
                return;
            }
        }
    }
}
