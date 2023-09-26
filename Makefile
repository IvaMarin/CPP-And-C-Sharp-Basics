CC=g++
BIN = main

$(BIN): lib.o lesson.o
	$(CC) lesson.o lib.o -o $(BIN)

lib.o: lib.cpp
	$(CC) lib.cpp -c

lesson.o: lesson.cpp
	$(CC) lesson.cpp -c

clean:
	rm *.o $(BIN)