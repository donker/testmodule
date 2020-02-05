using DotNetNuke.Data;
using DotNetNuke.Framework;
using System;
using System.Collections.Generic;

namespace Dnn.Test.ModulesTestModule.Components
{
    public class TestRepository : ServiceLocator<ITestRepository, TestRepository>, ITestRepository
    {
        protected override Func<ITestRepository> GetFactory()
        {
            return () => new TestRepository();
        }
        public IEnumerable<TestComponent> GetTabs()
        {
            using (var context = DataContext.Instance())
            {
                var rep = context.GetRepository<TestComponent>();
                return rep.Get();
            }
        }
    }
    public partial interface ITestRepository
    {
        IEnumerable<TestComponent> GetTabs();
    }
}