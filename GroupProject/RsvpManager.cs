using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
	class RsvpManager
	{
		private int curretnId;
		private int maxRsvp;
		private int numRsvp;
		private RSVP[] rsvpList;
		private Customer c;
		private Event e;
		private CustomerManager custMan;
		private EventManager eventMan;



		public RsvpManager(int idSeed, int max, CustomerManager cMan, EventManager eMan)
		{
			custMan = cMan;
			eventMan = eMan;
			
			this.curretnId = idSeed;
			this.maxRsvp = max;
			this.numRsvp = 0;
			rsvpList = new RSVP[maxRsvp];
			
			
		}

		public bool addRsvp( int cId, int eId)
        {
            if (numRsvp >= maxRsvp) { return false; }
			for (int i = 0; i < numRsvp; i++)
            {
				if(cId == rsvpList[i].getCus().getId())
                {
					if(eId == rsvpList[i].getEvent().getEventId())
                    {
						return false;
                    }
                }
            }
			
			c = custMan.getCustomer(cId);
			e = eventMan.getEvent(eId);
			RSVP r = new RSVP(curretnId,c , e);
			rsvpList[numRsvp] = r;
			numRsvp++;
			curretnId++;
			e.addAttendee(c);
			c.setBookings();
			return true;
        }

		private int findRsvp(int eid)

		{

			for (int i = 0; i < numRsvp; i++)

			{

				if (rsvpList[i].getRsvpId() == eid)

					return i;

			}

			return -1;

		}

		public RSVP getRsvp(int eid)

		{

			int loc = findRsvp(eid);

			if (loc == -1) { return null; }

			return rsvpList[loc];

		}

		public string getRsvpInfo(int eid)

		{

			int loc = findRsvp(eid);

			if (loc == -1) { return "There is no event with id " + eid + "."; }

			return rsvpList[loc].ToString();

		}


		public string getRsvpList()

		{

			string output = "Rsvp List:";

			for (int x = 0; x < numRsvp; x++)

			{

				output = output + "\n" + rsvpList[x].getRsvpId() + "   \t "+rsvpList[x].getCus().getFirstName()+"    \t"+rsvpList[x].getEvent().getEventName() + "    \t" + rsvpList[x].getEvent().getDate();

			}

			return output;

		}
	}
}
