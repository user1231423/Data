using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Authentication.Models
{
    public class BaseEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Create date
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Update date
        /// </summary>
        public DateTime? UpdateDate { get; set; }
    }
}
