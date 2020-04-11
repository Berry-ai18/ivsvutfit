# Provizorny makefile
# Treba vediet,kde su vsetky zdrojove subory a hlavickove subory
# Najlepsie je aby boli v jednom adresari
# Nie vhodne pre C#

objects = main.o file.o math.o ui.o profiling.o

# prelozi projekt
all : $(objects)
	cc -o edit $(objects)

# zabali projekt aby mohol byt odovzdany
pack : 

main.o : main.c main.h
	cc -c main.c
file.o : file.c file.h
	cc -c file.c 
math.o : math.c mathlibs.h
	cc -c math.c
ui.o : ui.c ui.h
	cc -c ui.c

profiling.o : profiling.cs 
	cc -c profiling.cs

run : projekt.csproj
	cc -c projekt.csproj

# Spusti generovanie dokumentacie
doc : docum.cs 
	cc -c docum.cs

# Spusti testy matematickej knihovne
test : unit_math_tests.cs math_lib.cs
	cc -c unit_math_tests.cs

# zmaze vsetky subory,ktore nemaju byt odovzdane
clean : 
	rm edit $(objects)