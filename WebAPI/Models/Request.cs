// ***********************************************************************
// Assembly         : WebAPI
// Author           : Andrey Lavrinenko
// Created          : 08-23-2019
//
// Last Modified By : Andrey Lavrinenko
// Last Modified On : 08-23-2019
// ***********************************************************************
// <copyright file="Request.cs" company="WebAPI">
//     Copyright (c) Andrey Lavrinenko. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    /// <summary>
    /// Class Request.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Gets or sets the no.
        /// </summary>
        /// <value>The no.</value>
        [Key]
        public int no { get; set; }
        /// <summary>
        /// Gets or sets the firm.
        /// </summary>
        /// <value>The firm.</value>
        [Required]
        [Column(TypeName ="nvarchar(255)")]
        public string firm { get; set; }
        /// <summary>
        /// Gets or sets the fio.
        /// </summary>
        /// <value>The fio.</value>
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string fio { get; set; }
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The position.</value>
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string position { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string email { get; set; }
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        [Required]
        [Column(TypeName = "BIGINT")]
        public long date { get; set; }
    }
}
