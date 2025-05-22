// Lista för att lagra anställda
using Övning_1_Personalregister;

List<Employee> employees = new List<Employee>();

// Huvudloop för meny
while (true)
{
    // Visa menyval
    Console.WriteLine("\nMeny: ---------");
    Console.WriteLine("1. Lägg till anställd");
    Console.WriteLine("2. Ta bort anställd");
    Console.WriteLine("3. Visa anställda");
    Console.WriteLine("4. Sluta");
    Console.Write("Välj: ");

    string? choice = Console.ReadLine(); // Läs användarens val
    if (string.IsNullOrEmpty(choice)) // Kontrollera ogiltig inmatning
    {
        Console.WriteLine("Ogiltigt val, försök igen.");
        continue;
    }

    switch (choice)
    {
        case "1":
            // Lägg till ny anställd
            Console.Write("Namn: ");
            string name = Console.ReadLine(); // Läs namn

            Console.Write("Lön: ");
            string salaryInput = Console.ReadLine(); // Läs lön
            double salary;

            // Försök konvertera lön till nummer
            if (double.TryParse(salaryInput, out salary))
            {
                Employee emp = new Employee(name, salary); // Skapa anställd
                employees.Add(emp); // Lägg till i listan
                Console.WriteLine("Anställd tillagd.");
            }
            else
            {
                Console.WriteLine("Fel: Skriv lön som nummer.");
            }
            break;
        case "2":
            // Lista alla anställda
            if (employees.Count == 0)
            {
                Console.WriteLine("Inga anställda.");
            }
            else
            {
                Console.WriteLine("Anställda:");
                // Loopa genom listan och skriv ut anställda
                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine("#:" + i + " Namn: " + employees[i].name + ", Lön: " + employees[i].salary + " kr");
                }
                Console.WriteLine("Ange numret på den anställde som ska tas bort: ");
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int index) && index >= 0 && index < employees.Count)
                {
                    employees.RemoveAt(index); // Ta bort anställd
                    Console.WriteLine("Anställd borttagen.");
                }
                else
                {
                    Console.WriteLine("Fel: Ogiltigt nummer eller ingen anställd med det numret.");
                }
            }

            break;
        case "3":
            // Visa alla anställda
            if (employees.Count == 0)
            {
                Console.WriteLine("Inga anställda.");
            }
            else
            {
                Console.WriteLine("Anställda:");
                // Loopa genom listan och skriv ut anställda
                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine("Namn: " + employees[i].name + ", Lön: " + employees[i].salary + " kr");
                }
            }
            break;
        case "4":
            return; // Avsluta programmet
        default:
            Console.WriteLine("Ogiltigt val, försök igen.");
            break;
    }
}
/*
 * Övning 1 - Personalregister
 * Datum: 2025-05-21
 * Beskrivning: En enkel personalregisterapplikation som låter användaren lägga till och visa anställda.
 * 
 * 
 * Uppgift 1
 * Vilka klasser bör ingå i programmet? 
 * Vi bör ha en klass för anställd och en klass för personalregister.
 * 
 * 
 * Uppgift 2
 * Vilka attribut och metoder bör ingå i dessa klasser? 
 * Klassen för anställd bör ha attributen namn och lön. Den bör också ha en konstruktor för att initiera dessa värden.
 * 
 */

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
