// Copyright (c) Microsoft. All rights reserved.

using RedisIntegrationTests.Support;
using VectorDataSpecificationTests.Collections;
using Xunit;

namespace RedisIntegrationTests.Collections;

public class RedisCollectionConformanceTests(RedisFixture fixture)
    : CollectionConformanceTests<string>(fixture), IClassFixture<RedisFixture>
{
}
