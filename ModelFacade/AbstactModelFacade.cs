﻿namespace VetmanagerApiGateway.ModelFacade
{
    abstract public class AbstactModelFacade
    {
        protected readonly ApiGateway ApiGateway;

        public AbstactModelFacade(ApiGateway apiGateway)
        {
            ApiGateway = apiGateway;
        }
    }
}
