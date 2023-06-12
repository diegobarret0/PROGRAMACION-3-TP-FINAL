using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Entities
{
    public class Project
    {
        private int id;
        private string name;
        private float estimatedAmount;
        private int estimatedTime;
        private int proprietorId;
        private int leaderFile;

        public Project(string name, float estimatedAmount, int estimatedTime, int proprietorId, int leaderFile)
        {
            Name = name;
            EstimatedAmount = estimatedAmount;
            EstimatedTime = estimatedTime;
            ProprietorId = proprietorId;
            LeaderFile = leaderFile;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float EstimatedAmount
        {
            get { return estimatedAmount; }
            set { estimatedAmount = value; }
        }
        public int EstimatedTime
        {
            get { return estimatedTime; }
            set { estimatedTime = value; }
        }
        public int ProprietorId
        {
            get { return proprietorId; }
            set { proprietorId = value;}
        }
        public int LeaderFile
        {
            get { return leaderFile; }
            set { leaderFile = value; }
        }
    }
}
