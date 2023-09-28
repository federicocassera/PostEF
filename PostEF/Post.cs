using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PostEF
{
    internal class Post
    {
        //segnalazione chiave primaria sul campo sottostante
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("codice")] //seganlo la colonna che sarà la chiave primaria
        public int Code { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PubDate { get; set; }

        public string Note { get; set; }

        [Column("author")]
        [ForeignKey("Author")]
        public string authorLogin { get; set; }
        public User Author{ get; set; }
    }
}
