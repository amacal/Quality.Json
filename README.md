### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 1968,750 ms        4968,750 ms
Jayrock.Json-0.9.16530.2159                      6953,125 ms       25421,875 ms
Jil-2.1.0                                          FAILED           2312,500 ms
JsonToolkit-4.3.832.1632                         6281,250 ms        6000,000 ms
Nancy-0.23.2.0                                  11875,000 ms       19906,250 ms
NetJSON-1.0.4.5                                  1000,000 ms        2421,875 ms
Newtonsoft.Json-6.0.5.17707                      2531,250 ms        3359,375 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.32.0                       2031,250 ms        5484,375 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 6937,500 ms       23640,625 ms
Jayrock.Json-0.9.16530.2159                    119500,000 ms      283765,625 ms
Jil-2.1.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                 124953,125 ms       77531,250 ms
NetJSON-1.0.4.5                                  1921,875 ms        8000,000 ms
Newtonsoft.Json-6.0.5.17707                     10593,750 ms       19171,875 ms
protobuf-net-2.0.0.668                           3031,250 ms        4890,625 ms
ServiceStack.Text-4.0.32.0                       6250,000 ms       23968,750 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                      6453,125 ms        9906,250 ms
Jil-2.1.0                                        3546,875 ms        3187,500 ms
JsonToolkit-4.3.832.1632                         3203,125 ms        2828,125 ms
Nancy-0.23.2.0                                   9921,875 ms       10281,250 ms
NetJSON-1.0.4.5                                  2593,750 ms        2578,125 ms
Newtonsoft.Json-6.0.5.17707                      1796,875 ms        2578,125 ms
protobuf-net-2.0.0.668                           1421,875 ms        1921,875 ms
ServiceStack.Text-4.0.32.0                       3390,625 ms        4453,125 ms
-------------------------------------------------------------------------------


Case: Large
Requirements: json-only, deserialize-only

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   -- --- --       50390,625 ms
Jayrock.Json-0.9.16530.2159                        -- --- --      167578,125 ms
Jil-2.1.0                                          -- --- --        9750,000 ms
JsonToolkit-4.3.832.1632                           -- --- --       35218,750 ms
Nancy-0.23.2.0                                     -- --- --          FAILED
NetJSON-1.0.4.5                                    -- --- --        1000,000 ms
Newtonsoft.Json-6.0.5.17707                        -- --- --       47859,375 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.32.0                         -- --- --       14328,125 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 5437,500 ms       17640,625 ms
Jayrock.Json-0.9.16530.2159                     69781,250 ms      174140,625 ms
Jil-2.1.0                                        2140,625 ms        4343,750 ms
JsonToolkit-4.3.832.1632                        18265,625 ms       18281,250 ms
Nancy-0.23.2.0                                  95750,000 ms       55265,625 ms
NetJSON-1.0.4.5                                  1078,125 ms        3828,125 ms
Newtonsoft.Json-6.0.5.17707                      8234,375 ms       12140,625 ms
protobuf-net-2.0.0.668                           1906,250 ms        3968,750 ms
ServiceStack.Text-4.0.32.0                       4781,250 ms       11734,375 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                     48265,625 ms      169453,125 ms
Jil-2.1.0                                        3156,250 ms       10343,750 ms
JsonToolkit-4.3.832.1632                        23062,500 ms       35546,875 ms
Nancy-0.23.2.0                                 133703,125 ms      102234,375 ms
NetJSON-1.0.4.5                                  1421,875 ms        9875,000 ms
Newtonsoft.Json-6.0.5.17707                     11125,000 ms       57453,125 ms
protobuf-net-2.0.0.668                          13906,250 ms       19640,625 ms
ServiceStack.Text-4.0.32.0                       6453,125 ms       25671,875 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 3671,875 ms       10593,750 ms
Jayrock.Json-0.9.16530.2159                     42265,625 ms       79859,375 ms
Jil-2.1.0                                        3093,750 ms        5234,375 ms
JsonToolkit-4.3.832.1632                        14890,625 ms       12921,875 ms
Nancy-0.23.2.0                                  62296,875 ms       41843,750 ms
NetJSON-1.0.4.5                                  2171,875 ms        4968,750 ms
Newtonsoft.Json-6.0.5.17707                      5484,375 ms        8656,250 ms
protobuf-net-2.0.0.668                           1312,500 ms        2468,750 ms
ServiceStack.Text-4.0.32.0                       4750,000 ms        7718,750 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                        FAILED          71218,750 ms
Jil-2.1.0                                          FAILED           4687,500 ms
JsonToolkit-4.3.832.1632                        10140,625 ms       10968,750 ms
Nancy-0.23.2.0                                  21796,875 ms       32203,125 ms
NetJSON-1.0.4.5                                  1578,125 ms        3593,750 ms
Newtonsoft.Json-6.0.5.17707                      5781,250 ms        8031,250 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.32.0                       3687,500 ms       17703,125 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 7046,875 ms       22171,875 ms
Jayrock.Json-0.9.16530.2159                     56218,750 ms      170500,000 ms
Jil-2.1.0                                        2406,250 ms        6578,125 ms
JsonToolkit-4.3.832.1632                        24562,500 ms       28218,750 ms
Nancy-0.23.2.0                                 136796,875 ms       87000,000 ms
NetJSON-1.0.4.5                                  2171,875 ms        7078,125 ms
Newtonsoft.Json-6.0.5.17707                      9546,875 ms       15343,750 ms
protobuf-net-2.0.0.668                           1281,250 ms        2328,125 ms
ServiceStack.Text-4.0.32.0                       7890,625 ms       22484,375 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 3765,625 ms       14187,500 ms
Jayrock.Json-0.9.16530.2159                     76718,750 ms      154984,375 ms
Jil-2.1.0                                        1875,000 ms        3812,500 ms
JsonToolkit-4.3.832.1632                        16968,750 ms       17171,875 ms
Nancy-0.23.2.0                                  90000,000 ms       52796,875 ms
NetJSON-1.0.4.5                                  1250,000 ms        4671,875 ms
Newtonsoft.Json-6.0.5.17707                      5718,750 ms        9468,750 ms
protobuf-net-2.0.0.668                           1375,000 ms        2468,750 ms
ServiceStack.Text-4.0.32.0                       4546,875 ms       10765,625 ms
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