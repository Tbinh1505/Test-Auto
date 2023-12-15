using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
using _1_DAL.IRepon;
namespace _1_DAL.Repon
{
    public class SeatDetailRepo : ISeatDetailRepo
    {
		BookingAirlineContext _context;
		public SeatDetailRepo()
		{
			_context=new BookingAirlineContext();
		}
        public bool Create(SeatDetail seatDetail)
        {
			try
			{
				_context.SeatDetails.Add(seatDetail);
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
        }

        public SeatDetail get(int id,string code)
        {
            return _context.SeatDetails.Where(c => c.Id == id && c.SeatCode==code).FirstOrDefault();
        }

        public List<SeatDetail> get_list()
        {
			return _context.SeatDetails.ToList();
        }

        public bool Update(SeatDetail seatDetail)
        {
            try
            {
                _context.SeatDetails.Update(seatDetail);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
