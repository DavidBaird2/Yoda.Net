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


        public AmebaStream binary()
        {
            var _loc_1 = new AmebaStream();
            _config.writeData(_loc_1);
            _emblem.writeData(_loc_1);
            return _loc_1;
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

