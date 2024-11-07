﻿using Microsoft.AspNetCore.Mvc;
using MVCVoertuig.Data;

namespace MVCVoertuig.Components
{
    public class HeaderMenuViewComponent : ViewComponent
    {
        VoertuigDbContext _context;
        public HeaderMenuViewComponent(VoertuigDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var merken = _context.Voertuigen.Select(x=>x.Merk).Distinct().OrderBy(x=>x);    
            return View(merken);
        }
    }
}
