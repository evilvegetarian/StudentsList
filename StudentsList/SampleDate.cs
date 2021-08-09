using StudentsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsList
{
    public class SampleDate
    {
        public static void Initialization(StudentGroupContext context)
        {
            Group radiophysics = new Group() { GroupName = "Radiophysics" };
            Group microelectronics = new Group() { GroupName = "Microelectronics" };
            Group generalPhysics = new Group() { GroupName = "General physics" };

            if ((context.Groups.Any(p => p.GroupName == radiophysics.GroupName) &&
                        context.Groups.Any(p => p.GroupName == microelectronics.GroupName) &&
                        context.Groups.Any(p => p.GroupName == generalPhysics.GroupName)) != true)
            {
                context.Groups.AddRange(radiophysics, microelectronics, generalPhysics);
                context.SaveChanges();
            }
        }
    }
}
