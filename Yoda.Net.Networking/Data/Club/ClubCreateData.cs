namespace Yoda.Net.Networking.Data.Club
{

    using System;
    using Yoda.Net.Networking.Data.Common;


    public class ClubCreateData
    {
        
        private ClubConfigData _config;
        private ClubEmblemData _emblem;

        public ClubCreateData()
        {
            return;
        }
        public ClubCreateData(ClubConfigData config, ClubEmblemData emblem)
        {
            _config = config;
            _emblem = emblem;
            return;
        }
        public ClubConfigData config
        {
            get{
            return _config;}
        }


        public PiggStream binary()
        {
            var stream = new PiggStream();
            _config.writeData(stream);
            _emblem.writeData(stream);
            return stream;
        }

        public ClubEmblemData emblem
        {
            get
            {
                return _emblem;
            }
        }

    }
}

