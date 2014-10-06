### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 2296,875 ms        6562,500 ms
Jayrock.Json-0.9.16530.2159                      9328,125 ms       29234,375 ms
Jil-2.1.0                                          FAILED           3234,375 ms
JsonToolkit-4.3.832.1632                         8187,500 ms        7687,500 ms
Nancy-0.23.2.0                                  17031,250 ms       26046,875 ms
NetJSON-1.0.4.4                                  1484,375 ms        2890,625 ms
Newtonsoft.Json-6.0.5.17707                      3203,125 ms        4328,125 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.31.0                       2718,750 ms        7296,875 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 3078,125 ms       10843,750 ms
Jayrock.Json-0.9.16530.2159                     52828,125 ms      114671,875 ms
Jil-2.1.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                  58375,000 ms       35031,250 ms
NetJSON-1.0.4.4                                  1187,500 ms        3328,125 ms
Newtonsoft.Json-6.0.5.17707                      4765,625 ms        8546,875 ms
protobuf-net-2.0.0.668                           1453,125 ms        2375,000 ms
ServiceStack.Text-4.0.31.0                       2828,125 ms       11359,375 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                      5593,750 ms        7609,375 ms
Jil-2.1.0                                        2890,625 ms        2906,250 ms
JsonToolkit-4.3.832.1632                         2828,125 ms        2656,250 ms
Nancy-0.23.2.0                                   8343,750 ms        8781,250 ms
NetJSON-1.0.4.4                                  2453,125 ms        2156,250 ms
Newtonsoft.Json-6.0.5.17707                      2296,875 ms        2609,375 ms
protobuf-net-2.0.0.668                           1625,000 ms        2250,000 ms
ServiceStack.Text-4.0.31.0                       3109,375 ms        4906,250 ms
-------------------------------------------------------------------------------


Case: Large
Requirements: json-only, deserialize-only

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   -- --- --      119281,250 ms
Jayrock.Json-0.9.16530.2159                        -- --- --      349203,125 ms
Jil-2.1.0                                          -- --- --       19437,500 ms
JsonToolkit-4.3.832.1632                           -- --- --       79656,250 ms
Nancy-0.23.2.0                                     -- --- --          FAILED
NetJSON-1.0.4.4                                    -- --- --        1968,750 ms
Newtonsoft.Json-6.0.5.17707                        -- --- --      100406,250 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.31.0                         -- --- --       20078,125 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 9828,125 ms       31328,125 ms
Jayrock.Json-0.9.16530.2159                    123906,250 ms      278703,125 ms
Jil-2.1.0                                        3625,000 ms        7015,625 ms
JsonToolkit-4.3.832.1632                        30984,375 ms       31015,625 ms
Nancy-0.23.2.0                                 169562,500 ms       92468,750 ms
NetJSON-1.0.4.4                                  2156,250 ms        6343,750 ms
Newtonsoft.Json-6.0.5.17707                     13687,500 ms       19562,500 ms
protobuf-net-2.0.0.668                           3421,875 ms        6921,875 ms
ServiceStack.Text-4.0.31.0                       7718,750 ms       21656,250 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                     28671,875 ms       91031,250 ms
Jil-2.1.0                                        1828,125 ms        5875,000 ms
JsonToolkit-4.3.832.1632                        12671,875 ms       20593,750 ms
Nancy-0.23.2.0                                  81109,375 ms       57765,625 ms
NetJSON-1.0.4.4                                  1109,375 ms        5437,500 ms
Newtonsoft.Json-6.0.5.17707                      6328,125 ms       33640,625 ms
protobuf-net-2.0.0.668                           8453,125 ms       12359,375 ms
ServiceStack.Text-4.0.31.0                       3468,750 ms       15734,375 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 3250,000 ms        9468,750 ms
Jayrock.Json-0.9.16530.2159                     36578,125 ms       63640,625 ms
Jil-2.1.0                                        2703,125 ms        4421,875 ms
JsonToolkit-4.3.832.1632                        12828,125 ms       11859,375 ms
Nancy-0.23.2.0                                  54328,125 ms       36093,750 ms
NetJSON-1.0.4.4                                  2109,375 ms        4218,750 ms
Newtonsoft.Json-6.0.5.17707                      5328,125 ms        7187,500 ms
protobuf-net-2.0.0.668                           1359,375 ms        2593,750 ms
ServiceStack.Text-4.0.31.0                       4406,250 ms        7234,375 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                        FAILED          62750,000 ms
Jil-2.1.0                                          FAILED           5062,500 ms
JsonToolkit-4.3.832.1632                        10578,125 ms       10906,250 ms
Nancy-0.23.2.0                                  21890,625 ms       32890,625 ms
NetJSON-1.0.4.4                                  1515,625 ms        3390,625 ms
Newtonsoft.Json-6.0.5.17707                      5687,500 ms        7796,875 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.31.0                       3828,125 ms       17765,625 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 6078,125 ms       20046,875 ms
Jayrock.Json-0.9.16530.2159                     45828,125 ms      129875,000 ms
Jil-2.1.0                                        2203,125 ms        5984,375 ms
JsonToolkit-4.3.832.1632                        22468,750 ms       24421,875 ms
Nancy-0.23.2.0                                 123046,875 ms       73531,250 ms
NetJSON-1.0.4.4                                  1890,625 ms        6093,750 ms
Newtonsoft.Json-6.0.5.17707                      8562,500 ms       12500,000 ms
protobuf-net-2.0.0.668                           1140,625 ms        1984,375 ms
ServiceStack.Text-4.0.31.0                       6828,125 ms       19031,250 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 3375,000 ms       12546,875 ms
Jayrock.Json-0.9.16530.2159                     66312,500 ms      122718,750 ms
Jil-2.1.0                                        1750,000 ms        3562,500 ms
JsonToolkit-4.3.832.1632                        14687,500 ms       14578,125 ms
Nancy-0.23.2.0                                  80812,500 ms       45687,500 ms
NetJSON-1.0.4.4                                  1281,250 ms        3921,875 ms
Newtonsoft.Json-6.0.5.17707                      4843,750 ms        7765,625 ms
protobuf-net-2.0.0.668                           1265,625 ms        2234,375 ms
ServiceStack.Text-4.0.31.0                       3906,250 ms       10031,250 ms
-------------------------------------------------------------------------------


Remarks:

# Object reference not set to an instance of an object.
# Unable to cast object of type 'System.Object[]' to type 'Quality.Json.Performa
nce.Resources.Job[]'.
# Unable to cast object of type 'System.Object[]' to type 'Quality.Json.Performa
nce.Resources.Job[]'.
# Maximum JSON input length has been exceeded.
# Unable to cast object of type 'System.Object[]' to type 'Quality.Json.Performa
nce.Resources.Number[]'.
# Unable to cast object of type 'System.Object[]' to type 'Quality.Json.Performa
nce.Resources.Number[]'.
# Object must implement IConvertible.
# Object must implement IConvertible.
# Cannot import Quality.Json.Performance.Resources.Twitter+Attributes from a JSO
N String value.
# Object reference not set to an instance of an object.
````
