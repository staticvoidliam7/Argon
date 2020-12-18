using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Diagnostics;

public class Transaction
{
   public int Id { get; set; }
   public string Sender { set; get; }
   public string Recipient { set; get; }
   public double Amount { set; get; }
   public double Fee { set; get; }
}

class main{

  static void Main(){
  //Example transaction data
var trx1 = new Transaction()
   {
      Sender = "Ricard",
      Recipient = "Frodo",
      Amount = 10,
      Fee = 0.001
   };
   

//example transaction data   
var trx2 = new Transaction()
   {
      Sender = "Amir",
      Recipient = "Wati",
      Amount = 20,
      Fee = 0.0001
   };   
   Console.WriteLine(trx2.Sender);
   Console.Read();
   

  }
}