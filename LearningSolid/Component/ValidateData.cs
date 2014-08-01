﻿using LearningSolid.Component.Validators;
using LearningSolid.Model;
using System.Collections.Generic;
using System.Linq;

namespace LearningSolid.Component
{
    public class ValidateData
    {
        private readonly IEnumerable<IDataValidator> _validators;

        public ValidateData(IEnumerable<IDataValidator> validators)
        {
            _validators = validators;
        }

        public bool Validate(ServerData data, SourceServerData sourceData)
        {
            return _validators.Any(validator => validator.Validate(data, sourceData));
        }
    }
}