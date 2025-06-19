using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPracticeExercises.LieDetection
{
    internal class ThermalScanner : ILieDetector
    {
        public bool IsLying(string data)
        {
            return data.Contains("heat");
        }
    }
}
