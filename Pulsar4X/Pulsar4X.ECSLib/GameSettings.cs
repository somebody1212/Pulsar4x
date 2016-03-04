﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pulsar4X.ECSLib
{
    public static class GameConstants
    {
        public const int MinimumTimestep = 5;

        /// <summary>
        /// Scientific Constants
        /// </summary>
        public static class Science
        {
            // Gravitation Constant
            public const double GravitationalConstant = 6.67384E-11;
        }

        /// <summary>
        /// Constants dealing with units and measurements
        /// </summary>
        public static class Units
        {
            public const double SolarMassInKG = 1.98855E30;

            public const double EarthMassInKG = 5.97219E24;

            public const double SolMassInEarthMasses = 332946;

            public const double KmPerLightYear = 9460730472580.8;

            public const double AuPerLightYear = KmPerLightYear / KmPerAu;

            public const double KmPerAu = MetersPerAu / 1000;

            public const double MetersPerAu = 149597870700;  // this is exact, see: http://en.wikipedia.org/wiki/Astronomical_unit

            /// <summary>
            /// Plus or Minus 65Km
            /// </summary>
            public const double SolarRadiusInKm = 696342.0;

            public const double SolarRadiusInAu = SolarRadiusInKm / KmPerAu;

            /// <summary>
            /// Earth's gravity in m/s^2. Aka 1g.
            /// </summary>
            public const double EarthGravity = 9.81;

            /// <summary>
            /// Note that this is = to 1 ATM.
            /// </summary>
            public const double EarthAtmosphereInKpa = 101.325;

            /// <summary>
            /// Add to Kelvin to get degrees c.
            /// </summary>
            public const double DegreesCToKelvin = 273.15;

            /// <summary>
            /// Add to degrees c to get kelvin.
            /// </summary>
            public const double KelvinToDegreesC = -273.15;
        }
    }

    public class GameSettings
    {
        #region General Game Settings

        public string GameName { get; set; } = "New Game";

        public int MaxSystems { get; set; } = 1000;

        public DateTime StartDateTime { get; set; } = DateTime.Parse("2050-01-01T00:00:00");

        [JsonIgnore]
        public string SMPassword { get; set; } = "";

        [JsonIgnore]
        public IEnumerable<string> DataSets { get; set; } = new List<string>(); 

        public VersionInfo Version => VersionInfo.PulsarVersionInfo;

        #endregion

        #region Game Processing Settings

        public TimeSpan OrbitCycleTime { get; set; } = TimeSpan.FromHours(1);

        public TimeSpan ConstructionCycleTime { get; set; } = TimeSpan.FromDays(1);

        public bool? EnableMultiThreading { get; set; } = true;

        #endregion

        public bool? OrbitalMotionForPlanets { get; set; } = true;

        public bool? OrbitalMotionForAsteroids { get; set; } = true;

        public bool? AllJumpPointsStabilized { get; set; } = false;
    }
}
