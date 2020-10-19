using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_trainer
{
    class UserProfile
    {
        public string Name = "";

        public bool HpIsLocked = false;
        public bool CsIsLocked = false;
        public bool ArIsLocked = false;
        public bool OdIsLocked = false;
        public decimal lockedHP = 0M;
        public decimal lockedCS = 0M;
        public decimal lockedAR = 0M;
        public decimal lockedOD = 0M;
        
        public bool ScaleAR = true;
        public bool ScaleOD = true;

        public bool ForceHardrockCirclesize = false;
        public bool ChangePitch = false;
        public bool NoSpinners = false;

        public bool BpmIsLocked = false;
        public int lockedBpm = 200;
        public decimal BpmMultiplier = 1.0M;

        public UserProfile(string name)
        {
            Name = name;
        }
    }
}
