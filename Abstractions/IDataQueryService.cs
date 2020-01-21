namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>A service that reads data.</summary>
    [PublicAPI]
    public interface IDataQueryService : INameableService
    {
        /// <summary>Determines whether any element of a sequence satisfies a condition.</summary>
        /// <param name="source">A sequence whose elements to test for a condition.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns><see langword="true" /> if any elements in the source sequence pass the test in the specified predicate; otherwise, <see langword="false" />.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> or <paramref name="predicate"/> is <see langword="null" />.</exception>
        Task<bool> AnyAsync<T>(IQueryable<T> source, Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

        /// <summary>Determines whether a sequence contains any elements.</summary>
        /// <param name="source">A sequence to check for being empty.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns><see langword="true" /> if the source sequence contains any elements; otherwise, <see langword="false" />.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />.</exception>
        Task<bool> AnyAsync<T>(IQueryable<T> source, CancellationToken cancellationToken = default);

        /// <summary>Computes the average of a sequence of nullable <see cref="decimal"/> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of nullable <see cref="decimal"/> values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values, or <see langword="null" /> if the <paramref name="source"/> sequence is empty or contains only <see langword="null" /> values.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> or <paramref name="selector"/> is <see langword="null" />.</exception>
        Task<decimal?> AverageAsync<T>(IQueryable<T> source, Expression<Func<T, decimal?>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the average of a sequence of <see cref="decimal"/> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of <see cref="decimal"/> values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> or <paramref name="selector"/> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="source" /> contains no elements.</exception>
        Task<decimal> AverageAsync<T>(IQueryable<T> source, Expression<Func<T, decimal>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the average of a sequence of nullable <see cref="double"/> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of nullable <see cref="double"/> values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values, or <see langword="null" /> if the <paramref name="source"/> sequence is empty or contains only <see langword="null" /> values.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> or <paramref name="selector"/> is <see langword="null" />.</exception>
        Task<double?> AverageAsync<T>(IQueryable<T> source, Expression<Func<T, double?>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the average of a sequence of <see cref="double"/> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of <see cref="double"/> values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> or <paramref name="selector"/> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="source" /> contains no elements.</exception>
        Task<double> AverageAsync<T>(IQueryable<T> source, Expression<Func<T, double>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the average of a sequence of nullable <see cref="float"/> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of nullable <see cref="float"/> values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values, or <see langword="null" /> if the <paramref name="source"/> sequence is empty or contains only <see langword="null" /> values.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> or <paramref name="selector"/> is <see langword="null" />.</exception>
        Task<float?> AverageAsync<T>(IQueryable<T> source, Expression<Func<T, float?>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the average of a sequence of <see cref="float"/> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of <see cref="float"/> values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> or <paramref name="selector"/> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="source" /> contains no elements.</exception>
        Task<float> AverageAsync<T>(IQueryable<T> source, Expression<Func<T, float>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the average of a sequence of nullable <see cref="int"/> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of nullable <see cref="int"/> values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values, or <see langword="null" /> if the <paramref name="source"/> sequence is empty or contains only <see langword="null" /> values.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> or <paramref name="selector"/> is <see langword="null" />.</exception>
        Task<double?> AverageAsync<T>(IQueryable<T> source, Expression<Func<T, int?>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the average of a sequence of <see cref="int"/> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of <see cref="int"/> values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> or <paramref name="selector"/> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="source" /> contains no elements.</exception>
        Task<double> AverageAsync<T>(IQueryable<T> source, Expression<Func<T, int>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the average of a sequence of nullable <see cref="long"/> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of nullable <see cref="long"/> values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values, or <see langword="null" /> if the <paramref name="source"/> sequence is empty or contains only <see langword="null" /> values.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> or <paramref name="selector"/> is <see langword="null" />.</exception>
        Task<double?> AverageAsync<T>(IQueryable<T> source, Expression<Func<T, long?>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the average of a sequence of <see cref="long"/> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of <see cref="long"/> values to calculate the average of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> or <paramref name="selector"/> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="source" /> contains no elements.</exception>
        Task<double> AverageAsync<T>(IQueryable<T> source, Expression<Func<T, long>> selector, CancellationToken cancellationToken = default);

        /// <summary>Returns the number of elements in a sequence.</summary>
        /// <param name="source">The <see cref="IQueryable{T}" /> that contains the elements to be counted.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The number of elements in the input sequence.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> is <see langword="null" />.</exception>
        /// <exception cref="OverflowException">The number of elements in <paramref name="source" /> is larger than <see cref="int.MaxValue" />.</exception>
        Task<int> CountAsync<T>(IQueryable<T> source, CancellationToken cancellationToken = default);

        /// <summary>Returns the number of elements in the specified sequence that satisfies a condition.</summary>
        /// <param name="source">An <see cref="IQueryable{T}" /> that contains the elements to be counted.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The number of elements in the sequence that satisfies the condition in the predicate function.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        /// <exception cref="OverflowException">The number of elements in <paramref name="source" /> is larger than <see cref="int.MaxValue" />.</exception>
        Task<int> CountAsync<T>(IQueryable<T> source, Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

        /// <summary>Returns the first element of a sequence.</summary>
        /// <param name="source">The <see cref="IQueryable{T}" /> to return the first element of.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The first element in <paramref name="source" />.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException">The source sequence is empty.</exception>
        Task<T> FirstAsync<T>(IQueryable<T> source, CancellationToken cancellationToken = default);

        /// <summary>Returns the first element of a sequence that satisfies a specified condition.</summary>
        /// <param name="source">An <see cref="IQueryable{T}" /> to return an element from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The first element in <paramref name="source" /> that passes the test in <paramref name="predicate" />.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException">No element satisfies the condition in <paramref name="predicate" />.
        /// -or-
        /// The source sequence is empty.</exception>
        Task<T> FirstAsync<T>(IQueryable<T> source, Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

        /// <summary>Returns the first element of a sequence, or a default value if the sequence contains no elements.</summary>
        /// <param name="source">The <see cref="IQueryable{T}" /> to return the first element of.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>
        /// <c>default</c>(<typeparamref name="T" />) if <paramref name="source" /> is empty; otherwise, the first element in <paramref name="source" />.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> is <see langword="null" />.</exception>
        Task<T> FirstOrDefaultAsync<T>(IQueryable<T> source, CancellationToken cancellationToken = default);

        /// <summary>Returns the first element of a sequence that satisfies a specified condition or a default value if no such element is found.</summary>
        /// <param name="source">An <see cref="IQueryable{T}" /> to return an element from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>
        /// <c>default</c>(<typeparamref name="T" />) if <paramref name="source" /> is empty or if no element passes the test specified by <paramref name="predicate" />; otherwise, the first element in <paramref name="source" /> that passes the test specified by <paramref name="predicate" />.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        Task<T> FirstOrDefaultAsync<T>(IQueryable<T> source, Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

        /// <summary>Performs the specified action on each element of the <see cref="IQueryable{T}" />.</summary>
        /// <param name="source">The <see cref="IQueryable{T}" /> that contains the elements to be acted on.</param>
        /// <param name="action">The <see cref="Action{T}" /> delegate to perform on each element of the <see cref="IQueryable{T}" />.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>A <see cref="Task" />.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="action" /> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException">An element in the collection has been modified.</exception>
        Task ForEachAsync<T>(IQueryable<T> source, Action<T> action, CancellationToken cancellationToken = default);

        /// <summary>Finds a single element by its key value(s).</summary>
        /// <param name="source">An <see cref="IQueryable{T}" /> that contains the elements to be queried.</param>
        /// <param name="keyValues">The key values of the element to be returned.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The element with the specified <paramref name="keyValues"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" /> or <paramref name="keyValues"/> is <see langword="null" />.</exception>
        /// <exception cref="ArgumentException"><paramref name="keyValues"/> is empty.</exception>
        ValueTask<T> GetAsync<T>(IQueryable<T> source, object[] keyValues, CancellationToken cancellationToken = default)
            where T : class;

        /// <summary>Returns an <see cref="long" /> that represents the total number of elements in a sequence.</summary>
        /// <param name="source">An <see cref="IQueryable{T}" /> that contains the elements to be counted.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The number of elements in <paramref name="source" />.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> is <see langword="null" />.</exception>
        /// <exception cref="OverflowException">The number of elements exceeds <see cref="long.MaxValue" />.</exception>
        Task<long> LongCountAsync<T>(IQueryable<T> source, CancellationToken cancellationToken = default);

        /// <summary>Returns an <see cref="long" /> that represents the number of elements in a sequence that satisfy a condition.</summary>
        /// <param name="source">An <see cref="IQueryable{T}" /> that contains the elements to be counted.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The number of elements in <paramref name="source" /> that satisfy the condition in the predicate function.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        /// <exception cref="OverflowException">The number of matching elements exceeds <see cref="long.MaxValue" />.</exception>
        Task<long> LongCountAsync<T>(IQueryable<T> source, Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

        /// <summary>Returns the maximum value in a generic <see cref="IQueryable{T}" />.</summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The maximum value in the sequence.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> is <see langword="null" />.</exception>
        Task<T> MaxAsync<T>(IQueryable<T> source, CancellationToken cancellationToken = default);

        /// <summary>Invokes a projection function on each element of a generic <see cref="IQueryable{T}" /> and returns the maximum resulting value.</summary>
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by the function represented by <paramref name="selector" />.</typeparam>
        /// <returns>The maximum value in the sequence.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        Task<TResult> MaxAsync<T, TResult>(IQueryable<T> source, Expression<Func<T, TResult>> selector, CancellationToken cancellationToken = default);

        /// <summary>Returns the minimum value of a generic <see cref="IQueryable{T}" />.</summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The minimum value in the sequence.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> is <see langword="null" />.</exception>
        Task<T> MinAsync<T>(IQueryable<T> source, CancellationToken cancellationToken = default);

        /// <summary>Invokes a projection function on each element of a generic <see cref="IQueryable{T}" /> and returns the minimum resulting value.</summary>
        /// <param name="source">A sequence of values to determine the minimum of.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by the function represented by <paramref name="selector" />.</typeparam>
        /// <returns>The minimum value in the sequence.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        Task<TResult> MinAsync<T, TResult>(IQueryable<T> source, Expression<Func<T, TResult>> selector, CancellationToken cancellationToken = default);

        /// <summary>Creates an <see cref="IQueryable{T}" /> of type <typeparamref name="T" />.</summary>
        /// <typeparam name="T"> The type of record for which a query should be returned.</typeparam>
        /// <returns> A sequence of the given type.</returns>
        IQueryable<T> Query<T>()
            where T : class;

        /// <summary>Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.</summary>
        /// <param name="source">An <see cref="IQueryable{T}" /> to return the single element of.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The single element of the input sequence.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException">
        /// <paramref name="source" /> has more than one element.</exception>
        Task<T> SingleAsync<T>(IQueryable<T> source, CancellationToken cancellationToken = default);

        /// <summary>Returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.</summary>
        /// <param name="source">An <see cref="IQueryable{T}" /> to return a single element from.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The single element of the input sequence that satisfies the condition in <paramref name="predicate" />.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException">No element satisfies the condition in <paramref name="predicate" />.
        /// -or-
        /// More than one element satisfies the condition in <paramref name="predicate" />.
        /// -or-
        /// The source sequence is empty.</exception>
        Task<T> SingleAsync<T>(IQueryable<T> source, Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

        /// <summary>Returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence.</summary>
        /// <param name="source">An <see cref="IQueryable{T}" /> to return the single element of.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The single element of the input sequence, or <c>default</c>(<typeparamref name="T" />) if the sequence contains no elements.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException">
        /// <paramref name="source" /> has more than one element.</exception>
        Task<T> SingleOrDefaultAsync<T>(IQueryable<T> source, CancellationToken cancellationToken = default);

        /// <summary>Returns the only element of a sequence that satisfies a specified condition or a default value if no such element exists; this method throws an exception if more than one element satisfies the condition.</summary>
        /// <param name="source">An <see cref="IQueryable{T}" /> to return a single element from.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The single element of the input sequence that satisfies the condition in <paramref name="predicate" />, or <c>default</c>(<typeparamref name="T" />) if no such element is found.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException">More than one element satisfies the condition in <paramref name="predicate" />.</exception>
        Task<T> SingleOrDefaultAsync<T>(IQueryable<T> source, Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

        /// <summary>Computes the sum of the sequence of nullable <see cref="decimal" /> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of values of type <typeparamref name="T" />.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        /// <exception cref="OverflowException">The sum is larger than <see cref="decimal.MaxValue" />.</exception>
        Task<decimal?> SumAsync<T>(IQueryable<T> source, Expression<Func<T, decimal?>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the sum of the sequence of <see cref="decimal" /> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of values of type <typeparamref name="T" />.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        /// <exception cref="OverflowException">The sum is larger than <see cref="decimal.MaxValue" />.</exception>
        Task<decimal> SumAsync<T>(IQueryable<T> source, Expression<Func<T, decimal>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the sum of the sequence of nullable <see cref="double" /> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of values of type <typeparamref name="T" />.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        Task<double?> SumAsync<T>(IQueryable<T> source, Expression<Func<T, double?>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the sum of the sequence of <see cref="double" /> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of values of type <typeparamref name="T" />.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        Task<double> SumAsync<T>(IQueryable<T> source, Expression<Func<T, double>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the sum of the sequence of nullable <see cref="float" /> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of values of type <typeparamref name="T" />.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        Task<float?> SumAsync<T>(IQueryable<T> source, Expression<Func<T, float?>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the sum of the sequence of <see cref="float" /> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of values of type <typeparamref name="T" />.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        Task<float> SumAsync<T>(IQueryable<T> source, Expression<Func<T, float>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the sum of the sequence of nullable <see cref="int" /> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of values of type <typeparamref name="T" />.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        /// <exception cref="OverflowException">The sum is larger than <see cref="int.MaxValue" />.</exception>
        Task<int?> SumAsync<T>(IQueryable<T> source, Expression<Func<T, int?>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the sum of the sequence of <see cref="int" /> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of values of type <typeparamref name="T" />.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        /// <exception cref="OverflowException">The sum is larger than <see cref="int.MaxValue" />.</exception>
        Task<int> SumAsync<T>(IQueryable<T> source, Expression<Func<T, int>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the sum of the sequence of nullable <see cref="long" /> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of values of type <typeparamref name="T" />.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        /// <exception cref="OverflowException">The sum is larger than <see cref="long.MaxValue" />.</exception>
        Task<long?> SumAsync<T>(IQueryable<T> source, Expression<Func<T, long?>> selector, CancellationToken cancellationToken = default);

        /// <summary>Computes the sum of the sequence of <see cref="long" /> values that is obtained by invoking a projection function on each element of the input sequence.</summary>
        /// <param name="source">A sequence of values of type <typeparamref name="T" />.</param>
        /// <param name="selector">A projection function to apply to each element.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        /// <exception cref="OverflowException">The sum is larger than <see cref="long.MaxValue" />.</exception>
        Task<long> SumAsync<T>(IQueryable<T> source, Expression<Func<T, long>> selector, CancellationToken cancellationToken = default);

        /// <summary>Creates a <see cref="List{T}" /> from an <see cref="IQueryable{T}" />.</summary>
        /// <param name="source">The <see cref="IQueryable{T}" /> to create a <see cref="List{T}" /> from.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>A <see cref="List{T}" /> that contains elements from the input sequence.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source" /> is <see langword="null" />.</exception>
        Task<List<T>> ToListAsync<T>(IQueryable<T> source, CancellationToken cancellationToken = default);
    }
}