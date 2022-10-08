## Cinnamon Cinemas Movie Theatre Seating Challenge

This project is to allocate seats to customer. Customer specify their name and number of seats they want. Customer can reserves between 1 to 3 seats.

## How to Run

This system is a Console application, can run using Visual Studio with .Net6.0+

## Example of the user interface:

May I know who is reserving the seat?

Dennis

How many seats do you want to reserve? (1-3 seats)

3

May I know who is reserving the seat?

Skyrah

How many seats do you want to reserve? (1-3 seats)

2

May I know who is reserving the seat?

Elkie

How many seats do you want to reserve? (1-3 seats)

3

May I know who is reserving the seat?

Sean

How many seats do you want to reserve? (1-3 seats)

1

May I know who is reserving the seat?

Peter

How many seats do you want to reserve? (1-3 seats)

2

May I know who is reserving the seat?

Anna

How many seats do you want to reserve? (1-3 seats)

3

May I know who is reserving the seat?

Dan

How many seats do you want to reserve? (1-3 seats)

2


Not enough seats to allocate, remaining seat(s):

C5


Allocated seats are:

A1 for Dennis

A2 for Dennis

A3 for Dennis

A4 for Skyrah

A5 for Skyrah

B1 for Elkie

B2 for Elkie

B3 for Elkie

B4 for Sean

B5 for Peter

C1 for Peter

C2 for Anna

C3 for Anna

C4 for Anna


## Development framework
The system was developed using Test Driven Development framework, starting from the simplest test cases with Arrange, Act and Assert approach to implement the classes. All test cases were starting from a fail case, then write the code to get the case pass and then refactor the code. 

## How to test
To run all test cases, under the solution folder, user can type: dotnet test
Or use the test feature in Visual Studio.

## Assumptions:
1. The program only handle seat allocation, not include purchasing tickets, no pricing information in the program.
2. The number of Row and Column are fixed.
3. All seats are available when start to run the program, no repairing nor blocked seats.
4. The program will leave the remaining seats empty once there are not enough seats available to allocate.
5. This program will not take into account on Cinema, Hall and Movie.
6. Customer will enter their name and number of seats they want to reserve.



