using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a valid Sender Id")]
        public int SenderId { get; set; }

        [ForeignKey("SenderId")]
        public virtual UserProfile Sender { get; set; } = null!;

        [Required(ErrorMessage = "Please provide a valid Receiver Id")]
        public int ReceiverId { get; set; }

        [ForeignKey("ReceiverId")]
        public virtual UserProfile Receiver { get; set; } = null!;

        [Required(ErrorMessage = "Please provide a Status")]
        public int Status { get; set; } = 0;

        [Required(ErrorMessage = "Please provide a Message. At least 2 letters required")]
        [MinLength(2, ErrorMessage = "Use at least 2 letters")]
        public string Msg { get; set; } = null!;

        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
