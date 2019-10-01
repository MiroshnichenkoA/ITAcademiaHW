using System;
using System.Collections.Generic;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> collection = new List<object>;
            collection.Add(43);
            collection.Add(DayOfWeek.Tuesday);
            collection.Add("Hello!");
            collection.Add(null);
            collection.Add(false);

            foreach (var item in collection)
            {
                case string txt when txt.Equals("Hello!"):
                Console.WriteLine(txt);
                break;
            }
        }
    } 