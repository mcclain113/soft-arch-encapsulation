using System;
using System.Reflection.Metadata;

namespace soft_arch_encapsulation
{
    public class Employee
    {
        public const String RequiredMes = " is mandatory ";
        public const  String NewLine = "\n";

        public String FirstName {get;set;}
        public String LastName {get;set;}
        public String Ssn {get;set;}
        public bool MetWithHr {get; set; }
        public bool MetDeptStaff {get; set; }
        public bool ReviewedDeptPolicies {get; set; }
        public bool MovedIn {get; set; }
        public String CubeId {get;set;}
        public DateTime OrientationDate {get;set;}
        public EmployeeReportService ReportService = new EmployeeReportService(); 
        
        public Employee(String firstName, String lastName, String ssn) {
            // Using setter method guarantees validation will be performed
            // Ignore the warning messages for now. Will be explained later
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Ssn = ssn;
        }
        
        private String GetFormattedDate() {
            return OrientationDate.ToString("M/d/yy");
        }
        public void DoFirstTimeOrientation(String cubeId) {
            
            OrientationDate = DateTime.Now;
            MeetWithHrForBenefitAndSalaryInfo();
            MeetDepartmentStaff();
            ReviewDeptPolicies();
            MoveIntoCubicle(cubeId);
        }
        
        private void MeetWithHrForBenefitAndSalaryInfo() {
            MetWithHr = true;
            ReportService.AddData(FirstName + " " + LastName + " met with HR on "
                                  + GetFormattedDate() + NewLine);
        }
        
        private void MeetDepartmentStaff() {
            MetDeptStaff = true;
            ReportService.AddData(FirstName + " " + LastName + " met with dept staff on "
                                  + GetFormattedDate() + NewLine);
        }
        
        public void ReviewDeptPolicies() {
            ReviewedDeptPolicies = true;
            ReportService.AddData(FirstName + " " + LastName + " reviewed dept policies on "
                                  + GetFormattedDate() + NewLine);
        }

        public void MoveIntoCubicle(String cubeId) {
            this.CubeId = cubeId;
            this.MovedIn = true;
            ReportService.AddData(FirstName + " " + LastName + " moved into cubicle "
                                  + cubeId + " on " + GetFormattedDate() + NewLine);
        }
        
        
        public void PrintReport() {
            ReportService.OutputReport();
        }
        
        
        public override string ToString() {
            return "Employee{" + "firstName=" + FirstName + ", lastName=" + LastName + ", ssn=" + Ssn + '}';
        }

        
        public bool HasMetWithHr() {
            return MetWithHr;
        }

        public bool HasMetDeptStaff() {
            return MetDeptStaff;
        }

        public bool HasReviewedDeptPolicies() {
            return ReviewedDeptPolicies;
        }

        public bool HasMovedIn() {
            return MovedIn;
        }
        
    }
}