WIF Examples for .NET 3.5
=========================

This project contains Windows Identity Foundation example code and configuration for .NET 3.5.
It has servers and clients for http and https.

System requirements to run the code:
------------------------------------
* Visual Studio 2010 or 2012
* IIS Express (for HTTPS support)

To run the code
---------------
* Run install.bat from the SetupCertificates folder. The script will install the necessary test certificates on your computer.
* Open the solution in Visual Studio. 
* Right click on the solution and select "Set startup projects".
* Select "Multiple startup projects" and set at least "DummySTS" and one of the server projects to "Start". 
* Run the code by pressing F5.

Access checking
---------------
Access checking in .NET 3.5 is made as follows:
* Web pages is protected by <authorization> declarations in web.config
* Web services is protected by [PrincipalPermission] attributes on the web service method.

Developing your own solutions
-----------------------------
Your server side code needs a reference to Microsoft.IdentityModel.dll from Windows Identity Foundation. You can get it in the following ways:
* By adding "Windows Identity Foundation" to your project from NuGet
* By downloading and installing "Windows Identity Foundation" from download.microsoft.com
* By copying it from this project.

Client side code does not need any WIF components.

Official SDK
------------
There is a "Windows Identity Foundation SDK" available on download.microsoft.com. The SDK includes the WIF assemblies, as well as:
* Some project items for Visual Studio, i.e. "Claims enabled web site" and "Claims enabled WCF service".
* A configuration wizard, sometimes called FedUtil.exe. It can enable claims authentication in an existing web project.

