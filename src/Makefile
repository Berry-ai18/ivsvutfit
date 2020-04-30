# Windows dependencies
# GNU make for Windows http://gnuwin32.sourceforge.net/packages/make.htm
# GNU zip for Windows http://gnuwin32.sourceforge.net/packages/zip.htm
# Doxygen for Windows http://www.stack.nl/~dimitri/doxygen/download.html


.PHONY: all run profile pack clean test 


all: run

run: 
	zdrojove_kody\bin\Debug\IVS_Calc_v01.exe

profile: Program.exe
	cd profiling & profiling.exe < data.txt

Program.exe:
	cd profiling & csc profiling.cs kniznica.cs

ROOT_DIR:=$(shell cd)\..
PACK_ARCHIVE=xcella01_xhyros00_xsmola08_xduran03.zip

DOC_DIR=doc\html
INSTALL_DIR=install
MOCKUP=mockup
REPO_DIR=$(ROOT_DIR)\..\git

pack: 

	 cd .. & mkdir "$(PACK_ARCHIVE)" & xcopy "$(INSTALL_DIR)" "$(PACK_ARCHIVE)" & xcopy "$(DOC_DIR)" "$(PACK_ARCHIVE)" & xcopy "$(REPO_DIR)" "$(PACK_ARCHIVE)"

	
test: 
	cd dotnet_tests\Math_Tests & dotnet test

clean:
	cd .. & cd .. & del "$(REPO_DIR)" /f /s /q 1>nul & rmdir "$(REPO_DIR)" /s /q



