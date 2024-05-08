namespace FactoryWithComposition.Validators
{
    using FactoryWithComposition.Service;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class ValidatorB(ICacheService service) : IValidator
    {
        private readonly ICacheService service = service;

        public bool IsValid => service.GetCacheKey("sdg") == "ASDFG";
    }
}
