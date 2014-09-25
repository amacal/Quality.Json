### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   85,948 ms         215,836 ms
Jil-2.1.0                                          FAILED            116,209 ms
JsonToolkit-4.3.832.1632                          249,999 ms         243,160 ms
Nancy-0.23.2.0                                    575,202 ms         812,500 ms
NetJSON-1.0.4.2                                    43,949 ms          93,747 ms
Newtonsoft.Json-6.0.5.17707                       110,323 ms         144,519 ms
ServiceStack.Text-4.0.31.0                         92,781 ms         218,759 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   97,653 ms         394,537 ms
Jil-2.1.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                    733,419 ms        1134,760 ms
NetJSON-1.0.4.2                                    29,293 ms         107,639 ms
Newtonsoft.Json-6.0.5.17707                       143,559 ms         284,187 ms
ServiceStack.Text-4.0.31.0                         93,750 ms         338,870 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                        2381,835 ms        2088,657 ms
JsonToolkit-4.3.832.1632                         2161,116 ms        1839,859 ms
Nancy-0.23.2.0                                   4523,438 ms        6879,890 ms
NetJSON-1.0.4.2                                  1824,230 ms        1718,750 ms
Newtonsoft.Json-6.0.5.17707                      1306,644 ms        1687,488 ms
ServiceStack.Text-4.0.31.0                       2332,023 ms        3283,196 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  152,337 ms         619,131 ms
Jil-2.1.0                                          60,542 ms         113,275 ms
JsonToolkit-4.3.832.1632                          512,696 ms         507,774 ms
Nancy-0.23.2.0                                   1138,723 ms        1572,103 ms
NetJSON-1.0.4.2                                    35,159 ms         109,377 ms
Newtonsoft.Json-6.0.5.17707                       228,532 ms         336,918 ms
ServiceStack.Text-4.0.31.0                        136,697 ms         333,983 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   99,613 ms         328,148 ms
Jil-2.1.0                                          95,697 ms         144,533 ms
JsonToolkit-4.3.832.1632                          394,531 ms         369,140 ms
Nancy-0.23.2.0                                    733,402 ms        1166,009 ms
NetJSON-1.0.4.2                                    68,361 ms         137,695 ms
Newtonsoft.Json-6.0.5.17707                       151,362 ms         254,880 ms
ServiceStack.Text-4.0.31.0                        135,741 ms         211,913 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  145,506 ms         542,966 ms
Jil-2.1.0                                          58,597 ms         155,271 ms
JsonToolkit-4.3.832.1632                          524,414 ms         611,320 ms
Nancy-0.23.2.0                                   1180,662 ms        1870,119 ms
NetJSON-1.0.4.2                                    45,885 ms         149,424 ms
Newtonsoft.Json-6.0.5.17707                       209,987 ms         339,841 ms
ServiceStack.Text-4.0.31.0                        203,874 ms         443,389 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  107,421 ms         446,286 ms
Jil-2.1.0                                          54,687 ms         124,023 ms
JsonToolkit-4.3.832.1632                          469,721 ms         492,191 ms
Nancy-0.23.2.0                                    939,460 ms        1497,076 ms
NetJSON-1.0.4.2                                    42,011 ms         132,865 ms
Newtonsoft.Json-6.0.5.17707                       169,920 ms         252,935 ms
ServiceStack.Text-4.0.31.0                        128,907 ms         318,362 ms
-------------------------------------------------------------------------------


Remarks:

# Object reference not set to an instance of an object.
# Unable to cast object of type 'System.Object[]' to type 'Quality.Json.Performa
nce.Resources.Job[]'.
# Unable to cast object of type 'System.Object[]' to type 'Quality.Json.Performa
nce.Resources.Job[]'.
````
