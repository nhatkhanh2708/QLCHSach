
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public abstract class BaseDTO
    {
        [DisplayName("Id")]
        public int Id { get; set; }
    }
}
