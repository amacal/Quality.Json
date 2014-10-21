### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 2093,750 ms        5843,750 ms
Jayrock.Json-0.9.16530.2159                      7890,625 ms       28781,250 ms
Jil-2.2.0                                        1968,750 ms        2437,500 ms
JsonToolkit-4.3.832.1632                         7734,375 ms        6781,250 ms
Nancy-0.23.2.0                                  14859,375 ms       22046,875 ms
NetJSON-1.0.5                                    1234,375 ms        2781,250 ms
Newtonsoft.Json-6.0.5.17707                      3000,000 ms        3890,625 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.32.0                       2296,875 ms        6171,875 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 3781,250 ms       13796,875 ms
Jayrock.Json-0.9.16530.2159                     67234,375 ms      155359,375 ms
Jil-2.2.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                  72500,000 ms       44984,375 ms
NetJSON-1.0.5                                    1125,000 ms        4250,000 ms
Newtonsoft.Json-6.0.5.17707                      5718,750 ms       11125,000 ms
protobuf-net-2.0.0.668                           1687,500 ms        2671,875 ms
ServiceStack.Text-4.0.32.0                       3484,375 ms       13218,750 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                      5609,375 ms        8484,375 ms
Jil-2.2.0                                        3046,875 ms        2546,875 ms
JsonToolkit-4.3.832.1632                         2640,625 ms        2578,125 ms
Nancy-0.23.2.0                                   8656,250 ms        8390,625 ms
NetJSON-1.0.5                                    2125,000 ms        2187,500 ms
Newtonsoft.Json-6.0.5.17707                      1625,000 ms        2234,375 ms
protobuf-net-2.0.0.668                           1375,000 ms        1781,250 ms
ServiceStack.Text-4.0.32.0                       2750,000 ms        4171,875 ms
-------------------------------------------------------------------------------


Case: Large
Requirements: json-only, deserialize-only

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   -- --- --      122968,750 ms
Jayrock.Json-0.9.16530.2159                        -- --- --      367906,250 ms
Jil-2.2.0                                          -- --- --       20718,750 ms
JsonToolkit-4.3.832.1632                           -- --- --       92890,625 ms
Nancy-0.23.2.0                                     -- --- --          FAILED
NetJSON-1.0.5                                      -- --- --        2140,625 ms
Newtonsoft.Json-6.0.5.17707                        -- --- --      123250,000 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.32.0                         -- --- --       28093,750 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 6203,125 ms       20937,500 ms
Jayrock.Json-0.9.16530.2159                     79734,375 ms      194718,750 ms
Jil-2.2.0                                        2312,500 ms        4281,250 ms
JsonToolkit-4.3.832.1632                        21109,375 ms       20484,375 ms
Nancy-0.23.2.0                                 111640,625 ms       61515,625 ms
NetJSON-1.0.5                                    1218,750 ms        4234,375 ms
Newtonsoft.Json-6.0.5.17707                      8906,250 ms       13562,500 ms
protobuf-net-2.0.0.668                           2125,000 ms        4234,375 ms
ServiceStack.Text-4.0.32.0                       5468,750 ms       13265,625 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                     54562,500 ms      190562,500 ms
Jil-2.2.0                                        3187,500 ms       10375,000 ms
JsonToolkit-4.3.832.1632                        24890,625 ms       39843,750 ms
Nancy-0.23.2.0                                 150703,125 ms      112031,250 ms
NetJSON-1.0.5                                    1687,500 ms       10453,125 ms
Newtonsoft.Json-6.0.5.17707                     12562,500 ms       68531,250 ms
protobuf-net-2.0.0.668                          15984,375 ms       22890,625 ms
ServiceStack.Text-4.0.32.0                       7109,375 ms       28734,375 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 5484,375 ms       16000,000 ms
Jayrock.Json-0.9.16530.2159                     63484,375 ms      118000,000 ms
Jil-2.2.0                                        4671,875 ms        6578,125 ms
JsonToolkit-4.3.832.1632                        22125,000 ms       19453,125 ms
Nancy-0.23.2.0                                  92171,875 ms       60343,750 ms
NetJSON-1.0.5                                    3218,750 ms        7312,500 ms
Newtonsoft.Json-6.0.5.17707                      8218,750 ms       12875,000 ms
protobuf-net-2.0.0.668                           1953,125 ms        3437,500 ms
ServiceStack.Text-4.0.32.0                       7078,125 ms       11734,375 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                        FAILED          62890,625 ms
Jil-2.2.0                                        1734,375 ms        4187,500 ms
JsonToolkit-4.3.832.1632                         9375,000 ms        9578,125 ms
Nancy-0.23.2.0                                  19750,000 ms       29031,250 ms
NetJSON-1.0.5                                    1406,250 ms        3109,375 ms
Newtonsoft.Json-6.0.5.17707                      5171,875 ms        7265,625 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.32.0                       3343,750 ms       15734,375 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 7859,375 ms       26093,750 ms
Jayrock.Json-0.9.16530.2159                     63703,125 ms      194484,375 ms
Jil-2.2.0                                        2906,250 ms        7296,875 ms
JsonToolkit-4.3.832.1632                        28343,750 ms       31859,375 ms
Nancy-0.23.2.0                                 156531,250 ms       98531,250 ms
NetJSON-1.0.5                                    2343,750 ms        7718,750 ms
Newtonsoft.Json-6.0.5.17707                     11015,625 ms       17515,625 ms
protobuf-net-2.0.0.668                           1375,000 ms        2531,250 ms
ServiceStack.Text-4.0.32.0                       8968,750 ms       25828,125 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.4.0                                 4515,625 ms       15796,875 ms
Jayrock.Json-0.9.16530.2159                     85171,875 ms      171343,750 ms
Jil-2.2.0                                        2093,750 ms        4296,875 ms
JsonToolkit-4.3.832.1632                        18703,125 ms       19140,625 ms
Nancy-0.23.2.0                                 101875,000 ms       58390,625 ms
NetJSON-1.0.5                                    1281,250 ms        5265,625 ms
Newtonsoft.Json-6.0.5.17707                      6453,125 ms       10078,125 ms
protobuf-net-2.0.0.668                           1500,000 ms        2453,125 ms
ServiceStack.Text-4.0.32.0                       5156,250 ms       12406,250 ms
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