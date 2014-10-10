### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 1765,625 ms        4890,625 ms
Jayrock.Json-0.9.16530.2159                      6921,875 ms       25500,000 ms
Jil-2.1.1                                        1593,750 ms        2031,250 ms
JsonToolkit-4.3.832.1632                         6375,000 ms        5703,125 ms
Nancy-0.23.2.0                                  11890,625 ms       20578,125 ms
NetJSON-1.0.4.5                                  1031,250 ms        2406,250 ms
Newtonsoft.Json-6.0.5.17707                      2437,500 ms        3453,125 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.32.0                       1921,875 ms        5296,875 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 6718,750 ms       22796,875 ms
Jayrock.Json-0.9.16530.2159                    119031,250 ms      290671,875 ms
Jil-2.1.1                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                 126750,000 ms       80906,250 ms
NetJSON-1.0.4.5                                  2156,250 ms        8703,125 ms
Newtonsoft.Json-6.0.5.17707                     10671,875 ms       20359,375 ms
protobuf-net-2.0.0.668                           3000,000 ms        5031,250 ms
ServiceStack.Text-4.0.32.0                       6359,375 ms       25359,375 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                      6312,500 ms        9859,375 ms
Jil-2.1.1                                        3546,875 ms        2906,250 ms
JsonToolkit-4.3.832.1632                         3296,875 ms        2703,125 ms
Nancy-0.23.2.0                                   9937,500 ms       10250,000 ms
NetJSON-1.0.4.5                                  2640,625 ms        2593,750 ms
Newtonsoft.Json-6.0.5.17707                      1906,250 ms        2531,250 ms
protobuf-net-2.0.0.668                           1296,875 ms        1718,750 ms
ServiceStack.Text-4.0.32.0                       3234,375 ms        4515,625 ms
-------------------------------------------------------------------------------


Case: Large
Requirements: json-only, deserialize-only

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   -- --- --       67625,000 ms
Jayrock.Json-0.9.16530.2159                        -- --- --      215531,250 ms
Jil-2.1.1                                          -- --- --       13671,875 ms
JsonToolkit-4.3.832.1632                           -- --- --       46640,625 ms
Nancy-0.23.2.0                                     -- --- --          FAILED
NetJSON-1.0.4.5                                    -- --- --        2265,625 ms
Newtonsoft.Json-6.0.5.17707                        -- --- --       63171,875 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.32.0                         -- --- --       17015,625 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 7390,625 ms       23296,875 ms
Jayrock.Json-0.9.16530.2159                     92562,500 ms      230906,250 ms
Jil-2.1.1                                        2625,000 ms        4812,500 ms
JsonToolkit-4.3.832.1632                        24140,625 ms       24375,000 ms
Nancy-0.23.2.0                                 127781,250 ms       73703,125 ms
NetJSON-1.0.4.5                                  1484,375 ms        5156,250 ms
Newtonsoft.Json-6.0.5.17707                     10671,875 ms       16078,125 ms
protobuf-net-2.0.0.668                           2593,750 ms        5156,250 ms
ServiceStack.Text-4.0.32.0                       6593,750 ms       15562,500 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                     47593,750 ms      173421,875 ms
Jil-2.1.1                                        2750,000 ms        9218,750 ms
JsonToolkit-4.3.832.1632                        23171,875 ms       35421,875 ms
Nancy-0.23.2.0                                 133421,875 ms      103640,625 ms
NetJSON-1.0.4.5                                  1390,625 ms        9765,625 ms
Newtonsoft.Json-6.0.5.17707                     11437,500 ms       61750,000 ms
protobuf-net-2.0.0.668                          13703,125 ms       19312,500 ms
ServiceStack.Text-4.0.32.0                       6500,000 ms       25859,375 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 3531,250 ms        9906,250 ms
Jayrock.Json-0.9.16530.2159                     42343,750 ms       79796,875 ms
Jil-2.1.1                                        3046,875 ms        4750,000 ms
JsonToolkit-4.3.832.1632                        14937,500 ms       13468,750 ms
Nancy-0.23.2.0                                  61906,250 ms       41375,000 ms
NetJSON-1.0.4.5                                  1781,250 ms        4828,125 ms
Newtonsoft.Json-6.0.5.17707                      5734,375 ms        8765,625 ms
protobuf-net-2.0.0.668                           1359,375 ms        2343,750 ms
ServiceStack.Text-4.0.32.0                       4718,750 ms        7812,500 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                        FAILED          58156,250 ms
Jil-2.1.1                                        1671,875 ms        3640,625 ms
JsonToolkit-4.3.832.1632                         8203,125 ms        8875,000 ms
Nancy-0.23.2.0                                  17421,875 ms       26375,000 ms
NetJSON-1.0.4.5                                  1218,750 ms        2718,750 ms
Newtonsoft.Json-6.0.5.17707                      4562,500 ms        6500,000 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.32.0                       3171,875 ms       14234,375 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                10484,375 ms       32906,250 ms
Jayrock.Json-0.9.16530.2159                     82921,875 ms      255015,625 ms
Jil-2.1.1                                        3703,125 ms        9765,625 ms
JsonToolkit-4.3.832.1632                        38484,375 ms       41828,125 ms
Nancy-0.23.2.0                                 201859,375 ms      131984,375 ms
NetJSON-1.0.4.5                                  3171,875 ms       10562,500 ms
Newtonsoft.Json-6.0.5.17707                     14750,000 ms       22906,250 ms
protobuf-net-2.0.0.668                           1859,375 ms        3515,625 ms
ServiceStack.Text-4.0.32.0                      12062,500 ms       34062,500 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 7578,125 ms       26718,750 ms
Jayrock.Json-0.9.16530.2159                    152640,625 ms      308921,875 ms
Jil-2.1.1                                        3687,500 ms        7765,625 ms
JsonToolkit-4.3.832.1632                        35640,625 ms       33562,500 ms
Nancy-0.23.2.0                                 179031,250 ms      105046,875 ms
NetJSON-1.0.4.5                                  2281,250 ms        9546,875 ms
Newtonsoft.Json-6.0.5.17707                     11718,750 ms       17453,125 ms
protobuf-net-2.0.0.668                           2625,000 ms        4343,750 ms
ServiceStack.Text-4.0.32.0                       8765,625 ms       21578,125 ms
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