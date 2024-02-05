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

        public Dictionary<string, object[]> tourpacks;
       
    }
}
