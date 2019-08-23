// ***********************************************************************
// Assembly         : WebAPI
// Author           : Andrey Lavrinenko
// Created          : 08-23-2019
//
// Last Modified By : Andrey Lavrinenko
// Last Modified On : 08-23-2019
// ***********************************************************************
// <copyright file="RequestContext.cs" company="WebAPI">
//     Copyright (c) Andrey Lavrinenko. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    /// <summary>
    /// Class RequestContext.
    /// Implements the <see cref="Microsoft.EntityFrameworkCore.DbContext" />
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class RequestContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public RequestContext(DbContextOptions<RequestContext> options) : base(options)
        {
            
        }

        /// <summary>
        /// Gets or sets the request details.
        /// </summary>
        /// <value>The request details.</value>
        public DbSet<Request> RequestDetails { get; set; }

    }
}
