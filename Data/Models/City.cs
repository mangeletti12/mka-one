using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

//
namespace mka_one.Data.Models
{
    public class City
    {
        #region Constructor
        public City()
        {

        }
        #endregion


        #region Props

        /// <summary>
        /// This unique id and primary key for this City
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// City Name (in UTF8 format)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// City Name (in ASCII format)
        /// </summary>
        public string Name_ASCII { get; set; }

        /// <summary>
        /// City latitufe
        /// </summary>
        [Column (TypeName = "decimal(7,4)")]
        public decimal Lat { get; set; }

        /// <summary>
        /// City longitude
        /// </summary>
        [Column (TypeName = "decimal(7,4)")]
        public decimal Lon { get; set; }

        /// <summary>
        /// Country Id (foreign key)
        /// </summary>
        [ForeignKey("Country")]
        public int CountryId { get; set; }

        #endregion

        public virtual Country Country { get; set; }



    }
}
