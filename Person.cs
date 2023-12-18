using System;
using System.Collections.Generic;
using System.Text;

namespace mid_term
{
    //Details of Person
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string AirplaneModel { get; set; }
        public string AppointmentTime { get; set; }
        public List<int> TotalService { get; set; }

        //
        public Person(string firstName, string lastName, string email, string airmodel, string aTime, List<int> service)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = email;
            this.AirplaneModel = airmodel;
            this.AppointmentTime = aTime;
            this.TotalService = service;
        }
        public Person()
        {

        }
    }
}
