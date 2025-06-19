using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPracticeExercises.MissionLogger
{
    internal class FileLogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging to file: " + message);
        }
    }
}
