namespace CSharpOne
{
    using System;

    // \ \...../ /
    // #\ \.../ /#
    // ##\ \./ /##
    // ###\   /###
    // ####\ /####
    // #####X#####
    // ####/ \####
    // ###/   \###
    // ##/     \##
    // #/  /.\  \#
    // /  /...\  \

    public class PersianRugs
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int dimention = (2 * n) + 1;
            int startSlash = 0;
            int endSlash = n;
            int startTri = 1 + d;
            int endTri = n;

            int[,] matrix = new int[dimention, dimention];

            for (int row = 0; row < dimention / 2; row++)
            {
                for (int col = 0; col < dimention / 2; col++)
                {
                    if (startSlash <= col && endSlash >= col)
                    {
                        if (d < n - 2 && col > startTri && col <= endTri)
                        {
                            matrix[row, col] = 4;
                            matrix[dimention - 1 - row, col] = 4;
                            matrix[row, dimention - 1 - col] = 4;
                            matrix[dimention - 1 - row, dimention - 1 - col] = 4;
                        }
                        else
                            if (d <= n - 2 && col >= startTri && col <= endTri)
                            {
                                matrix[row, col] = 2;
                                matrix[dimention - 1 - row, col] = 3;
                                matrix[row, dimention - 1 - col] = 3;
                                matrix[dimention - 1 - row, dimention - 1 - col] = 2;
                            }
                            else
                                if (startSlash + 1 <= col && endSlash >= col)
                                {
                                    matrix[row, col] = 1;
                                    matrix[dimention - 1 - row, col] = 1;
                                    matrix[row, dimention - 1 - col] = 1;
                                    matrix[dimention - 1 - row, dimention - 1 - col] = 1;
                                }
                                else
                                {
                                    matrix[row, col] = 2;
                                    matrix[dimention - 1 - row, col] = 3;
                                    matrix[row, dimention - 1 - col] = 3;
                                    matrix[dimention - 1 - row, dimention - 1 - col] = 2;
                                }
                    }
                }

                startSlash++;
                startTri++;
            }

            for (int row = 0; row < dimention; row++)
            {
                int col = n;
                matrix[row, col] = 1;
                matrix[n, col] = 5;
            }

            for (int row = 0; row < dimention; row++)
            {
                int col = n;

                if (n - d - 1 >= row && ((matrix[row, n - 1] == 2 && matrix[row, n - 2] != 0) || matrix[row, n - 1] == 4))
                {
                    matrix[row, col] = 4;
                    matrix[dimention - 1 - row, col] = 4;
                }
            }

            for (int row = 0; row < dimention; row++)
            {
                for (int col = 0; col < dimention; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write('#');
                    }
                    else if (matrix[row, col] == 1)
                    {
                        Console.Write(' ');
                    }
                    else if (matrix[row, col] == 2)
                    {
                        Console.Write('\\');
                    }
                    else if (matrix[row, col] == 3)
                    {
                        Console.Write('/');
                    }
                    else if (matrix[row, col] == 4)
                    {
                        Console.Write('.');
                    }
                    else if (matrix[row, col] == 5)
                    {
                        Console.Write('X');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}