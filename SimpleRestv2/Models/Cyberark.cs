using System.ComponentModel.DataAnnotations;

namespace SimpleRestv2.Models
{
    public class Cyberark
    {
        [Key]
        public int Id { get; set; }
        public string APP { get; set; }
        public string Data { get; set; }
        
    }
}
