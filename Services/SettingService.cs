using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB.DAL;

namespace WEB.Services
{
    public class SettingService
    {
        private AppDbContext _context { get; set; }
        public SettingService(AppDbContext context)
        {
            _context = context;

        }
        public Dictionary<string, string> GetAllSettings()
        {
            return _context.Settings.ToDictionary(s => s.Key, s => s.Value);
        }
    }
}
