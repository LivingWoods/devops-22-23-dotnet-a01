﻿namespace Domain;

public class Address
{
    public string AddressLine1 { get; }
    public string AddressLine2 { get; }
    public string ZipCode { get; }
    public string City { get; }

    public Address(string addressLine1, string addressLine2, string zipCode, string city)
    {
        Guard.Against.NullOrEmpty(addressLine1, nameof(addressLine1));
        Guard.Against.NullOrWhiteSpace(addressLine2, nameof(addressLine2));

        Guard.Against.NullOrEmpty(addressLine2, nameof(addressLine2));
        Guard.Against.NullOrWhiteSpace(addressLine2, nameof(addressLine2));

        Guard.Against.NullOrEmpty(zipCode, nameof(zipCode));
        Guard.Against.NullOrWhiteSpace(city, nameof(city));

        Guard.Against.NullOrEmpty(city, nameof(city));
        Guard.Against.NullOrWhiteSpace(city, nameof(city));

        AddressLine1 = addressLine1;
        AddressLine2 = addressLine2;
        ZipCode = zipCode;
        City = city;    
    }
}
