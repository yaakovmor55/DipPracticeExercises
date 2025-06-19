using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPracticeExercises.BaseAlertSystem
{
    internal class SirenAlert : IAlert
    {
        public void Alert()
        {
            Console.WriteLine("Siren is sounding!");
        }
    }
}
