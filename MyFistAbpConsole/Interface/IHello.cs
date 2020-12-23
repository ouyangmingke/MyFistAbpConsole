using System;
using System.Collections.Generic;
using System.Text;

using MyFistAbpConsole.Service;

using Volo.Abp.DependencyInjection;

namespace MyFistAbpConsole.Interface
{
    public interface IHello : ITransientDependency
    {
        public void Writer();

    }
}
