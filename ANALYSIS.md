Solution: UKPostCode
Project: UKPostCode, UKPostCodeTest

Note1: Regular Expression supplied does not validate all the post codes cases.
For Example: 

*Input data in small letters are ot validated correctly.

*Input data that has random beginning and end and only contains valid post code as a substring, are not validated correctly.

*Areas with a district '0' (zero): BL, BS, CM, CR, FY, HA, PR, SL, SS (BS is the only area to have both a district 0 and a district 10). are not validated.

Note: I have included the correct regular expression which validates the beginging and end of the input string also but have commented this out in order to stick to give regular expression.

Note2: Performance: Given regular expressions does not include Anchors (start and beginning validation). 
       When start and beginning anchors (^,$) are introduced in regular expression, postcode validation can be correctly realized. 
       But the performance of validation check depends on input data. Non-Matching cases are better in performance by around 100% when 
       anchors are used. Matching cases validation is faster when no anchors are used. This  performance can be mesaured using diagnostic 
       timer in the code. However, since input_data supplied contains far more matching cases perfromance is better by 75% if no anchors are used.
