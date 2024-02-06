using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    public class SearchResultModel
    {
        public struct TourPartial
        {
            public int ct;
            public DateTime dt;
            public int id;
            public int mf;
            public int ml;
            public int nm;
            public int nt;
            public int ntf;
            public int op;
            public int pl;
            public int pr;
            public int prclean;
            public int prfuel;
            public int prue;
            public int reg;
            public int rm;
        }

        public struct Data
        {
            public struct Block
            {
                public struct Hotel
                {
                    public int id;
                    public int price;
                    public List<TourPartial> tour;
                }

                public int id;
                public int minprice;
                public int _operator;
                public Hotel hotel;
            }

            public struct Decode
            {
                public struct Cityto
                {
                    public struct Coord
                    {
                        public int lat;
                        public int lng;
                    }

                    public string areaname;
                    public Coord coord;
                    public string name;
                    public List<int> regions;
                    public int tempair;
                    public int tempwater;
                }

                public struct Hotels
                {
                    public struct Detail
                    {
                        public int desc;
                        public int foto;
                        public int reviews;
                    }

                    public int actype;
                    public string country;
                    public int countrycode;
                    public string desc;
                    public Detail detail;
                    public int details;
                    public int lat;
                    public int lng;
                    public string name;
                    public string pic;
                    public int pict;
                    public int pop;
                    public int rating;
                    public string region;
                    public int regioncode;
                    public int reviews;
                    public Dictionary<int, int> roominfo;
                    public int seadistance;
                    public string services;
                    public int stars;
                    public string subregion;
                    public int subregioncode;
                    public string types;
                }

                public struct Meal
                {
                    public string name;
                    public string nameshort;
                    public int ourid;
                }

                public struct Place
                {
                    public int adults;
                    public int child;
                    public string name;
                }

                public Dictionary<int, Cityto> cityto;
                public Dictionary<int, Hotels> hotels;
                public Dictionary<int, Meal> meal;
                public Dictionary<int, Place> place;
                public Dictionary<int, string> rooms;
                public Dictionary<int, string> tourname;
            }

            public struct Operators
            {
                public int id;
                public int minprice;
                public string name;
                public int status;
            }

            public struct Status
            {
                public int finished;
                public int progress;
                public int requestid;
            }

            public Block block;
            public Decode decode;
            public Operators operators;
            public Status status;
        }

        public Data data;
        public dynamic? debug;
    }
}
