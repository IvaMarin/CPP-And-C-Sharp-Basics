CC = g++
BIN = main

all: $(BIN)

$(BIN): lib.o lesson.o
	$(CC) lesson.o lib.o -o $(BIN)

lib.o: lib.cpp lib.hpp
	$(CC) lib.cpp -c

lesson.o: lesson.cpp
	$(CC) lesson.cpp -c

clean:
	rm -f *.o $(BIN)