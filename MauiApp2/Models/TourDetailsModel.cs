using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    public class TourDetailsModel
    {
        public struct Data
        {
            public struct Client
            {
                public int cart;
                public int customer_address_enabled;
                public int customer_passport_enabled;
                public int detailed;
                public int fueldisable;
                public int myltioffice;
                public int online;
                public int recommend;
                public int russianpassport;
                public int showrequest;
                public int showrequestoffice;
            }

            public struct Hotel
            {
                public struct Detail
                {
                    public string beach;
                    public string build;
                    public string child;
                    public string inroom;
                    public string meallist;
                    public string mealtypes;
                    public string phone;
                    public string placement;
                    public string repair;
                    public string roomtypes;
                    public string servicefree;
                    public string servicepay;
                    public string services;
                    public string site;
                    public string territory;
                    public string video_link;
                }

                public struct Images
                {
                    public string big;
                    public string height;
                    public int isvertical;
                    public int isverybig;
                    public string preview;
                    public string width;
                }

                public struct Reviews
                {
                    public string content;
                    public string dateadd;
                    public string minus;
                    public string name;
                    public string plus;
                    public string rating;
                    public string rating_food;
                    public string rating_placement;
                    public string rating_service;
                    public string timeadd;
                    public string traveltime;
                }

                public struct Types
                {
                    public int active;
                    public int beach;
                    public int city;
                    public int deluxe;
                    public int family;
                    public int health;
                    public int relax;
                }

                public int coord1;
                public int coord2;
                public int countrycode;
                public string countryname;
                public Detail detail;
                public int hotelactype;
                public string hotelactypename;
                public int hotelcode;
                public string hoteldescription;
                public string hotelname;
                public string hotelpicturemedium;
                public string hotelpictureshort;
                public string hotelpicturesmall;
                public int hotelregioncode;
                public string hotelregionname;
                public int hotelstars;
                public List<Images> images;
                public int rating;
                public List<Reviews> reviews;
                public int reviewscount;
                public Types types;
            }

            public struct Result
            {
                public struct Cleanprice
                {
                    public string currency;
                    public int value;
                }

                public struct _Condition
                {
                    public int isInsurance;
                    public int isTransfer;
                }

                public struct Flights
                {
                    public struct DefaultSet
                    {
                        public struct Forward
                        {
                            public struct Port
                            {
                                public string id;
                                public string name;
                                public string shortName;
                                public string timeZone;
                            }

                            public struct Arrival
                            {
                                public string date;
                                public Port port;
                                public string time;
                            }

                            public struct Company
                            {
                                public string id;
                                public string logo;
                                public string name;
                                public string thumb;
                            }

                            public struct Departure
                            {
                                public string date;
                                public Port port;
                                public string time;
                            }

                            public Arrival arrival;
                            public int baggage;
                            public int carryOn;
                            public Company company;
                            public Departure departure;
                            public dynamic fuelCharges;
                            public bool noPlaces;
                            public string number;
                            public bool onDemand;
                            public string plane;
                        }

                        public struct ForwardDate
                        {
                            public int d;
                            public string day;
                            public string formed;
                            public int m;
                            public string month;
                            public bool valid;
                            public int y;
                        }

                        public struct FuelCharge
                        {
                            public string currency;
                            public bool perPerson;
                            public int value;
                        }

                        public struct Price
                        {
                            public string currency;
                            public int value;
                        }

                        public struct ReverseDate
                        {
                            public int d;
                            public string day;
                            public string formed;
                            public int m;
                            public string month;
                            public bool valid;
                            public int y;
                        }

                        public struct Reverse
                        {
                            public struct Port
                            {
                                public string id;
                                public string name;
                                public string shortName;
                                public string timeZone;
                            }

                            public struct Arrival
                            {
                                public string date;
                                public Port port;
                                public string time;
                            }

                            public struct Company
                            {
                                public string id;
                                public string logo;
                                public string name;
                                public string thumb;
                            }

                            public struct Departure
                            {
                                public string date;
                                public Port port;
                                public string time;
                            }

                            public Arrival arrival;
                            public int baggage;
                            public int carryOn;
                            public Company company;
                            public Departure departure;
                            public dynamic fuelCharges;
                            public bool noPlaces;
                            public string number;
                            public bool onDemand;
                            public string plane;
                        }

                        public dynamic additional;
                        public int flightDurationForward;
                        public int flightDurationReverse;
                        public List<Forward> forward;
                        public ForwardDate forwardDate;
                        public FuelCharge fuelCharge;
                        public bool isDefault;
                        public bool isDummy;
                        public Price price;
                        public dynamic regularCharge;
                        public ReverseDate reverseDate;
                        public List<Reverse> reverse;
                    }

                    public DefaultSet defaultSet;
                    public bool extraQuery;
                    public List<dynamic> extraSet;
                }

                public string agencyLink;
                public Cleanprice cleanprice;
                public _Condition condition;
                public List<string> contents;
                public bool contentsauto;
                public string engine;
                public Flights flights;
            }

            public struct Tour
            {
                public int adults;
                public int child;
                public int city_to;
                public int cleanprice;
                public int countrycode;
                public string countryname;
                public string currency;
                public int curue;
                public int departurecode;
                public string departurename;
                public string departurenamefrom;
                public string flydate;
                public int fuelcharge;
                public string fueldesclink;
                public int hotelactype;
                public string hotelactypename;
                public int hotelcode;
                public string hotelname;
                public string hotelpicturemedium;
                public string hotelpicturesmall;
                public int hotelplace;
                public int hotelregioncode;
                public string hotelregioname;
                public int hotelstars;
                public int infantaddrub;
                public string meal;
                public int mealcode;
                public int nights;
                public int nightsinflight;
                public int operatorcode;
                public string operatorlogo;
                public string operatorname;
                public int originalcurrency;
                public int originalprice;
                public string placement;
                public int price;
                public int regular;
                public string room;
                public int roomcode;
                public int roominfocode;
                public dynamic share;
                public int shortid;
                public int tourid;
                public string tourname;
                public string tornamecode;
                public int visacharge;
            }

            public Client client;
            public bool error;
            public bool fromcache;
            public Hotel hotel;
            public Result result;
            public Tour tour;
        }

        public Data data;
    }
}
