using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Entities
{
    public class Task
    {
        private int id_;
        private int projectId;
        private string description;
        private int estimatedHours;
        private decimal estimatedCost;
        private int actualHours;
        private decimal actualCost;
        private DateTime endDate;
        private int isActive;

        public Task(int projectId, string description, int estimatedHours, decimal estimatedCost, int actualHours, decimal actualCost, DateTime endDate, int isActive)
        {
            proyect_id = projectId;
            description_ = description;
            estimated_hours = estimatedHours;
            estimated_cost = estimatedCost;
            actual_hours = actualHours;
            actual_cost = actualCost;
            end_date = endDate;
            active = isActive;
        }
        public Task() { }

        public int id
        {
            get { return id_; }
            set { id_ = value; }
        }
        public int proyect_id
        {
            get { return projectId; }
            set { projectId = value; }
        }
        public string description_
        {
            get { return description; }
            set { description = value; }
        }
        public int estimated_hours
        {
            get { return estimatedHours; }
            set { estimatedHours = value; }
        }
        public decimal estimated_cost
        {
            get { return estimatedCost; }
            set { estimatedCost = value; }
        }
        public int actual_hours
        {
            get { return actualHours; }
            set { actualHours = value; }
        }
        public decimal actual_cost
        {
            get { return actualCost; }
            set { actualCost = value; }
        }
        public DateTime end_date
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public int active
        {
            get { return isActive; }
            set { isActive = value; }
        }
        public override string ToString()
        {
            return $"Task ID: {id}\n" +
                   $"Project ID: {proyect_id}\n" +
                   $"Description: {description_}\n" +
                   $"Estimated Hours: {estimated_hours}\n" +
                   $"Estimated Cost: {estimated_cost}\n" +
                   $"Actual Hours: {actual_hours}\n" +
                   $"Actual Cost: {actual_cost}\n" +
                   $"End Date: {end_date}\n" +
                   $"Active: {active}";
        }
    }
}
