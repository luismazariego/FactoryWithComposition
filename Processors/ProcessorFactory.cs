namespace FactoryWithComposition.Processors
{
    using FactoryWithComposition.Service;
    using FactoryWithComposition.Validators;

    internal class ProcessorFactory(ICacheService cacheService) : IProcessorFactory
    {
        public (IProcessor? processor, IValidator[] validators) CreateProcessor(string action)
        {
            return action switch
            {
                "A" => (new ProcessorA(), [new ValidatorA(), new ValidatorB(cacheService)]),
                "B" => (new ProcessorB(), [new ValidatorB(cacheService), new ValidatorC(), new ValidatorD(cacheService)]),
                _ => (null,[]),
            };
        }
    }
}
