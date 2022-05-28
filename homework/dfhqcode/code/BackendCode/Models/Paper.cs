/*namespace TopConferenceProj.Models
{
    public class Paper
    {
    }
}*/

using System.ComponentModel.DataAnnotations;

namespace dfhqcode;

    public class Paper
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
