### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 4126,859 ms        5563,588 ms
Jil-2.1.0                                          FAILED           2562,506 ms
JsonToolkit-4.3.832.1632                         9454,344 ms        6328,139 ms
Nancy-0.23.2.0                                  16248,957 ms       21233,823 ms
NetJSON-1.0.4.2                                  1156,232 ms        2281,242 ms
Newtonsoft.Json-6.0.5.17707                      5186,550 ms        3656,252 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.31.0                       2235,232 ms        5720,300 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 3109,629 ms       11578,145 ms
Jil-2.1.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                  58797,221 ms       36656,287 ms
NetJSON-1.0.4.2                                  1218,723 ms        3406,275 ms
Newtonsoft.Json-6.0.5.17707                      4829,561 ms        8547,632 ms
protobuf-net-2.0.0.668                           1484,352 ms        2420,874 ms
ServiceStack.Text-4.0.31.0                       3000,803 ms       11531,949 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                        2718,037 ms        2969,418 ms
JsonToolkit-4.3.832.1632                         3095,762 ms        2515,642 ms
Nancy-0.23.2.0                                   8577,124 ms        9734,392 ms
NetJSON-1.0.4.2                                  2537,346 ms        2108,613 ms
Newtonsoft.Json-6.0.5.17707                      2265,650 ms        2484,357 ms
protobuf-net-2.0.0.668                           1328,132 ms        1891,523 ms
ServiceStack.Text-4.0.31.0                       3171,916 ms        4906,262 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 4999,993 ms       17485,436 ms
Jil-2.1.0                                        2079,768 ms        3969,203 ms
JsonToolkit-4.3.832.1632                        17078,134 ms       17078,069 ms
Nancy-0.23.2.0                                  91497,053 ms       51765,669 ms
NetJSON-1.0.4.2                                  1218,933 ms        3532,376 ms
Newtonsoft.Json-6.0.5.17707                      7329,315 ms       10297,881 ms
protobuf-net-2.0.0.668                           1906,244 ms        3812,469 ms
ServiceStack.Text-4.0.31.0                       4436,592 ms       11563,637 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                        1703,133 ms        5953,157 ms
JsonToolkit-4.3.832.1632                        13578,680 ms       20875,091 ms
Nancy-0.23.2.0                                  82578,816 ms       61671,920 ms
NetJSON-1.0.4.2                                  1108,460 ms        5328,133 ms
Newtonsoft.Json-6.0.5.17707                      6218,816 ms       33548,150 ms
protobuf-net-2.0.0.668                           8297,932 ms       12218,020 ms
ServiceStack.Text-4.0.31.0                       3859,416 ms       16109,420 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 2750,093 ms        8453,110 ms
Jil-2.1.0                                        2514,879 ms        4107,973 ms
JsonToolkit-4.3.832.1632                        11125,047 ms        9937,536 ms
Nancy-0.23.2.0                                  45295,823 ms       30032,345 ms
NetJSON-1.0.4.2                                  1735,283 ms        3390,641 ms
Newtonsoft.Json-6.0.5.17707                      4158,073 ms        5828,140 ms
protobuf-net-2.0.0.668                           1171,869 ms        2187,528 ms
ServiceStack.Text-4.0.31.0                       3781,251 ms        6109,399 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                          FAILED           5375,031 ms
JsonToolkit-4.3.832.1632                        11406,247 ms       11156,265 ms
Nancy-0.23.2.0                                  23376,124 ms       33921,914 ms
NetJSON-1.0.4.2                                  1656,277 ms        3454,017 ms
Newtonsoft.Json-6.0.5.17707                      6015,636 ms        7953,162 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.31.0                       3983,484 ms       17546,071 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 6046,898 ms       20875,348 ms
Jil-2.1.0                                        2468,787 ms        6218,007 ms
JsonToolkit-4.3.832.1632                        23890,638 ms       24250,046 ms
Nancy-0.23.2.0                                 124641,195 ms       75936,758 ms
NetJSON-1.0.4.2                                  1875,003 ms        5969,845 ms
Newtonsoft.Json-6.0.5.17707                      8625,016 ms       13156,258 ms
protobuf-net-2.0.0.668                           1188,597 ms        2062,501 ms
ServiceStack.Text-4.0.31.0                       6890,828 ms       19094,880 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 3469,280 ms       13437,479 ms
Jil-2.1.0                                        1781,975 ms        3640,609 ms
JsonToolkit-4.3.832.1632                        15437,522 ms       14892,409 ms
Nancy-0.23.2.0                                  80766,814 ms       48078,315 ms
NetJSON-1.0.4.2                                  1359,388 ms        4046,881 ms
Newtonsoft.Json-6.0.5.17707                      5140,643 ms        7640,911 ms
protobuf-net-2.0.0.668                           1312,522 ms        2248,962 ms
ServiceStack.Text-4.0.31.0                       4266,389 ms       10296,851 ms
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
