
using System;
using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        public string Description { get; set; }

    // Foreign key to Venue
        [Required(ErrorMessage = "Venue is required.")]  //  Ensures validation
        [ForeignKey("Venue")]
        public int VenueId { get; set; }

        [Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidateNever]
        public Venue Venue { get; set; }
    }


