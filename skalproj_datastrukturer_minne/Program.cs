using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    + "\n4. CheckParanthesis"
                    + "\n5. CheckRecursive"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
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
                        CheckRecursive();
                        break;

                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        return;
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
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            List<string> theList = new List<string>();
            while (true)
            {
               Console.WriteLine("Type '+' or '-'  to add or remove from the list or zero to exit :");
               
               string input = Console.ReadLine();
               char nav = input[0];
               string value = input.Substring(1);
                 
                switch (nav)
                {
                    case '0':
                        {
                            return;
                        }

                    case '+':

                        {
                            Console.WriteLine("Enter value:");
                            value = Console.ReadLine();
                            theList.Add(value);
                            // Console.WriteLine($"theList[0]: {theList[0]} ");
                            foreach (Object obj in theList)
                            {
                                Console.WriteLine("..............................");
                                Console.WriteLine(obj);
                            }
                            Console.WriteLine($"the List Capacity: {theList.Capacity }");
                            Console.WriteLine($"the List Count: {theList.Count }");

                            break;

                        }

                    case '-':

                        {
                            Console.WriteLine("Enter value:");
                            value = Console.ReadLine();
                            theList.Remove(value);
                            foreach (Object obj in theList)
                            {
                                Console.WriteLine("..............................");
                                Console.WriteLine(obj);
                            }
                            // Console.WriteLine($"theList[0]: {theList[0]} ");
                            Console.WriteLine($"the List Capacity: {theList.Capacity }");
                            Console.WriteLine($"the List Count: {theList.Count }");
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
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue<string> thequeue = new Queue<string>();
            while (true)

            { 
                Console.WriteLine("Type '+' or '-'  to add or remove from the queue or zero to exit: ");
                string input = Console.ReadLine();
                char nav = input[0];
                if (nav == '0') { return; }
                else { TestQueue(input, thequeue); }
                        
            }

    }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            Stack<string> thestack = new Stack<string>();
            while (true)

            {
                Console.WriteLine("Type '+' or '-'  to add or remove from the stack, '1' to revers input characters or zero to exit: ");
                string input = Console.ReadLine();
                char nav = input[0];
                if (nav == '0') { return; }
                else { TestStack(input, thestack);  }
                        
            }


        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            Stack<char> thestack = new Stack<char>();
            while (true)

            {
                Console.WriteLine("Type '1' to check paranthesis or zero to exit: ");
                string input = Console.ReadLine();
                char nav = input[0];
                if (nav == '0') { return; }
                else { CheckParentheses(input, thestack); }
            }

        }

        static void CheckRecursive()
        {
            while (true)
            {
                Console.WriteLine("Type '1' to check Even Recursive or '2'  to calculate Fibonaccisequence or zero to exit :");

                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '0':
                        {
                            return;
                        }

                    case '1':

                        {
                            Console.WriteLine("Enter number:");
                            value = Console.ReadLine();
                            int evenNum = Int32.Parse(value);
                            Console.WriteLine("All even numbers from 1 to {0} are : ", evenNum);
                            RecursiveEven(2, evenNum);
                            Console.WriteLine("\n");
                            break;

                        }

                    case '2':

                        {
                            Console.WriteLine("Enter the length of number:");
                            value = Console.ReadLine();
                            int evenNum = Int32.Parse(value);
                            //Console.WriteLine("All even numbers from 1 to {0} are : ", evenNum);
                            Fibonacci(0, 1, 1, evenNum);
                            Console.WriteLine("\n");
                            break;

                        }


                }
            }
        }

            static void TestQueue(string input, Queue<string> queue) 

        {  
            char nav = input[0];
            string value = input.Substring(1);

            switch (nav)
            {
                

                case '+':
                    {                
                        Console.WriteLine("Enter value:");
                        value = Console.ReadLine();
                        queue.Enqueue(value);
                        foreach (Object obj in queue)
                        {
                            Console.WriteLine("..............................");
                            Console.WriteLine(obj);
                        }
                        Console.WriteLine($"Number of elements in the Queue : {queue.Count }");
                        break;
                    }

                case '-':
                    {
                        
                        queue.Dequeue();
                        foreach (Object obj in queue)
                        {
                            Console.WriteLine("..............................");
                            Console.WriteLine(obj);
                        }
                        Console.WriteLine($"Number of elements in the Queue : {queue.Count }");
                        break;
                    }

            }

        }

        static void TestStack(string input, Stack<string> stack)

        {
            char nav = input[0];
            string value = input.Substring(1);

            switch (nav)
            {
               
                case '+':
                    {
                        Console.WriteLine("Enter value:");
                        value = Console.ReadLine();
                        stack.Push(value);
                        foreach (Object obj in stack)
                        {
                            Console.WriteLine("..............................");
                            Console.WriteLine(obj);
                        }
                        Console.WriteLine($"Number of elements in the Stack : {stack.Count }");
                        break;
                    }

                case '-':
                    {
                        
                        stack.Pop();
                        foreach (Object obj in stack)
                        {
                            Console.WriteLine("..............................");
                            Console.WriteLine(obj);
                        }
                        Console.WriteLine($"Number of elements in the Stack : {stack.Count }");
                        break;

                    }

                case '1':
                    {
                        Console.WriteLine("Please enter string:");
                        value = Console.ReadLine();
                        ReverseTex(value, stack);
                        break;

                    }

            }

        }

        static void ReverseTex(string input, Stack<string> stack)
        {        
            char[] cArray = input.ToCharArray();
            for (int i = 0 ; i < cArray.Length ; i++)
            {
                stack.Push(cArray[i].ToString());
            }

            foreach (Object obj in stack)
            {
                Console.WriteLine(obj);
            }

        }

        static void CheckParentheses(string input, Stack<char> stack)
        {
            char nav = input[0];
            string value = input.Substring(1);
         
            switch (nav)
            {
                case '1':
                    {
                        Console.WriteLine("Enter the string:");
                        value = Console.ReadLine();

                        if (ParenthesisBalanced(value.ToCharArray(), stack))
                            Console.WriteLine("Well formed ");
                        else
                            Console.WriteLine("Not well formed ");

                        break;
                    }
            }

        }
        // chack match pairs
        static Boolean isMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
                return true;
            else if (character1 == '{' && character2 == '}')
                return true;
            else if (character1 == '[' && character2 == ']')
                return true;
            else
                return false;
        }

        static Boolean ParenthesisBalanced(char[] exp, Stack<char> st)
        {    
           
             //check matching parenthesis 
            for (int i = 0; i < exp.Length; i++)
            {
                //If the exp[i] is a starting parenthesis then push it
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                    st.Push(exp[i]);

                /* If exp[i] is an ending parenthesis  
                    then pop from stack and check if the  
                    popped parenthesis is a matching pair*/
                if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
                {
                    /* If we see an ending parenthesis without  
                        a pair then return false*/
                    if (st.Count == 0)
                    {
                        return false;
                    }

                    /* Pop the top element from stack, if  
                        it is not a pair parenthesis of character  
                        then there is a mismatch. */

                    else if (!isMatchingPair(st.Pop(), exp[i]))
                    {
                        return false;
                    }
                }

            }

            /* If there is something left in expression  
                then there is a starting parenthesis without  
                a closing parenthesis */

            if (st.Count == 0)
                return true; //balanced
            else
            { 
                return false; //not balanced
            }
        }
        
        static void RecursiveEven(int startVal, int number)
        {
            if (startVal > number)
                return;
            Console.Write(" {0}  ", startVal);
            RecursiveEven(startVal + 2, number);
        }

        static void Fibonacci(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0} ", a);
                Fibonacci(b, a + b, counter + 1, len);
            }
        }



    }
}
