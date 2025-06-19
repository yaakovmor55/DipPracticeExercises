using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPracticeExercises.LieDetection
{
    internal interface ILieDetector
    {
        bool IsLying(string data);
    }
}
