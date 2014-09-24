using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Resources;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quality.Json.Performance.Cases
{
    [Serializable]
    public class WeatherCase : ICase, IResource<WeatherContainer>
    {
        public string Name
        {
            get { return "Weather"; }
        }

        public string Description
        {
            get { return null; }
        }

        public IEnumerable<IRequirement> GetRequirements()
        {
            yield break;
        }

        public IResultData Execute(IProcedure procedure, ISubject subject)
        {
            return procedure.Process(this, subject);
        }

        public string GetText()
        {
            return File.ReadAllText(@"Resources\Weather.json");
        }

        public byte[] GetData()
        {
            return File.ReadAllBytes(@"Resources\Weather.json");
        }

        public int Multiply(int times)
        {
            return times * 50;
        }

        public WeatherContainer GetInstance()
        {
            return new WeatherContainer
            {
                cnt = 3,
                list = new[]
                {
                    new WeatherContainer.City
                    {
                        id = 524901,
                        dt = 1411148535,
                        name = "Moscow",
                        clouds = new WeatherContainer.Clouds { all = 0 },
                        coord = new WeatherContainer.Coordinates { lat = 55.75, lon = 37.619999999999997 },
                        main = new WeatherContainer.Main
                        {
                            humidity = 71,
                            pressure = 1026,
                            temp = 12.869999999999999,
                            temp_max = 15,
                            temp_min = 12
                        },
                        sys = new WeatherContainer.System
                        {
                            country = "RU",
                            id = 7323,
                            message = 0.20119999999999999,
                            sunrise = 1411096190,
                            sunset = 1411140993,
                            type = 1
                        },
                        weather = new[]
                        {
                            new WeatherContainer.Weather
                            {
                                description = "Sky is Clear",
                                icon = "01n",
                                id = 800,
                                main = "Clear"
                            }
                        },
                        wind = new WeatherContainer.Wind
                        {
                            deg = 260,
                            speed = 3
                        }
                    },
                    new WeatherContainer.City
                    {
                        id = 703448,
                        dt = 1411148345,
                        name = "Kiev",
                        clouds = new WeatherContainer.Clouds { all = 0 },
                        coord = new WeatherContainer.Coordinates { lat = 50.43, lon = 30.52 },
                        main = new WeatherContainer.Main
                        {
                            humidity = 57,
                            pressure = 1025,
                            temp = 11,
                            temp_max = 15,
                            temp_min = 7
                        },
                        sys = new WeatherContainer.System
                        {
                            country = "UA",
                            id = 7358,
                            message = 0.040599999999999997,
                            sunrise = 1411098015,
                            sunset = 1411142574,
                            type = 1
                        },
                        weather = new[]
                        {
                            new WeatherContainer.Weather
                            {
                                description = "Sky is Clear",
                                icon = "01n",
                                id = 800,
                                main = "Clear"
                            }
                        },
                        wind = new WeatherContainer.Wind
                        {
                            deg = 0,
                            speed = 1
                        }
                    },
                    new WeatherContainer.City
                    {
                        id = 2643743,
                        dt = 1411148660,
                        name = "London",
                        clouds = new WeatherContainer.Clouds { all = 20 },
                        coord = new WeatherContainer.Coordinates { lat = 51.509999999999998, lon = -0.13 },
                        main = new WeatherContainer.Main
                        {
                            humidity = 78,
                            pressure = 1011,
                            temp = 20.829999999999998,
                            temp_max = 23,
                            temp_min = 17
                        },
                        sys = new WeatherContainer.System
                        {
                            country = "GB",
                            id = 5091,
                            message = 0.3165,
                            sunrise = 1411105356,
                            sunset = 1411149938,
                            type = 1
                        },
                        weather = new[]
                        {
                            new WeatherContainer.Weather
                            {
                                description = "mist",
                                icon = "50d",
                                id = 701,
                                main = "Mist"
                            },
                            new WeatherContainer.Weather
                            {
                                description = "proximity thunderstorm",
                                icon = "11d",
                                id = 211,
                                main = "Thunderstorm"
                            },
                            new WeatherContainer.Weather
                            {
                                description = "haze",
                                icon = "50d",
                                id = 721,
                                main = "Haze"
                            }
                        },
                        wind = new WeatherContainer.Wind
                        {
                            deg = 10,
                            speed = 1
                        }
                    }
                }
            };
        }
    }
}