using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOMS
{
    public class Users
    {
        private String firstName;
        private String lastName;
        private bool isManager;
        private int workingHours;

        public Users(String fname, String lname, bool isManager = false, int whours = 4)
        {
            firstName = fname;
            lastName = lname;
            workingHours = whours;
            this.isManager = isManager;
        }
    }
}
