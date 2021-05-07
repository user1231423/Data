using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Chat.Models
{
    public class Conversation
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// <para>1: Private</para>
        /// <para>2: Group</para>
        /// </summary>
        [Required]
        [Range(1, 2, ErrorMessage = "Value must be between 1 and 2")]
        public byte Type { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Required]
        [StringLength(255, ErrorMessage = "Max conversation name lenght is 55")]
        public string Name { get; set; }

        /// <summary>
        /// Date started
        /// </summary>
        public DateTime DateStarted { get; set; } = DateTime.Now;
    }
}
