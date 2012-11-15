@echo off

setlocal EnableDelayedExpansion 

call "C:\Program Files\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"
::call "C:\Program Files\Microsoft Visual Studio 9.0\Common7\Tools\vsvars32.bat"

"%ProgramFiles%\Xsd2Code\Xsd2Code.exe" 

set SCHEMAS=^
	"D:\SRC\Core_2011\Core.DLL_121_BL_XML_XSLT_XSD_POCOs\OData\OData.Service.CompositeC1.xsd" ^
	"%ProgramFiles%\MSBuild\Novell\android-layout-xml.xsd" ^
	"%ProgramFiles%\Microsoft Visual Studio 10.0\Xml\Schemas\xaml2006.xsd" ^
	"%ProgramFiles%\Microsoft Visual Studio 10.0\Xml\Schemas\wpfe.xsd" ^


	
for %%s IN (%SCHEMAS%) DO (
	echo %%s
	set FILENAME=%%~nxs
	echo !FILENAME!

	xcopy /y /q %%s .\
	"%ProgramFiles%\Xsd2Code\Xsd2Code.exe" ^
		!FILENAME! ^
		HolisticWare.XSD ^
		!FILENAME! ^
		/output !FILENAME!

pause
)	


pause


