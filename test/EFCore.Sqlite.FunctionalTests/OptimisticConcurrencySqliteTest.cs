// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Xunit;

namespace Microsoft.EntityFrameworkCore
{
    public class OptimisticConcurrencyULongSqliteTest : OptimisticConcurrencySqliteTestBase<F1ULongSqliteFixture, ulong?>
    {
        public OptimisticConcurrencyULongSqliteTest(F1ULongSqliteFixture fixture)
            : base(fixture)
        {
        }
    }

    public class OptimisticConcurrencySqliteTest : OptimisticConcurrencySqliteTestBase<F1SqliteFixture, byte[]>
    {
        public OptimisticConcurrencySqliteTest(F1SqliteFixture fixture)
            : base(fixture)
        {
        }
    }

    public abstract class OptimisticConcurrencySqliteTestBase<TFixture, TRowVersion>
        : OptimisticConcurrencyTestBase<TFixture, TRowVersion>
        where TFixture : F1FixtureBase<TRowVersion>, new()
    {
        protected OptimisticConcurrencySqliteTestBase(TFixture fixture)
            : base(fixture)
        {
        }

        [ConditionalFact(Skip = "Optimistic Offline Lock #2195")]
        public override Task Simple_concurrency_exception_can_be_resolved_with_store_values()
            => Task.FromResult(true);

        [ConditionalFact(Skip = "Optimistic Offline Lock #2195")]
        public override Task Simple_concurrency_exception_can_be_resolved_with_client_values()
            => Task.FromResult(true);

        [ConditionalFact(Skip = "Optimistic Offline Lock #2195")]
        public override Task Simple_concurrency_exception_can_be_resolved_with_new_values()
            => Task.FromResult(true);

        [ConditionalFact(Skip = "Optimistic Offline Lock #2195")]
        public override Task Simple_concurrency_exception_can_be_resolved_with_store_values_using_equivalent_of_accept_changes()
            => Task.FromResult(true);

        [ConditionalFact(Skip = "Optimistic Offline Lock #2195")]
        public override Task Simple_concurrency_exception_can_be_resolved_with_store_values_using_Reload()
            => Task.FromResult(true);

        [ConditionalFact(Skip = "Optimistic Offline Lock #2195")]
        public override Task Updating_then_deleting_the_same_entity_results_in_DbUpdateConcurrencyException()
            => Task.FromResult(true);

        [ConditionalFact(Skip = "Optimistic Offline Lock #2195")]
        public override Task
            Updating_then_deleting_the_same_entity_results_in_DbUpdateConcurrencyException_which_can_be_resolved_with_store_values()
            => Task.FromResult(true);

        [ConditionalFact(Skip = "Optimistic Offline Lock #2195")]
        public override Task
            Change_in_independent_association_after_change_in_different_concurrency_token_results_in_independent_association_exception()
            => Task.FromResult(true);

        [ConditionalFact(Skip = "Optimistic Offline Lock #2195")]
        public override Task Change_in_independent_association_results_in_independent_association_exception()
            => Task.FromResult(true);

        [ConditionalFact(Skip = "Optimistic Offline Lock #2195")]
        public override Task Two_concurrency_issues_in_one_to_many_related_entities_can_be_handled_by_dealing_with_dependent_first()
            => Task.FromResult(true);

        [ConditionalFact(Skip = "Optimistic Offline Lock #2195")]
        public override Task Two_concurrency_issues_in_one_to_one_related_entities_can_be_handled_by_dealing_with_dependent_first()
            => Task.FromResult(true);

        protected override void UseTransaction(DatabaseFacade facade, IDbContextTransaction transaction)
            => facade.UseTransaction(transaction.GetDbTransaction());
    }
}
