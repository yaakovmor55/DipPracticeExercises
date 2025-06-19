using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPracticeExercises.BaseAlertSystem
{
    internal class DroneDispatchAlert : IAlert
    {
        public void Alert()
        {
            Console.WriteLine("Drone dispatched to investigate the threat!");
        }
    }
}
