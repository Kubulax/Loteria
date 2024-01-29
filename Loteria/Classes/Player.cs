﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loteria.Classes
{
    public class Player
    {
        [AutoIncrement,PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }

        public Player(int id, string name, string surname, string email, string code)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Code = code;
        }

        public Player(string name, string surname, string email, string code)
        {
            
            Name = name;
            Surname = surname;
            Email = email;
            Code = code;
        }

        public Player()
        {
           
        }
    }
}
