﻿using GigHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigHub.ViewModels
{
    public class GigFormViewModels
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}