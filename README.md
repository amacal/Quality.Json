### JSON Benchmarks

The project aims at doing automated benchmarks of available JSON libraries.

### Results

````
Case: Congress
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  347,662 ms         377,301 ms
Jil-2.1.0                                          FAILED            187,816 ms
JsonToolkit-4.3.832.1632                          634,885 ms         424,811 ms
Nancy-0.23.2.0                                   1141,591 ms        1465,850 ms
NetJSON-1.0.4.2                                    90,011 ms         158,338 ms
Newtonsoft.Json-6.0.5.17707                       408,149 ms         249,056 ms
ServiceStack.Text-4.0.31.0                        179,997 ms         405,228 ms
-------------------------------------------------------------------------------


Case: Glossary
Requirements: case-insensitive

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  173,837 ms         658,396 ms
Jil-2.1.0                                          -- --- --          -- --- --
JsonToolkit-4.3.832.1632                           -- --- --          -- --- --
Nancy-0.23.2.0                                   1300,680 ms        2076,266 ms
NetJSON-1.0.4.2                                    64,495 ms         198,370 ms
Newtonsoft.Json-6.0.5.17707                       302,879 ms         449,224 ms
ServiceStack.Text-4.0.31.0                        163,118 ms         667,087 ms
-------------------------------------------------------------------------------


Case: Jobs
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                        1465,818 ms        1658,197 ms
JsonToolkit-4.3.832.1632                         1785,152 ms        1401,433 ms
Nancy-0.23.2.0                                   3059,567 ms        5235,350 ms
NetJSON-1.0.4.2                                  1357,540 ms        1184,607 ms
Newtonsoft.Json-6.0.5.17707                      1280,285 ms        1478,102 ms
ServiceStack.Text-4.0.31.0                       1699,218 ms        2842,224 ms
-------------------------------------------------------------------------------


Case: Menu
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  268,566 ms         991,465 ms
Jil-2.1.0                                         144,733 ms         227,659 ms
JsonToolkit-4.3.832.1632                          928,742 ms         915,055 ms
Nancy-0.23.2.0                                   2023,480 ms        2869,586 ms
NetJSON-1.0.4.2                                   103,806 ms         181,627 ms
Newtonsoft.Json-6.0.5.17707                       452,313 ms         579,301 ms
ServiceStack.Text-4.0.31.0                        235,566 ms         627,139 ms
-------------------------------------------------------------------------------


Case: Number
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                         105,586 ms         333,004 ms
JsonToolkit-4.3.832.1632                          595,839 ms         925,256 ms
Nancy-0.23.2.0                                   1587,954 ms        2674,003 ms
NetJSON-1.0.4.2                                    47,914 ms         213,111 ms
Newtonsoft.Json-6.0.5.17707                       274,384 ms        1447,482 ms
ServiceStack.Text-4.0.31.0                        158,535 ms         721,163 ms
-------------------------------------------------------------------------------


Case: Row
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  187,501 ms         621,147 ms
Jil-2.1.0                                         195,307 ms         284,252 ms
JsonToolkit-4.3.832.1632                          802,862 ms         678,104 ms
Nancy-0.23.2.0                                   1327,218 ms        2168,980 ms
NetJSON-1.0.4.2                                   133,964 ms         232,402 ms
Newtonsoft.Json-6.0.5.17707                       320,108 ms         408,205 ms
ServiceStack.Text-4.0.31.0                        277,526 ms         405,376 ms
-------------------------------------------------------------------------------


Case: Twitter
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                   FAILED             FAILED
Jil-2.1.0                                          FAILED           2094,704 ms
JsonToolkit-4.3.832.1632                         4620,202 ms        4275,443 ms
Nancy-0.23.2.0                                   8711,037 ms       12566,481 ms
NetJSON-1.0.4.2                                   621,436 ms        1252,910 ms
Newtonsoft.Json-6.0.5.17707                      2251,015 ms        2991,212 ms
ServiceStack.Text-4.0.31.0                       1521,519 ms        6480,491 ms
-------------------------------------------------------------------------------


Case: Weather
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  266,613 ms         943,348 ms
Jil-2.1.0                                         126,649 ms         296,022 ms
JsonToolkit-4.3.832.1632                         1026,353 ms        1082,058 ms
Nancy-0.23.2.0                                   2232,023 ms        3261,780 ms
NetJSON-1.0.4.2                                    82,174 ms         247,814 ms
Newtonsoft.Json-6.0.5.17707                       368,282 ms         559,748 ms
ServiceStack.Text-4.0.31.0                        317,365 ms         840,852 ms
-------------------------------------------------------------------------------


Case: Widget
Requirements: none

-------------------------------------------------------------------------------
Name                                           Serialization    Deserialization
-------------------------------------------------------------------------------
fastJSON-2.1.3.0                                  217,008 ms         790,025 ms
Jil-2.1.0                                         131,054 ms         217,778 ms
JsonToolkit-4.3.832.1632                          865,269 ms         814,198 ms
Nancy-0.23.2.0                                   1639,850 ms        2692,532 ms
NetJSON-1.0.4.2                                    77,210 ms         223,862 ms
Newtonsoft.Json-6.0.5.17707                       356,500 ms         413,280 ms
ServiceStack.Text-4.0.31.0                        234,597 ms         574,230 ms
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
