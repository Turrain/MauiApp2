using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2
{
    public class GlobalPrefs
    {
        public delegate void hasThemeChanged(bool value);
        public hasThemeChanged themeChanged;
        public bool _isDarkMode = true;
		public bool isDarkMode {  get { return _isDarkMode; } set { _isDarkMode = value; themeChanged?.Invoke(_isDarkMode); } }
        private PrefStorage storage;
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
                if(value != _tourpacks)
                {
                    _tourpacks = value;
                    storage.Set("tourpacks", _tourpacks);
                }
            }
        }
       
    }
}
