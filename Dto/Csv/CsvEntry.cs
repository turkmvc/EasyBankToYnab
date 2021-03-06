﻿using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace QuestMaster.EasyBankToYnab.Gateways.Csv
{
  public class CsvEntry
  {
    private readonly Regex regex = new Regex(@"[ ]{2,}", RegexOptions.None);
    private static readonly CultureInfo cultureInfo = new CultureInfo("de-DE");

    // 20010351775;Kunde 1270519, Rechnung 074595730            FE/000004847|GIBAATWW AT062011129642361200 Vet-Concept GmbH Co KG;21.02.2012;21.02.2012;-322,39;EUR
    private const int AccountIndex = 0;
    private const int DescriptionIndex = 1;
    private const int BookingDateIndex = 2;
    private const int ValueDateIndex = 3;
    private const int AmountIndex = 4;
    private const int CurrencyIndex = 5;
    
    public CsvEntry(string statement)
    {
      string[] parts = statement.Replace("&#214;", "Ö").Replace("&#246;", "ö").Replace("&#196;", "Ä").Replace("&#228;", "ä").Replace("&#220;", "Ü").Replace("&#252;", "ü").Replace("&#233;", "ß").Split(';');
      var amount = decimal.Parse(parts[AmountIndex], cultureInfo);

      string description = RetrieveDescription(parts);
      string payee = RetrievePayee(parts);
      string account = parts[AccountIndex];

      if (IsCreditCardAccount(account))
      {
        var t = description;
        description = payee;
        payee = t;
      }

      this.Account = account;
      this.Description = description;
      this.Payee = payee;
      this.BookingDate = DateTime.ParseExact(parts[BookingDateIndex], "dd.MM.yyyy", CultureInfo.CurrentCulture);
      this.ValueDate = DateTime.ParseExact(parts[ValueDateIndex], "dd.MM.yyyy", CultureInfo.CurrentCulture);
      this.AmountIn = Math.Max(0, amount);
      this.AmountOut = Math.Abs(Math.Min(0, amount));
      this.Currency = parts[CurrencyIndex];
    }

    public string Currency { get; private set; }

    public decimal AmountOut { get; private set; }

    public decimal AmountIn { get; private set; }

    public DateTime ValueDate { get; private set; }

    public DateTime BookingDate { get; private set; }

    public string Payee { get; private set; }

    public string Description { get; private set; }

    public string Account { get; private set; }

    private static bool IsCreditCardAccount(string account)
    {
      return account.StartsWith("2000");
    }

    private string RetrieveDescription(string[] parts)
    {
      var descriptionParts = RetrieveDescriptionParts(parts);

      string result = descriptionParts[0];
      return result;
    }

    private string RetrievePayee(string[] parts)
    {
      var descriptionParts = RetrieveDescriptionParts(parts);

      string payee = string.Join(" ", descriptionParts.Skip(1).ToArray());
      return payee;
    }

    private string[] RetrieveDescriptionParts(string[] parts)
    {
      var description = parts[DescriptionIndex];
      description = regex.Replace(description, @" ");

      string[] descriptionParts = description.Split('|');
      return descriptionParts;
    }
  }
}