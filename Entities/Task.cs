﻿using System;
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
        private float estimatedCost;
        private int actualHours;
        private float actualCost;
        private DateTime endDate;

        public Task(int projectId, string description, int estimatedHours, float estimatedCost, int actualHours, float actualCost, DateTime endDate)
        {
            proyect_id = projectId;
            description_ = description;
            estimated_hours = estimatedHours;
            estimated_cost = estimatedCost;
            actual_hours = actualHours;
            actual_cost = actualCost;
            end_date = endDate;
        }

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
        public float estimated_cost
        {
            get { return estimatedCost; }
            set { estimatedCost = value; }
        }
        public int actual_hours
        {
            get { return actualHours; }
            set { actualHours = value; }
        }
        public float actual_cost
        {
            get { return actualCost; }
            set { actualCost = value; }
        }
        public DateTime end_date
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }
}
