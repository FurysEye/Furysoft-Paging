// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PagingHelpersTests.cs" company="Simon Paramore">
// © 2017, Simon Paramore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Furysoft.Paging.Tests.Unit
{
    using System.Diagnostics;
    using NUnit.Framework;

    /// <summary>
    /// The Paging Helpers Tests
    /// </summary>
    [TestFixture]
    public sealed class PagingHelpersTests : TestBase
    {
        /// <summary>
        /// Gets the skip when values provided expect correct page.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="itemsPerPage">The items per page.</param>
        /// <returns>The Expected Result</returns>
        [TestCase(1, 25, ExpectedResult = 0)]
        [TestCase(2, 25, ExpectedResult = 25)]
        [TestCase(3, 50, ExpectedResult = 100)]
        public int GetSkip_WhenValuesProvided_ExpectCorrectPage(int page, int itemsPerPage)
        {
            // Act
            var stopwatch = Stopwatch.StartNew();
            var skip = PagingHelpers.GetSkip(page, itemsPerPage);
            stopwatch.Stop();

            // Assert
            this.WriteTimeElapsed(stopwatch);

            return skip;
        }
    }
}