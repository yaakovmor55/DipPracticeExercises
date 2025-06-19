using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPracticeExercises.MissionLogger
{
    internal class MissionController
    {
        public void RunMission()
        {
            Console.WriteLine("Running mission...");
            FileLogger logger = new FileLogger();
            logger.Log("Mission completed.");
        }
    }
}
