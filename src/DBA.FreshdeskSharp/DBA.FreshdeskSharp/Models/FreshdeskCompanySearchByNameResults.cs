using System.Collections.Generic;

namespace DBA.FreshdeskSharp.Models
{

    public class FreshdeskCompanySearchByNameItem
    {
        public ulong Id { get; set; }
        public string Name { get; set; }

    }


    public class FreshdeskCompanySearchByNameResults
    {
        public FreshdeskCompanySearchByNameResults()
        {
            Companies = new List<FreshdeskCompanySearchByNameItem>();
        }

        public List<FreshdeskCompanySearchByNameItem> Companies { get; }
    }
}