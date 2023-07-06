﻿using VetmanagerApiGateway.DTO.ModelContainer.Model;

namespace VetmanagerApiGateway.DTO.ModelContainer
{
    abstract public class AbstractContainerWithOneModelAndIntCount : ModelContainerInterface
    {
        public required int totalCount { get; set; }
        public int TotalNumber
        {
            get { return totalCount; }
            set { totalCount = value; }
        }
        abstract public AbstractModel GetModel();
    }
}
