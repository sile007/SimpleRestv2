using System.ComponentModel.DataAnnotations;

namespace SimpleRestv2.Models
{
    public class Cyberark
    {
        [Key]
        public int Id { get; set; }
        public string UID { get; set; }
        public string Environment { get; set; }
        public string Client { get; set; }
        
    }
}
