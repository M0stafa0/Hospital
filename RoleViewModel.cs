﻿using System.ComponentModel.DataAnnotations;

namespace Security.ViewModels
{
    public class RoleViewModel
    {

        [Display(Name = "Role NAme")]
        public string RoleName { get; set; }
    }
}
