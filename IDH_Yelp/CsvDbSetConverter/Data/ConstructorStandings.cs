﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDbSetConverter.Data
{
    public class ConstructorStandings
    {
        [Key]
        public string ConstructorStandingsId { get; set; }
        public string RaceId { get; set; }
        public string ConstructorId { get; set; }
        public string Points { get; set; }
        public string Position { get; set; }
        public string PositionText { get; set; }
        public string Wins { get; set; }
    }
}
