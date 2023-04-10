using System;

namespace soft_arch_encapsulation
{
    public class EmployeeReportService
    {
        public String Report { get; set; }

        public void AddData(String data) {
            Report += data;
        }

        public void ClearReport() {
            Report = "";
        }

        public void OutputReport() {
            Console.WriteLine(Report);
        }
    }
}