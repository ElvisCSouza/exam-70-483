using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    //Dispose Pattern da Microsoft
    public class DisposableClass : IDisposable
    {
        bool _disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DisposableClass()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposingByUser)
        {
            if (_disposed) return;

            if (disposingByUser)
            {
                //Vc fecha conexão, dispose arquivo...
            }
            _disposed = true;
        }
    }

    public class NotDisposableClass
    {
        public int MyProperty { get; set; } = 999;
    }

    public class GarbageColletionExempleTest
    {
        public void Test()
        {
            TestDisposableClass();
            TestNotDisposableClass();
        }

        private void TestDisposableClass()
        {
            var before2 = GC.CollectionCount(2);
            var before1 = GC.CollectionCount(1);
            var before0 = GC.CollectionCount(0);

            for (int i = 0; i < 1_000_000; i++)
            {
                var teste = new DisposableClass();
            }

            var gcGen2 = GC.CollectionCount(2) - before2;
            var gcGen1 = GC.CollectionCount(1) - before1;
            var gcGen0 = GC.CollectionCount(0) - before0;
        }

        private void TestNotDisposableClass()
        {
            var before2 = GC.CollectionCount(2);
            var before1 = GC.CollectionCount(1);
            var before0 = GC.CollectionCount(0);

            for (int i = 0; i < 1_000_000; i++)
            {
                var teste = new NotDisposableClass();
            }

            var gcGen2 = GC.CollectionCount(2) - before2;
            var gcGen1 = GC.CollectionCount(1) - before1;
            var gcGen0 = GC.CollectionCount(0) - before0;
        }
    }
}
