using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace atmcc.Models
{
    public class ATMComplaint
    {

        private int id;
        [Key]
        public int ID
        {
            get => id;
            set {
                id = value;
            }
        }


        public string ComplaintRef { get; set; }

        public DateTime ComplaintDate {  get; set; }

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        public string CustomerCellphone { get; set; }

        public string CustomerEmail { get; set; }

        public string ATMNumber { get; set; }

        public string ATMLocation { get; set; }

        public bool isComplaint { get; set; }

        public string Reason { get; set; }

        public string Comments { get; set; }

    }
}
