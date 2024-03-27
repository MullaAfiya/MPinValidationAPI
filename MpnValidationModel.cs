using System.ComponentModel.DataAnnotations;

namespace MPinValidation
{
    public class MpnValidationModel
    {
        [Required(ErrorMessage = "MpnId is required")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "MpnId length must be between 8 and 50 characters")]
        [RegularExpression(@"^[A-Z][a-zA-Z0-9]*$", ErrorMessage = "MpnId must start with a capital letter and be alphanumeric")]
        public string MpnId { get; set; }
    }
}
