using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using static backend.Models.Shared;

namespace backend.Model.Devices
{
    public class Meta
    {
        public int totalPages { get; set; }
    }

    public class Links
    {
        public string next { get; set; }
        public string last { get; set; }
        public string prev { get; set; }
        public string self { get; set; }
        public string first { get; set; }
    }

    public class BreakTime
    {
        public object breakFromTime { get; set; }
        public object breakToTime { get; set; }
    }

    public class Day
    {
        public object closingTime { get; set; }
        public string dayCode { get; set; }
        public DateTime openingTime { get; set; }
        public List<BreakTime> BreakTime { get; set; }
    }

    public class StandardAvailability
    {
        public List<Day> Day { get; set; }
    }

    public class NonStandardAvailability
    {
        public object fromDate { get; set; }
        public object toDate { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<object> Day { get; set; }
    }

    public class Availability
    {
        public StandardAvailability StandardAvailability { get; set; }
        public bool sameAsOrganization { get; set; }
        public string description { get; set; }
        public List<NonStandardAvailability> NonStandardAvailability { get; set; }
        public bool isRestricted { get; set; }
        public bool access24Hours { get; set; }
    }

    public class Identification
    {
        public string identification { get; set; }
        public string schemeName { get; set; }
    }

    public class PaymentAgent
    {
        public string name { get; set; }
        public List<Identification> Identification { get; set; }
        public string paymentAgentIndicator { get; set; }
    }

    public class PostalAddress
    {
        public string country { get; set; }
        public string streetName { get; set; }
        public string townName { get; set; }
        public string countrySubDivision { get; set; }
        public string addressType { get; set; }
        public string buildingNumber { get; set; }
        public string postCode { get; set; }
        public List<string> addressLine { get; set; }
    }

    public class PostalAddressAndAdmZone
    {
        public PostalAddress PostalAddress { get; set; }
        public string administrationZone { get; set; }
    }

    public class GeographicCoordinates
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class Geolocation
    {
        public GeographicCoordinates GeographicCoordinates { get; set; }
    }

    public class Address
    {
        public PostalAddressAndAdmZone PostalAddressAndAdmZone { get; set; }
        public Geolocation Geolocation { get; set; }
        public string fias { get; set; }
    }

    public class CurrencyExchange
    {
        public double amountMax { get; set; }
        public int scaleCurrency { get; set; }
        public object targetCurrency { get; set; }
        public int exchangeRate { get; set; }
        public double amountMin { get; set; }
        public double fee { get; set; }
        public string exchangeType { get; set; }
        public object sourceCurrency { get; set; }
        public object updateDateTime { get; set; }
        public object quotationDate { get; set; }
        public string direction { get; set; }
    }

    public class Service
    {
        public string serviceType { get; set; }
        public string serviceName { get; set; }
    }

    public class Services
    {
        public List<Service> Service { get; set; }
    }

    public class BanknoteIn
    {
        public string banknoteType { get; set; }
        public object currency { get; set; }
    }

    public class SocialNetwork
    {
        public string networkName { get; set; }
        public string description { get; set; }
        public string url { get; set; }
    }

    public class ContactDetails
    {
        public string emailAddress { get; set; }
        public string other { get; set; }
        public string phoneNumber { get; set; }
        public string mobileNumber { get; set; }
        public List<SocialNetwork> SocialNetworks { get; set; }
    }
    public class Device
    {
        public string deviceType { get; set; }
        public Availability Availability { get; set; }
        public PaymentAgent PaymentAgent { get; set; }
        public bool qr { get; set; }
        public List<string> cards { get; set; }
        public Address Address { get; set; }
        public string currentStatus { get; set; }
        public string description { get; set; }
        public bool nfc { get; set; }
        public bool recirculation { get; set; }
        public List<CurrencyExchange> CurrencyExchange { get; set; }
        public string deviceId { get; set; }
        public string baseCurrency { get; set; }
        public Services Services { get; set; }
        public List<BanknoteIn> BanknoteIn { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public List<object> BanknoteOut { get; set; }
        public List<string> operationType { get; set; }
        public Accessibilities Accessibilities { get; set; }
    }

    public class Data
    {
        public List<Device> Device { get; set; }
    }

    public class Root
    {
        public Meta Meta { get; set; }
        public Links Links { get; set; }
        public Data Data { get; set; }
    }
}

