﻿// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Linq.Expressions;

namespace Microsoft.Extensions.VectorData;

/// <summary>
/// Options for vector search.
/// </summary>
public class VectorSearchOptions<TRecord>
{
    private int _top = 3, _skip = 0;

    /// <summary>
    /// Gets or sets a search filter to use before doing the vector search.
    /// </summary>
    [Obsolete("Use NewFilter instead")]
    public VectorSearchFilter? Filter { get; init; }

    /// <summary>
    /// Gets or sets a search filter to use before doing the vector search.
    /// </summary>
    public Expression<Func<TRecord, bool>>? NewFilter { get; init; }

    /// <summary>
    /// Gets or sets the name of the vector property to search on.
    /// Use the name of the vector property from your data model or as provided in the record definition.
    /// If not provided will default to the first vector property in the schema.
    /// </summary>
    public string? VectorPropertyName { get; init; }

    /// <summary>
    /// Gets or sets the maximum number of results to return.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the value is less than 1.</exception>
    public int Top
    {
        get => this._top;
        init
        {
            if (value < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Top must be greater than or equal to 1.");
            }

            this._top = value;
        }
    }

    /// <summary>
    /// Gets or sets the number of results to skip before returning results, i.e. the index of the first result to return.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the value is less than 0.</exception>
    public int Skip
    {
        get => this._skip;
        init
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Skip must be greater than or equal to 0.");
            }

            this._skip = value;
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether to include vectors in the retrieval result.
    /// </summary>
    public bool IncludeVectors { get; init; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether the total count should be included in the results.
    /// </summary>
    /// <remarks>
    /// Default value is false.
    /// Not all vector search implementations will support this option in which case the total
    /// count will be null even if requested via this option.
    /// </remarks>
    public bool IncludeTotalCount { get; init; } = false;
}
