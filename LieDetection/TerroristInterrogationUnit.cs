using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPracticeExercises.LieDetection
{
    internal class TerroristInterrogationUnit
    {
        private ILieDetector detector;

        public TerroristInterrogationUnit(ILieDetector detector)
        {
            this.detector = detector;
        }
    }

    public void Interrogate(string sample)
        {
            bool isLying = detector.IsLying(sample);

            if (isLying)
            {
                Console.WriteLine("Suspect is lying!");
            }
            else
            {
                Console.WriteLine("Suspect is telling the truth.");
            }
        }
}
