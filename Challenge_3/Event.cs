using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Event
    {
        //properties
        public string eventType { get; set; }
        public int eventNumber { get; set; }
        public DateTime dateEvent { get; set; }
        public int costPer { get; set; }
        public int costTotal { get; set; }

        //constructor
        public Event(string theEventType, int theEventNumber, DateTime theEventDate, int theCostPer)
        {
            eventType = theEventType;
            eventNumber = theEventNumber;
            dateEvent = theEventDate;
            costPer = theCostPer;
            costTotal = theCostPer * theEventNumber;
        }
         
        public Event()
        {
        }

        public override string ToString()
        {
            string stringToReturn = $"{eventType}\n{eventNumber} people\t{dateEvent.ToShortDateString()}\t ${costPer} each \t ${costTotal} Total Cost";
            return stringToReturn;
        }
    }
}