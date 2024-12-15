using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson3
{
    static class Program
    {
        static void Main()
        {
            string[] text = File.ReadAllLines("..\\..\\..\\text.txt");
            Console.WriteLine(CreateText(text));
        }

        public static string GetClass(string[] text)
        {
            return text[0].Remove(0, 7);
        }

        public static string[] GetProperties(string text)
        {
            string[] all = text.Split(':');
            string[] properties = all[1].Split(',');
            return properties;
        }
        //build smth
        public static StringBuilder CreateText(string[] text)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("namespace SillyProgram");
            sb.AppendLine("{");
            sb.AppendLine($"\tclass {GetClass(text)}");
            sb.AppendLine("\t{");

            foreach (string line in GetProperties(text[1]))
            {
                string[] props = line.Split(' ');
                if (props.Length == 4)
                {
                    sb.Append("\t\tprivate ");
                    switch (props[2])
                    {
                        case "число":
                            sb.Append("int ");
                            break;
                        case "строка":
                            sb.Append("string ");
                            break;
                        case "символ":
                            sb.Append("char ");
                            break;
                        default:
                            sb.Append("bool ");
                            break;
                    }
                    sb.AppendLine(props[3] + ";");
                }

                else
                {
                    sb.Append("\t\tpublic ");
                    switch (props[1])
                    {
                        case "число":
                            sb.Append("int ");
                            break;
                        case "строка":
                            sb.Append("string ");
                            break;
                        case "символ":
                            sb.Append("char ");
                            break;
                        default:
                            sb.Append("bool ");
                            break;
                    }
                    sb.AppendLine(props[2] + " { get; set; }");
                }
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");
            return sb;
        }
    }
}


