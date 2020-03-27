using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_10_2019
{

    public class Company
    {
        private string Name;// – назва компанії;
        private string Position;// – посада працівника;
        private int Salary;// – зарплата працівника.

        public Company()
        {
            Name = "Non name";
            Position = "NON position";
            Salary = 0;
        }

        public Company(string _name, string _position, int _salary)
        {
            Name = _name;
            Position = _position;
            Salary = _salary;
        }
        public Company(string _name, string _position)
        {
            Name = _name;
            Position = _position;
        }

        public void setName(string newName)
        { Name = newName; }
        public void setPosition(string newPosition)
        { Position = newPosition; }
        public void setSalary(int newSalary)
        { Salary = newSalary; }

        public string getName() { return Name; }
        public string getPosition() { return Position; }
        public int getSalary() { return Salary; }
    }
    public class Worker
    {
        private string Name;// – прізвище та ініціали працівника;
        private int Year;// – рік початку роботи;
        private int Month; // – місяць початку роботи;
        private Company WorkPlace;// – об’єкт типу Company;

        public Worker()
        {
            Name = "NON name";
            Year = 0;
            Month = 0;
        }


        public Worker(string _name, int _year, int _month)
        {
            Name = _name;
            Year = _year;
            Month = _month;
        }

        public Worker(string _name, int _year)
        {
            Name = _name;
            Year = _year;
        }

        public void setName(string newName)
        { Name = newName; }
        public void setYear(int newYear)
        { Year = newYear; }
        public void setMonth(int newMonth)
        { Month = newMonth; }

        public string getName() { return Name; }
        public int getYear() { return Year; }
        public int getMounth() { return Month; }
        public Company getWorkPlace() { return WorkPlace; }

        public void GetWorkExpirience()
        {
            int expmounth = DateTime.Now.Month - getMounth();
            int expyear = DateTime.Now.Year - getYear();
            Console.WriteLine($"Стаж роботи {getName()} = {expyear} років та {expmounth} місяців");
        }

    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Worker igor = new Worker("Igor", 2019, 1);
            igor.GetWorkExpirience();
            
            Console.ReadLine();
        }
    }
}
