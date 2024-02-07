using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MauiApp2
{
    public class GlobalPrefs
    {
        public delegate void hasThemeChanged(bool value);
        public hasThemeChanged themeChanged;
        public delegate void DataListsLoadedHandler(Models.DataListsModel data);

        public event DataListsLoadedHandler OnDataListsLoaded;
        public Models.DataListsModel? dataListsModel = null;
        public bool _isDarkMode = true;
        public bool isDarkMode { get { return _isDarkMode; } set { _isDarkMode = value; themeChanged?.Invoke(_isDarkMode); } }
        private PrefStorage storage;
        public Models.DataListsModel? datalists { get; set; } = null;

        
        public delegate void SelectedCountryChangedHandler(int value);
        public event SelectedCountryChangedHandler OnSelectedCountryChanged;
        private int _selectedCountry = 60;
        public int selectedCountry
        {
            get { return _selectedCountry; }
            set
            {
                if (_selectedCountry != value)
                {
                    _selectedCountry = value;
                    OnSelectedCountryChanged?.Invoke(_selectedCountry);
                }
            }
        }
    
        public async Task OnInitAsync()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync("https://tourvisor.ru/xml/listdev.php?type=departure,allcountry,country,region,subregions,operator&cndep=59&flydeparture=59&flycountry=0&format=json&referrer=https://travelstory.kz");
                    response.EnsureSuccessStatusCode();
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var deserializedData = JsonConvert.DeserializeObject<Models.DataListsModel>(System.Web.HttpUtility.HtmlDecode(jsonString));
                    datalists = deserializedData ?? throw new Exception("DataListsModel is null");
                     OnDataListsLoaded?.Invoke(datalists);
                }
            }
            catch (Exception)
            {
                // Handle exception here
            }
        }

        private Dictionary<string, object[]>? _tourpacks = null;
        public Dictionary<string, object[]> tourpacks
        {
            get
            {
                var temp = storage.Get<Dictionary<string, object[]>>("tourpacks");
                if (temp != null)
                {
                    _tourpacks = temp;
                }
                return _tourpacks;
            }
            set
            {
                if (value != _tourpacks)
                {
                    _tourpacks = value;
                    storage.Set("tourpacks", _tourpacks);
                }
            }
        }

    }
}
