### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.6.0                                 2906,250 ms        7984,375 ms
Jayrock.Json-0.9.17418.1141                     10953,125 ms       39250,000 ms
Jil-2.4.0                                        2765,625 ms        3296,875 ms
JsonToolkit-4.3.832.1632                         9828,125 ms        9296,875 ms
Nancy-0.23.2.0                                  20484,375 ms       31781,250 ms
NetJSON-1.0.5.4                                  1765,625 ms        3406,250 ms
Newtonsoft.Json-6.0.6.17820                      3890,625 ms        5375,000 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.33.0                       3359,375 ms        8796,875 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.6.0                                 3468,750 ms       12312,500 ms
Jayrock.Json-0.9.17418.1141                     62625,000 ms      146937,500 ms
Jil-2.4.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                  66437,500 ms       39343,750 ms
NetJSON-1.0.5.4                                  1046,875 ms        3546,875 ms
Newtonsoft.Json-6.0.6.17820                      5171,875 ms        9843,750 ms
protobuf-net-2.0.0.668                           1562,500 ms        2421,875 ms
ServiceStack.Text-4.0.33.0                       3203,125 ms       12921,875 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.6.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                      4968,750 ms        7781,250 ms
Jil-2.4.0                                        2109,375 ms        2125,000 ms
JsonToolkit-4.3.832.1632                         2484,375 ms        2187,500 ms
Nancy-0.23.2.0                                   7640,625 ms        7765,625 ms
NetJSON-1.0.5.4                                  1890,625 ms        1875,000 ms
Newtonsoft.Json-6.0.6.17820                      1406,250 ms        2000,000 ms
protobuf-net-2.0.0.668                           1140,625 ms        1343,750 ms
ServiceStack.Text-4.0.33.0                       2593,750 ms        3734,375 ms
-------------------------------------------------------------------------------


Case: Large
Requirements: json-only, deserialize-only

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.6.0                                   -- --- --      197765,625 ms
Jayrock.Json-0.9.17418.1141                        -- --- --      642015,625 ms
Jil-2.4.0                                          -- --- --       37281,250 ms
JsonToolkit-4.3.832.1632                           -- --- --      143156,250 ms
Nancy-0.23.2.0                                     -- --- --          FAILED
NetJSON-1.0.5.4                                    -- --- --        3843,750 ms
Newtonsoft.Json-6.0.6.17820                        -- --- --      201140,625 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.33.0                         -- --- --       40406,250 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.6.0                                 5734,375 ms       19296,875 ms
Jayrock.Json-0.9.17418.1141                     72250,000 ms      174843,750 ms
Jil-2.4.0                                        2312,500 ms        3656,250 ms
JsonToolkit-4.3.832.1632                        17875,000 ms       18234,375 ms
Nancy-0.23.2.0                                  98203,125 ms       54718,750 ms
NetJSON-1.0.5.4                                  1093,750 ms        3390,625 ms
Newtonsoft.Json-6.0.6.17820                      8062,500 ms       11781,250 ms
protobuf-net-2.0.0.668                           1968,750 ms        3890,625 ms
ServiceStack.Text-4.0.33.0                       5078,125 ms       12609,375 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.6.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                     49859,375 ms      175718,750 ms
Jil-2.4.0                                        3187,500 ms        9359,375 ms
JsonToolkit-4.3.832.1632                        24562,500 ms       36984,375 ms
Nancy-0.23.2.0                                 139046,875 ms      104562,500 ms
NetJSON-1.0.5.4                                  1437,500 ms        8750,000 ms
Newtonsoft.Json-6.0.6.17820                     11328,125 ms       58718,750 ms
protobuf-net-2.0.0.668                          14609,375 ms       20515,625 ms
ServiceStack.Text-4.0.33.0                       6609,375 ms       27671,875 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.6.0                                 3562,500 ms       11093,750 ms
Jayrock.Json-0.9.17418.1141                     43281,250 ms       80953,125 ms
Jil-2.4.0                                        3046,875 ms        4437,500 ms
JsonToolkit-4.3.832.1632                        14531,250 ms       13078,125 ms
Nancy-0.23.2.0                                  61281,250 ms       41343,750 ms
NetJSON-1.0.5.4                                  2000,000 ms        4515,625 ms
Newtonsoft.Json-6.0.6.17820                      5562,500 ms        8375,000 ms
protobuf-net-2.0.0.668                           1281,250 ms        2453,125 ms
ServiceStack.Text-4.0.33.0                       4984,375 ms        7796,875 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.6.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                        FAILED          58015,625 ms
Jil-2.4.0                                        1703,125 ms        3578,125 ms
JsonToolkit-4.3.832.1632                         8234,375 ms        8750,000 ms
Nancy-0.23.2.0                                  18078,125 ms       26359,375 ms
NetJSON-1.0.5.4                                  1218,750 ms        2546,875 ms
Newtonsoft.Json-6.0.6.17820                      4609,375 ms        6375,000 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.33.0                       3046,875 ms       13140,625 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.6.0                                10531,250 ms       34718,750 ms
Jayrock.Json-0.9.17418.1141                     87015,625 ms      254015,625 ms
Jil-2.4.0                                        3828,125 ms        9687,500 ms
JsonToolkit-4.3.832.1632                        37718,750 ms       44687,500 ms
Nancy-0.23.2.0                                 214375,000 ms      132953,125 ms
NetJSON-1.0.5.4                                  3265,625 ms        9859,375 ms
Newtonsoft.Json-6.0.6.17820                     16203,125 ms       22625,000 ms
protobuf-net-2.0.0.668                           1875,000 ms        3515,625 ms
ServiceStack.Text-4.0.33.0                      12562,500 ms       33750,000 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.6.0                                 3968,750 ms       13968,750 ms
Jayrock.Json-0.9.17418.1141                     77312,500 ms      156171,875 ms
Jil-2.4.0                                        1875,000 ms        3500,000 ms
JsonToolkit-4.3.832.1632                        17156,250 ms       16765,625 ms
Nancy-0.23.2.0                                  91343,750 ms       54484,375 ms
NetJSON-1.0.5.4                                  1234,375 ms        4265,625 ms
Newtonsoft.Json-6.0.6.17820                      5671,875 ms        8828,125 ms
protobuf-net-2.0.0.668                           1328,125 ms        2265,625 ms
ServiceStack.Text-4.0.33.0                       4765,625 ms       11421,875 ms
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