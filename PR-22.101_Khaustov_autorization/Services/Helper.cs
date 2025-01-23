using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR_22._101_Khaustov_autorization.Models;

namespace PR_22._101_Khaustov_autorization.Services
{
    internal class Helper
    {
        AutorizationEntities _context;
        public AutorizationEntities GetContext()
        {
            if (_context == null)
            {
                _context = new AutorizationEntities();
            }
            return _context;
        }
    }
}
