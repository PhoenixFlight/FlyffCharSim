using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFF_Character_Simulator
{
    class FClass
    {
        public enum Job
        {
            JOB_VAGRANT,
            JOB_MERCENARY,
            JOB_ACROBAT,
            JOB_ASSIST,
            JOB_MAGICIAN,
            JOB_KNIGHT,
            JOB_BLADE,
            JOB_JESTER,
            JOB_RANGER,
            JOB_RINGMASTER,
            JOB_BILLPOSTER,
            JOB_PSYCHIKEEPER,
            JOB_ELEMENTOR,
            JOB_KNIGHT_MASTER,
            JOB_BLADE_MASTER,
            JOB_JESTER_MASTER,
            JOB_RANGER_MASTER,
            JOB_RINGMASTER_MASTER,
            JOB_BILLPOSTER_MASTER,
            JOB_PSYCHIKEEPER_MASTER,
            JOB_ELEMENTOR_MASTER,
            JOB_KNIGHT_HERO,
            JOB_BLADE_HERO,
            JOB_JESTER_HERO,
            JOB_RANGER_HERO,
            JOB_RINGMASTER_HERO,
            JOB_BILLPOSTER_HERO,
            JOB_PSYCHIKEEPER_HERO,
            JOB_ELEMENTOR_HERO,
            JOB_LORDTEMPLER_HERO,
            JOB_STORMBLADE_HERO,
            JOB_WINDLURKER_HERO,
            JOB_CRACKSHOOTER_HERO,
            JOB_FLORIST_HERO,
            JOB_FORCEMASTER_HERO,
            JOB_MENTALIST_HERO,
            JOB_ELEMENTORLORD_HERO
        };

        public Job job;
        public FClass()
        {
            job = Job.JOB_VAGRANT;
        }
    }
}
