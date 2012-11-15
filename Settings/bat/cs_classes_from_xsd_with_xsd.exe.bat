echo off

call "C:\Program Files\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"
::call "C:\Program Files\Microsoft Visual Studio 9.0\Common7\Tools\vsvars32.bat"

xsd.exe /?

set SCHEMAS=^
	"..\HolisticWare\PropertyList.xsd" 


	
for %%s IN (%SCHEMAS%) DO (
	echo %%s
	xsd.exe ^
		/classes ^
		/language:cs ^
		/namespace:HolisticWare ^
		/outputdir:..\HolisticWare\cs_xsd\ ^
		%%s
)	


pause