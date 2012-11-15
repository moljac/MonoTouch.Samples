::echo off

:: http://www.microsoft.com/download/en/details.aspx?displaylang=en&id=7075

call "%ProgramFiles%\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"

set SCHEMAS=^
	"D:\SRC\Core_2011\Core.DLL_121_BL_XML_XSLT_XSD_POCOs\OData\OData.Service.CompositeC1.xsd" ^
	"%ProgramFiles%\MSBuild\Novell\android-layout-xml.xsd" ^
	"%ProgramFiles%\Microsoft Visual Studio 10.0\Xml\Schemas\xaml2006.xsd" ^
	"%ProgramFiles%\Microsoft Visual Studio 10.0\Xml\Schemas\wpfe.xsd" ^


	
for %%s IN (%SCHEMAS%) DO (
echo %%s
"%ProgramFiles%\XSDObjectGenerator\XSDObjectGen.exe" ^
		%%s ^
		/c ^
		/p ^
		/d ^
		/l:cs ^
		/n:HolisticWare

pause
)	


pause



::	set I1=%EBAY_COM%%%i
::	set I2=!EBAY_DE!%%i
::	set I3=%CL_C%%%i
::	set I4=%CL_I%%%i
::
::	echo I1=!I1!
::	echo I2=!I2!
::	echo I3=!I3!
::	echo I4=!I4!
::
::	set I_ALL=!I_ALL! !I1! !I2! !I3! !I4!