WifExamples
===========

The project goal is to provide example code and configuration for Windows Identity Foundation. For all .NET versions there are:
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

Windows environments commonly use Active Directory Federation Services (ADFS) in production. To be able to provide a complete, working solution, these projects uses the DummySTS from the WIF SDK. It accepts any user name or password, but provides valid tokens and claims. 

Setup instructions
------------------
See [Sample code installation](https://github.com/nordvall/WifExamples/wiki/Sample-code-installation) in the wiki.

Further instructions
--------------------
The wiki pages have instruction about HTTP vs HTTPS, SAML vs WS-Federation and how to develop your own solutions:
https://github.com/nordvall/WifExamples/wiki/_pages
