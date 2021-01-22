using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic
{

    public class Person {

        //constructor
        public Person() { 
        
        }

        //constructor
        public Person(string firstName, int age,  string gender) {
            this.firstName = firstName;
            this.age = age;
            this.gender = gender;
        
        }

        //getter and setter
        public string firstName { get; set; }

        public int age { get; set; }

        public string gender { get; set; }

       



    }

    class Program
    {
        public static void printAll(List<Person> personDetails) {
            foreach (Person p in personDetails) {
                Console.WriteLine(p.firstName + " " + p.age + " " + p.gender);
            }
        }

        public static void filterAgeOver35(List<Person> personDetails) {
            for (int i = 0; i < personDetails.Count; i++) {
                if (personDetails[i].age > 35) {
                    Console.WriteLine(personDetails[i].firstName + " " + personDetails[i].age + " " + personDetails[i].gender);
                }
            }
        }

        public static void sortName(List<Person> personDetails) {
            List<Person> sortedList = personDetails.OrderBy(x => x.firstName).ToList();
            foreach (Person p in sortedList)
            {
                Console.WriteLine(p.firstName + " " + p.age + " " + p.gender);
            }
        }

        public static List<Person> concatTwoList(List<Person> personDetails, List<Person> newPersonDetails) {
            List<Person> combineList = personDetails.Concat(newPersonDetails).ToList();
            foreach (Person p in combineList)
            {
                Console.WriteLine(p.firstName + " " + p.age + " " + p.gender);
            }
            return combineList;
        }

        public static void removeMale(List<Person> combineList) {
            List<Person> female = new List<Person>();

            for (int i = 0; i < combineList.Count; i++)
            {
                if (combineList[i].gender == "Female")
                {
                    Console.WriteLine(combineList[i].firstName + " " + combineList[i].age + " " + combineList[i].gender);
                }
            }
        }


        static void Main(string[] args)
        {

            List <Person> personDetails = new List<Person>();

            personDetails.Add(new Person("John", 43, "Male"));
            personDetails.Add(new Person("Gorge", 29, "Male"));
            personDetails.Add(new Person("Mary", 38, "Female"));
            personDetails.Add(new Person("Tiffany", 24, "Female"));
            personDetails.Add(new Person("Alex", 22, "Male"));

            List<Person> newPersonDetails = new List<Person>();
            newPersonDetails.Add(new Person("May", 25, "Female"));
            newPersonDetails.Add(new Person("Lee", 33, "Male"));
            newPersonDetails.Add(new Person("Adam", 34, "Male"));





            Console.WriteLine("List of PersonDetails:");
            printAll(personDetails);
            Console.WriteLine("====================================");

            Console.WriteLine("Age over 35:");
            filterAgeOver35(personDetails);
            Console.WriteLine("====================================");
            Console.WriteLine("Sorted by First Name:");
            sortName(personDetails);
            Console.WriteLine("====================================");
            Console.WriteLine("Add new List:");
            List<Person> combineList = personDetails.Concat(newPersonDetails).ToList();
            foreach (Person p in combineList)
            {
                Console.WriteLine(p.firstName + " " + p.age + " " + p.gender);
            }

            //concatTwoList(personDetails, newPersonDetails);
            Console.WriteLine("====================================");
            Console.WriteLine("Remove Male people");
            removeMale(personDetails);



        }
    }
}
