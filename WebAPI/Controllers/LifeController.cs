// ***********************************************************************
// Assembly         : WebAPI
// Author           : Andrey Lavrinenko
// Created          : 08-23-2019
//
// Last Modified By : Andrey Lavrinenko
// Last Modified On : 08-23-2019
// ***********************************************************************
// <copyright file="LifeController.cs" company="WebAPI">
//     Copyright (c) Andrey Lavrinenko. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Class LifeController.
    /// Implements the <see cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/life")]
    [ApiController]
    [DisableCors]
    public class LifeController : ControllerBase
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>ActionResult&lt;IEnumerable&lt;System.String&gt;&gt;.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new [] { "It's alive!", "Request.Test v1.0.0" };
        }
    }
}
