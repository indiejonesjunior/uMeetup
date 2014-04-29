using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuminousAcuity.Meetup.Infrastructure
{
    public interface IMeetUpVenueRepository<T> where T : class
    {
        T Get (int id);
    }
}
