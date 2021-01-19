using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NovelNew.Models
{
    public class Auther
    {

        // constructor for author
        public Auther()
        {
            ;
            NovelAuthors = new List<NovelAuthor>();

        }
        // seting pk for entity
        [Key]
        public int AuthorId { get; set; }
        // to store name of author
        public string Name { get; set; }
        // Author bio
        public string Bio { get; set; }
        // setting novel authors relationship
        public List<NovelAuthor> NovelAuthors { get; set; }
    }
}

