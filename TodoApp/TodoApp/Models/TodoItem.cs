using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    public class TodoItem
    {
        /// <summary>
        /// Az egyes tétel egyedi azonosítója, ennek segítségével a listán azonosítjuk az elemet
        /// </summary>
        public int Id { get; set; }
        public string Name { get; internal set; }
        public bool Done { get; internal set; }
    }
}