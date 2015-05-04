using System;
using LuminousAcuity.Meetup.Model;
using LuminousAcuity.Library.Helpers;

namespace LuminousAcuity.Meetup
{
    public partial class uMeetup : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConfigHelper configHelper = new ConfigHelper("/");
            string baseUrl = configHelper.GetConfigSetting("BaseURL");
            if (baseUrl == null)
                return;
            string nearestUrl = null;

            string events = configHelper.GetConfigSetting("Events");
            string openEvents = configHelper.GetConfigSetting("OpenEvents");
            string apiKey = configHelper.GetConfigSetting("MeetUpAPIKey");
            string groupURL = configHelper.GetConfigSetting("ByGroup");
            string groupName = configHelper.GetConfigSetting("MyGroup");
            string groups = configHelper.GetConfigSetting("Groups");

            string jsonService = baseUrl + events + apiKey;

            using (MeetUpEventRepository meetupEvents = new MeetUpEventRepository(jsonService))
            {
                eventRepeater.DataSource = meetupEvents.GetForGroup(groupURL + groupName);
                eventRepeater.DataBind();
            }

            jsonService = baseUrl + groups + apiKey;
            MeetUpGroupRepository meetUpGroups = new MeetUpGroupRepository(jsonService);
            Group group = meetUpGroups.GetGroup(groupURL + groupName);

            //get topics
            string urlkeys = null;
            foreach (Topic t in group.Topics)
            {

                urlkeys += t.urlkey + ",";
            }
            urlkeys = urlkeys.Substring(0, urlkeys.Length - 1);

            //get my nearest events
            jsonService = baseUrl + openEvents + apiKey;
            nearestUrl = "&lat=" + group.Lat + "&lon=" + group.Lon + "&category=" + group.Category.id + "&topic=" + urlkeys + "&page=3";
            using (MeetUpEventRepository meetupEvents = new MeetUpEventRepository(jsonService))
            {
                openEventRepeater.DataSource = meetupEvents.GetMyNearest(nearestUrl);
                openEventRepeater.DataBind();
            }
        }
    }
}