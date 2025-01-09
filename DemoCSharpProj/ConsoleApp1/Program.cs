using System;

public class Program
{
    static void printBoard(String[,] b) {
        Console.WriteLine("*****************");
        for(int y = 0; y < 5; y++) {
            for(int x = 0; x < 5; x++) {
                Console.Write(b[x, y] + " ");
            }
            Console.Write("\n");
        }
        Console.WriteLine("*****************");
    }

    static void Main(string[] args)
    {
        /*
        for(int i = 0; i < 10; i++) {
            Console.WriteLine("Hello World!");
        }
        */

        /*
        Console.Write("What's your name? ");
        String a = Console.ReadLine();
        Console.WriteLine(a + " is a fake name. You mus think I am a bot. I promise I am real.");
        */
        //float x = 3.0f;


        Random rgen = new Random();
        /*
        for(int i = 0; i < 100; i++) {
            //Console.WriteLine(rgen.Next(1, 4));
        }
        */
        int r = rgen.Next(0, 2);
        if(r == 0) {
            Console.WriteLine("Heads");
        }
        else {
            Console.WriteLine("Tails");
        }

        int[] nums = new int[5];
        nums[2] = 121342;
        for(int i = 0; i < 5; i++) {
            //Console.WriteLine(nums[i]);
        }
        
        //2D Array of strings
        String[,] board = new String[5,5];
        for(int y = 0; y < 5; y++) {
            for(int x = 0; x < 5; x++) {
                board[x, y] = ".";
            }
        }
        //board[0, 0] = "A";
        //board[1, 0] = "B";
        printBoard(board);

        Point playerPos = new Point(0, 0);
        board[playerPos.x, playerPos.y] = "P";
        printBoard(board);
        Point up = new Point(0, -1);
        Point down = new Point(0, 1);
        Point right = new Point(1, 0);
        Point left = new Point(-1, 0);

        //move player 
        board[playerPos.x, playerPos.y] = "."; //erase old
        Point temp = playerPos.add(up); //change pos
        if(board[temp.x, temp.y] == "*") {

        }
        else {
            playerPos = temp;
        }
        board[playerPos.x, playerPos.y] = "P"; //write new
    }
}
