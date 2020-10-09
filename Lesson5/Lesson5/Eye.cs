using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lesson5
{
    class Eye
    {
        public string Main()
        {
            StreamReader sr = new StreamReader("C:\\Users\\sweety\\Desktop\\LessonS\\LessonS1\\Lesson5\\Lesson5\\Text.txt");
            string line = "";
            while (sr.EndOfStream == false)
            {
                line = string.Concat(line, sr.ReadLine());
            }
            return line;
        }
    }
}
