@echo off

setlocal EnableDelayedExpansion 

call "C:\Program Files\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"
::call "C:\Program Files\Microsoft Visual Studio 9.0\Common7\Tools\vsvars32.bat"

"%ProgramFiles%\Xsd2Code\Xsd2Code.exe" 

set SCHEMAS=^
	"..\HolisticWare\PropertyList.xsd" 


	
for %%s IN (%SCHEMAS%) DO (
	echo %%s
	set FILENAME="%%~nxs:
	SET FILENAME_WO_EXT=%FILENAME:.xsd=%
	echo FILENAME       =!FILENAME!
	echo FILENAME_WO_EXT=!FILENAME_WO_EXT!

	xcopy /y /q %%s .\
	"%ProgramFiles%\Xsd2Code\Xsd2Code.exe" ^
		!FILENAME! ^
		HolisticWare.XSD ^
		!FILENAME! ^
		/output ..\HolisticWare\!FILENAME!.xsd2code.cs
)	


pause


