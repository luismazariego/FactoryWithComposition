namespace FactoryWithComposition.Processors
{
    using FactoryWithComposition.Validators;

    public interface IProcessorFactory
    {
        (IProcessor? processor, IValidator[] validators) CreateProcessor(string action);
    }
}
