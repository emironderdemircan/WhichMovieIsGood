using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace whichmovieisgood.Models
{
    [Table("Filmler")]
    public class Film
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FilmAd { get; set; }
        public string FilmYapimYili { get; set; }
        public string FilmTuru { get; set; }
        public string FilmSure { get; set; }
        public string FilmYonetmen { get; set; }
        public string FilmOyuncu { get; set; }
        public string FilmOzet { get; set; }

    }
}