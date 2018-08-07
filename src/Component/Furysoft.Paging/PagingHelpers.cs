// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PagingHelpers.cs" company="Simon Paramore">
// © 2017, Simon Paramore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Furysoft.Paging
{
    /// <summary>
    /// The Paging Helpers
    /// </summary>
    public static class PagingHelpers
    {
        /// <summary>
        /// Gets the skip.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="itemsPerPage">The items per page.</param>
        /// <returns>The Number of entries to skip</returns>
        public static int GetSkip(int page, int itemsPerPage)
        {
            return (page - 1) * itemsPerPage;
        }
    }
}