using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{

	class RSVP
	{
		private Event cEvent;
		private Customer cus;
		private int rsvpId;
		private string currentDate;
		private Date eventDate;
		private int maxCus;
		private int maxEvent;
		private int maxRsvp;
		private int numRsvp;
		private int numEvent;
		private int numCus;


		public RSVP(int rsvpId,Customer c, Event e)
		{
			this.rsvpId = rsvpId;
			

			this.numRsvp = 0;
			this.maxCus = 1;
			this.maxEvent = 1;
			this.numCus = 0;
			this.numEvent = 0;
			this.cus = c;
			this.cEvent = e;
			currentDate = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");

		}

		public int getRsvpId()
        {
			return rsvpId;
        }

		public int getMaxRsvp()
		{
			return maxRsvp;
		}

		public int getMaxCus()
		{
			return maxCus;
		}
		public int getMaxEvent()
		{
			return maxEvent;
		}

		public Customer getCus()
        {
			return cus;
        }

		public Event getEvent()
        {
			return cEvent;
        }
		
		public bool addCustomer(Customer c)
        {
            if (numCus >= maxCus) { return false; }
			cus = c;
			numCus++;
			return true;
        }

		public bool addEvent(Event e)
		{
			if (numEvent >= maxEvent) { return false; }
			cEvent = e;
			numEvent++;
			return true;


		}

	}
}
