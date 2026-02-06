using SmartStock.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.BusinessLayer
{
    public class ClsPerson
    {
        public enum enMood { Add = 0, Update = 1 }
        private enMood _Mood = enMood.Add;
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public byte?Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email {  get; set; }
        public string Phone {  get; set; }
        public int CountryID { get; set; }
        public clsCountry CountryInfo;

        public ClsPerson()
        {
            this.PersonID = -1;
            this.Gender = null;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = null;
            this.Email = null;
            this.Phone = string.Empty;
            DateOfBirth = DateTime.MinValue;
            _Mood = enMood.Add;
        }

        public ClsPerson(int PersonID,string FirstName,string SecondName,string ThirdName , string LastName,DateTime DateOfBirth,
             string Email,string Phone,int CountryID,byte?Gender)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.CountryID = CountryID;
            this.CountryInfo = clsCountry.FindCountryByID(CountryID);
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this._Mood = enMood.Update;
        }

        private bool _AddNew()
        {
            this.PersonID = ClsPeopleData.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName,
                 this.LastName, this.DateOfBirth, this.Email, this.Phone, this.CountryID,this.Gender);
            return (this.PersonID != -1);
        }

        private bool _Update()
        {
            return ClsPeopleData.UpDatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                 this.DateOfBirth, this.Email, this.Phone, this.CountryID,Gender);
        }

        public bool Save()
        {
            switch(_Mood)
            {
                case enMood.Add:
                    {
                        if (_AddNew())
                        {
                            _Mood = enMood.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMood.Update:
                    return _Update();
            }
            return false;
        }


        public static ClsPerson FindPersonByID(int PersonID)
        {
            var DtoPeople = ClsPeopleData.FindPersonByID(PersonID);
            if (DtoPeople == null)
                return null;

            return new ClsPerson(DtoPeople.PersonID, DtoPeople.FirstName, DtoPeople.SecondName, DtoPeople.ThirdName
                , DtoPeople.LastName, DtoPeople.DateOfBirth, DtoPeople.Email, DtoPeople.Phone, DtoPeople.CountryID,DtoPeople.Gender);
        }

        public static DataTable GetAllPeople()
        {
            return ClsPeopleData.GetAllpeople();
        }

        public bool Delete()
        {
            return ClsPeopleData.Delete(this.PersonID);
        }

        public bool IsExist()
        {
            return ClsPeopleData.IsPersonExist(this.PersonID);
        }
    }
}
