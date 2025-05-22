using System;

namespace Övning_1_Personalregister
{
    // Klass för att representera en anställd
    class Employee
    {
        public string name; // Anställds namn
        public double salary; // Anställds lön

        // Konstruktor för att skapa en anställd
        public Employee(string n, double s)
        {
            name = n;
            salary = s;
        }
    }
}