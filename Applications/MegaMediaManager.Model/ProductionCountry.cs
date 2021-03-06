using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infrastructure;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaMediaManager.Model
{
    public class ProductionCountry : IDateTracking
    {
        [Key, Column(Order = 0)]
        public int MovieId { get; set; }

        [Key, Column(Order = 1)]
        public Country CountryCd { get; set; }
        
        [JsonIgnore]
        public DateTime DateCreated { get; set; }

        [JsonIgnore]
        public DateTime DateModified { get; set; }
        
        #region Navigation Properties
        public virtual Movie Movie { get; set; }

        public virtual Country Country { get; set; }
        #endregion
    }
}
