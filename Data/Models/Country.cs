using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

//
namespace mka_one.Data.Models
{
    public class Country
    {
        #region Constructor
        public Country()
        {

        }
        #endregion


        #region Props

        /// <summary>
        /// This unique id and primary key for this Country
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// City Name (in UTF8 format)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Country code (alpha 2 format)
        /// </summary>
        public string ISO2 { get; set; }

        /// <summary>
        /// Country code (alpha 3 format)
        /// </summary>
        public string ISO3 { get; set; }


        #endregion

        public virtual List<City> Cities { get; set; }



    }
}
