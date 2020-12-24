using System;
using System.Collections.Generic;

//Домашнее задание №1
//Вариант F
//Разработать библиотеку классов, которая реализует сущности Song, Album, Composer

namespace homework1
{
    class Song
    {
        public string name { get; set; }
        public int year { get; set; }
        public string[] genre;
        public Composer[] composer { get; set; } = null;
        public Album songs { get; set; } = null;
    }
    class Album
    {
        public string name { get; set; }
        public int year { get; set; }
        public Song[] songs { get; set; }
    }
    class Composer
    {
        public string name { get; set; }
        public string last_name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
