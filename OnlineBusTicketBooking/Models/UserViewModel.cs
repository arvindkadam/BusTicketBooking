using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBusTicketBooking.Models
{
    public class UserViewModel
    {
        public int ID { get; set; }
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> USER_TYPE_ID { get; set; }
        public Nullable<int> USER_ADDRESS_ID { get; set; }


    }
}