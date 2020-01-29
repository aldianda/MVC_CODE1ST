using MVC_CODE1ST.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_CODE1ST.Models
{
    [Table("TB_M_Role")]
    public class Role : BaseModel
    {
        public string name { get; set; }
    }
}