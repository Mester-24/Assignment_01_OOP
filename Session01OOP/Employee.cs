using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Session01OOP
{
    internal class Employee
    {
        #region Attributes
        public int Id;
        public string Name;
        private decimal salary;
        #endregion
        #region Constructor
        public Employee(int _Id,string _Name, decimal _salary)
        {
            Id = _Id;
            Name = _Name;
            salary = _salary;
        }
        #endregion
        #region Methods
        public override string ToString() 
        {
            return $"Id :{Id}\nName :{Name}\nSalary :{salary}";
        }
        #endregion
        #region Ecapsulation
        //1.Encapsulation: Sperate Data Defenition [Attributes]
        //From It is Use (Getter / Setter - Property - Indexer)
        //Getter
        public string GetName()
        {
            return Name;
        }



        //Setter
        public void SetName(string value)
        {
            Name = value.Length<=5?value:value.Substring(0,5);
            //controll Data Validation
        }

        //2- Applying Property:
        //2.1 Full Property

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;//>=4000?value:4000;//Controll Data Validation 
            }
        }

        


        //2.2 Automatic Propery
        public int Age { get; set; }
         
        #endregion
    }
}
