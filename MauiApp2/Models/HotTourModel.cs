using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    public class HotTourModel
    {
        public struct Hot
        {
            public int price;
            public int priceold;
            public string tourid;
            public string tourid2;
            public string countryname;
            public  string  departure;
            public string departurefrom;
            public  string  hotelcode;
            public  string  hotelname;
            public int hotelstars;
            public int hotelregioncode;
            public string hotelregionname;
            public  int     hotelactype;
            public string hotelactypename;
            public string hotelpicture;
            public string flydate;
            public int nights;
            public string meal;
            public string currency;
        }
        public struct Departure
        {
            public int id;
            public string name;
            public string namefrom;
            public string national;
        }
        public struct DepSibling
        {
            public int id;
            public List<int> departures;
        }
        public struct Country
        {
            public int id;
            public string name;
            public int popular;
            public int? directfly;
        }
        public int hotcount;
        public List<Hot> hot;
        public List<Departure> departures;

        public List<Country> countries;
        public List<int> popcountries;
        public int usenational;
        public int country;
    }
}
