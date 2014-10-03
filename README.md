### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: empty-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 4248,733 ms        5702,372 ms
Jayrock.Json-0.9.16530.2159                      7640,613 ms       24516,417 ms
Jil-2.1.0                                          FAILED           2656,267 ms
JsonToolkit-4.3.832.1632                         9437,731 ms        6437,503 ms
Nancy-0.23.2.0                                  16201,505 ms       21343,689 ms
NetJSON-1.0.4.2                                  1172,946 ms        2343,725 ms
Newtonsoft.Json-6.0.5.17707                      5187,726 ms        3578,210 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.31.0                       2296,867 ms        5795,662 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 4126,128 ms       15047,639 ms
Jayrock.Json-0.9.16530.2159                     74655,455 ms      160218,194 ms
Jil-2.1.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                  76608,318 ms       48297,439 ms
NetJSON-1.0.4.2                                  1546,868 ms        4531,264 ms
Newtonsoft.Json-6.0.5.17707                      6124,962 ms       11015,645 ms
protobuf-net-2.0.0.668                           1969,809 ms        3266,459 ms
ServiceStack.Text-4.0.31.0                       3890,639 ms       15141,502 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                      6015,641 ms        8030,799 ms
Jil-2.1.0                                        2796,883 ms        3046,883 ms
JsonToolkit-4.3.832.1632                         3203,349 ms        2623,570 ms
Nancy-0.23.2.0                                   8640,851 ms        9842,748 ms
NetJSON-1.0.4.2                                  2546,819 ms        2108,316 ms
Newtonsoft.Json-6.0.5.17707                      2266,838 ms        2594,504 ms
protobuf-net-2.0.0.668                           1375,816 ms        1921,838 ms
ServiceStack.Text-4.0.31.0                       3297,011 ms        4968,621 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 4671,859 ms       16343,647 ms
Jayrock.Json-0.9.16530.2159                     64765,448 ms      144343,271 ms
Jil-2.1.0                                        1952,109 ms        3765,619 ms
JsonToolkit-4.3.832.1632                        15719,659 ms       15766,902 ms
Nancy-0.23.2.0                                  85470,022 ms       48655,280 ms
NetJSON-1.0.4.2                                  1218,751 ms        3422,151 ms
Newtonsoft.Json-6.0.5.17707                      7093,699 ms        9705,157 ms
protobuf-net-2.0.0.668                           1812,536 ms        3531,272 ms
ServiceStack.Text-4.0.31.0                       4140,606 ms       10937,969 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                     29712,207 ms       97078,009 ms
Jil-2.1.0                                        1781,277 ms        6000,984 ms
JsonToolkit-4.3.832.1632                        13734,292 ms       21203,065 ms
Nancy-0.23.2.0                                  82922,370 ms       63124,764 ms
NetJSON-1.0.4.2                                  1204,101 ms        5329,355 ms
Newtonsoft.Json-6.0.5.17707                      6248,483 ms       35578,717 ms
protobuf-net-2.0.0.668                           8405,273 ms       12156,635 ms
ServiceStack.Text-4.0.31.0                       3841,868 ms       16234,800 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 3531,230 ms       10640,564 ms
Jayrock.Json-0.9.16530.2159                     39875,759 ms       68109,921 ms
Jil-2.1.0                                        2875,989 ms        4718,583 ms
JsonToolkit-4.3.832.1632                        13984,322 ms       12531,190 ms
Nancy-0.23.2.0                                  56749,800 ms       37953,027 ms
NetJSON-1.0.4.2                                  2234,421 ms        4391,818 ms
Newtonsoft.Json-6.0.5.17707                      5547,809 ms        7751,438 ms
protobuf-net-2.0.0.668                           1375,042 ms        2765,326 ms
ServiceStack.Text-4.0.31.0                       4791,043 ms        7766,547 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: jagged-array

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jayrock.Json-0.9.16530.2159                        FAILED          66797,428 ms
Jil-2.1.0                                          FAILED           5453,110 ms
JsonToolkit-4.3.832.1632                        11671,813 ms       11374,928 ms
Nancy-0.23.2.0                                  23155,343 ms       34312,474 ms
NetJSON-1.0.4.2                                  1593,761 ms        3578,880 ms
Newtonsoft.Json-6.0.5.17707                      6453,126 ms        8031,254 ms
protobuf-net-2.0.0.668                             -- --- --          -- --- --
ServiceStack.Text-4.0.31.0                       4126,986 ms       17718,719 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 6062,791 ms       20954,267 ms
Jayrock.Json-0.9.16530.2159                     51593,540 ms      138265,108 ms
Jil-2.1.0                                        2281,242 ms        6297,658 ms
JsonToolkit-4.3.832.1632                        24453,800 ms       24641,393 ms
Nancy-0.23.2.0                                 124889,355 ms       76968,512 ms
NetJSON-1.0.4.2                                  2014,884 ms        6030,403 ms
Newtonsoft.Json-6.0.5.17707                      8641,409 ms       13389,476 ms
protobuf-net-2.0.0.668                           1188,455 ms        2109,483 ms
ServiceStack.Text-4.0.31.0                       6890,634 ms       19735,093 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 3529,066 ms       13795,968 ms
Jayrock.Json-0.9.16530.2159                     70122,764 ms      132999,552 ms
Jil-2.1.0                                        1889,220 ms        3751,813 ms
JsonToolkit-4.3.832.1632                        15531,326 ms       15156,230 ms
Nancy-0.23.2.0                                  81562,934 ms       47984,226 ms
NetJSON-1.0.4.2                                  1328,128 ms        4203,142 ms
Newtonsoft.Json-6.0.5.17707                      5171,914 ms        7750,508 ms
protobuf-net-2.0.0.668                           1328,207 ms        2296,444 ms
ServiceStack.Text-4.0.31.0                       4329,197 ms       10421,861 ms
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
# Cannot import Quality.Json.Performance.Resources.Twitter+Attributes from a JSO
N String value.
# Object reference not set to an instance of an object.
````
