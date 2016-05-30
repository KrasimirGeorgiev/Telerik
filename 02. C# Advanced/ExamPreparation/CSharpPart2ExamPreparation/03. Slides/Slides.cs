namespace _03.Slides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Slides
    {
        public static void Main()
        {
            int[] cubeDimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int height = cubeDimentions[1];
            int width = cubeDimentions[0];
            int depth = cubeDimentions[2];
            string[,,] cuboid = new string[height, width, depth];
            string exitsTheCuboid = string.Empty;
            string answer = string.Empty;
            for (int row = 0; row < height; row++)
            {
                string[] inputRows = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int d = 0; d < depth; d++)
                {
                    string[] inputDepth = inputRows[d].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    for (int col = 0; col < width; col++)
                    {
                        cuboid[row, col, d] = inputDepth[col];
                    }
                }
            }

            string[] wD = Console.ReadLine().Split();
            int ballW = int.Parse(wD[0]);
            int ballD = int.Parse(wD[1]);
            int currentRow = 0;
            while (exitsTheCuboid == string.Empty)
            {
                string[] currentCell = cuboid[currentRow, ballW, ballD].Split();
                switch (currentCell[0])
                {
                    case "S":
                        if (currentRow == height - 1)
                        {
                            exitsTheCuboid = "Yes";
                            answer = ballW + " " + currentRow + " " + ballD;
                        }
                        else
                        {
                            switch (currentCell[1])
                            {
                                case "L":
                                    if (ballW - 1 < 0)
                                    {
                                        exitsTheCuboid = "No";
                                        answer = ballW + " " + currentRow + " " + ballD;
                                    }
                                    else
                                    {
                                        currentRow++;
                                        ballW--;
                                    }

                                    break;
                                case "R":
                                    if (ballW + 1 >= width)
                                    {
                                        exitsTheCuboid = "No";
                                        answer = ballW + " " + currentRow + " " + ballD;
                                    }
                                    else
                                    {
                                        currentRow++;
                                        ballW++;
                                    }

                                    break;
                                case "F":
                                    if (ballD - 1 < 0)
                                    {
                                        exitsTheCuboid = "No";
                                        answer = ballW + " " + currentRow + " " + ballD;
                                    }
                                    else
                                    {
                                        currentRow++;
                                        ballD--;
                                    }

                                    break;
                                case "B":
                                    if (ballD + 1 >= depth)
                                    {
                                        exitsTheCuboid = "No";
                                        answer = ballW + " " + currentRow + " " + ballD;
                                    }
                                    else
                                    {
                                        currentRow++;
                                        ballD++;
                                    }

                                    break;
                                case "FL":
                                    if (ballD - 1 < 0 || ballW - 1 < 0)
                                    {
                                        exitsTheCuboid = "No";
                                        answer = ballW + " " + currentRow + " " + ballD;
                                    }
                                    else
                                    {
                                        currentRow++;
                                        ballD--;
                                        ballW--;
                                    }

                                    break;
                                case "FR":
                                    if (ballD - 1 < 0 || ballW + 1 >= width)
                                    {
                                        exitsTheCuboid = "No";
                                        answer = ballW + " " + currentRow + " " + ballD;
                                    }
                                    else
                                    {
                                        currentRow++;
                                        ballD--;
                                        ballW++;
                                    }

                                    break;
                                case "BL":
                                    if (ballD + 1 >= depth  || ballW - 1 < 0)
                                    {
                                        exitsTheCuboid = "No";
                                        answer = ballW + " " + currentRow + " " + ballD;
                                    }
                                    else
                                    {
                                        currentRow++;
                                        ballD++;
                                        ballW--;
                                    }

                                    break;
                                case "BR":
                                    if (ballD + 1 >= depth || ballW + 1 >= width)
                                    {
                                        exitsTheCuboid = "No";
                                        answer = ballW + " " + currentRow + " " + ballD;
                                    }
                                    else
                                    {
                                        currentRow++;
                                        ballD++;
                                        ballW++;
                                    }

                                    break;
                            }
                        }

                        break;
                    case "T":
                        int currentW = int.Parse(currentCell[1]);
                        int currentD = int.Parse(currentCell[2]);
                        if (currentW < 0 || currentW >= width || currentD < 0 || currentD >= depth)
                        {
                            exitsTheCuboid = "No";
                            answer = ballW + " " + currentRow + " " + ballD;
                        }
                        else
                        {
                            ballW = currentW;
                            ballD = currentD;
                        }

                        break;
                    case "E":
                        if (currentRow == height - 1)
                        {
                            exitsTheCuboid = "Yes";
                            answer = ballW + " " + currentRow + " " + ballD;
                        }
                        else
                        {
                            currentRow++;
                        }

                        break;
                    case "B":
                        exitsTheCuboid = "No";
                        answer = ballW + " " + currentRow + " " + ballD;
                        break;
                }
            }

            Console.WriteLine(exitsTheCuboid);
            Console.WriteLine(answer);
            //// Console.WriteLine(PrintDimentionOfCuboid(cuboid, height, width, 1));
        }

        private static string PrintDimentionOfCuboid(string[,,] cuboid, int height, int width, int d)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    result.Append(cuboid[i, j, d]);
                    result.Append(" ");
                }

                result.Length = result.Length - 1;
                result.AppendLine();
            }

            result.Length = result.Length - 1;
            return result.ToString();
        }
    }
}

// C# Part 2 - 2012/2013 @ 4 Feb 2013 - Morning
// http://bgcoder.com/Contests/Practice/Index/52#2