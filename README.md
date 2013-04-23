WifExamples
===========

The project goal is to provide example code and configuration for Windows Identity Foundation. For all .NET versions there will be:
* Http and https configurations
* Web page and web services
* Servers and clients

Token service
-------------
Windows environments commonly use Active Directory Federation Services (ADFS) in production. To be able to provide a complete, working solution, these projects uses the DummySTS from the WIF SDK. It accepts any user name or password, but provides valid tokens and claims.  

Http vs Https
-------------
Still to come...

Setup
-----
Here are the steps needed to run the examples:
1. Download this repository to your development computer.
2. Install some required certificates, by running the install.bat in the SetupCertificates folder
3. Navigate to the folder matching the .NET version you are using. Open the .sln file in Visual Studio 2010 or 2012.

Further instructions
--------------------
Every NET-folder has a readme.txt with version-specific information.
