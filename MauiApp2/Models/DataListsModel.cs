using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    public class DataListsModel
    {
        public struct Departures
        {
            public struct Departure
            {
                public int id;
                public string name;
                public string namefrom;
                public int national;
            }
            public List<Departure> departure;
        }

        public struct DepSibling
        {
            public List<List<int>> value;
        }

        public struct AllCountry
        {
            public struct Country
            {
                public int id;
                public string name;
                public int popular;
                public int? directfly;
            }
            public List<Country> country;
        }

        public struct Countries
        {
            public struct Country
            {
                public int id;
                public string name;
                public int popular;
                public int popularity;
                public int? directfly;
                public int regular;
                public int opened;
            }

            public List<Country> country;
        }

        public struct Airports
        {
            public struct Airport
            {
                public int id;
                public string name;
                public int country;
                public int regular;
            }

            public List<Airport> airport;
        }

        public struct Regions
        {
            public struct Region
            {
                public int id;
                public string name;
                public int country;
                public int parentid;
                public List<int>? airport;
            }

            public List<Region> region;
        }

        public struct Operators
        {
            public struct Operator
            {
                public int id;
                public string name;
                public string fullname;
                public string russian;
                public int active;
            }

            public List<Operator> _operator;
        }

        public struct Lists
        {
            public Departures departures;
            public DepSibling depsibling;
            public AllCountry allcountry;
            public List<int> popcountries;
            public Countries countries;
            public Airports airports;
            public Regions regions;
            public Operators operators;
        }

        public int departure;
        public Lists lists;
        public int usenational;
        public string currency;
    }
}
