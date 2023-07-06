﻿using VetmanagerApiGateway.DTO.ModelContainer.Model;
using System.Text.Json.Serialization;

namespace VetmanagerApiGateway.DTO.ModelContainer
{
    internal class ClientData : AbstractContainerWithOneModelAndIntCount
    {
        [JsonPropertyName("client")]
        public required Client Model { get; set; }

        public override Client GetModel()
        {
            return Model;
        }
    }
}
