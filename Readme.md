# Vetmanager Gateway API

![Vetmanager Logo](https://raw.githubusercontent.com/ionov-e/first-c-sharp-vetmanager/master/docs/logo-vetmanager.svg)

Vetmanager - a CRM service for veterinary clinics.

This package purpose is to help with Vetmanager REST API access.

## Quick usage

```cs
ApiGateway vetmanagerGateway = new ApiGateway(new HttpClient(), "https://three.test.kube-dev.vetmanager.cloud", "xxxxxxxxxxxxxxxxxxx");

Client[] allClients = await vetmanagerGateway.Client.All();
Client client = allClients[0];
MessageBox.Show($"{client.LastName} has email: {client.Email} ");

Pet pet = await vetmanagerGateway.Pet.ById(1);
string breedTitle = pet?.breed?.Title ?? "Breed is not not set";
MessageBox.Show($"Breed title is: {breedTitle}");
```

## Quick intro

This is a foundation for Vetmanager Gateway API. Or at the very least - a reference how to use Vetmanager REST API with C#. Fill free to fork it. Or contact me - I will expand this package.

I believe this is a good starting point either to work with Vetmanager Rest API, or to improve this package

## Known issues

- No "query builder" interface in Model Facades for now;
- Post ant put interfaces are needed in Model Facades;
- Somewhat different model DTOs we are getting from post and put requests;
- Sorting, offset and limit features are absent in Query builders;
- More DTOs are needed.
