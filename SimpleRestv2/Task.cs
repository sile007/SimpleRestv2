using System.ComponentModel.DataAnnotations;

namespace SimpleRestv2
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }

}
