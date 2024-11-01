# TicTacToe-CSharp

**Overview**
This is a C# program. It is a console-based imitation of the classic Tic-Tac-Toe Game. This game is played on a 3x3 grid. Two Players, 'X' and 'O', take turns and rotate marking spaces of their choice on the grid. The whole aim of the game is to have three markings in either a row, column or diagonally to win. The first person who reaches this goal, takes the win. The program will continuely give the players options to mark until a player wins.


**Documentation**
**Namespaces and Classes**
1. **Namespace**: TicTacToe
   Contains all classes and method used for the logic of the game

2. **Class**: MainProgram
   The main class for the whole game


**Main Components**
1. **Main Method**: Main(string[] args)
   Initialization of the 3x3 board
   Controls player turns, marking location on board, and the loop of the game
   Check after every turn for win condition


**Methods**
1. **Initialize (char[,] board)**:
   Initializes the 3x3 grid/board by giving each cell in the array blank space (" ")
   - Parameters:
     char[,] board: The 3x3 grid/board array
   Called once at start of game to show visual representation of board

2. **Output(char[,] board)**:
   Displays board in formatted grid (Current State of Board)
   - Parameters:
     Ccar[,] board: The 3x3 grid/board array
   Called after each turn/mark to show updated board

3. **boardchecker(char[,] board, char playerhand, int b1, int b2, int b3, int b4, int b5, int b6)**:
   Checks if conditions for win have been met by a player
   - Parameters:
     char[,] board: The 3x3 grid/board array
     char playerhand: The current player's character ('X' or 'O')
     int b1, b2, b3, b4, b5, b6: Positions on the board array representing pontential win conditions        (row, column, diagonal)
   If win condition is met, program announces the winner and terminates the program


**Variables**

1. **char player**:
   For tracking the character of the current player ('x' or 'O')

2. **char[,] board**:
   3x3 grid/board of characters representing Tic-Tac-Toe board

3. **int runtime**:
   Tracks total number of moves made during the game

4. **bool RUN**:
   Controls game loop. Program to continue running while bool RUN is _true_.

     



   
-
**boardchecker(char[,] board, char playerhand, int b1, int b2, int b3, int b4, int b5, int b6)**
Checks combination entered and returns Victory if order follows rule of tictactoe or does nothing.

-
**Intialize(char[,] board)**
Creates the a 3x3 board

-
**Output(char[,] board)**
Visualization of the 3x3 board in command-line. Does not update.

-
**Main()**
Game runs here. Board is created, visualization of board. Runs till either user wins or the board fills up. Checks if someone won after every try.

-


**Important**:
The code is in **Program.cs** if you didn't know.


**Advise**:
Use parts of my code and write the rest yourself so you learn something too :)

Good Luck! Please Enjoy! 😊
