@echo off
echo Converting SVG files to PNGs
echo Warning: Do not use filenames with whitespace!!!

setlocal EnableDelayedExpansion


FOR /F "tokens=*" %%s IN ('dir /s /b .\*.rnc') DO (

	echo =======================================================================
	set FILENAME_PATH_RNC=%%s
	set FILENAME=%%~ns
	set FILENAME_W_EXT=%%~nxs
	::set DIRNAME=!FILENAME_PATH:.rnc=!  No renaming
	set DIRNAME="!FILENAME_PATH_RNC!.holisticware-imagemagick-generated.tmp"
	
	echo FILENAME_PATH_RNC=!FILENAME_PATH_RNC!
	echo FILENAME=!FILENAME!
	echo FILENAME_W_EXT=!FILENAME_W_EXT!
	echo DIRNAME=!DIRNAME!
	echo -----------------------------------------------------------------------
		
	java -jar ^
	.\utils\trang-20081028\trang.jar ^
	-I rnc ^
	-O xsd ^
	!DIRNAME!\!FILENAME_W_EXT! ^
	!DIRNAME!\!FILENAME_W_EXT!.xsd 

	echo =======================================================================
)	
	
pause
	

pause
http://bitworking.org/projects/atom/rfc5023.html#schema
http://www.thaiopensource.com/relaxng/trang-manual.html#rng-input