# Provizorny makefile
# Treba vediet,kde su vsetky zdrojove subory a hlavickove subory
# Najlepsie je aby boli v jednom adresari
# Nie vhodne pre C#

SOURCE_FILES = $(wildcard *.cs)

TEST_FILES = unit_math_tests.cs TheClassToTest.cs

PROFILE_FILES = kniznica.cs Math_lib.cs Smerodatna_Odchylka.cs 

MATH_FILES = kniznica.cs

DOC_FILES = # doplni sa subor dokumentacie

CSHARP_COMPILER = mcs

CSHARP_FLAGS = -out



# prelozi projekt
all : $(SOURCE_FILES)

$(EXECUTABLE) : $(CSHARP_FILES)
	@ $(CSHARP_COMPILER) $(CSHARP_FILES) $(CSHARP_FLAGS)

run : $(SOURCE_FILES)
	@ $(CSHARP_COMPILER) $(SOURCE_FILES) $(CSHARP_FLAGS)

# zabali projekt aby mohol byt odovzdany
pack : 


# vypocet smerodatnej odchylky
profile : $(PROFILE_FILES)
	@ $(CSHARP_FILES) $(PROFILE_FILES) $(CSHARP_FLAGS)

# spusti program
run : all
	./$(SOURCE_FILES)

# Spusti generovanie dokumentacie
doc : docum.cs 
	cc -c docum.cs

# Spusti testy matematickej knihovne
test : $(TEST_FILES)
	@ $(CSHARP_COMPILER) $(TEST_FILES) $(CSHARP_FILES)

# zmaze vsetky subory,ktore nemaju byt odovzdane
clean : 
	rm edit $(SOURCE_FILES) $(TEST_FILES) $(PROFILE_FILES) $(MATH_FILES) $(DOC_FILES)