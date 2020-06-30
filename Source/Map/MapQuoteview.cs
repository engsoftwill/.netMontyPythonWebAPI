using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codenation.Challenge.Models;
using Codenation.Challenge.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;


namespace Codenation.Challenge
{
    public class MapQuotetoQuoteView
    {
        public QuoteView QUotetoQuoteView(Quote quote)

        {
            QuoteView quoteview = new QuoteView();
            quoteview.Actor = quote.Actor;
            quoteview.Detail = quote.Detail;
            quoteview.Id = quote.Id;
            return quoteview;
        }
    }

}
