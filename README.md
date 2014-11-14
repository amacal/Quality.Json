### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                 1890,625 ms        5031,250 ms
Jayrock.Json-0.9.17418.1141                      7078,125 ms       25312,500 ms
Jil-2.3.1                                        1781,250 ms        2078,125 ms
JsonToolkit-4.3.832.1632                         6015,625 ms        6000,000 ms
Nancy-0.23.2.0                                  12281,250 ms       20250,000 ms
NetJSON-1.0.5.2                                  1078,125 ms        2437,500 ms
Newtonsoft.Json-6.0.6.17820                      2484,375 ms        3296,875 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.33.0                       2000,000 ms        5484,375 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                 3468,750 ms       11687,500 ms
Jayrock.Json-0.9.17418.1141                     59718,750 ms      147625,000 ms
Jil-2.3.1                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                  63468,750 ms       40125,000 ms
NetJSON-1.0.5.2                                  1015,625 ms        3937,500 ms
Newtonsoft.Json-6.0.6.17820                      4921,875 ms        9859,375 ms
protobuf-net-2.0.0.668                           1546,875 ms        2328,125 ms
ServiceStack.Text-4.0.33.0                       3187,500 ms       12703,125 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                      7890,625 ms       12921,875 ms
Jil-2.3.1                                        4484,375 ms        3406,250 ms
JsonToolkit-4.3.832.1632                         3984,375 ms        3421,875 ms
Nancy-0.23.2.0                                  12968,750 ms       12500,000 ms
NetJSON-1.0.5.2                                  3187,500 ms        3171,875 ms
Newtonsoft.Json-6.0.6.17820                      2437,500 ms        3265,625 ms
protobuf-net-2.0.0.668                           1968,750 ms        2312,500 ms
ServiceStack.Text-4.0.33.0                       4234,375 ms        6062,500 ms
-------------------------------------------------------------------------------


Case: Large
Requirements: json-only, deserialize-only

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                   -- --- --       83656,250 ms
Jayrock.Json-0.9.17418.1141                        -- --- --      270343,750 ms
Jil-2.3.1                                          -- --- --       15593,750 ms
JsonToolkit-4.3.832.1632                           -- --- --       60671,875 ms
Nancy-0.23.2.0                                     -- --- --          FAILED
NetJSON-1.0.5.2                                    -- --- --        1437,500 ms
Newtonsoft.Json-6.0.6.17820                        -- --- --       81875,000 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.33.0                         -- --- --       18265,625 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                 5687,500 ms       17828,125 ms
Jayrock.Json-0.9.17418.1141                     71796,875 ms      181953,125 ms
Jil-2.3.1                                        2171,875 ms        3609,375 ms
JsonToolkit-4.3.832.1632                        17640,625 ms       17953,125 ms
Nancy-0.23.2.0                                 100828,125 ms       56593,750 ms
NetJSON-1.0.5.2                                  1078,125 ms        3765,625 ms
Newtonsoft.Json-6.0.6.17820                      7921,875 ms       11671,875 ms
protobuf-net-2.0.0.668                           1890,625 ms        3906,250 ms
ServiceStack.Text-4.0.33.0                       5015,625 ms       12250,000 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                     49828,125 ms      170125,000 ms
Jil-2.3.1                                        2687,500 ms        9125,000 ms
JsonToolkit-4.3.832.1632                        22171,875 ms       35390,625 ms
Nancy-0.23.2.0                                 135062,500 ms      101859,375 ms
NetJSON-1.0.5.2                                  1562,500 ms        9484,375 ms
Newtonsoft.Json-6.0.6.17820                     11625,000 ms       60640,625 ms
protobuf-net-2.0.0.668                          13984,375 ms       19546,875 ms
ServiceStack.Text-4.0.33.0                       6359,375 ms       25218,750 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                 4703,125 ms       14406,250 ms
Jayrock.Json-0.9.17418.1141                     57250,000 ms      106406,250 ms
Jil-2.3.1                                        4468,750 ms        5890,625 ms
JsonToolkit-4.3.832.1632                        19656,250 ms       17968,750 ms
Nancy-0.23.2.0                                  81937,500 ms       54859,375 ms
NetJSON-1.0.5.2                                  2875,000 ms        6671,875 ms
Newtonsoft.Json-6.0.6.17820                      7437,500 ms       10718,750 ms
protobuf-net-2.0.0.668                           1781,250 ms        3265,625 ms
ServiceStack.Text-4.0.33.0                       6703,125 ms       10500,000 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                        FAILED          57328,125 ms
Jil-2.3.1                                        1656,250 ms        3703,125 ms
JsonToolkit-4.3.832.1632                         8171,875 ms        8531,250 ms
Nancy-0.23.2.0                                  18406,250 ms       26671,875 ms
NetJSON-1.0.5.2                                  1265,625 ms        2765,625 ms
Newtonsoft.Json-6.0.6.17820                      4500,000 ms        6562,500 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.33.0                       3046,875 ms       13218,750 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                 9859,375 ms       33312,500 ms
Jayrock.Json-0.9.17418.1141                     83625,000 ms      257687,500 ms
Jil-2.3.1                                        3531,250 ms        9968,750 ms
JsonToolkit-4.3.832.1632                        37281,250 ms       44828,125 ms
Nancy-0.23.2.0                                 213156,250 ms      130609,375 ms
NetJSON-1.0.5.2                                  3234,375 ms       10531,250 ms
Newtonsoft.Json-6.0.6.17820                     14781,250 ms       22171,875 ms
protobuf-net-2.0.0.668                           1968,750 ms        3453,125 ms
ServiceStack.Text-4.0.33.0                      11796,875 ms       31984,375 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.5.0                                 3828,125 ms       13968,750 ms
Jayrock.Json-0.9.17418.1141                     75218,750 ms      160515,625 ms
Jil-2.3.1                                        1843,750 ms        3515,625 ms
JsonToolkit-4.3.832.1632                        16265,625 ms       16984,375 ms
Nancy-0.23.2.0                                  88515,625 ms       52062,500 ms
NetJSON-1.0.5.2                                  1093,750 ms        4718,750 ms
Newtonsoft.Json-6.0.6.17820                      5875,000 ms        8375,000 ms
protobuf-net-2.0.0.668                           1312,500 ms        2265,625 ms
ServiceStack.Text-4.0.33.0                       4515,625 ms       10968,750 ms
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