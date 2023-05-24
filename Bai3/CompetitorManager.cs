using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class CompetitorManager
    {
        private List<Competitor> competitors;

        public CompetitorManager()
        {
            this.competitors = new List<Competitor>();
        }
        public void AddNewCompetitor(Competitor competitor)
        {
            this.competitors.Add(competitor);
        }
        public List<Competitor> GetCompetitors()
        {
            return this.competitors;
        }
        public Competitor FindByIdentificationNumber(string num)
        {
            var competitor = this.competitors.Where(c=>c.IdentificationNumber.Equals(num)).FirstOrDefault();
            if(competitor != null)
            {
                return competitor;
            }
            else
            {
                return null;
            }
        }
    }
}
