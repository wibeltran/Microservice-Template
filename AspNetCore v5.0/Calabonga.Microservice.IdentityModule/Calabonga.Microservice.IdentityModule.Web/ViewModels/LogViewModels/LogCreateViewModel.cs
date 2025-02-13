﻿using System;
using System.ComponentModel.DataAnnotations;
using Calabonga.EntityFrameworkCore.Entities.Base;
using Microsoft.Extensions.Logging;

namespace Calabonga.Microservice.IdentityModule.Web.ViewModels.LogViewModels
{
    /// <summary>
    /// Data Transfer Object for Log entity
    /// </summary>
    public class LogCreateViewModel : IViewModel
    {
        /// <summary>
        /// Log Created At
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Service name or provider
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Logger { get; set; } = null!;

        /// <summary>
        /// Log level for logging. See <see cref="LogLevel"/>
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Level { get; set; } = null!;

        /// <summary>
        /// Log Message
        /// </summary>
        [Required]
        [StringLength(4000)]
        public string Message { get; set; } = null!;

        /// <summary>
        /// Thread identifier
        /// </summary>
        public string? ThreadId { get; set; }

        /// <summary>
        /// Exception message
        /// </summary>
        public string? ExceptionMessage { get; set; }
    }
}