using System;
using System.Linq;
using Codenation.Challenge.Models;

namespace Codenation.Challenge.Services
{
    public class QuoteService : IQuoteService
    {
        private ScriptsContext _context;
        private IRandomService _randomService;

        public QuoteService(ScriptsContext context, IRandomService randomService)
        {
            this._context = context;
            this._randomService = randomService;
        }

        public Quote GetAnyQuote()
        {
            return null;
        }

        public Quote GetAnyQuote(string actor)
        {
            if (actor == null)
                return null;
            return _context.Quotes.Find(actor);
        }
    }
}