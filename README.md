### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  298,246 ms         345,048 ms
Jil-2.1.0                                          FAILED            172,526 ms
JsonToolkit-4.3.832.1632                          610,874 ms         407,231 ms
Nancy-0.23.2.0                                   1094,178 ms        1358,858 ms
NetJSON-1.0.4                                      79,065 ms         142,883 ms
Newtonsoft.Json-6.0.5.17707                       391,415 ms         233,617 ms
ServiceStack.Text-4.0.31.0                        188,268 ms         375,795 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  190,191 ms         639,824 ms
Jil-2.1.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                   1220,106 ms        1890,651 ms
NetJSON-1.0.4                                      48,805 ms         188,328 ms
Newtonsoft.Json-6.0.5.17707                       297,988 ms         468,759 ms
ServiceStack.Text-4.0.31.0                        157,176 ms         578,586 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                        6766,610 ms        7592,208 ms
JsonToolkit-4.3.832.1632                         8078,117 ms        6609,404 ms
Nancy-0.23.2.0                                  13875,394 ms       24531,380 ms
NetJSON-1.0.4                                    6376,553 ms          FAILED
Newtonsoft.Json-6.0.5.17707                      5703,910 ms        6750,011 ms
ServiceStack.Text-4.0.31.0                       7938,499 ms       12922,935 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  249,591 ms         922,686 ms
Jil-2.1.0                                         141,751 ms         219,587 ms
JsonToolkit-4.3.832.1632                          907,055 ms         862,214 ms
Nancy-0.23.2.0                                   1937,653 ms        2796,916 ms
NetJSON-1.0.4                                      63,842 ms         187,728 ms
Newtonsoft.Json-6.0.5.17707                       437,384 ms         562,495 ms
ServiceStack.Text-4.0.31.0                        250,973 ms         624,993 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  171,876 ms         562,479 ms
Jil-2.1.0                                         188,140 ms         283,029 ms
JsonToolkit-4.3.832.1632                          796,929 ms         639,760 ms
Nancy-0.23.2.0                                   1218,754 ms        1969,746 ms
NetJSON-1.0.4                                     125,724 ms         219,870 ms
Newtonsoft.Json-6.0.5.17707                       298,403 ms         390,481 ms
ServiceStack.Text-4.0.31.0                        265,650 ms         390,617 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  267,686 ms         890,618 ms
Jil-2.1.0                                         140,391 ms         280,267 ms
JsonToolkit-4.3.832.1632                          970,002 ms        1000,355 ms
Nancy-0.23.2.0                                   2015,651 ms        3063,988 ms
NetJSON-1.0.4                                      78,024 ms         265,625 ms
Newtonsoft.Json-6.0.5.17707                       344,682 ms         516,545 ms
ServiceStack.Text-4.0.31.0                        296,882 ms         749,057 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  202,318 ms         767,510 ms
Jil-2.1.0                                         140,278 ms         204,556 ms
JsonToolkit-4.3.832.1632                          845,822 ms         829,051 ms
Nancy-0.23.2.0                                   1576,783 ms        2547,827 ms
NetJSON-1.0.4                                      62,561 ms         203,669 ms
Newtonsoft.Json-6.0.5.17707                       296,102 ms         406,297 ms
ServiceStack.Text-4.0.31.0                        203,145 ms         547,489 ms
-------------------------------------------------------------------------------


Remarks:

# Object reference not set to an instance of an object.
# Unable to cast object of type 'System.Object[]' to type 'Quality.Json.Performa
nce.Resources.Job[]'.
# Unable to cast object of type 'System.Object[]' to type 'Quality.Json.Performa
nce.Resources.Job[]'.
# Input string was not in a correct format.
````

