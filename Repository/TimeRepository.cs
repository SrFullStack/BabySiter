using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TimeRepository: ITimeRepository
    {
        private readonly DB_BABYSITERContext _DB_BABYSITERContext;
        public TimeRepository(DB_BABYSITERContext DB_BABYSITERContext)
        {
            _DB_BABYSITERContext = DB_BABYSITERContext;
        }
        async public Task<Time> Get(int BabysiterId)
        {
            var userQuery = (from Time in _DB_BABYSITERContext.Times
                             where Time.BabysiterId == BabysiterId 
                             select Time).ToArray<Time>();
            return userQuery.FirstOrDefault();



        }
        public async Task<Time> Insert(Time time)
        {
            await _DB_BABYSITERContext.AddRangeAsync(time);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return time;
        }
        public async Task<Time> put(int id, Time time)
        {
            _DB_BABYSITERContext.Times.Update(time);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return time;
        }
    }
}
