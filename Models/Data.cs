namespace cdmp_Function.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Data
    {
        [Key]
        public string deviceId { get; set; }
        [Required]
        public int messageId { get; set; }
        [Required]
        public float Temperatura { get; set; }
        [Required]
        public float Presion { get; set; }
    }
}
