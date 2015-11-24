namespace _02.RefactoringIfStatement
{
    using System;

    public class LoopRefactoring
    {
        public static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int valueToFind = 5;

            Loop(array, valueToFind);
        }

        public static void Loop(int[] array, int expectedValue)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);

                if (array[index] == expectedValue)
                {
                    Console.WriteLine("The number {0} was found.", array[index]);
                    break;
                }
            }
        }
    }
}