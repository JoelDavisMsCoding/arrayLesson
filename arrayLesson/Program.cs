namespace arrayLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiceRoller();
        }
//-------------------------------------------------------------------------------------------------------------

        static void NumberCube()
        {
            //Declare Variables
            Random randomBox = new Random();
            int[,,] arrayNums = new int[100, 100, 100];
            int rowNumber = 1;
            int lowestNum = 255;
            int highestNum = 0;
            double totalNums = 0.0;
            double averageNums = 0.0;

            //Request & Set Data
            for (int z = 0; z < arrayNums.GetLength(2); z++)
            {
                for (int y = 0; y < arrayNums.GetLength(1); y++)
                {
                    for (int x = 0; x < arrayNums.GetLength(0); x++)
                    {
                        arrayNums[x, y, z] = randomBox.Next(255);
                        if (highestNum < arrayNums[x, y, z])
                        {
                            highestNum = arrayNums[x, y, z];
                        }                      
                        if (lowestNum > arrayNums[x, y, z])
                        {
                            lowestNum = arrayNums[x, y, z];
                        }
                        totalNums += arrayNums[x, y, z];
                        averageNums = totalNums / 1000000;
                        averageNums = Math.Round(averageNums, 2);
                    }//End X axis
                }//End Y axis
            }//End Z axis

            //Display Data
            for (int z = 0; z < arrayNums.GetLength(2); z++)
            {
                //Console.WriteLine();
                for (int y = 0; y < arrayNums.GetLength(1); y++)
                {
                    //Console.Write($"{rowNumber++} - ");
                    for (int x = 0; x < arrayNums.GetLength(0); x++)
                    {

                        //Console.Write($"{arrayNums[x, y, z]}");
                    }//End X axis
                    //Console.WriteLine();
                }//End Y axis
            }//End Z axis
            Console.WriteLine();
            Console.WriteLine($"Total of Numbers: {totalNums}");
            Console.WriteLine($"Average of Numbers: {averageNums}");
            Console.WriteLine($"Lowest Number: {lowestNum}");
            Console.WriteLine($"Highest Number: {highestNum}");
        }
//------------------------------------------------------------------------------------------------------------
        static void ThreeDimensional()
        {
            Random randomBox = new Random();
            int[,,] arrayNums = new int[10, 10, 10];
            int rowNumber = 1;

            for (int z = 0; z < arrayNums.GetLength(2); z++)
            {
                for (int y = 0; y < arrayNums.GetLength(1); y++)
                {                    
                    for (int x = 0; x < arrayNums.GetLength(0); x++)
                    {
                        arrayNums[x, y, z] = randomBox.Next(10);
                    }//End X axis
                }//End Y axis
            }//End Z axis

            for (int z = 0; z < arrayNums.GetLength(2); z++)
            {
                Console.WriteLine();
                for (int y = 0; y < arrayNums.GetLength(1); y++)
                {
                    Console.Write($"{rowNumber++} - ");
                    for (int x = 0; x < arrayNums.GetLength(0); x++)
                    {
                        Console.Write($"{arrayNums[x, y, z]}");
                    }//End X axis
                    Console.WriteLine();
                }//End Y axis
                Console.WriteLine();
            switch (z) 
            {
                case 0: 
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 1: 
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 2:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 3:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 4:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                case 7:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                case 8:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                case 9:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                case 10:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                }
            }//End Z axis
            Console.WriteLine();
        }
//----------------------------------------------------------------------------------------------------------------------
        static void TwoBySix()
        {
            Random randomNums = new Random();
            int[,] ranNums = new int[6, 7];
            int rowNum = 1;
            for (int y = 0; y < ranNums.GetLength(1); y++)
            {
                for (int x = 0; x < ranNums.GetLength(0); x++)
                {
                    ranNums[x, y] = randomNums.Next(0, 8);
                }//End X axis
            }//End Y axis

            for (int y = 0; y < ranNums.GetLength(1); y++)
            {
                    Console.Write($"{rowNum++} - ");
                for (int x = 0; x < ranNums.GetLength(0); x++)
                {
                    Console.Write(ranNums[x,y]);
                }//End X axis
                Console.WriteLine();
            }//End Y axis
        }
//----------------------------------------------------------------------------------------------------------------
        static void TwoDimensional()
        {
            int[,] oneToNine = new int[3,3];
            int count = 1;
            for (int y = 0; y < oneToNine.GetLength(1); y++)
            {
                for (int x = 0; x < oneToNine.GetLength(0); x++)
                {
                    oneToNine[x,y] = count++;
                }//End X axis
            }//End Y axis

            for (int y = 0; y < oneToNine.GetLength(1); y++)
            {
                for (int x = 0; x < oneToNine.GetLength(0); x++)
                {
                    Console.Write(oneToNine[x, y] );
                }//End X axis
                Console.WriteLine();
            }//End Y axis

            int[,] nums =
            {
                {1, 3, 5, 7, 9, 11},
                {2, 4, 6, 8, 10, 12}
            };

            for (int y = 0; y < nums.GetLength(1); y++)
            {
                for (int x = 0; x < nums.GetLength(0); x++)
                {
                    Console.Write(nums[x, y]);
                }//End X axis
            }//End Y axis
        }
//----------------------------------------------------------------------------------------------------------------
        static void MultiDimensional()
        {
            //The first number int the bracket(X-axis) is the ROW second number is the (Y-axis) COLUMN,
            char[,] ticTacToe =
            {
                //0 or Y Axis
                {'A', 'B', 'C'},
                //1
                {'D', 'E', 'F'}, 
                //2                 
                {'G', 'H', 'I'}           
            };
            /*Console.WriteLine(ticTacToe[1,1]);
            
            for (int row = 0; row < ticTacToe.GetLength(0); row++)
            {
                Console.Write($"{ticTacToe[row, 0]} ");
            } */

            Console.WriteLine();

            for (int row = 0; row < ticTacToe.GetLength(0); row++)
            {
                for (int column = 0; column < ticTacToe.GetLength(1); column++)
                {
                Console.Write($"{ticTacToe[row, column]} ");
                }//End Column
                    Console.WriteLine();
            }//End Row
        }
//-------------------------------------------------------------------------------------------------------
        static void ChipsAndSalsa()
        {
            string[] salsaTypes = {"MILD", "MEDIUM", "SWEET", "ZESTY", "HOT" };
            int[] sales = new int[5];
            double totalSales = 0;
            int minimumsale = int.MaxValue;
            int maximumsale = int.MinValue;
            string salsaTypeMin = "";
            string salsaTypeMax = "";

            Console.WriteLine("\nSalsa Type & Monthly Sells\n-------------------------");
            for (int i = 0; i < salsaTypes.Length; i++)
            {
                sales[i] = PromptInt($"How many jars were sold for the {salsaTypes[i]} sauce type? ");
                if (minimumsale > sales[i])
                {
                    minimumsale = sales[i];
                    salsaTypeMin = salsaTypes[i];
                }
                if (maximumsale < sales[i])
                {
                    maximumsale = sales[i];
                    salsaTypeMax= salsaTypes[i];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < salsaTypes.Length; i++)
            {
                totalSales += sales[i];
                Console.WriteLine($"Salsa Type: {salsaTypes[i]}\nMonthly Sells: {sales[i]}\n");
            }
            Console.WriteLine($"Total Sales: {totalSales}");
            Console.WriteLine($"Lowest Selling Product: {salsaTypeMin}      Sales: {minimumsale}");
            Console.WriteLine($"Highest Selling Product: {salsaTypeMax}     Sales: {maximumsale}");
        }
//--------------------------------------------------------------------------------------------------------------
        static void MakingCopies()
        {
            int[] array1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25};
            int[] array2 = array1;

            Console.WriteLine("\nMaking Copies\n-------------");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]}, ");
            }
            Console.WriteLine();
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array2[i]}, ");
            }
            Console.WriteLine();
        }
//--------------------------------------------------------------------------------------------------------------
        static void RainfallStatistics()
        {
            //Declare Variables
            int minimumRain = int.MaxValue;
            int maximumRain = int.MinValue;
            string[] months = { "Jan", "Feb", "Mar", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec"};
            int[] rainFall = new int[months.Length];
            double totalRainFall = 0;
            double monthlyRainFall = 0;
            string MinimumMonth = "";
            string MaximumMonth = "";


            //Request Data
            for (int i = 0; i < months.Length; i++)
                rainFall[i] = PromptInt($"How much rainfall did {months[i]} have? ");

            //Set Data
            for (int i = 0; i < months.Length; i++)
            {
                totalRainFall += rainFall[i];
                monthlyRainFall += rainFall[i];
                if (minimumRain > rainFall[i])
                {
                    minimumRain = rainFall[i];
                    MinimumMonth = months[i];
                }
                if (maximumRain < rainFall[i])
                {
                    maximumRain = rainFall[i];
                    MaximumMonth = months[i];
                }
            }
            monthlyRainFall = monthlyRainFall / 12;
            monthlyRainFall = Math.Round(monthlyRainFall, 2);
            //Display Outcome
            Console.WriteLine("\nRain Fall Statistics\n-------------------");
            Console.WriteLine($"Total Yearly Rainfall: {totalRainFall}");
            Console.WriteLine($"Monthly Average Rainfall: {monthlyRainFall}");
            Console.WriteLine($"The month with the highest rainfall is ({MaximumMonth}) with ({maximumRain}) inches of rain.");
            Console.WriteLine($"The month with the lowest rainfall is ({MinimumMonth}) with ({minimumRain}) inches of rain.");
        }//End Of Function
//------------------------------------------------------------------------------------------------------------
        static void lotteryNumGenerator()
        {
            //Declare Variables
            Random randomNum = new Random();
            int[] lotteryNums = new int[6];

            //Make Random Nums
            for (int i = 0; i < lotteryNums.Length; i++)
            {
                lotteryNums[i] = randomNum.Next(0, 10);
            }

            //Display
            Console.WriteLine("\nLotter Numbers\n---------------");
            for (int i = 0; i < lotteryNums.Length; i++)
            {
                Console.Write($"{lotteryNums[i]}\n");
            }
        }//End Of Function
//----------------------------------------------------------------------------------------------------------------
        static void TotalSales()
        {
            //Declare Variables
            string[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            double[] storeSells = new double[7];
            double total = 0;

            //Request 
            for (int i = 0; i < weekDays.Length; i++)
            {
                storeSells[i] = PromptDouble($"What is the sale's price for {weekDays[i]}? ");
            }

            //Display Outcome
            Console.WriteLine("\nTotal Sales\n---------------");
            for (int i = 0; i < weekDays.Length; i++)
            {
                total += storeSells[i];
            }
            Console.WriteLine(total);
        }//End Of Function Total Sales
//-------------------------------------------------------------------------------------------
        static void DiceRoller()
        {
            //Declare Variables
            Random robot = new Random();

            //Request Dice Sides and Number Of Rolls
            int sides = PromptInt("How many sides does your dice have? ");
            int rollCount = PromptInt($"How many times should we roll the dice? ");
            int[] rollOutcomes = new int[rollCount];
            
            //Roll All Of The Dice
            for (int i = 0; i < rollOutcomes.Length; i++)
            {
                rollOutcomes[i] = robot.Next(1, sides + 1);
            }

            //Display Outcome Of Dice Rolls
            Console.WriteLine("\nROLL OUTCOMES\n---------------");
            for (int i = 0; i < rollOutcomes.Length; i++)
            {
                //Console.Write(rollOutcomes[i] + " ");
                Console.Write($"{rollOutcomes[i]} ");
            }
        }//End Of Function Dice Roller       
         //--------------------------------------------------------------------------------------------------
        #region PROMPT FUNCTIONS
        static string Prompt(string dataRequest)
        { //START FUNCTION
            //Variables
            string userInput = "";

            //Request Information From User
            Console.Write(dataRequest);

            //Receive Response
            userInput = Console.ReadLine();

            return userInput;
        }
        //--------------------------------------------------------------------------------
        static int PromptInt(string dataRequest)
        { //START FUNCTION PromptTryInt
            //Variables
            int userInput = 0;
            bool isValid = false;

            do
            {
                Console.Write(dataRequest);
                isValid = int.TryParse(Console.ReadLine(), out userInput);
            }
            while (isValid == false);
            {
            }

            return userInput;
        } //END FUNCTION PromptTryInt
          //---------------------------------------------------------------------------------

        static double PromptDouble(string dataRequest)
        { //START FUNCTION
            //Variables
            double userInput = 0.0;
            bool isValid = false;

            do
            {
                Console.Write(dataRequest);
                isValid |= double.TryParse(Console.ReadLine(), out userInput);
            }
            while (isValid == false);
            {
            }

            return userInput;
        } //END FUNCTION PromptDouble
        #endregion PROMPT FUNCTIONS
    }
}
