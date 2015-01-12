### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.8.0                                 1843,750 ms        4187,500 ms
Jayrock.Json-0.9.17418.1141                      7125,000 ms       25406,250 ms
Jil-2.7.0                                        1781,250 ms        2109,375 ms
JsonToolkit-4.3.833.2221                         6703,125 ms        6062,500 ms
Nancy-0.23.2.0                                  13015,625 ms       20546,875 ms
NetJSON-1.0.6.2                                  1125,000 ms        2265,625 ms
Newtonsoft.Json-6.0.8.18111                      2390,625 ms        3515,625 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.35.0                       2140,625 ms        5484,375 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.8.0                                 3531,250 ms       10203,125 ms
Jayrock.Json-0.9.17418.1141                     62140,625 ms      141578,125 ms
Jil-2.7.0                                          -- --- --          -- --- --
JsonToolkit-4.3.833.2221                           -- --- --          -- --- --
Nancy-0.23.2.0                                  65640,625 ms       38843,750 ms
NetJSON-1.0.6.2                                  1031,250 ms        3453,125 ms
Newtonsoft.Json-6.0.8.18111                      5093,750 ms        9468,750 ms
protobuf-net-2.0.0.668                           1500,000 ms        2546,875 ms
ServiceStack.Text-4.0.35.0                       3234,375 ms       12828,125 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.8.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                      8062,500 ms       12781,250 ms
Jil-2.7.0                                        2843,750 ms        3500,000 ms
JsonToolkit-4.3.833.2221                         4062,500 ms        3562,500 ms
Nancy-0.23.2.0                                  12515,625 ms       12750,000 ms
NetJSON-1.0.6.2                                  3406,250 ms        3265,625 ms
Newtonsoft.Json-6.0.8.18111                      2234,375 ms        3312,500 ms
protobuf-net-2.0.0.668                           1609,375 ms        2250,000 ms
ServiceStack.Text-4.0.35.0                       4078,125 ms        5953,125 ms
-------------------------------------------------------------------------------


Case: Large
Requirements: json-only, deserialize-only

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.8.0                                   -- --- --       74281,250 ms
Jayrock.Json-0.9.17418.1141                        -- --- --      332687,500 ms
Jil-2.7.0                                          -- --- --       19937,500 ms
JsonToolkit-4.3.833.2221                           -- --- --       72625,000 ms
Nancy-0.23.2.0                                     -- --- --          FAILED
NetJSON-1.0.6.2                                    -- --- --        2406,250 ms
Newtonsoft.Json-6.0.8.18111                        -- --- --      102312,500 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.35.0                         -- --- --       21781,250 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.8.0                                 5296,875 ms       15328,125 ms
Jayrock.Json-0.9.17418.1141                     72593,750 ms      178500,000 ms
Jil-2.7.0                                        2250,000 ms        3953,125 ms
JsonToolkit-4.3.833.2221                        19093,750 ms       17734,375 ms
Nancy-0.23.2.0                                  99218,750 ms       54171,875 ms
NetJSON-1.0.6.2                                  1015,625 ms        3531,250 ms
Newtonsoft.Json-6.0.8.18111                      8062,500 ms       11656,250 ms
protobuf-net-2.0.0.668                           1921,875 ms        3921,875 ms
ServiceStack.Text-4.0.35.0                       5125,000 ms       12390,625 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.8.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                     49796,875 ms      176562,500 ms
Jil-2.7.0                                        3187,500 ms        9703,125 ms
JsonToolkit-4.3.833.2221                        24328,125 ms       36500,000 ms
Nancy-0.23.2.0                                 139406,250 ms      105796,875 ms
NetJSON-1.0.6.2                                  1484,375 ms        9046,875 ms
Newtonsoft.Json-6.0.8.18111                     11046,875 ms       59906,250 ms
protobuf-net-2.0.0.668                          14421,875 ms       20171,875 ms
ServiceStack.Text-4.0.35.0                       6562,500 ms       26531,250 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.8.0                                 4812,500 ms       12312,500 ms
Jayrock.Json-0.9.17418.1141                     57109,375 ms      107375,000 ms
Jil-2.7.0                                        4031,250 ms        5656,250 ms
JsonToolkit-4.3.833.2221                        20062,500 ms       17937,500 ms
Nancy-0.23.2.0                                  83546,875 ms       56390,625 ms
NetJSON-1.0.6.2                                  2921,875 ms        6109,375 ms
Newtonsoft.Json-6.0.8.18111                      7515,625 ms       10906,250 ms
protobuf-net-2.0.0.668                           1703,125 ms        3328,125 ms
ServiceStack.Text-4.0.35.0                       6687,500 ms       10546,875 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.8.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                        FAILED          57859,375 ms
Jil-2.7.0                                        1562,500 ms        3546,875 ms
JsonToolkit-4.3.833.2221                         8531,250 ms        8765,625 ms
Nancy-0.23.2.0                                  19187,500 ms       26453,125 ms
NetJSON-1.0.6.2                                  1250,000 ms        2546,875 ms
Newtonsoft.Json-6.0.8.18111                      4625,000 ms        6406,250 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.35.0                       3187,500 ms       13328,125 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.8.0                                10656,250 ms       28593,750 ms
Jayrock.Json-0.9.17418.1141                     90062,500 ms      255500,000 ms
Jil-2.7.0                                        3671,875 ms        9359,375 ms
JsonToolkit-4.3.833.2221                        41296,875 ms       42515,625 ms
Nancy-0.23.2.0                                 208140,625 ms      129343,750 ms
NetJSON-1.0.6.2                                  3156,250 ms        9281,250 ms
Newtonsoft.Json-6.0.8.18111                     14484,375 ms       21562,500 ms
protobuf-net-2.0.0.668                           1875,000 ms        3484,375 ms
ServiceStack.Text-4.0.35.0                      12000,000 ms       32625,000 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.8.0                                 4109,375 ms       11265,625 ms
Jayrock.Json-0.9.17418.1141                     76078,125 ms      155734,375 ms
Jil-2.7.0                                        1796,875 ms        3703,125 ms
JsonToolkit-4.3.833.2221                        18421,875 ms       17125,000 ms
Nancy-0.23.2.0                                  92015,625 ms       54906,250 ms
NetJSON-1.0.6.2                                  1296,875 ms        4203,125 ms
Newtonsoft.Json-6.0.8.18111                      6250,000 ms        8796,875 ms
protobuf-net-2.0.0.668                           1406,250 ms        2203,125 ms
ServiceStack.Text-4.0.35.0                       4625,000 ms       11562,500 ms
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