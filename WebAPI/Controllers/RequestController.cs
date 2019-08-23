// ***********************************************************************
// Assembly         : WebAPI
// Author           : Andrey Lavrinenko
// Created          : 08-23-2019
//
// Last Modified By : Andrey Lavrinenko
// Last Modified On : 08-23-2019
// ***********************************************************************
// <copyright file="RequestController.cs" company="WebAPI">
//     Copyright (c) Andrey Lavrinenko. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Class RequestController.
    /// Implements the <see cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/request")]
    [ApiController]
    [DisableCors]
    public class RequestController : ControllerBase
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly RequestContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestController"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public RequestController(RequestContext context)
        {
            _context = context;
        }

        // GET: api/request
        /// <summary>
        /// Gets the request details.
        /// </summary>
        /// <returns>Task&lt;ActionResult&lt;IEnumerable&lt;Request&gt;&gt;&gt;.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Request>>> GetRequestDetails()
        {
            return await _context.RequestDetails.ToListAsync();
        }


        // PUT: api/request/5
        /// <summary>
        /// Puts the request detail.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequestDetail(int id, Request request)
        {
            if(id!=request.no)
            {
                return BadRequest();
            }
            _context.Entry(request).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // GET: api/request/5
        /// <summary>
        /// Gets the request detail.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;ActionResult&lt;Request&gt;&gt;.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Request>> GetRequestDetail(int id)
        {
            var paymentDetail = await _context.RequestDetails.FindAsync(id);

            if (paymentDetail == null)
            {
                return NotFound();
            }

            return paymentDetail;
        }

        // POST: api/request
        /// <summary>
        /// Posts the request detail.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;ActionResult&lt;Request&gt;&gt;.</returns>
        [HttpPost]
        public async Task<ActionResult<Request>> PostRequestDetail(Request request)
        {
            _context.RequestDetails.Add(request);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRequestDetail", new { id = request.no }, request);
        }

        // DELETE: api/request/5
        /// <summary>
        /// Deletes the request detail.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;ActionResult&lt;Request&gt;&gt;.</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Request>> DeleteRequestDetail(int id)
        {
            var paymentDetail = await _context.RequestDetails.FindAsync(id);
            if (paymentDetail == null)
            {
                return NotFound();
            }

            _context.RequestDetails.Remove(paymentDetail);
            await _context.SaveChangesAsync();

            return paymentDetail;
        }

        /// <summary>
        /// Payments the detail exists.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool RequestDetailExists(int id)
        {
            return _context.RequestDetails.Any(e => e.no == id);
        }
    }
}
