using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LuminousAcuity.Meetup.Infrastructure;
using LuminousAcuity.Meetup.Model;
using LuminousAcuity.Library;

namespace LuminousAcuity.Meetup
{
    public class MeetUpGroupRepository : IMeetUpGroupRepository<Group>
    {
        #region fields
        private string _serviceUrl;
        private Group _group;

        #endregion

        public MeetUpGroupRepository(string serviceUrl)
        {
            _serviceUrl = serviceUrl;
        }

        public Group GetGroup(int id)
        {
            throw new NotImplementedException();
        }

        public Group GetGroup(string groupurl)
        {
            _group = null;

            WebRequestHelper requestHelper = new WebRequestHelper(_serviceUrl + groupurl);
            ConfigHelper configHelper = new ConfigHelper("/");
            //push response to stream then string
            IOHelper ioHelper = new IOHelper();

            string json = ioHelper.StreamToString(requestHelper.GetResponseAsStream());

            JsonHelper jsonHelper = new JsonHelper(json);
            _group = jsonHelper.GetJsonObject<Group>(configHelper.GetConfigSetting("JsonRoot"));

            return _group;
        }

        public IEnumerable<Group> GetForCity(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
           
        }
    }
}