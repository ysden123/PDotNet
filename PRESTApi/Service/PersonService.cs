using Microsoft.AspNetCore.Mvc;
using PRESTApi.Data;
using System.Net;

namespace PRESTApi.Service
{
    public class PersonService
    {
        private static List<Person> _persons;

        static PersonService() {
            _persons = [];
        }

        public static Person? ReadPerson()
        {
            return  _persons.Count() == 0? null : _persons.First();
        }

        public static Person? ReadPerson(string name)
        {
            return _persons.Find((p) => p.name == name);
        }

        public static List<Person> ReadAllPersons()
        {
            return new List<Person>(_persons);
        }

        public static Person AddPerson(Person person)
        {
            var nextId = _persons.Count == 0 ? 1 : _persons.Last().id + 1;
            var newPerson = new Person(nextId, person.name, person.age);
            Console.WriteLine($"Adding person: {newPerson}");
            _persons.Add(newPerson);
            //throw new BadHttpRequestException("Some message with explanation");
            return newPerson;
        }
    }
}
