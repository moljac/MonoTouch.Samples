
set SCHEMA=^
%ProgramFiles%\Microsoft Visual Studio 10.0\Xml\Schemas\1033\snippetformat.xsd
::http://www.thinktecture.com/resourcearchive/tools-and-software/wscf
:: xsd2code

:: notepad %SCHEMA%

:: Microsoft (R) XSD Inference Command Line Utility V1.0
:: Copyright (C) Microsoft Corporation 1998-2002. All rights reserved.
:: 
:: Infer.exe infers a collection of schemas for xml file(s) and validates the 
:: input xml file(s) against the collection.
:: Usage:
::         Infer [-v] file1 [file2 [... fileN]] [-o schemaName.xsd]
::         -v              - optional, validates the input file(s) against
::                         - the result schema collection
::         file1,...fileN: - one or more xml documents. Infer.exe will infer
::                           the schema collection from the first document
::                           and refine the schema using the rest of
::                           the xml documents.
::         -o schema.xsd:  - optional, name of the file to write schema(s) to.
::                           Infer.exe will create a separate file for each
::                           schema inferred: schema_1.xsd,schema_2.xsd, etc.
:: 

"%ProgramFiles%"\XSDInference\bin\infer.exe ^
	-v ^
	"OData\OData.Service.CompositeC1.xml" ^
	-o OData\OData.Service.CompositeC1.xsd

pause

"%ProgramFiles%"\XSDInference\bin\infer.exe ^
	-v ^
	"%ProgramFiles%"\MonoDevelop\data\options\MonoDevelop-templates.xml ^
	-o MonoDevelop-templates.xsd
	
	
	
pause
call .\cs_classes_from_xsd_with_xsd.exe.bat
call .\cs_classes_from_xsd_with_XsdObjectGen.exe.bat

pause