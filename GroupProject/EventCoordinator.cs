using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public class EventCoordinator

    {

        CustomerManager custMan;

        EventManager eventMan;

        RsvpManager rsvpMan;

        public EventCoordinator(int custIdSeed, int maxCust, int eventIdSeed, int maxEvents, int rsvpIdSeed, int maxRsvp)

        {

            custMan = new CustomerManager(custIdSeed, maxCust);

            eventMan = new EventManager(eventIdSeed, maxEvents);

            rsvpMan = new RsvpManager(rsvpIdSeed, maxRsvp, custMan,eventMan );

        }



        //customer related methods

        public bool addCustomer(string fname, string lname, string phone)

        {
            
                return custMan.addCustomer(fname, lname, phone);
            
           
            

        }



        public string customerList()

        {

            return custMan.getCustomerList();

        }



        public string getCustomerInfoById(int id)

        {

            return custMan.getCustomerInfo(id);

        }

        public bool deleteCustomer(int id)

        {

            return custMan.deleteCustomer(id);

        }



        // Event related methods

        public bool addEvent(string name, string venue, Date eventDate, int maxAttendee)

        {

            return eventMan.addEvent(name, venue, eventDate, maxAttendee);

        }



        public string eventList()

        {

            return eventMan.getEventList();

        }



        public string getEventInfoById(int id)

        {

            return eventMan.getEventInfo(id);

        }


        public bool deleteEvent(int id)

        {

            return eventMan.deleteEvent(id);

        }









        public string getRsvpInfo()
        {
            return rsvpMan.getRsvpList();
        }

        public bool addRsvp( int custId, int eventId)
        {
            return rsvpMan.addRsvp(  custId, eventId);
        }
    }
}
