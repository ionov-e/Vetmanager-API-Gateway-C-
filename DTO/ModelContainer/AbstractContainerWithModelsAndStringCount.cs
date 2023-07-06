﻿using VetmanagerApiGateway.DTO.ModelContainer.Model;

namespace VetmanagerApiGateway.DTO.ModelContainer
{

    abstract public class AbstractContainerWithModelsAndStringCount : ModelContainerInterface
    {
        public required string totalCount { get; set; }
        public int TotalNumber
        {
            get { return int.Parse(totalCount); }
            set { totalCount = value.ToString(); }
        }
        abstract public AbstractModel[] GetModels();
    }
}
