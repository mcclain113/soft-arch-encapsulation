using System;

namespace soft_arch_encapsulation
{
    public class Company
    {
      public  HrPerson Hr;
      public Company() {
          Hr = new HrPerson();
      }
      public void HireEmployee(String firstName, String lastName, String ssn) {
          Hr.HireEmployee(firstName, lastName, ssn);
          Hr.OutputReport(ssn);
      }

        
    }
}