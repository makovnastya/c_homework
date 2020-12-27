using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

//Домашнее задание №1
//Вариант F1
//Разработать библиотеку классов, которая реализует сущности Song, Album, Composer;
//реализовать сохранение корневой сущности в XML путем сериализации

namespace homework1
{
    [Serializable]
    public class Composer
    {
        public string Name { get; set; }
        public string Last_name { get; set; }
        public Composer() { }

        public Composer(string name, string last_name)
        {
            Name = name;
            Last_name = last_name;
        }
    }

    [Serializable]
    public class Song
    {
        public string Name { get; set; }
        public List<string> Genre { get; set; }
        public int Year { get; set; }
        public List<Composer> Composer { get; set; }

        public Song() { }

        public Song(string name, List<string> genre, int year, List<Composer> composer)
        {
            Name = name;
            Genre = genre;
            Year = year;
            Composer = composer;
        }
    }

    [Serializable]
    public class Album
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public int Year { get; set; }
        public Album() { }

        public Album(string name, List<Song> songs, int year)
        {
            Name = name;
            Songs = songs;
            Year = year;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var philipGlass = new Composer { Name = "Philip", Last_name = "Glass" };
            var composers = new List<Composer>() { philipGlass };
            var song = new Song("Mad Rush", new List<string>() { "Instrumental" }, 1989, composers);
            var album = new Album("Mad Rush", new List<Song>() { song }, 2015);

            XmlSerializer formatter = new XmlSerializer(typeof(Album));

            using (FileStream fs = new FileStream("album.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, album);
            }
        }
    }
}
