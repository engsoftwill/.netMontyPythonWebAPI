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
            var randomquotes = _context.Quotes
                .Where(x => x.Actor != null).ToList();
            if (randomquotes.Count == 0)
                return null;
            var randomquote = _randomService.RandomInteger(randomquotes.Count);
            return randomquotes[randomquote]; 
        }

        public Quote GetAnyQuote(string actor)
        {

            var randomquotes = _context.Quotes
                .Where(x => x.Actor == actor).ToList();
            if (randomquotes.Count == 0)
                return null;
            var randomquote = _randomService.RandomInteger(randomquotes.Count);
            return randomquotes[randomquote];

        }
    }
}