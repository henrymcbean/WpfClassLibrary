using System;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class GmcurrsContext : DbContext
    {
        public GmcurrsContext(string Connection) : base(Connection) { }
        public DbSet<GmcurrsCURCurrenciesRec> CURCurrenciesRec { get; set; }
    }
}
