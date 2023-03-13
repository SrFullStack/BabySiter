using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{



    public class TimeService : ITimeService
    {
        private readonly ITimeRepository _ITimeRepository;
        public TimeService(ITimeRepository ITimeRepository)
        {
            _ITimeRepository = ITimeRepository;
        }

        async public Task<Time[]> Get(int BabysiterId)
        {
            {

                return await _ITimeRepository.Get(BabysiterId);


            }
        }
        public async Task<Time> Insert(Time time)
        {
            Time restime = await _ITimeRepository.Insert(time);
            if (restime != null)
            {
                return restime;
            }
            return null;
        }
        public void put(int id, Time time)
        {
            _ITimeRepository.put(id, time);


        }
    }
}

