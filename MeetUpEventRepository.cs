using LuminousAcuity.Library.Helpers;
using LuminousAcuity.Meetup.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace LuminousAcuity.Meetup.Model
{
    public class MeetUpEventRepository : IMeetUpEventRepository<Event>
    {
        #region fields
        private string _serviceURL;
        private IEnumerable<Event> _meetUpEvents;
        #endregion

        //TO DO
        //look at open events API to search by location
        //

        public MeetUpEventRepository(string serviceURL)
        {
            _serviceURL = serviceURL;


        }

        public Event Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Event> GetForGroup(string groupurl)
        {
            _meetUpEvents = null;

            WebRequestHelper requestHelper = new WebRequestHelper(_serviceURL + groupurl);
            ConfigHelper configHelper = new ConfigHelper("/");
            //push response to stream then string
            IOHelper ioHelper = new IOHelper();

            string json = ioHelper.StreamToString(requestHelper.GetResponseAsStream());

            JsonHelper jsonHelper = new JsonHelper(json);
            _meetUpEvents = jsonHelper.GetJsonAsList<Event>(configHelper.GetConfigSetting("JsonRoot"));

            return _meetUpEvents;

        }

        public IEnumerable<Event> GetForMember(int id)
        {
            throw new NotImplementedException();
        }
        

        public IEnumerable<Event> GetMyNearest(string nearesturl)
        {
            _meetUpEvents = null;

            //TODO
            //Get nearest events with params
            //Tidy up these key values into config
           
            WebRequestHelper requestHelper = new WebRequestHelper(_serviceURL + nearesturl);
            ConfigHelper configHelper = new ConfigHelper("/");
            
            //push response to stream then string
            IOHelper ioHelper = new IOHelper();

            string json = ioHelper.StreamToString(requestHelper.GetResponseAsStream());

            JsonHelper jsonHelper = new JsonHelper(json);
            _meetUpEvents = jsonHelper.GetJsonAsList<Event>(configHelper.GetConfigSetting("JsonRoot"));
                        
            return _meetUpEvents;
        }

        public void Dispose()
        {
           

        }
    }
}