using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Requirements;
using Quality.Json.Performance.Resources;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quality.Json.Performance.Cases
{
    [Serializable]
    public class TwitterCase : ICase, IResource<Twitter>
    {
        public string Name
        {
            get { return "Twitter"; }
        }

        public string Description
        {
            get { return null; }
        }

        public IEnumerable<IRequirement> GetRequirements()
        {
            yield return new JaggedArrayRequirement();
        }

        public IResultData Execute(IProcedure procedure, ISubject subject, ITimes times)
        {
            return procedure.Process(this, subject, times);
        }

        public string GetText()
        {
            return File.ReadAllText(@"Resources\Twitter.json");
        }

        public MemoryStream GetData()
        {
            return new MemoryStream(File.ReadAllBytes(@"Resources\Twitter.bin"));
        }

        public ITimes Multiply(ITimes times)
        {
            return times.Multiply(100);
        }

        public Twitter GetInstance()
        {
            return new Twitter
            {
                query = new Twitter.Query
                {
                    @params = new Twitter.Parameters
                    {
                        accuracy = 0,
                        autocomplete = false,
                        granularity = "neighborhood",
                        query = "Toronto",
                        trim_place = false
                    },
                    type = "search",
                    url = "https://api.twitter.com/1.1/geo/search.json?accuracy=0&query=Toronto&granularity=neighborhood&autocomplete=false&trim_place=false"
                },
                result = new Twitter.Result
                {
                    places = new[] 
                    { 
                        new Twitter.Place
                        {
                            attributes = new Twitter.Attributes(),
                            bounding_box = new Twitter.BoundingBox
                            {
                                coordinates = new[]{ new[]
                                {
                                    new double[]{ -96.647415, 44.566715 },
                                    new double[]{ -96.630435, 44.566715 },
                                    new double[]{ -96.630435, 44.578118 },
                                    new double[]{ -96.647415, 44.578118 },
                                }},
                                type = "Polygon"
                            },
                            contained_within = new[]
                            {
                                new Twitter.Place
                                {
                                    attributes = new Twitter.Attributes(),
                                    bounding_box = new Twitter.BoundingBox
                                    {
                                coordinates = new[]{ new[]
                                        {
                                            new double[]{ -104.057739, 42.479686 },
                                            new double[]{ -96.436472, 42.479686 },
                                            new double[]{ -96.436472, 45.945716 },
                                            new double[]{ -104.057739, 45.945716 },
                                        }},
                                        type = "Polygon"
                                    },
                                    country = "United States",
                                    country_code = "US",
                                    full_name = "South Dakota, US",
                                    id = "d06e595eb3733f42",
                                    name = "South Dakota",
                                    place_type = "admin",
                                    url = "https://api.twitter.com/1.1/geo/id/d06e595eb3733f42.json"
                                }
                            },
                            country = "United States",
                            country_code = "US",
                            full_name = "Toronto, SD",
                            id = "3e8542a1e9f82870",
                            name = "Toronto",
                            place_type = "city",
                            url = "https://api.twitter.com/1.1/geo/id/3e8542a1e9f82870.json"
                        },
                        new Twitter.Place
                        {
                            attributes = new Twitter.Attributes(),
                            bounding_box = new Twitter.BoundingBox
                            {
                                coordinates = new[]{ new[]
                                {
                                    new double[]{ -80.622815, 40.436469 },
                                    new double[]{ -80.596567, 40.436469 },
                                    new double[]{ -80.596567, 40.482566 },
                                    new double[]{ -80.622815, 40.482566 },
                                }},
                                type = "Polygon"
                            },
                            contained_within = new[]
                            {
                                new Twitter.Place
                                {
                                    attributes = new Twitter.Attributes(),
                                    bounding_box = new Twitter.BoundingBox
                                    {
                                coordinates = new[]{ new[]
                                        {
                                            new double[]{ -84.820305, 38.403423 },
                                            new double[]{ -80.518454, 38.403423 },
                                            new double[]{ -80.518454, 42.327132 },
                                            new double[]{ -84.820305, 42.327132 },
                                        }},
                                        type = "Polygon"
                                    },
                                    country = "United States",
                                    country_code = "US",
                                    full_name = "Ohio, US",
                                    id = "de599025180e2ee7",
                                    name = "Ohio",
                                    place_type = "admin",
                                    url = "https://api.twitter.com/1.1/geo/id/de599025180e2ee7.json"
                                }
                            },
                            country = "United States",
                            country_code = "US",
                            full_name = "Toronto, OH",
                            id = "53d949149e8cd438",
                            name = "Toronto",
                            place_type = "city",
                            url = "https://api.twitter.com/1.1/geo/id/53d949149e8cd438.json"
                        },
                        new Twitter.Place
                        {
                            attributes = new Twitter.Attributes(),
                            bounding_box = new Twitter.BoundingBox
                            {
                                coordinates = new[]{ new[]
                                {
                                    new double[]{ -79.639128, 43.403221 },
                                    new double[]{ -78.90582, 43.403221 },
                                    new double[]{ -78.90582, 43.855466 },
                                    new double[]{ -79.639128, 43.855466 },
                                }},
                                type = "Polygon"
                            },
                            contained_within = new[]
                            {
                                new Twitter.Place
                                {
                                    attributes = new Twitter.Attributes(),
                                    bounding_box = new Twitter.BoundingBox
                                    {
                                coordinates = new[]{ new[]
                                        {
                                            new double[]{ -95.155919, 41.676329 },
                                            new double[]{ -74.339383, 41.676329 },
                                            new double[]{ -74.339383, 56.852398 },
                                            new double[]{ -95.155919, 56.852398 },
                                        }},
                                        type = "Polygon"
                                    },
                                    country = "Canada",
                                    country_code = "CA",
                                    full_name = "Ontario, Canada",
                                    id = "89b2eb8b2b9847f7",
                                    name = "Ontario",
                                    place_type = "admin",
                                    url = "https://api.twitter.com/1.1/geo/id/89b2eb8b2b9847f7.json"
                                }
                            },
                            country = "Canada",
                            country_code = "CA",
                            full_name = "Toronto, Ontario",
                            id = "8f9664a8ccd89e5c",
                            name = "Toronto",
                            place_type = "city",
                            url = "https://api.twitter.com/1.1/geo/id/8f9664a8ccd89e5c.json"
                        },
                        new Twitter.Place
                        {
                            attributes = new Twitter.Attributes(),
                            bounding_box = new Twitter.BoundingBox
                            {
                                coordinates = new[]{ new[]
                                {
                                    new double[]{ -90.867234, 41.898723 },
                                    new double[]{ -90.859467, 41.898723 },
                                    new double[]{ -90.859467, 41.906811 },
                                    new double[]{ -90.867234, 41.906811 },
                                }},
                                type = "Polygon"
                            },
                            contained_within = new[]
                            {
                                new Twitter.Place
                                {
                                    attributes = new Twitter.Attributes(),
                                    bounding_box = new Twitter.BoundingBox
                                    {
                                coordinates = new[]{ new[]
                                        {
                                            new double[]{ -96.639485, 40.375437 },
                                            new double[]{ -90.140061, 40.375437 },
                                            new double[]{ -90.140061, 43.501196 },
                                            new double[]{ -96.639485, 43.501196 },
                                        }},
                                        type = "Polygon"
                                    },
                                    country = "United States",
                                    country_code = "US",
                                    full_name = "Iowa, US",
                                    id = "3cd4c18d3615bbc9",
                                    name = "Iowa",
                                    place_type = "admin",
                                    url = "https://api.twitter.com/1.1/geo/id/3cd4c18d3615bbc9.json"
                                }
                            },
                            country = "United States",
                            country_code = "US",
                            full_name = "Toronto, IA",
                            id = "173d6f9c3249b4fd",
                            name = "Toronto",
                            place_type = "city",
                            url = "https://api.twitter.com/1.1/geo/id/173d6f9c3249b4fd.json"
                        },
                        new Twitter.Place
                        {
                            attributes = new Twitter.Attributes(),
                            bounding_box = new Twitter.BoundingBox
                            {
                                coordinates = new[]{ new[]
                                {
                                    new double[]{ -95.956873, 37.792724 },
                                    new double[]{ -95.941288, 37.792724 },
                                    new double[]{ -95.941288, 37.803752 },
                                    new double[]{ -95.956873, 37.803752 },
                                }},
                                type = "Polygon"
                            },
                            contained_within = new[]
                            {
                                new Twitter.Place
                                {
                                    attributes = new Twitter.Attributes(),
                                    bounding_box = new Twitter.BoundingBox
                                    {
                                coordinates = new[]{ new[]
                                        {
                                            new double[]{ -102.051769, 36.993016 },
                                            new double[]{ -94.588387, 36.993016 },
                                            new double[]{ -94.588387, 40.003166 },
                                            new double[]{ -102.051769, 40.003166 },
                                        }},
                                        type = "Polygon"
                                    },
                                    country = "United States",
                                    country_code = "US",
                                    full_name = "Kansas, US",
                                    id = "27c45d804c777999",
                                    name = "Kansas",
                                    place_type = "admin",
                                    url = "https://api.twitter.com/1.1/geo/id/27c45d804c777999.json"
                                }
                            },
                            country = "United States",
                            country_code = "US",
                            full_name = "Toronto, KS",
                            id = "b90e4628bff4ad82",
                            name = "Toronto",
                            place_type = "city",
                            url = "https://api.twitter.com/1.1/geo/id/b90e4628bff4ad82.json"
                        }
                    }
                }
            };
        }
    }
}
