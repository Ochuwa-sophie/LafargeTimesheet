using System.ComponentModel.DataAnnotations;

namespace LafargeTimesheet.Models
{
    public class TimeSheet
    {
        public int Id { get; set; }
        public string? Employee { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime ClockInDate { get; set; }

        [Required] 
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString="{0:HH:M}", ApplyFormatInEditMode=true)]
        public DateTime ClockInTime { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime ClockOutDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString="{0:HH:M}", ApplyFormatInEditMode=true)]
        public DateTime ClockOutTime { get; set; }

    }
}
