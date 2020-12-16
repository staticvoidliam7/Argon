using System;
using System
//Example transaction data

public class Transaction
{
   public int Id { get; set; }
   public string Sender { set; get; }
   public string Recipient { set; get; }
   public double Amount { set; get; }
   public double Fee { set; get; }
}
public class Block
{
    public int Height { get; set; }
    public Int64 TimeStamp { get; set; }
    public byte[] PrevHash { get; set; }
    public byte[] Hash { get; set; }
    public Transaction[] Transactions { get; set; }
    public string Creator { get; set; }
}    



class main{
  static void Main(){

//Create one transaction
var trx1 = new Transaction
{
    Sender = "Johana",
    Recipient = "Merlin",
    Amount = 3.0,
    Fee = 0.3
};

//insert transaction into list
Transaction[] lsTrx = {trx1};

//asume previous hash is empty
var prevHash = System.Text.Encoding.UTF8.GetBytes("");

//create new Block
var block = new Block(0, String.Empty.ConvertToBytes(), lsTrx, "Admin");

  }
}