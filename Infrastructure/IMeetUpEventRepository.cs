using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuminousAcuity.Meetup.Infrastructure
{
    public interface IMeetUpEventRepository<T> : IDisposable where T :  class 
    {
        T Get(int id);
        IEnumerable<T> GetForGroup(string groupurl);
        IEnumerable<T> GetForMember(int id);
        IEnumerable<T> GetMyNearest(string nearesturl);
    }
}
