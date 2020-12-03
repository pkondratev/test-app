using System;

namespace WpfApp1.Model
{
    public class SettingsModel
    {
        public DateTime RefreshTimeout
        {
            get => DateTime.Parse(Properties.Settings.Default.RefreshTimeout);
            set
            {
                Properties.Settings.Default.RefreshTimeout = value.ToLongTimeString();
                Properties.Settings.Default.Save();
            }
        }
    }
}