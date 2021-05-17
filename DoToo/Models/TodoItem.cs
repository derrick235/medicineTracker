using System;
using SQLite;

namespace MedicineTracker.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NameOfPill { get; set; } // Title
        public bool Completed { get; set; }
        public DateTime ExpirationDate { get; set; } // Due
        public int PillNum { get; set; }
        public string Frequency { get; set; }
        public string Notes { get; set; }

    }
}