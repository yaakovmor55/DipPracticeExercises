using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPracticeExercises.BaseAlertSystem
{
    internal class BaseDefenseController
    {
        private IAlert alertSystem;

        public BaseDefenseController(IAlert alertSystem)
        {
            this.alertSystem = alertSystem;
        }

        public void ThreatDetected()
        {
            alertSystem.Alert();
        }
    }
}
