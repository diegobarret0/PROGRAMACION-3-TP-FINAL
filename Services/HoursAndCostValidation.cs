using PROGRAMACION_3_TP_FINAL.DataBaseServices;
using PROGRAMACION_3_TP_FINAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Services
{
    public class HoursAndCostValidation
    {
        public HoursAndCostValidation() 
        {
        }
        public int validateHours(int idProject, int hoursToAdd)
        {
            int hoursExtended = hoursToAdd;

            SqlServer sql = new SqlServer();

            List <object> tasksList = sql.searchRow(typeof(Entities.Task), "dbo.task", $"proyect_id={idProject};");

            if(!tasksList.Any()) return 0;

            Entities.Task myTask = new Entities.Task();

            for(int i=0; i < tasksList.Count; i++ )
            {
                myTask = (Entities.Task)tasksList[i];
                hoursExtended += myTask.estimated_hours;
            }

            Project myProject = new Project();
            myProject = (Project)sql.searchRow(typeof(Project), "dbo.project", $"id={idProject}")[0];

            if(myProject.estimated_time >= hoursExtended) return 0;

            int totalHoursExtended = myProject.estimated_time + (hoursExtended - myProject.estimated_time);
            myProject.estimated_time = totalHoursExtended;
            sql.updateRow(myProject, "dbo.project", $"id={idProject};");

            return totalHoursExtended;
        }
        public decimal valitateCost(int idProject, decimal costToAdd)
        {
            decimal costExtended = costToAdd;

            SqlServer sql = new SqlServer();
            List<object> tasksList = sql.searchRow(typeof(Entities.Task), "dbo.task", $"proyect_id={idProject};");

            if (!tasksList.Any()) return 0;

            Entities.Task myTask = new Entities.Task();

            for (int i = 0; i < tasksList.Count; i++)
            {
                myTask = (Entities.Task)tasksList[i];
                costExtended += myTask.estimated_cost;
            }

            Project myProject = new Project();
            myProject = (Project)sql.searchRow(typeof(Project), "dbo.project", $"id={idProject}")[0];

            if (myProject.estimated_amount >= costExtended) return 0;

            decimal totalCostExtended = myProject.estimated_amount + (costExtended - myProject.estimated_amount);
            myProject.estimated_amount = totalCostExtended;
            sql.updateRow(myProject, "dbo.project", $"id={idProject};");

            return myProject.estimated_amount + (costExtended - myProject.estimated_amount);
        }
        public string isFinished(int idProject) 
        {
            string isFinished = "";

            SqlServer sql = new SqlServer();
            List<object> tasksList = sql.searchRow(typeof(Entities.Task), "dbo.task", $"proyect_id={idProject};");

            if (!tasksList.Any()) return "";

            Entities.Task myTask = new Entities.Task();

            for (int i = 0; i < tasksList.Count; i++)
            {
                myTask = (Entities.Task)tasksList[i];
                if (myTask.active == 0) return "";
            }

            Project myProject = new Project();
            myProject = (Project)sql.searchRow(typeof(Project), "dbo.project", $"id={idProject}")[0];
            myProject.active = 1;

            sql.updateRow(myProject, "dbo.project", $"id={idProject}");

            return $"El proyecto {myProject.name_} ha sido finalizado.";
        }
    }
}
