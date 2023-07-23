using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace KeyboardOutputSwitcher
{
    class Program
    {
        static Dictionary<char, char> characterMap = new Dictionary<char, char>();

        static void Main()
        {

            //System.Resources.ResourceManager mgr = new
            //System.Resources.ResourceManager("MyConsoleApp.MyResource",
            //System.Reflection.Assembly.GetExecutingAssembly());
            //Console.WriteLine(mgr.GetString("resourceName"));
            Console.Title = "charswitch";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Keyboard Output Character Switcher for old keyboard"); 
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("SWITCHED OUTPUT ");

            Console.BackgroundColor= ConsoleColor.Black;
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("Type 'exit' to quit.");
            

            AddCharacterMapping('a', 'b');
            AddCharacterMapping('b', 'c');
            AddCharacterMapping('c', 'd');
            AddCharacterMapping('d', 'e');
            AddCharacterMapping('e', 'f');
            AddCharacterMapping('f', 'g');
            AddCharacterMapping('g', 'h');
            AddCharacterMapping('h', 'i');
            AddCharacterMapping('i', 'j');
            AddCharacterMapping('j', 'k');
            AddCharacterMapping('k', 'l');
            AddCharacterMapping('l', 'm');
            AddCharacterMapping('m', 'n');
            AddCharacterMapping('n', 'o');
            AddCharacterMapping('o', 'p');
            AddCharacterMapping('p', 'q');
            AddCharacterMapping('q', 'r');
            AddCharacterMapping('r', 's');
            AddCharacterMapping('s', 't');
            AddCharacterMapping('t', 'u');
            AddCharacterMapping('u', 'v');
            AddCharacterMapping('v', 'w');
            AddCharacterMapping('w', 'x');
            AddCharacterMapping('x', 'y');
            AddCharacterMapping('y', 'z');
            AddCharacterMapping('z', 'a');

            AddCharacterMapping('A', 'B');
            AddCharacterMapping('B', 'C');
            AddCharacterMapping('C', 'D');
            AddCharacterMapping('D', 'E');
            AddCharacterMapping('E', 'F');
            AddCharacterMapping('F', 'G');
            AddCharacterMapping('G', 'H');
            AddCharacterMapping('H', 'I');
            AddCharacterMapping('I', 'J');
            AddCharacterMapping('J', 'K');
            AddCharacterMapping('K', 'L');
            AddCharacterMapping('L', 'M');
            AddCharacterMapping('M', 'N');
            AddCharacterMapping('N', 'O');
            AddCharacterMapping('O', 'P');
            AddCharacterMapping('P', 'Q');
            AddCharacterMapping('Q', 'R');
            AddCharacterMapping('R', 'S');
            AddCharacterMapping('S', 'T');
            AddCharacterMapping('T', 'U');
            AddCharacterMapping('U', 'V');
            AddCharacterMapping('V', 'W');
            AddCharacterMapping('W', 'X');
            AddCharacterMapping('X', 'Y');
            AddCharacterMapping('Y', 'Z');
            AddCharacterMapping('Z', 'A');
            
            AddCharacterMapping('!', '@');
            AddCharacterMapping('@', '#');
            AddCharacterMapping('#', '$');
            AddCharacterMapping('$', '%');
            AddCharacterMapping('%', '^');
            AddCharacterMapping('^', '&');
            AddCharacterMapping('&', '*');
            AddCharacterMapping('*', '(');
            AddCharacterMapping('(', ')');
            AddCharacterMapping(')', '_');
            AddCharacterMapping('_', '+');
            AddCharacterMapping('[', ']');
            AddCharacterMapping(']', ';');
            AddCharacterMapping(';', '.');
            AddCharacterMapping('/', '\\');
            AddCharacterMapping('"', ',');
            AddCharacterMapping('~', '`');

            AddCharacterMapping('0', '1');
            AddCharacterMapping('1', '2');
            AddCharacterMapping('2', '3');
            AddCharacterMapping('3', '4');
            AddCharacterMapping('4', '5');
            AddCharacterMapping('5', '6');
            AddCharacterMapping('6', '7');
            AddCharacterMapping('7', '8');
            AddCharacterMapping('8', '9');
            AddCharacterMapping('9', '0');

            string input;

            do
            {
                input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.Clear();
                    string word = "...PROGRAM SHUTDOWN";
                    int delayInMilliseconds = 100;
                    foreach (char c in word)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(c);
                        Thread.Sleep(delayInMilliseconds);
                    }
                    Thread.Sleep(500);
                    Console.Clear();
                    break;
                }

                string switchedOutput = SwitchCharacters(input);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine(switchedOutput);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            } while (true);
        }

        static void AddCharacterMapping(char originalChar, char switchedChar)
        {

            originalChar = char.ToLower(originalChar);
            switchedChar = char.ToLower(switchedChar);
            characterMap[originalChar] = switchedChar;
            characterMap[char.ToUpper(originalChar)] = char.ToUpper(switchedChar);
        
        }
        
        static string SwitchCharacters(string input)
        {
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char originalChar = chars[i];

                if (characterMap.ContainsKey(originalChar))
                {
                    chars[i] = characterMap[originalChar];
                }
            }
           
            return new string(chars);
        }
    }
}
