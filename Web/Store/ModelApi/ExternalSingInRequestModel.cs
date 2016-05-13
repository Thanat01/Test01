﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Store.ModelApi
{
    [Serializable]
    public class ExternalSingInRequestModel
    {
        [Required]
        public string ExternalSystem { get; set; }
        [Required]
        public string ExternalUserId { get; set; }
    }
}