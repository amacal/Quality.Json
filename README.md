### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                 2843,750 ms        6250,000 ms
Jayrock.Json-0.9.17418.1141                     10718,750 ms       38156,250 ms
Jil-2.5.2                                        2390,625 ms        3031,250 ms
JsonToolkit-4.3.833.2221                         9921,875 ms        8875,000 ms
Nancy-0.23.2.0                                  20453,125 ms       31406,250 ms
NetJSON-1.0.5.4                                  1578,125 ms        3328,125 ms
Newtonsoft.Json-6.0.6.17820                      3828,125 ms        5203,125 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.34.0                       3140,625 ms        8187,500 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                 3468,750 ms       10718,750 ms
Jayrock.Json-0.9.17418.1141                     60156,250 ms      142109,375 ms
Jil-2.5.2                                          -- --- --          -- --- --
JsonToolkit-4.3.833.2221                           -- --- --          -- --- --
Nancy-0.23.2.0                                  66937,500 ms       38921,875 ms
NetJSON-1.0.5.4                                  1093,750 ms        3562,500 ms
Newtonsoft.Json-6.0.6.17820                      5609,375 ms        9953,125 ms
protobuf-net-2.0.0.668                           1515,625 ms        2546,875 ms
ServiceStack.Text-4.0.34.0                       3359,375 ms       13046,875 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                      6468,750 ms       10234,375 ms
Jil-2.5.2                                        2859,375 ms        2687,500 ms
JsonToolkit-4.3.833.2221                         3156,250 ms        2859,375 ms
Nancy-0.23.2.0                                  10031,250 ms       10125,000 ms
NetJSON-1.0.5.4                                  2546,875 ms        2500,000 ms
Newtonsoft.Json-6.0.6.17820                      1781,250 ms        2593,750 ms
protobuf-net-2.0.0.668                           1375,000 ms        1859,375 ms
ServiceStack.Text-4.0.34.0                       3531,250 ms        4687,500 ms
-------------------------------------------------------------------------------


Case: Large
Requirements: json-only, deserialize-only

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                   -- --- --       52390,625 ms
Jayrock.Json-0.9.17418.1141                        -- --- --      221218,750 ms
Jil-2.5.2                                          -- --- --       13593,750 ms
JsonToolkit-4.3.833.2221                           -- --- --       49421,875 ms
Nancy-0.23.2.0                                     -- --- --          FAILED
NetJSON-1.0.5.4                                    -- --- --        1109,375 ms
Newtonsoft.Json-6.0.6.17820                        -- --- --       67437,500 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.34.0                         -- --- --       13421,875 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                 5296,875 ms       15656,250 ms
Jayrock.Json-0.9.17418.1141                     71484,375 ms      174703,125 ms
Jil-2.5.2                                        2265,625 ms        3500,000 ms
JsonToolkit-4.3.833.2221                        19000,000 ms       17562,500 ms
Nancy-0.23.2.0                                  97828,125 ms       54046,875 ms
NetJSON-1.0.5.4                                  1109,375 ms        3421,875 ms
Newtonsoft.Json-6.0.6.17820                      7968,750 ms       11593,750 ms
protobuf-net-2.0.0.668                           1921,875 ms        3859,375 ms
ServiceStack.Text-4.0.34.0                       4875,000 ms       11828,125 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                     48546,875 ms      173703,125 ms
Jil-2.5.2                                        3593,750 ms        8921,875 ms
JsonToolkit-4.3.833.2221                        24546,875 ms       35609,375 ms
Nancy-0.23.2.0                                 136515,625 ms      101921,875 ms
NetJSON-1.0.5.4                                  1500,000 ms        8656,250 ms
Newtonsoft.Json-6.0.6.17820                     11140,625 ms       61312,500 ms
protobuf-net-2.0.0.668                          14109,375 ms       20281,250 ms
ServiceStack.Text-4.0.34.0                       6390,625 ms       25906,250 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                 3484,375 ms        9562,500 ms
Jayrock.Json-0.9.17418.1141                     42843,750 ms       80906,250 ms
Jil-2.5.2                                        3218,750 ms        3984,375 ms
JsonToolkit-4.3.833.2221                        15218,750 ms       13343,750 ms
Nancy-0.23.2.0                                  61203,125 ms       41031,250 ms
NetJSON-1.0.5.4                                  2093,750 ms        4750,000 ms
Newtonsoft.Json-6.0.6.17820                      5515,625 ms        8093,750 ms
protobuf-net-2.0.0.668                           1343,750 ms        2468,750 ms
ServiceStack.Text-4.0.34.0                       4984,375 ms        7750,000 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                        FAILED          72015,625 ms
Jil-2.5.2                                        2015,625 ms        4562,500 ms
JsonToolkit-4.3.833.2221                        10859,375 ms       11000,000 ms
Nancy-0.23.2.0                                  22625,000 ms       33343,750 ms
NetJSON-1.0.5.4                                  1562,500 ms        3156,250 ms
Newtonsoft.Json-6.0.6.17820                      5609,375 ms        7921,875 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.34.0                       3703,125 ms       16500,000 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                10140,625 ms       29515,625 ms
Jayrock.Json-0.9.17418.1141                     83640,625 ms      257656,250 ms
Jil-2.5.2                                        3640,625 ms        9453,125 ms
JsonToolkit-4.3.833.2221                        39984,375 ms       42937,500 ms
Nancy-0.23.2.0                                 207953,125 ms      129265,625 ms
NetJSON-1.0.5.4                                  3093,750 ms        9343,750 ms
Newtonsoft.Json-6.0.6.17820                     14500,000 ms       22328,125 ms
protobuf-net-2.0.0.668                           1906,250 ms        3562,500 ms
ServiceStack.Text-4.0.34.0                      12234,375 ms       32062,500 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                 3859,375 ms       12109,375 ms
Jayrock.Json-0.9.17418.1141                     76859,375 ms      155640,625 ms
Jil-2.5.2                                        1890,625 ms        3437,500 ms
JsonToolkit-4.3.833.2221                        17265,625 ms       17203,125 ms
Nancy-0.23.2.0                                  90328,125 ms       51687,500 ms
NetJSON-1.0.5.4                                  1234,375 ms        4171,875 ms
Newtonsoft.Json-6.0.6.17820                      5765,625 ms        8765,625 ms
protobuf-net-2.0.0.668                           1421,875 ms        2296,875 ms
ServiceStack.Text-4.0.34.0                       4609,375 ms       11078,125 ms
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