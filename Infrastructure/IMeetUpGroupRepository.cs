using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuminousAcuity.Meetup.Infrastructure
{
    public interface IMeetUpGroupRepository<T> : IDisposable where T: class
    {
        T GetGroup(int id);
        T GetGroup(string groupurl);
        IEnumerable<T> GetForCity(int id);
    }
}
