// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Paged.cs" company="Simon Paramore">
// © 2017, Simon Paramore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Furysoft.Paging
{
    using System.Collections.Generic;

    /// <summary>
    /// The Paged Entity
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public sealed class Paged<TEntity>
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public IList<TEntity> Data { get; set; }

        /// <summary>
        /// Gets or sets the items per page.
        /// </summary>
        public int ItemsPerPage { get; set; }

        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the total items.
        /// </summary>
        public int TotalItems { get; set; }

        /// <summary>
        /// Gets or sets the total pages.
        /// </summary>
        public int TotalPages { get; set; }
    }
}