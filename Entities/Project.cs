using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Entities
{
    public class Project
    {
        private int id_;
        private string name;
        private float estimatedAmount;
        private int estimatedTime;
        private int proprietorId;
        private int leaderFile;

        public Project(string name, float estimatedAmount, int estimatedTime, int proprietorId, int leaderFile)
        {
            name_ = name;
            estimated_amount = estimatedAmount;
            estimated_time = estimatedTime;
            proprietor_id = proprietorId;
            leader_file = leaderFile;
        }
        public Project() { }

        public int id
        {
            get { return id_; }
            set { id_ = value; }
        }
        public string name_
        {
            get { return name; }
            set { name = value; }
        }
        public float estimated_amount
        {
            get { return estimatedAmount; }
            set { estimatedAmount = value; }
        }
        public int estimated_time
        {
            get { return estimatedTime; }
            set { estimatedTime = value; }
        }
        public int proprietor_id
        {
            get { return proprietorId; }
            set { proprietorId = value;}
        }
        public int leader_file
        {
            get { return leaderFile; }
            set { leaderFile = value; }
        }
    }
}
