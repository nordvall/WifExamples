WifExamples
===========

The project goal is to provide example code and configuration for Windows Identity Foundation. For all .NET versions there will be:
* Http and https configurations
* Web page and web services
* Servers and clients

Solution contents
-----------------
All server projects has the same contents:
* A web site with two pages:
  * Default.aspx - Open for all authenicated users. Displays all claims received from the STS.
  * Managers.aspx - Restricted to users in the "Manager" role
* A web service with two methods:
  * WhoAmI() - Open for all authenicated users. Returns the user's name, as provided by the STS.
  * RestrictedMethod() - restricted to users in the "Manager" role

All client project contains a console application, that calls the WCF service methods.

Setup
-----
Here are the steps needed to run the examples:
1. Download this repository to your development computer.
2. Install some required certificates, by running the install.bat in the SetupCertificates folder
3. Navigate to the folder matching the .NET version you are using. Open the .sln file in Visual Studio 2010 or 2012.

Token service
-------------
Windows environments commonly use Active Directory Federation Services (ADFS) in production. To be able to provide a complete, working solution, these projects uses the DummySTS from the WIF SDK. It accepts any user name or password, but provides valid tokens and claims.  

Protocols
---------
WIF uses the following protocols for claims authentication:
* Browser authentication: WS-Federation with SAML 1.1 tokens
* Web services: WS-Trust to obtain SAML 1.1 tokens and WS-Security to embed the tokens into the SOAP requests.

Http vs Https
-------------
Still to come...


Further instructions
--------------------
Every NET-folder has a readme.txt with version-specific information.
