using DipPracticeExercises.MissionLogger;

namespace DipPracticeExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MissionController missionController = new MissionController();
            missionController.RunMission();
        }
    }
}
