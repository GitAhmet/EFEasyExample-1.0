using EFEasyExample.Enums;
using System.Diagnostics.SymbolStore;

namespace EFEasyExample.DataModels
{
    using EFEasyExample.Enums;
    using System.ComponentModel.DataAnnotations;
    public class Class
    {
        public int ClassID { get; set; }
        [MaxLength(50)]

        public string ClassName { get; set; }
        [Required]

        public int MaxClassSize { get; set; }

        public Language ClassLanguage { get; set; }

    }
}