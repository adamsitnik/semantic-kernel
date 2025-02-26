﻿// Copyright (c) Microsoft. All rights reserved.

using SqlServerIntegrationTests.Support;
using VectorDataSpecificationTests.Support;
using VectorDataSpecificationTests.VectorSearch;
using Xunit;

namespace SqlServerIntegrationTests.VectorSearch;

public class SqlServerBasicVectorSearchTests(SqlServerFixture fixture)
    : BasicVectorSearchTests<int>(fixture), IClassFixture<SqlServerFixture>
{
    public override Task CosineSimilarity() => Assert.ThrowsAsync<NotSupportedException>(base.CosineSimilarity);

    public override Task DotProductSimilarity() => Assert.ThrowsAsync<NotSupportedException>(base.DotProductSimilarity);

    public override Task EuclideanSquaredDistance() => Assert.ThrowsAsync<NotSupportedException>(base.EuclideanSquaredDistance);

    public override Task Hamming() => Assert.ThrowsAsync<NotSupportedException>(base.Hamming);

    public override Task ManhattanDistance() => Assert.ThrowsAsync<NotSupportedException>(base.ManhattanDistance);
}
