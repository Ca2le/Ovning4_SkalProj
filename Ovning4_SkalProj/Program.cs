using System;
using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n5. ReverseText"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                        case '5':
                            ReverseText();
                        break;
  
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            bool isRunning = true;
       
            List<string> theList = new List<string>();
            while (isRunning)
            {
                Console.WriteLine("Please enter a command + or - with a text to add or remove from the list, 0 to exit.");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    string action = input.Substring(0, 1);
                    string word = input.Substring(1);
                    switch (action)
                    {
                        case "+":
                            theList.Add(word);
                            Console.WriteLine($"{word}: added!");
                            Console.WriteLine($"{theList.Count} elements in list.");
                            Console.WriteLine("The list has a capacity of: " + theList.Capacity);
                            break;
                        case "-":
                            theList.Remove(input.Substring(1));
                            Console.WriteLine($"{word}: removed!");
                            Console.WriteLine($"{theList.Count} elements in list.");
                            Console.WriteLine("The list has a capacity of: " + theList.Capacity);
                            break;
                        case "0":
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Please use only + or -");
                            break;
                    }
                }

            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {

            bool isRunning = true;
            Queue<string> theQueue = new Queue<string>();
 
            while (isRunning)
            {
                Console.WriteLine("ADD: add a person to the queue. example: +Peter Parker\nRemove: To remove the first person in queue write: - \nEXIT: to exist write: 0");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    char command = input[0];
                    
                    switch (command)
                    {
                       case '+':
                            theQueue.Enqueue(input.Substring(1));
                            Console.WriteLine($"{input.Substring(1)} added to queue!");
                            Console.WriteLine($"{theQueue.Count} elements in list.");
                            Console.WriteLine($"First in line: {theQueue.Peek()}");
                            break;
                            case '-':
                            if(theQueue.Count > 0)
                            {
                                Console.WriteLine($"{theQueue.Peek()} left the queue!");
                                theQueue.Dequeue();
                                Console.WriteLine($"Current {theQueue.Count} elements in list.");
                                Console.WriteLine($"First in line is now: {theQueue.Peek()}.");
                            }
                            else
                            {
                                Console.WriteLine("The queue is empty!");
                            }
                         
                           ;
                            break;
                        case '0':
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Not a valid input.");
                            break;
                    }
                }

            }
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            bool isRunning = true;
            Stack<string> theStack = new Stack<string>();
            while (isRunning)
            {
                Console.WriteLine("ADD: add a person to the stack. example: +Peter Parker\nREMOVE: To remove last person in stack write: - \nEXIT: to exist write: 0");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    char command = input[0];
                    switch (command)
                    {
                        case '+':
                            theStack.Push(input.Substring(1));
                            Console.WriteLine($"{input.Substring(1)} added to stack!");
                            Console.WriteLine($"{theStack.Count} customers in line.");
                            Console.WriteLine($"Last person in line: {theStack.Peek()}");
                            break;
                        case '-':
                            if (theStack.Count > 0)
                            {
                                Console.WriteLine($"{theStack.Peek()} left the stack!");
                                theStack.Pop();
                                Console.WriteLine($"Current {theStack.Count} elements in list.");
                                Console.WriteLine($"Last person in line is now: {theStack.Peek()}.");
                            }
                            else
                            {
                                Console.WriteLine("The stack is empty!");
                            }
                            break;
                        case '0':
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Not a valid input.");
                            break;
                    }
                }

            }
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void ReverseText()
        {
       
            Stack<char> theStack = new Stack<char>();
            Console.WriteLine("Please enter a text to reverse: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                foreach (char c in input)
                {
                    theStack.Push(c);
                }
                Console.WriteLine("Reversed text: ");
                while (theStack.Count > 0)
                {
                    Console.Write(theStack.Pop());
                }
            }
            Console.WriteLine();
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            Stack<char> theStack = new Stack<char>();
            Console.WriteLine("Please enter a text to check for correct paranthesis: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                foreach (char c in input)
                {
                    if (c == '(' || c == '{' || c == '[')
                    {
                        theStack.Push(c);
                    }
                    else if (c == ')' || c == '}' || c == ']')
                    {
                        if (theStack.Count == 0)
                        {
                            Console.WriteLine("Incorrect paranthesis!");
                            return;
                        }
                        char last = theStack.Pop();
                        if (c == ')' && last != '(' || c == '}' && last != '{' || c == ']' && last != '[')
                        {
                            Console.WriteLine("Incorrect paranthesis!");
                            return;
                        }
                    }
                }
                if (theStack.Count == 0)
                {
                    Console.WriteLine("Correct paranthesis!");
                }
                else
                {
                    Console.WriteLine("Incorrect paranthesis!");
                }
            }

        }

    }
}

