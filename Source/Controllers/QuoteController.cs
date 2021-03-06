﻿using System;
using System.Collections.Generic;
using Codenation.Challenge.Models;
using Codenation.Challenge.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;


namespace Codenation.Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private readonly IQuoteService _service;

        public QuoteController(IQuoteService service)
        {
            _service = service;
        }

        // GET api/quote
        [HttpGet]
        public ActionResult<QuoteView> GetAnyQuote()
        {
            var quote = _service.GetAnyQuote();
            MapQuotetoQuoteView quoteView = new MapQuotetoQuoteView();
            return quoteView.QUotetoQuoteView(quote);
        }

        // GET api/quote/{actor}
        [HttpGet("{actor}")]
        public ActionResult<QuoteView> GetAnyQuote(string actor)
        {
            Quote quote = _service.GetAnyQuote(actor);
            MapQuotetoQuoteView mapper = new MapQuotetoQuoteView();
            if (quote == null)
            {
                return new NotFoundResult();
            }

            return mapper.QUotetoQuoteView(quote);
        }

    }
}
