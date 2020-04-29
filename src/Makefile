# Windows dependencies
# GNU make for Windows http://gnuwin32.sourceforge.net/packages/make.htm
# GNU zip for Windows http://gnuwin32.sourceforge.net/packages/zip.htm
# Doxygen for Windows http://www.stack.nl/~dimitri/doxygen/download.html


.PHONY: all run profile pack clean test 


all: run

run: 
	src\bin\Debug\IVS_Calc_v01.exe

profile: Program.exe
	cd profiling\Odchylka & Program.exe < data.txt

Program.exe:
	cd profiling\Odchylka & csc kniznica.cs Program.cs


PACK_ARCHIVE=xcella01_xhyros00_xsmola08_xduran03.zip

DOC_DIR=doc
INSTALL_DIR=install
REPO_DIR=repo

pack: 	
	if exist "$(DOC_DIR)" del "$(DOC_DIR)" /f /s /q 1>nul & rmdir "$(DOC_DIR)" /s /q
	
	if exist "$(INSTALL_DIR)" del "$(INSTALL_DIR)" /f /s /q 1>nul & rmdir "$(INSTALL_DIR)" /s /q
	
	if exist "$(REPO_DIR)" del "$(REPO_DIR)" /f /s /q 1>nul & rmdir "$(REPO_DIR)" /s /q

	mkdir "$(DOC_DIR)"
	xcopy /s "IVS_Calc_v01\dconfig" "$(DOC_DIR)"

	mkdir "$(INSTALL_DIR)"
	xcopy /s "Instalacka" "$(INSTALL_DIR)"

	mkdir "$(REPO_DIR)"
	make clean

	mkdir "$(PACK_ARCHIVE)" 
	xcopy "$(INSTALL_DIR)" "$(PACK_ARCHIVE)"
	xcopy "$(DOC_DIR)" "$(PACK_ARCHIVE)"
	xcopy "$(REPO_DIR)" "$(PACK_ARCHIVE)"

	del "$(DOC_DIR)" /f /s /q 1>nul
	rmdir "$(DOC_DIR)" /s /q
	del "$(INSTALL_DIR)" /f /s /q 1>nul
	rmdir "$(INSTALL_DIR)" /s /q
	del "$(REPO_DIR)" /f /s /q 1>nul
	rmdir "$(REPO_DIR)" /s /q
	

test: 
	cd dotnet_tests\Math_Tests & dotnet test

clean:
#rm -f kalkulacka/*.*



