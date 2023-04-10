using System;
using System.Collections.Generic;

namespace soft_arch_encapsulation
{
    public class HrPerson
    {
        private List<Employee> Employees = new List<Employee>();

        public HrPerson() {

        }
        public void HireEmployee(String firstName, String lastName, String ssn) {
            Employee e = new Employee(firstName, lastName, ssn);
            Employees.Add(e);
            OrientEmployee(e);
        }
        
        private void OrientEmployee(Employee emp) {
            emp.DoFirstTimeOrientation("B101");
        }
        
        public void OutputReport(String ssn) {

            // find employee in list

            for (int i = 0; i < Employees.Count; i++)
            {
                Employee emp = Employees[i];
                if (emp.Ssn == ssn) {
                    // if found run report
                    if (emp.HasMetWithHr() && emp.HasMetDeptStaff()
                                           && emp.HasReviewedDeptPolicies() && emp.HasMovedIn()) {
                        emp.PrintReport();
                    }
                    break;
                }
                
            } 
        }
            
            

        }
    }
