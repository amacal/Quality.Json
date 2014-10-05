### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 2000,000 ms        5843,750 ms
Jayrock.Json-0.9.16530.2159                      7640,625 ms       23656,250 ms
Jil-2.1.0                                          FAILED           2671,875 ms
JsonToolkit-4.3.832.1632                         6937,500 ms        5906,250 ms
Nancy-0.23.2.0                                  14281,250 ms       22062,500 ms
NetJSON-1.0.4.3                                  1250,000 ms        2421,875 ms
Newtonsoft.Json-6.0.5.17707                      2765,625 ms        3640,625 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.31.0                       2171,875 ms        5859,375 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 3125,000 ms       11296,875 ms
Jayrock.Json-0.9.16530.2159                     54203,125 ms      116265,625 ms
Jil-2.1.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                  58375,000 ms       36000,000 ms
NetJSON-1.0.4.3                                  1187,500 ms        3359,375 ms
Newtonsoft.Json-6.0.5.17707                      4593,750 ms        8937,500 ms
protobuf-net-2.0.0.668                           1500,000 ms        2328,125 ms
ServiceStack.Text-4.0.31.0                       2734,375 ms       11562,500 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                      5796,875 ms        7859,375 ms
Jil-2.1.0                                        2812,500 ms        2875,000 ms
JsonToolkit-4.3.832.1632                         3031,250 ms        2671,875 ms
Nancy-0.23.2.0                                   8562,500 ms        9015,625 ms
NetJSON-1.0.4.3                                  2421,875 ms        2109,375 ms
Newtonsoft.Json-6.0.5.17707                      2234,375 ms        2687,500 ms
protobuf-net-2.0.0.668                           1750,000 ms        2406,250 ms
ServiceStack.Text-4.0.31.0                       2953,125 ms        4968,750 ms
-------------------------------------------------------------------------------


Case: Large
Requirements: json-only, deserialize-only

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   -- --- --       95328,125 ms
Jayrock.Json-0.9.16530.2159                        -- --- --      278078,125 ms
Jil-2.1.0                                          -- --- --       15203,125 ms
JsonToolkit-4.3.832.1632                           -- --- --       62921,875 ms
Nancy-0.23.2.0                                     -- --- --          FAILED
NetJSON-1.0.4.3                                    -- --- --        1718,750 ms
Newtonsoft.Json-6.0.5.17707                        -- --- --       78187,500 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.31.0                         -- --- --       15390,625 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 5062,500 ms       17359,375 ms
Jayrock.Json-0.9.16530.2159                     65812,500 ms      145046,875 ms
Jil-2.1.0                                        2046,875 ms        3781,250 ms
JsonToolkit-4.3.832.1632                        16062,500 ms       16781,250 ms
Nancy-0.23.2.0                                  89109,375 ms       48968,750 ms
NetJSON-1.0.4.3                                  1187,500 ms        3500,000 ms
Newtonsoft.Json-6.0.5.17707                      7265,625 ms       10359,375 ms
protobuf-net-2.0.0.668                           1906,250 ms        3546,875 ms
ServiceStack.Text-4.0.31.0                       4296,875 ms       11656,250 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                     29375,000 ms       93234,375 ms
Jil-2.1.0                                        1750,000 ms        5796,875 ms
JsonToolkit-4.3.832.1632                        12765,625 ms       20890,625 ms
Nancy-0.23.2.0                                  81437,500 ms       59937,500 ms
NetJSON-1.0.4.3                                  1093,750 ms        5234,375 ms
Newtonsoft.Json-6.0.5.17707                      6406,250 ms       33187,500 ms
protobuf-net-2.0.0.668                           8656,250 ms       12437,500 ms
ServiceStack.Text-4.0.31.0                       3578,125 ms       16000,000 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 3484,375 ms       10343,750 ms
Jayrock.Json-0.9.16530.2159                     37453,125 ms       64968,750 ms
Jil-2.1.0                                        3000,000 ms        4906,250 ms
JsonToolkit-4.3.832.1632                        13515,625 ms       12500,000 ms
Nancy-0.23.2.0                                  56234,375 ms       36453,125 ms
NetJSON-1.0.4.3                                  2140,625 ms        4250,000 ms
Newtonsoft.Json-6.0.5.17707                      5437,500 ms        7640,625 ms
protobuf-net-2.0.0.668                           1281,250 ms        2781,250 ms
ServiceStack.Text-4.0.31.0                       4593,750 ms        7843,750 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                        FAILED          63968,750 ms
Jil-2.1.0                                          FAILED           5093,750 ms
JsonToolkit-4.3.832.1632                        11312,500 ms       10875,000 ms
Nancy-0.23.2.0                                  22703,125 ms       34171,875 ms
NetJSON-1.0.4.3                                  1593,750 ms        3484,375 ms
Newtonsoft.Json-6.0.5.17707                      5781,250 ms        8078,125 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.31.0                       3781,250 ms       18031,250 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 6046,875 ms       20781,250 ms
Jayrock.Json-0.9.16530.2159                     47515,625 ms      131859,375 ms
Jil-2.1.0                                        2171,875 ms        6281,250 ms
JsonToolkit-4.3.832.1632                        22703,125 ms       24187,500 ms
Nancy-0.23.2.0                                 122203,125 ms       75093,750 ms
NetJSON-1.0.4.3                                  1921,875 ms        5812,500 ms
Newtonsoft.Json-6.0.5.17707                      8375,000 ms       12265,625 ms
protobuf-net-2.0.0.668                           1156,250 ms        2062,500 ms
ServiceStack.Text-4.0.31.0                       6859,375 ms       19156,250 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 3703,125 ms       13625,000 ms
Jayrock.Json-0.9.16530.2159                     66031,250 ms      124281,250 ms
Jil-2.1.0                                        1843,750 ms        3562,500 ms
JsonToolkit-4.3.832.1632                        15187,500 ms       14921,875 ms
Nancy-0.23.2.0                                  79812,500 ms       46984,375 ms
NetJSON-1.0.4.3                                  1250,000 ms        3984,375 ms
Newtonsoft.Json-6.0.5.17707                      4984,375 ms        7703,125 ms
protobuf-net-2.0.0.668                           1296,875 ms        2328,125 ms
ServiceStack.Text-4.0.31.0                       4140,625 ms       10453,125 ms
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
