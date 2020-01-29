using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CODE1ST.Base
{
    public class BaseModel
    {
        [Key]
        public int id { get; set; }
    }
}