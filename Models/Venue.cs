
    using System.ComponentModel.DataAnnotations;

    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

        [Required]
        public string VenueName { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int Capacity { get; set; }

        // URL for the venue image (using placeholder URLs in Phase 1)
        public string ImageUrl { get; set; }
    }


