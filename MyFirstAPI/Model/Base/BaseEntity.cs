using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstAPI.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
