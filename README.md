### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                 2890,625 ms        6156,250 ms
Jayrock.Json-0.9.17418.1141                     11031,250 ms       39015,625 ms
Jil-2.5.2                                        2703,125 ms        3406,250 ms
JsonToolkit-4.3.833.2221                        10796,875 ms        9281,250 ms
Nancy-0.23.2.0                                  19187,500 ms       30578,125 ms
NetJSON-1.0.6                                    1406,250 ms        3406,250 ms
Newtonsoft.Json-6.0.6.17820                      3984,375 ms        5265,625 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.34.0                       3156,250 ms        8156,250 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                 3593,750 ms       10671,875 ms
Jayrock.Json-0.9.17418.1141                     62593,750 ms      142187,500 ms
Jil-2.5.2                                          -- --- --          -- --- --
JsonToolkit-4.3.833.2221                           -- --- --          -- --- --
Nancy-0.23.2.0                                  65937,500 ms       41921,875 ms
NetJSON-1.0.6                                    1031,250 ms        3453,125 ms
Newtonsoft.Json-6.0.6.17820                      5796,875 ms       10000,000 ms
protobuf-net-2.0.0.668                           1468,750 ms        2484,375 ms
ServiceStack.Text-4.0.34.0                       3234,375 ms       13171,875 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                      5156,250 ms        8093,750 ms
Jil-2.5.2                                        2312,500 ms        2203,125 ms
JsonToolkit-4.3.833.2221                         2500,000 ms        2234,375 ms
Nancy-0.23.2.0                                   7671,875 ms        7562,500 ms
NetJSON-1.0.6                                    2140,625 ms        1890,625 ms
Newtonsoft.Json-6.0.6.17820                      1406,250 ms        2015,625 ms
protobuf-net-2.0.0.668                           1125,000 ms        1406,250 ms
ServiceStack.Text-4.0.34.0                       2687,500 ms        3765,625 ms
-------------------------------------------------------------------------------


Case: Large
Requirements: json-only, deserialize-only

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                   -- --- --       80031,250 ms
Jayrock.Json-0.9.17418.1141                        -- --- --      340000,000 ms
Jil-2.5.2                                          -- --- --       20562,500 ms
JsonToolkit-4.3.833.2221                           -- --- --       74968,750 ms
Nancy-0.23.2.0                                     -- --- --          FAILED
NetJSON-1.0.6                                      -- --- --        2375,000 ms
Newtonsoft.Json-6.0.6.17820                        -- --- --       97531,250 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.34.0                         -- --- --       19906,250 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                 5718,750 ms       16640,625 ms
Jayrock.Json-0.9.17418.1141                     74500,000 ms      176500,000 ms
Jil-2.5.2                                        2671,875 ms        3812,500 ms
JsonToolkit-4.3.833.2221                        19015,625 ms       20421,875 ms
Nancy-0.23.2.0                                 110281,250 ms       56093,750 ms
NetJSON-1.0.6                                    1109,375 ms        3546,875 ms
Newtonsoft.Json-6.0.6.17820                      7843,750 ms       13328,125 ms
protobuf-net-2.0.0.668                           2046,875 ms        4078,125 ms
ServiceStack.Text-4.0.34.0                       5015,625 ms       12843,750 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                     53281,250 ms      178625,000 ms
Jil-2.5.2                                        3250,000 ms        9625,000 ms
JsonToolkit-4.3.833.2221                        24312,500 ms       37203,125 ms
Nancy-0.23.2.0                                 140859,375 ms      104906,250 ms
NetJSON-1.0.6                                    1546,875 ms        9000,000 ms
Newtonsoft.Json-6.0.6.17820                     11390,625 ms       58796,875 ms
protobuf-net-2.0.0.668                          14859,375 ms       21718,750 ms
ServiceStack.Text-4.0.34.0                       6812,500 ms       27312,500 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                 5671,875 ms       13062,500 ms
Jayrock.Json-0.9.17418.1141                     59312,500 ms      110984,375 ms
Jil-2.5.2                                        4015,625 ms        6062,500 ms
JsonToolkit-4.3.833.2221                        21031,250 ms       18593,750 ms
Nancy-0.23.2.0                                  84593,750 ms       56718,750 ms
NetJSON-1.0.6                                    2875,000 ms        6140,625 ms
Newtonsoft.Json-6.0.6.17820                      7343,750 ms       10734,375 ms
protobuf-net-2.0.0.668                           1890,625 ms        3187,500 ms
ServiceStack.Text-4.0.34.0                       6796,875 ms       11328,125 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                   FAILED             FAILED
Jayrock.Json-0.9.17418.1141                        FAILED          58875,000 ms
Jil-2.5.2                                        1703,125 ms        3906,250 ms
JsonToolkit-4.3.833.2221                         8859,375 ms        8968,750 ms
Nancy-0.23.2.0                                  17750,000 ms       26062,500 ms
NetJSON-1.0.6                                    1265,625 ms        2484,375 ms
Newtonsoft.Json-6.0.6.17820                      4546,875 ms        6531,250 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.34.0                       3187,500 ms       13250,000 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                10593,750 ms       30234,375 ms
Jayrock.Json-0.9.17418.1141                     86531,250 ms      265437,500 ms
Jil-2.5.2                                        4390,625 ms        9937,500 ms
JsonToolkit-4.3.833.2221                        42437,500 ms       44203,125 ms
Nancy-0.23.2.0                                 207843,750 ms      132625,000 ms
NetJSON-1.0.6                                    3296,875 ms        9578,125 ms
Newtonsoft.Json-6.0.6.17820                     14515,625 ms       22250,000 ms
protobuf-net-2.0.0.668                           1984,375 ms        3562,500 ms
ServiceStack.Text-4.0.34.0                      12468,750 ms       33593,750 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.7.0                                 4156,250 ms       11671,875 ms
Jayrock.Json-0.9.17418.1141                     77015,625 ms      157921,875 ms
Jil-2.5.2                                        1968,750 ms        3640,625 ms
JsonToolkit-4.3.833.2221                        18453,125 ms       17718,750 ms
Nancy-0.23.2.0                                  90984,375 ms       53078,125 ms
NetJSON-1.0.6                                    1234,375 ms        4140,625 ms
Newtonsoft.Json-6.0.6.17820                      5937,500 ms        8703,125 ms
protobuf-net-2.0.0.668                           1375,000 ms        2375,000 ms
ServiceStack.Text-4.0.34.0                       4609,375 ms       11546,875 ms
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