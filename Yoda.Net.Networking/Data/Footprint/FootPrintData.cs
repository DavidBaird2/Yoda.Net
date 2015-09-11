namespace Yoda.Net.Networking.Data.Footprint
{
    using System;
    using System.Collections;

    public class FootPrintData
    {
        public string amebaId;
        public DateTime date;
        public string userCode;
        public string nickname;
        public FootPrintData()
        {
            return;
        }

        public bool friendRequestable { get; set; }

        public string oneMessage { get; set; }

        public bool endGarden { get; set; }

        public bool endRoom { get; set; }
    }
}

