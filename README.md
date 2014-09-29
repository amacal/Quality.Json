### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 3848,270 ms        9114,323 ms
Jil-2.1.0                                          FAILED           5380,576 ms
JsonToolkit-4.3.832.1632                        12006,401 ms       10514,603 ms
Nancy-0.23.2.0                                  30044,008 ms       37790,557 ms
NetJSON-1.0.4.2                                  1847,369 ms        5752,650 ms
Newtonsoft.Json-6.0.5.17707                      5768,654 ms        7840,568 ms
ServiceStack.Text-4.0.31.0                       4420,384 ms       10196,039 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 5571,614 ms       17434,486 ms
Jil-2.1.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                  45190,036 ms       72220,441 ms
NetJSON-1.0.4.2                                  1772,855 ms        6963,392 ms
Newtonsoft.Json-6.0.5.17707                      9003,300 ms       15421,084 ms
ServiceStack.Text-4.0.31.0                       5503,601 ms       21466,793 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                        2035,407 ms        1569,814 ms
JsonToolkit-4.3.832.1632                         1482,296 ms        1228,746 ms
Nancy-0.23.2.0                                   3502,200 ms        5078,516 ms
NetJSON-1.0.4.2                                  1218,744 ms        1387,277 ms
Newtonsoft.Json-6.0.5.17707                      1019,204 ms        1258,752 ms
ServiceStack.Text-4.0.31.0                       1830,366 ms        2346,469 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                10783,656 ms       32817,562 ms
Jil-2.1.0                                        3936,787 ms        7982,096 ms
JsonToolkit-4.3.832.1632                        33603,719 ms       33337,666 ms
Nancy-0.23.2.0                                  79377,872 ms      105170,530 ms
NetJSON-1.0.4.2                                  1941,388 ms        8094,619 ms
Newtonsoft.Json-6.0.5.17707                     16003,200 ms       22914,082 ms
ServiceStack.Text-4.0.31.0                       9859,972 ms       22973,594 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                        3635,227 ms       13635,727 ms
JsonToolkit-4.3.832.1632                        28449,189 ms       45565,111 ms
Nancy-0.23.2.0                                  78760,749 ms      134453,385 ms
NetJSON-1.0.4.2                                  1915,383 ms       12699,039 ms
Newtonsoft.Json-6.0.5.17707                     14504,900 ms       74251,347 ms
ServiceStack.Text-4.0.31.0                       8540,708 ms       32882,075 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 3521,204 ms        9398,879 ms
Jil-2.1.0                                        3498,200 ms        4976,495 ms
JsonToolkit-4.3.832.1632                        13642,228 ms       12068,413 ms
Nancy-0.23.2.0                                  26299,759 ms       39844,967 ms
NetJSON-1.0.4.2                                  1960,392 ms        5413,082 ms
Newtonsoft.Json-6.0.5.17707                      5672,134 ms        7689,538 ms
ServiceStack.Text-4.0.31.0                       4886,977 ms        7480,996 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                          FAILED           3929,786 ms
JsonToolkit-4.3.832.1632                         8239,148 ms        8450,690 ms
Nancy-0.23.2.0                                  17776,055 ms       25404,080 ms
NetJSON-1.0.4.2                                  1193,739 ms        2669,534 ms
Newtonsoft.Json-6.0.5.17707                      4735,447 ms        6005,701 ms
ServiceStack.Text-4.0.31.0                       3098,620 ms       11909,882 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 6648,830 ms       20403,580 ms
Jil-2.1.0                                        2370,474 ms        6820,864 ms
JsonToolkit-4.3.832.1632                        25073,014 ms       26228,745 ms
Nancy-0.23.2.0                                  57700,038 ms       82843,065 ms
NetJSON-1.0.4.2                                  1917,383 ms        7083,416 ms
Newtonsoft.Json-6.0.5.17707                      9652,430 ms       14738,947 ms
ServiceStack.Text-4.0.31.0                       8425,185 ms       19419,883 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 6490,298 ms       21960,391 ms
Jil-2.1.0                                        3046,609 ms        6657,331 ms
JsonToolkit-4.3.832.1632                        27138,427 ms       26219,243 ms
Nancy-0.23.2.0                                  56927,883 ms       87172,431 ms
NetJSON-1.0.4.2                                  1926,385 ms        8017,603 ms
Newtonsoft.Json-6.0.5.17707                      9429,386 ms       14679,435 ms
ServiceStack.Text-4.0.31.0                       7955,091 ms       18666,233 ms
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
