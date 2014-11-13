### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                 3625,000 ms       10296,875 ms
Jayrock.Json-0.9.17418.1141                     14281,250 ms       51562,500 ms
Jil-2.3.0                                        3453,125 ms        4171,875 ms
JsonToolkit-4.3.832.1632                        12250,000 ms       11937,500 ms
Nancy-0.23.2.0                                  25453,125 ms       41000,000 ms
NetJSON-1.0.5.1                                  2062,500 ms        4906,250 ms
Newtonsoft.Json-6.0.6.17820                      4687,500 ms        6734,375 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.33.0                       4000,000 ms       10796,875 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                 6593,750 ms       23234,375 ms
Jayrock.Json-0.9.17418.1141                    118796,875 ms      283343,750 ms
Jil-2.3.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                 127218,750 ms       78765,625 ms
NetJSON-1.0.5.1                                  1921,875 ms        7843,750 ms
Newtonsoft.Json-6.0.6.17820                     10375,000 ms       19265,625 ms
protobuf-net-2.0.0.668                           2953,125 ms        4812,500 ms
ServiceStack.Text-4.0.33.0                       6343,750 ms       24578,125 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                      6406,250 ms       10187,500 ms
Jil-2.3.0                                        3546,875 ms        2828,125 ms
JsonToolkit-4.3.832.1632                         3218,750 ms        2843,750 ms
Nancy-0.23.2.0                                  10140,625 ms       10000,000 ms
NetJSON-1.0.5.1                                  2812,500 ms        2609,375 ms
Newtonsoft.Json-6.0.6.17820                      1812,500 ms        2796,875 ms
protobuf-net-2.0.0.668                           1484,375 ms        1921,875 ms
ServiceStack.Text-4.0.33.0                       3343,750 ms        5000,000 ms
-------------------------------------------------------------------------------


Case: Large
Requirements: json-only, deserialize-only

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                   -- --- --       68656,250 ms
Jayrock.Json-0.9.17418.1141                        -- --- --      220953,125 ms
Jil-2.3.0                                          -- --- --       12421,875 ms
JsonToolkit-4.3.832.1632                           -- --- --       46375,000 ms
Nancy-0.23.2.0                                     -- --- --          FAILED
NetJSON-1.0.5.1                                    -- --- --        1093,750 ms
Newtonsoft.Json-6.0.6.17820                        -- --- --       63109,375 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.33.0                         -- --- --       13265,625 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                10687,500 ms       35406,250 ms
Jayrock.Json-0.9.17418.1141                    140515,625 ms      346953,125 ms
Jil-2.3.0                                        4062,500 ms        7218,750 ms
JsonToolkit-4.3.832.1632                        36406,250 ms       34781,250 ms
Nancy-0.23.2.0                                 191640,625 ms      110578,125 ms
NetJSON-1.0.5.1                                  2171,875 ms        8046,875 ms
Newtonsoft.Json-6.0.6.17820                     15343,750 ms       22625,000 ms
protobuf-net-2.0.0.668                           3828,125 ms        7750,000 ms
ServiceStack.Text-4.0.33.0                       9593,750 ms       24265,625 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                     48531,250 ms      173500,000 ms
Jil-2.3.0                                        2828,125 ms        9046,875 ms
JsonToolkit-4.3.832.1632                        22640,625 ms       35687,500 ms
Nancy-0.23.2.0                                 134750,000 ms      103375,000 ms
NetJSON-1.0.5.1                                  1640,625 ms        9500,000 ms
Newtonsoft.Json-6.0.6.17820                     11343,750 ms       62296,875 ms
protobuf-net-2.0.0.668                          14265,625 ms       20000,000 ms
ServiceStack.Text-4.0.33.0                       6468,750 ms       25312,500 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                 5531,250 ms       14171,875 ms
Jayrock.Json-0.9.17418.1141                     57593,750 ms      106328,125 ms
Jil-2.3.0                                        4531,250 ms        6531,250 ms
JsonToolkit-4.3.832.1632                        20031,250 ms       17687,500 ms
Nancy-0.23.2.0                                  82140,625 ms       55875,000 ms
NetJSON-1.0.5.1                                  2765,625 ms        6453,125 ms
Newtonsoft.Json-6.0.6.17820                      7781,250 ms       10765,625 ms
protobuf-net-2.0.0.668                           1703,125 ms        3140,625 ms
ServiceStack.Text-4.0.33.0                       6906,250 ms       11125,000 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                        FAILED          71484,375 ms
Jil-2.3.0                                        2093,750 ms        4609,375 ms
JsonToolkit-4.3.832.1632                         9984,375 ms       10734,375 ms
Nancy-0.23.2.0                                  22359,375 ms       32781,250 ms
NetJSON-1.0.5.1                                  1562,500 ms        3546,875 ms
Newtonsoft.Json-6.0.6.17820                      5640,625 ms        7937,500 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.33.0                       3718,750 ms       16375,000 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                10125,000 ms       34953,125 ms
Jayrock.Json-0.9.17418.1141                     85656,250 ms      257421,875 ms
Jil-2.3.0                                        3656,250 ms        9890,625 ms
JsonToolkit-4.3.832.1632                        38437,500 ms       42687,500 ms
Nancy-0.23.2.0                                 206390,625 ms      132515,625 ms
NetJSON-1.0.5.1                                  3109,375 ms       10640,625 ms
Newtonsoft.Json-6.0.6.17820                     14484,375 ms       23031,250 ms
protobuf-net-2.0.0.668                           1906,250 ms        3515,625 ms
ServiceStack.Text-4.0.33.0                      12000,000 ms       32437,500 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                 3843,750 ms       14218,750 ms
Jayrock.Json-0.9.17418.1141                     77015,625 ms      154515,625 ms
Jil-2.3.0                                        1953,125 ms        3718,750 ms
JsonToolkit-4.3.832.1632                        15890,625 ms       16812,500 ms
Nancy-0.23.2.0                                  87671,875 ms       53296,875 ms
NetJSON-1.0.5.1                                  1203,125 ms        4609,375 ms
Newtonsoft.Json-6.0.6.17820                      6000,000 ms        8453,125 ms
protobuf-net-2.0.0.668                           1328,125 ms        2312,500 ms
ServiceStack.Text-4.0.33.0                       4531,250 ms       11437,500 ms
-------------------------------------------------------------------------------


Remarks:

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
````