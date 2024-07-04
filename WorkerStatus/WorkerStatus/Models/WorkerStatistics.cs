using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WorkerStatus.Models
{
    public class WorkerStatistics
    {
        public List<Person>? Persons { get; set; }

        public SelectList? Positions {  get; set; }

        public SelectList? Teams { get; set; }

        public string? PersonPosition { get; set; }

        public string? SearchString { get; set; }

        public string? PersonTeam { get; set; }

        public string? SearchPersonTeam { get; set; }


    }
}
