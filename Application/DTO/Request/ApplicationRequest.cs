using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Request
{
    public class ApplicationRequest
    {
        [Required(ErrorMessage = "El ID de usuario es obligatorio.")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "El ID de oferta es obligatorio.")]
        public Guid OfferId { get; set; }
    }
}
