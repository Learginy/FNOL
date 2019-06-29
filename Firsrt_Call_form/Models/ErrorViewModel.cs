using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Firsrt_Call_form.Models
{
    public class FirstCallModel
    {
        public List<string> SimpthomIds { get; set; }
        public string AnotherSimpthoms { get; set; }
        public string HowLong { get; set; }
        public bool FirstTimeCall { get; set; }
        public string Contacts { get; set; }
        public string CallingPerson { get; set; }
        public string RelToIns { get; set; }

        public bool Citizenship { get; set; }

        public string Adress { get; set; }

        public DateTime Vstart { get; set; }
        public DateTime   { get; set; } vggjgh

    public string Email { get; set; }
    }  

    public class AllSimptoms
    {
        public List<SelectListItem> Items { get; set; }
    }
}