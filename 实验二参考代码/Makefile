main:mytool1.o mytool2.o main.o
	gcc mytool1.o mytool2.o main.o -o main
main.o:main.c ./functions/mytool1.h ./functions/mytool2.h
	gcc -c main.c -o main.o -I functions
mytool1.o:./functions/mytool1.c ./functions/mytool1.h
	gcc -c ./functions/mytool1.c -o mytool1.o
mytool2.o:./functions/mytool2.c ./functions/mytool2.h
	gcc -c ./functions/mytool2.c -o mytool2.o
clean:
	rm -rf *.o main
