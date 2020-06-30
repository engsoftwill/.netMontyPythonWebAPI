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
    public class AutoMapperQuoteView:Profile
    {
        public AutoMapperQuoteView()

        {
            CreateMap<Quote, QuoteView>().ReverseMap();
        }
    }
}