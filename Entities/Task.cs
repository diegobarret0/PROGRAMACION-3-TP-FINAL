using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Entities
{
    public class Task
    {
        private int id;
        private int projectId;
        private string description;
        private int estimatedHours;
        private float estimatedCost;
        private int actualHours;
        private float actualCost;
        private DateTime endDate;

        public Task(int projectId, string description, int estimatedHours, float estimatedCost, int actualHours, float actualCost, DateTime endDate)
        {
            ProjectId = projectId;
            Description = description;
            EstimatedHours = estimatedHours;
            EstimatedCost = estimatedCost;
            ActualHours = actualHours;
            ActualCost = actualCost;
            EndDate = endDate;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int EstimatedHours
        {
            get { return estimatedHours; }
            set { estimatedHours = value; }
        }
        public float EstimatedCost
        {
            get { return estimatedCost; }
            set { estimatedCost = value; }
        }
        public int ActualHours
        {
            get { return actualHours; }
            set { actualHours = value; }
        }
        public float ActualCost
        {
            get { return actualCost; }
            set { actualCost = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }
}
