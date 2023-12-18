using System;
using System.Collections.Generic;

namespace mid_term
{

    class AppointmentList:Person
    {
        public int SelectedPerson { get; set; }
        public int SelectedService { get; set; }
        public List<Person> ListedPerson = new List<Person>();
    }

    class Program
    {
        static void Main(string[] args)
        {
            int selectoption = 0;
            bool IsSlotAvailable = true;
            List<Person> person1 = new List<Person>();
            AppointmentList appointmentList = new AppointmentList();
            int j = 0;
            int s = 5;
            int selectSer;

            //this is services
            List<int> tService1, tService2, tService3;

            tService1 = new List<int>();
            tService2 = new List<int>();
            tService3 = new List<int>();

            //3 hardcore data
            person1.Add(new Person("Tasvir", "Rupareliya", "trupareliya@conestogac.on.ca","air123", "08:00", tService1));
            person1.Add(new Person("Keyur", "Moradiya", "kmoradiya@gmail.com", "air445", "09:00", tService2));
            person1.Add(new Person("Jaydip", "Koladiya", "jkoladiya@gmail.com", "air378", "10:00", tService3));

            appointmentList.ListedPerson.Add(person1[0]);
            appointmentList.ListedPerson.Add(person1[1]);
            appointmentList.ListedPerson.Add(person1[2]);

            person1[0].TotalService.Add(1);
            person1[1].TotalService.Add(2);
            person1[2].TotalService.Add(3);

            for (; ; )
            {
                Console.WriteLine("\n---------Welcome to Airplane Mechanic---------");
                Console.WriteLine("1. List all appointments");
                Console.WriteLine("2. Create an Appointment");
                Console.WriteLine("3. Reset Schedule");
                Console.WriteLine("4. Exit ");

                try
                {
                    Console.Write("\nPlease Enter Number::");
                    selectoption = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter valid numbar");
                }

                if(selectoption == 4)
                {
                    break;
                }
                if(selectoption == 1 || selectoption == 2 || selectoption == 3)
                {
                    if (selectoption == 1)
                    {
                        Console.Clear();
                        Calculation ca = new Calculation();

                        if (appointmentList.ListedPerson.Count == 0)
                        {
                            Console.WriteLine("\n\tAppointment are not Booked!");
                        }
                        int k = 1;
                        foreach (var details in appointmentList.ListedPerson)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("\tYour Name Is           : {0}", details.FirstName + " " + details.LastName);
                            Console.WriteLine("\tEmailId                : {0}", details.EmailAddress);

                            switch (k)
                            {
                                case 1:
                                    Console.WriteLine("\tAppointment Time       : 08:00");
                                    break;
                                case 2:
                                    Console.WriteLine("\tAppointment Time       : 09:00");
                                    break;
                                case 3:
                                    Console.WriteLine("\tAppointment Time       : 10:00");
                                    break;
                                case 4:
                                    Console.WriteLine("\tAppointment Time       : 11:00");
                                    break;
                                case 5:
                                    Console.WriteLine("\tAppointment Time       : 12:00");
                                    break;
                                case 6:
                                    Console.WriteLine("\tAppointment Time       : 01:00");
                                    break;
                                case 7:
                                    Console.WriteLine("\tAppointment Time       : 02:00");
                                    break;
                                case 8:
                                    Console.WriteLine("\tAppointment Time       : 03:00");
                                    break;
                            }

                            Console.WriteLine("\tYour Total Services Is : {0}", details.TotalService.Count);
                            double TotalExpence = 0;
                            for (int i = 1; i <= details.TotalService.Count; i++)
                            {
                                Console.Write("\t{0}.", i);
                                switch (details.TotalService[i - 1])
                                {
                                    case 1:
                                        Console.WriteLine("Services is          : Refuel");
                                        TotalExpence += 1232.29;
                                        break;
                                    case 2:
                                        Console.WriteLine("Services is          : Engine_Repair");
                                        TotalExpence += 3945.34;
                                        break;
                                    case 3:
                                        Console.WriteLine("Services is          : Deicing");
                                        TotalExpence += 302.32;
                                        break;
                                }
                            }
                            ca.TotalTax(TotalExpence);
                            k++;

                        }
                        Console.WriteLine("Press Key To exit");
                        Console.ReadLine();
                    }
                    else if(selectoption == 2)
                    {

                            if (IsSlotAvailable == false)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tNo Slot Available Right Now!");
                                Console.ReadLine();
                            }
                            else
                            {

                                if (j == 5)
                                {
                                    IsSlotAvailable = false;
                                    Console.WriteLine("There is not slot available right now");

                                }
                                else
                                {
                                    Console.Clear();
                                    if (j != 5 || j != 1)
                                    {
                                        Console.WriteLine("\n\t\t " + s + " Slot Available\n");
                                    }

                                    Console.WriteLine("\t---Book Your Appointment---\n");
                                    Console.WriteLine("\tSelect One Of The Person\n");
                                    int i = 1;
                                    foreach (var details in person1)
                                    {
                                        Console.WriteLine(i + " : {0}", details.FirstName + " " + details.LastName);
                                        i++;
                                        Console.WriteLine("");
                                    }

                                    AppointmentList SelectP = new AppointmentList();
                                    try
                                    {
                                        Console.Write("\nPlease Enter Number::");
                                        SelectP.SelectedPerson = int.Parse(Console.ReadLine());
                                        Console.WriteLine(person1.Count);

                                        if (SelectP.SelectedPerson <= person1.Count && SelectP.SelectedPerson >= 1)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\t\t---Please Select One Of The Following Service----\n");

                                            s--;

                                            for (int k = 1; k <= 3; k++)
                                            {
                                                Console.WriteLine("\t1.Refuel");
                                                Console.WriteLine("\t2.Engine_Repair");
                                                Console.WriteLine("\t3.Deicing");
                                                Console.WriteLine("\t4.Exit");

                                                try
                                                {
                                                    Console.Write("\nPlease Enter Number::");
                                                    selectSer = int.Parse(Console.ReadLine());

                                                    if (selectSer <= 4 && selectSer >= 1)
                                                    {
                                                        if (selectSer == 4)
                                                        {
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            person1[SelectP.SelectedPerson - 1].TotalService.Add(selectSer);

                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Please Enter Valid Number");
                                                    }

                                                }
                                                catch (Exception e)
                                                {
                                                    Console.WriteLine("Please Enter Valid Number" + e.ToString());
                                                }
                                            }

                                            appointmentList.ListedPerson.Add(person1[SelectP.SelectedPerson - 1]);

                                        }
                                        else
                                        {
                                            Console.WriteLine("Please Enter Valid Number");
                                        }


                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Please Enter Valid Number");
                                    }
                                    Console.WriteLine("Press Key To exit");
                                    Console.ReadLine();
                                }
                            }                       
                    }
                    else if (selectoption == 3)
                    {
                        appointmentList.ListedPerson.Clear();
                        Console.Clear();
                        Console.WriteLine("Reset SuccessFull");
                        Console.WriteLine("Press Key To exit");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (selectoption == 4)
                    {
                        break;
                    }
                }

            }
        }
    }
}
