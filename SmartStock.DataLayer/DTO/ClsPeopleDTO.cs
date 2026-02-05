using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.DataLayer.DTO
{
    public class ClsPeopleDTO
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Email {  get; set; }
        public string Phone { get; set; }
        public int CountryID { get; set; }
        public byte? Gender { get; set; }

    }
}
