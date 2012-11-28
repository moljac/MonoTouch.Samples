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
	set FILENAME="%%~nxs:
	SET FILENAME_WO_EXT=%FILENAME:.xsd=%
	echo FILENAME       =!FILENAME!
	echo FILENAME_WO_EXT=!FILENAME_WO_EXT!

	"%ProgramFiles%\XSDObjectGenerator\XSDObjectGen.exe" ^
		%%s ^
		/c ^
		/p ^
		/d ^
		/l:cs ^
		/n:HolisticWare

)	


pause
