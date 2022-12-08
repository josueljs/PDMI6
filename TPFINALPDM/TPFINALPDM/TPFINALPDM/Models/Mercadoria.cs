using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace TPFINALPDM.Models
{
    [Table("Mercadoria")]
    public class Mercadoria
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeMercadoria { get; set; }
        public string Peso { get; set; }
        public string NomeProdutor { get; set; }
        public string Email { get; set; }
        public string NCM { get; set; }
    }
}