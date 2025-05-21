using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPgatomCallBackDetail
{
    public long Id { get; set; }

    public string? MerchantId { get; set; }

    public string? MerchantTxnId { get; set; }

    public decimal? Amt { get; set; }

    public string? Verified { get; set; }

    public string? Bid { get; set; }

    public string? BankName { get; set; }

    public string? AtomTxnId { get; set; }

    public string? Discriminator { get; set; }

    public decimal? Surcharge { get; set; }

    public string? CardNumber { get; set; }

    public string? TxnDate { get; set; }

    public string? CustomerAccNo { get; set; }

    public string? Clientcode { get; set; }

    public string? OrderId { get; set; }

    public string? TrackingId { get; set; }

    public string? BankRefNo { get; set; }

    public string? OrderStatus { get; set; }

    public string? FailureMessage { get; set; }

    public string? PaymentMode { get; set; }

    public string? CardName { get; set; }

    public string? StatusCode { get; set; }

    public string? StatusMessage { get; set; }

    public string? Currency { get; set; }

    public string? BillingName { get; set; }

    public string? BillingAddress { get; set; }

    public string? BillingCity { get; set; }

    public string? BillingState { get; set; }

    public string? BillingZip { get; set; }

    public string? BillingCountry { get; set; }

    public string? BillingTel { get; set; }

    public string? BillingEmail { get; set; }

    public string? DeliveryName { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? DeliveryCity { get; set; }

    public string? DeliveryState { get; set; }

    public string? DeliveryZip { get; set; }

    public string? DeliveryCountry { get; set; }

    public string? DeliveryTel { get; set; }

    public string? MerchantParam1 { get; set; }

    public string? MerchantParam2 { get; set; }

    public string? MerchantParam3 { get; set; }

    public string? MerchantParam4 { get; set; }

    public string? MerchantParam5 { get; set; }
}
