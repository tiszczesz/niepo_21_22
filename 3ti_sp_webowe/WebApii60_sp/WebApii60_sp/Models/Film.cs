using System.ComponentModel.DataAnnotations;

namespace WebApii60_sp.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Director { get; set; }
        public DateOnly CreateDate { get; set; }
    }
}
