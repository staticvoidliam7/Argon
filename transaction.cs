using System;

public class Transaction
{
   public int Id { get; set; }
   public string Sender { set; get; }
   public string Recipient { set; get; }
   public decimal Amount { set; get; }
   public decimal Fee { set; get; }
}