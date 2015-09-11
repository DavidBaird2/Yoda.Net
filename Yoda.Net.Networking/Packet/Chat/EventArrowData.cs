using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Yoda.Net.Networking.Data
{
    public class EventArrowData
    {
        public string swfCode;
        public string eventAreaMessage;
        public string category;
        public string subCategoryCode;
        public double startTime;
        public double endTime;

        public EventArrowData(string swfCode, string eventAreaMessage, string category, string subCategoryCode, double startTime, double endTime)
        {
            // TODO: Complete member initialization
            this.swfCode = swfCode;
            this.eventAreaMessage = eventAreaMessage;
            this.category = category;
            this.subCategoryCode = subCategoryCode;
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }
}
