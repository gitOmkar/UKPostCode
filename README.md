Solution: UKPostCode
Download the solution on your local machine.
1) Run the Console application folder Debug folder-->UKPostCode.exe
2) Run the unit test project in folder Debug--->UKPostCodeTest.dll

Project: UKPostCodeDescription:This project is an console application developed in C# to validate data against valid UK Post codes.This application works as followed:

 a) Asks the user to input data which application check against the valid UK Post Code and gives output as 'VALID POSTCODE' or 'INVALID POSTCODE'. Note: The logic does not have validation for input data in lower cases.   
 
 b) Next, On the console, the user is the given the option to run the BATCH JOBS by pressing 'Esc' or Continue validating input data against valid UK Postcodes by pressing 'Enter' Key.   
 
 c) If User presses 'Esc' key, 2 BATCH jobs are run. 1 job will process the data in #import_data.csv file in Resources folder, check the validity of postcodes in file and produces the file in Resources folder as failed_validation.csv which will contain all the postcodes data which failed validation.2nd job will process the data in #import_data.csv file in Resources folder, check the validity of postcodes in file and produces the file in Resources folder as succeeded_validation.csv which will contain all the postcodes data which passed validation. As part of BATCH JOBS, application also displays the time to process the data.
 
Project: UKPostCode

TestDescription: This project contains unit tests which validates the test data (series of given postcodes) against the valid postcodes.
Test Data: Test data is initilized as part of project.

Project: UKPostCode
TestDescription: This project contains unit tests which validates the test data (series of given postcodes) against the valid postcodes.
Test Data: Test data is initilized as part of project.
