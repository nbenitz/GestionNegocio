using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDoor
{
    public class DataAcceso
    {
        public List<view_finger_print> FindDataList(string employeeNo)
        {
            using (var db = new minegocioEntities())
            {
                List<view_finger_print> fp_List = new List<view_finger_print>();
                try
                {
                    fp_List = db.view_finger_print.Where(f => f.employeeNo == employeeNo)
                                                  .ToList();
                }
                catch (Exception e)
                {
                    ;
                }
                return fp_List;
            }
        }
    }
}
