using Fligoo.Challenge.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace Fligoo.Challenge.Data.Repository
{
    public class CompetitionRepository : ICompetitionRepository, IDisposable
    {
        private ApplicationDbContext _applicationDbcontext;

        public CompetitionRepository(ApplicationDbContext context)
        {
            _applicationDbcontext = context;
        }

        public List<Competition> GetCompetitions()
        {
            return _applicationDbcontext.Competitions.ToList();
        }

        public void InsertCompetition(Competition competition)
        {
            _applicationDbcontext.Competitions.Add(competition);
        }

        public void InsertCompetitions(IEnumerable<Competition> competitions)
        {
            _applicationDbcontext.Competitions.AddRange(competitions);
        }

        public void Save()
        {
            try
            {
                _applicationDbcontext.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                IEnumerable<DbEntityValidationResult> errors = ex.EntityValidationErrors;
                throw;
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _applicationDbcontext.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
