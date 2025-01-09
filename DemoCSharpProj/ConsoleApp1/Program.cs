using System;

public class Program
{
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
        float x = 3.0f;

        Random rgen = new Random();
        for(int i = 0; i < 100; i++) {
            //Console.WriteLine(rgen.Next(1, 4));
        }

        int[] nums = new int[5];
        nums[2] = 121342;
        for(int i = 0; i < 5; i++) {
            Console.WriteLine(nums[i]);
        }

        // Example Change.



    }
}
