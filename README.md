### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 6546,735 ms        8733,832 ms
Jil-2.1.0                                          FAILED           4079,088 ms
JsonToolkit-4.3.832.1632                        14937,618 ms        9937,121 ms
Nancy-0.23.2.0                                  25141,705 ms       33437,486 ms
NetJSON-1.0.4.2                                  1859,376 ms        3593,368 ms
Newtonsoft.Json-6.0.5.17707                      8047,630 ms        5656,425 ms
ServiceStack.Text-4.0.31.0                       3533,099 ms        9139,867 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 4703,132 ms       17937,519 ms
Jil-2.1.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                  36735,366 ms       57187,509 ms
NetJSON-1.0.4.2                                  1703,120 ms        5296,878 ms
Newtonsoft.Json-6.0.5.17707                      7422,671 ms       13046,139 ms
ServiceStack.Text-4.0.31.0                       4563,420 ms       18094,638 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                        1328,248 ms        1468,683 ms
JsonToolkit-4.3.832.1632                         1562,519 ms        1235,511 ms
Nancy-0.23.2.0                                   2688,436 ms        4671,905 ms
NetJSON-1.0.4.2                                  1172,705 ms        1015,653 ms
Newtonsoft.Json-6.0.5.17707                      1078,488 ms        1250,932 ms
ServiceStack.Text-4.0.31.0                       1532,056 ms        2453,957 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 7812,054 ms       26703,891 ms
Jil-2.1.0                                        3031,237 ms        5891,819 ms
JsonToolkit-4.3.832.1632                        26281,266 ms       26125,629 ms
Nancy-0.23.2.0                                  56282,178 ms       78954,108 ms
NetJSON-1.0.4.2                                  1813,389 ms        5312,504 ms
Newtonsoft.Json-6.0.5.17707                     11733,486 ms       16438,297 ms
ServiceStack.Text-4.0.31.0                       6797,376 ms       18390,480 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                        2923,477 ms        9734,358 ms
JsonToolkit-4.3.832.1632                        22609,391 ms       34954,044 ms
Nancy-0.23.2.0                                  58156,259 ms      102345,205 ms
NetJSON-1.0.4.2                                  1860,413 ms        8656,252 ms
Newtonsoft.Json-6.0.5.17707                     10797,944 ms       55142,303 ms
ServiceStack.Text-4.0.31.0                       6310,889 ms       26954,238 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 1657,147 ms        5157,056 ms
Jil-2.1.0                                        1562,522 ms        2296,895 ms
JsonToolkit-4.3.832.1632                         6765,643 ms        5999,659 ms
Nancy-0.23.2.0                                  11154,803 ms       18219,603 ms
NetJSON-1.0.4.2                                  1048,776 ms        2014,422 ms
Newtonsoft.Json-6.0.5.17707                      2578,157 ms        3640,646 ms
ServiceStack.Text-4.0.31.0                       2265,566 ms        3593,770 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                          FAILED           3468,748 ms
JsonToolkit-4.3.832.1632                         7438,575 ms        7359,383 ms
Nancy-0.23.2.0                                  14999,723 ms       21907,217 ms
NetJSON-1.0.4.2                                  1015,604 ms        2266,592 ms
Newtonsoft.Json-6.0.5.17707                      3892,227 ms        5187,509 ms
ServiceStack.Text-4.0.31.0                       2593,823 ms       11390,617 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 3688,302 ms       13546,785 ms
Jil-2.1.0                                        1532,900 ms        4046,866 ms
JsonToolkit-4.3.832.1632                        15406,257 ms       15532,069 ms
Nancy-0.23.2.0                                  31468,751 ms       48031,420 ms
NetJSON-1.0.4.2                                  1173,299 ms        4079,086 ms
Newtonsoft.Json-6.0.5.17707                      5408,090 ms        8157,031 ms
ServiceStack.Text-4.0.31.0                       4405,454 ms       12235,286 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                 2890,629 ms       11390,949 ms
Jil-2.1.0                                        1500,024 ms        3032,030 ms
JsonToolkit-4.3.832.1632                        13126,021 ms       12455,264 ms
Nancy-0.23.2.0                                  24798,206 ms       39625,523 ms
NetJSON-1.0.4.2                                  1139,696 ms        3469,941 ms
Newtonsoft.Json-6.0.5.17707                      4328,139 ms        6358,553 ms
ServiceStack.Text-4.0.31.0                       3578,116 ms        8828,134 ms
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
