using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageObjectsProblem
{
    class UC1
    {
            public void GetAttendance()
            {
                int IS_FULL_TIME = 1;
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                if (empCheck == IS_FULL_TIME)
                    Console.WriteLine("Employee Present");
                else
                    Console.WriteLine("Employee Absent");
            }
        
    }
    
}


