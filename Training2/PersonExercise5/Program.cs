using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person("Kamil", "Nowak", 28));
            people.Add(new Person("Krzysztof", "Krawczyk", 45));
            people.Add(new Person("Anna", "Dabrowska", 12));
            people.Add(new Person("Jan", "Nowakowski", 17));
            people.Add(new Person("Jan", "Cebula", 56));

            Console.WriteLine("People added to the list:");

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }


            var youngestPerson =
                from Person person in people
                where person.Age == people.Min(p => p.Age)
                select person;

            Console.WriteLine("\nYoungest " + youngestPerson.ElementAt(0));


            var oldestPerson =
                from Person person in people
                where person.Age == people.Max(p => p.Age)
                select person;

            Console.WriteLine("Oldest " + oldestPerson.ElementAt(0));


            var averageAge = people.Average(p => p.Age);

            Console.WriteLine("Average age: " + averageAge.ToString("F"));

            var specificFirstName = "Jan";
            var personWithSpecificFirstName =
                from Person person in people
                where person.FirstName == specificFirstName
                select person;

            Console.WriteLine("\nPeople with name {0}", specificFirstName);

            foreach (Person person in personWithSpecificFirstName)
            {
                Console.WriteLine(person);
            }

            var peopleOrderedByAge =
                from Person person in people
                orderby person.Age
                select person;

            Console.WriteLine("\nPeople orderded by age: ");

            foreach (Person person in peopleOrderedByAge)
            {
                Console.WriteLine(person);
            }


            var peopleOrderedByFirstNameAndLastName =
                from Person person in people
                orderby person.FirstName, person.LastName
                select person;

            Console.WriteLine("\nPeople orderded by First Name and Last Name: ");

            foreach (Person person in peopleOrderedByFirstNameAndLastName)
            {
                Console.WriteLine(person);
            }

            var firstPersonFromPeople =
                (from Person person in people
                 select person).First();

            Console.WriteLine("\nFirst person on the list: \n{0}", firstPersonFromPeople);

            var lastPersonFromPeople =
                (from Person person in people
                 select person).Reverse().First();

            Console.WriteLine("\nLast person on the list: \n{0}", lastPersonFromPeople);


            var nameStarter = "K";
            var peopleWithSpecificFirstName =
                from Person person in people
                where person.FirstName.ToLower().StartsWith(nameStarter.ToLower())
                select person;

            Console.WriteLine("\nPeople whose name starts with \"{0}\":", nameStarter);

            foreach (Person person in peopleWithSpecificFirstName)
            {
                Console.WriteLine(person);
            }

            var lastNameEndsWith = "A";
            var peopleWithSpecificLasttName =
                from Person person in people
                where person.LastName.ToLower().EndsWith(lastNameEndsWith.ToLower())
                select person;

            Console.WriteLine("\nPeople whose last name ends with \"{0}\":", lastNameEndsWith);

            foreach (Person person in peopleWithSpecificLasttName)
            {
                Console.WriteLine(person);
            }

            var firstNameWith = "N";
            var peopleWithFirstName =
                from Person person in people
                where person.FirstName.ToLower().Contains(firstNameWith.ToLower())
                select person;

            Console.WriteLine("\nPeople whose last name ends with \"{0}\":", firstNameWith);

            foreach (Person person in peopleWithFirstName)
            {
                Console.WriteLine(person);
            }

            var adults =
                from Person person in people
                where person.Age >= 18
                select person;

            Console.WriteLine("\nAdults: ");

            //writeListResuts(peopleWithFirstName);

            foreach (Person person in adults)
            {
                Console.WriteLine(person);
            }


            Console.ReadKey();






                //void writeListResuts(System.Collections.Generic.IEnumerable(PersonExercise5.Person) listOfPeople) {

                //foreach (Person person in listOfPeople)
                //{
                //    Console.WriteLine(person);
                //}

            //}


        }
    }
}
