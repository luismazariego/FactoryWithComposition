namespace FactoryWithComposition
{
    using FactoryWithComposition.Processors;
    using FactoryWithComposition.Validators;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Client(IProcessorFactory factory)
    {
        private readonly IProcessorFactory factory = factory;

        internal (IProcessor? p, IValidator[] v) GetProcessor(string action)
        {
            return factory.CreateProcessor(action);
        }
    }
}
