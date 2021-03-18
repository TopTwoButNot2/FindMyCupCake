using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FindMyCupCake.Models
{
    public class FindCupCakeContext :DbContext
    {
        public virtual DbSet<MyCupCake> MyCupCakes { get; set; }
    }
}