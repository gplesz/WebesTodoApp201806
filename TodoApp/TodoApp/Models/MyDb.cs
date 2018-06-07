using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    /// <summary>
    /// Egy ideiglenes barkács "adatbázis"
    /// ami kiszolgálja a webszerver alkalmazásunkat
    /// tanulási/tesztelési időben
    /// </summary>
    public class MyDb
    {
        //bevásárló lista adatai:
        public static List<TodoItem> Lista = new List<TodoItem>
        {
            new TodoItem() { Name = "Só", Done = true },
            new TodoItem() { Name = "Cukor", Done = true },
            new TodoItem() { Name = "Spagetti", Done = true },
            new TodoItem() { Name = "Marhahús", Done = false },
            new TodoItem() { Name = "Paradicsom", Done = false }
        };
    }
}