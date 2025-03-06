// See https://aka.ms/new-console-template for more information


// // Take an array and reverse the contents of it. 
// int[] GenerateNumbers(int n)
// {
//     Random rnd = new Random();
//     return Enumerable.Range(1, n).Select(i => rnd.Next(1, n + 1)).ToArray();
// }
//
// void Reverse(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
// }
//
// void PrintNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//         if (i < array.Length - 1)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.WriteLine();
// }
//
// int[] numbers = GenerateNumbers(10);
// PrintNumbers(numbers);
// Reverse(numbers);
// PrintNumbers(numbers);


// // The Fibonacci sequence. 
// int Fibonacci(int n)
// {
//     if (n <= 2)
//     {
//         return 1;
//     }
//     return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
//
// for (int i = 1; i <= 10; i++)
// {
//     Console.Write(Fibonacci(i));
//     if (i < 10)
//     {
//         Console.Write(", ");
//     }
// }


// Write a program that that demonstrates use of four basic principles of object-oriented programming
// See the OOPDesign folder


// Try creating the two classes Color and Ball, and make a simple program to work with them. 
using SEPAssignment03;

// Create a few balls
Ball redBall = new Ball(10, new Color(255, 0, 0));
Ball greenBall = new Ball(8, new Color(0, 255, 0));
Ball blueBall = new Ball(12, new Color(0, 0, 225));

// Throw them around a few times
redBall.Throw();
greenBall.Throw();
greenBall.Throw();
blueBall.Throw();
blueBall.Throw();
blueBall.Throw();
Console.WriteLine($"redBall was thrown {redBall.GetThrowCount()} times");
Console.WriteLine($"greenBall was thrown {greenBall.GetThrowCount()} times");
Console.WriteLine($"blueBall was thrown {blueBall.GetThrowCount()} times");
Console.WriteLine();

// Pop a few
greenBall.Pop();
blueBall.Pop();
Console.WriteLine("greenBall and blueBall were popped");
Console.WriteLine();

// Try to throw them again
redBall.Throw();
greenBall.Throw();
blueBall.Throw();
Console.WriteLine($"redBall was thrown {redBall.GetThrowCount()} times");
Console.WriteLine($"greenBall was thrown {greenBall.GetThrowCount()} times");
Console.WriteLine($"blueBall was thrown {blueBall.GetThrowCount()} times");