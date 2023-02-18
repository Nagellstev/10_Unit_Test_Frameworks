using System;
using System.Security.Permissions;
using CalculatorProgram;
using Newtonsoft.Json;
using StringLibrary;

namespace CalculatorProgram
{
    public class Program
    {
        static void Main()
        {
            bool endApp = false;

            Console.WriteLine("Practical Task: Chapter Development and Build Tools\r");
            Console.WriteLine("-----------\n");
            StringProcessing strPr = new StringProcessing();
            JsonWriting Jwriter = new JsonWriting();

            while (!endApp)
            {
                bool endSwitch = false;
                string Input = "";
                int result = 0;

                while (Input == "")
                {
                    Console.WriteLine("Type string, press Enter\n");
                    Input = Console.ReadLine();
                }

                while (endSwitch == false)
                {
                    Console.WriteLine("Choose action:");
                    Console.WriteLine("\ta - calculate maximum number of unequal consecutive characters per line");
                    Console.WriteLine("\tb - calculate maximum number of consecutive identical latin letters in a line");
                    Console.WriteLine("\tc - calculate maximum number of consecutive identical digits in a line");
                    Console.WriteLine("\te - exit");

                    switch (Console.ReadLine())
                    {
                        case "a":
                            try
                            {
                                Jwriter.StartJsonPartition(Input);
                                result = strPr.MaxNumberUnequalSymbols(Input);
                                Console.WriteLine($"Maximum number of unequal consecutive characters in this line is \n {result}");
                                Jwriter.EndJsonPartition(result.ToString());
                            }
                            catch (Exception exeption)
                            {
                                Jwriter.StartJsonPartition(Input);
                                Console.WriteLine($"Something Wrong!\n {exeption.Message}");
                                Jwriter.EndJsonPartition($"Something Wrong!\n {exeption.Message}");
                            }

                            endSwitch = true;

                            break;

                        case "b":
                            try
                            {
                                Jwriter.StartJsonPartition(Input);
                                result = strPr.MaxNumberEqualLatinLetters(Input);
                                Console.WriteLine($"Maximum number of consecutive identical latin letters in this line is \n {result}");
                                Jwriter.EndJsonPartition(result.ToString());
                            }
                            catch (Exception exeption)
                            {
                                Jwriter.StartJsonPartition(Input);
                                Console.WriteLine($"Something Wrong!\n {exeption.Message}");
                                Jwriter.EndJsonPartition(result.ToString());
                            }

                            endSwitch = true;

                            break;

                        case "c":
                            try
                            {
                                Jwriter.StartJsonPartition(Input);
                                result = strPr.MaxNumberEqualDigits(Input);
                                Console.WriteLine($"Maximum number of consecutive identical digits in this line is \n {result}");
                                Jwriter.EndJsonPartition(result.ToString());
                            }
                            catch (Exception exeption)
                            {
                                Jwriter.StartJsonPartition(Input);
                                Console.WriteLine($"Something Wrong!\n {exeption.Message}");
                                Jwriter.EndJsonPartition(result.ToString());
                            }

                            endSwitch = true;

                            break;

                        case "e":
                            endApp = true;
                            endSwitch = true;

                            break;

                        default:
                            Console.WriteLine("You have not chosen anything.");

                            break;
                    }
                }

                Console.WriteLine("\n");
            }
            Jwriter.EndJsonFile();
            return;
        }
    }

}