﻿// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace AlcoolGasolina.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string GoogleMapsTokenkey = "";
        private static readonly string GoogleMapsTokensDefault = "";

        private const string GoogleMapsPlacesUrlkey = "";
        private static readonly string GoogleMapsPlacesUrlDefault = "";

        #endregion


        public static string GoogleMapsToken
        {
            get => AppSettings.GetValueOrDefault(GoogleMapsTokenkey, GoogleMapsTokensDefault);
            set => AppSettings.AddOrUpdateValue(GoogleMapsTokenkey, value);
        }

        public static string GoogleMapsPlacesUrl
        {
            get => AppSettings.GetValueOrDefault(GoogleMapsPlacesUrlkey, GoogleMapsPlacesUrlDefault);
            set => AppSettings.AddOrUpdateValue(GoogleMapsPlacesUrlkey, value);
        }

    }
}