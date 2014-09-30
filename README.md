### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 5405,939 ms        6265,716 ms
Jil-2.1.0                                          FAILED           2890,631 ms
JsonToolkit-4.3.832.1632                        10453,164 ms        6968,881 ms
Nancy-0.23.2.0                                  17920,970 ms       23578,166 ms
NetJSON-1.0.4.2                                  1264,778 ms        2453,520 ms
Newtonsoft.Json-6.0.5.17707                      5860,505 ms        3954,014 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.31.0                       2624,677 ms        6500,067 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 3517,164 ms       13812,678 ms
Jil-2.1.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                  63921,944 ms       39954,016 ms
NetJSON-1.0.4.2                                  1329,342 ms        3984,734 ms
Newtonsoft.Json-6.0.5.17707                      5296,889 ms        9875,029 ms
protobuf-net-2.0.0.668                           2045,945 ms        2843,638 ms
ServiceStack.Text-4.0.31.0                       3313,393 ms       12937,544 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                        3062,485 ms        3342,929 ms
JsonToolkit-4.3.832.1632                         3422,967 ms        2842,457 ms
Nancy-0.23.2.0                                   9139,524 ms       10249,180 ms
NetJSON-1.0.4.2                                  2718,776 ms        2296,871 ms
Newtonsoft.Json-6.0.5.17707                      2577,033 ms        2874,898 ms
protobuf-net-2.0.0.668                           1515,835 ms        1938,473 ms
ServiceStack.Text-4.0.31.0                       3687,879 ms        5484,397 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 4656,871 ms       16751,161 ms
Jil-2.1.0                                        1969,074 ms        3671,852 ms
JsonToolkit-4.3.832.1632                        15327,714 ms       14469,252 ms
Nancy-0.23.2.0                                  77936,790 ms       45031,432 ms
NetJSON-1.0.4.2                                  1093,760 ms        3079,032 ms
Newtonsoft.Json-6.0.5.17707                      5796,690 ms        8889,752 ms
protobuf-net-2.0.0.668                           2063,452 ms        3705,442 ms
ServiceStack.Text-4.0.31.0                       3610,440 ms       10203,169 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                        2078,864 ms        6500,984 ms
JsonToolkit-4.3.832.1632                        15296,876 ms       22828,095 ms
Nancy-0.23.2.0                                  89312,488 ms       68062,460 ms
NetJSON-1.0.4.2                                  1407,859 ms        5814,130 ms
Newtonsoft.Json-6.0.5.17707                      7312,515 ms       37029,913 ms
protobuf-net-2.0.0.668                           9171,956 ms       13311,739 ms
ServiceStack.Text-4.0.31.0                       4360,666 ms       18016,491 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 2640,610 ms        7517,752 ms
Jil-2.1.0                                        2282,163 ms        3375,201 ms
JsonToolkit-4.3.832.1632                        10032,485 ms        8797,793 ms
Nancy-0.23.2.0                                  39890,663 ms       27656,989 ms
NetJSON-1.0.4.2                                  1609,063 ms        3078,594 ms
Newtonsoft.Json-6.0.5.17707                      3860,006 ms        5345,279 ms
protobuf-net-2.0.0.668                           1014,461 ms        2015,582 ms
ServiceStack.Text-4.0.31.0                       3312,526 ms        5436,541 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                          FAILED           5782,465 ms
JsonToolkit-4.3.832.1632                        12842,888 ms       12078,118 ms
Nancy-0.23.2.0                                  24703,922 ms       37812,515 ms
NetJSON-1.0.4.2                                  1721,925 ms        3765,570 ms
Newtonsoft.Json-6.0.5.17707                      6812,780 ms        9157,123 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.31.0                       4486,284 ms       19328,212 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 6781,425 ms       23453,903 ms
Jil-2.1.0                                        2609,404 ms        6891,360 ms
JsonToolkit-4.3.832.1632                        26234,416 ms       26328,127 ms
Nancy-0.23.2.0                                 136015,318 ms       83391,425 ms
NetJSON-1.0.4.2                                  2140,611 ms        6517,428 ms
Newtonsoft.Json-6.0.5.17707                      9640,680 ms       14516,779 ms
protobuf-net-2.0.0.668                           1531,259 ms        2563,465 ms
ServiceStack.Text-4.0.31.0                       7375,908 ms       21015,639 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 3797,284 ms       15329,055 ms
Jil-2.1.0                                        2094,578 ms        4063,441 ms
JsonToolkit-4.3.832.1632                        16829,153 ms       15687,520 ms
Nancy-0.23.2.0                                  83983,210 ms       51422,828 ms
NetJSON-1.0.4.2                                  1421,899 ms        4375,948 ms
Newtonsoft.Json-6.0.5.17707                      5436,757 ms        8704,049 ms
protobuf-net-2.0.0.668                           1625,278 ms        2532,265 ms
ServiceStack.Text-4.0.31.0                       4390,669 ms       10923,641 ms
-------------------------------------------------------------------------------


Remarks:

# Object reference not set to an instance of an object.
# Unable to cast object of type 'System.Object[]' to type 'Quality.Json.Performa
nce.Resources.Job[]'.
# Unable to cast object of type 'System.Object[]' to type 'Quality.Json.Performa
nce.Resources.Job[]'.
# Unable to cast object of type 'System.Object[]' to type 'Quality.Json.Performa
nce.Resources.Number[]'.
# Unable to cast object of type 'System.Object[]' to type 'Quality.Json.Performa
nce.Resources.Number[]'.
# Object must implement IConvertible.
# Object must implement IConvertible.
# Object reference not set to an instance of an object.
````
