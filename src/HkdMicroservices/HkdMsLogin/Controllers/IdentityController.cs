// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Api.Data;
using Api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("identity")]
    [Authorize]
    public class IdentityController : ControllerBase
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public IdentityController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Get()
        {



            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }


        //public IActionResult Get51()
        //{
        //    Golpe golpe = new Golpe
        //    {
        //        MidiaLonga = new Midia
        //        {

        //        }
        //    };
        //    _applicationDbContext.Golpes.Add(golpe);



        //    _applicationDbContext.Golpes.Include(x => x.MidiaLonga);

        //    return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        //}
    }
}