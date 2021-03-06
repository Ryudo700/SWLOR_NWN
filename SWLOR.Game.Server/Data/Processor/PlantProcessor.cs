﻿using FluentValidation;
using Newtonsoft.Json.Linq;
using SWLOR.Game.Server.Data.Contracts;
using SWLOR.Game.Server.Data.Entity;
using SWLOR.Game.Server.Data.Validator;
using SWLOR.Game.Server.Service.Contracts;
using SWLOR.Game.Server.ValueObject;

namespace SWLOR.Game.Server.Data.Processor
{
    public class PlantProcessor : IDataProcessor<Plant>
    {
        public IValidator Validator => new PlantValidator();

        public DatabaseAction Process(IDataService data, JObject dataObject)
        {
            return null;
        }
    }
}
