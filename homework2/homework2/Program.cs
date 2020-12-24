using System;
using System.IO;
using System.Xml.Serialization;


//Домашнее задание №2
//Вариант 1
//Реализовать сохранение корневой сущности в XML путем сериализации

namespace Serialization
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            Person person = new Person("Anastasiya", 20);
            Console.WriteLine("Объект создан");

            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(Person));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);

                Console.WriteLine("Объект сериализован");
            }

            
            Console.ReadLine();
        }
    }
}