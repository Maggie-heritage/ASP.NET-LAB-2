using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace WebApplication1.Models
{
    public class OffersGenreViewModel
    {
        public List<Offers> Offerss { get; set; }
        public SelectList Genres { get; set; }
        public string OffersGenre { get; set; }
        public string SearchString { get; set; }
    }
}





       