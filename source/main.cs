using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Diagnostics;


public class Transactions
{
   public int Id { get; set; }
   public string Sender { set; get; }
   public string Recipient { set; get; }
   public double Amount { set; get; }
   public double Fee { set; get; }
}
public class Block
{
  static void trans(){
 
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
   public byte[] GenerateHash()
{
    var sha = SHA256.Create();
    
    //convert current timestamp to array of byte
    byte[] timeStamp = BitConverter.GetBytes(TimeStamp);

    //convert transaction collection to array of byte
    var transactionHash = Transactions.ConvertToByte();

    //make block header in array of byte
    byte[] headerBytes = new byte[timeStamp.Length + PrevHash.Length + transactionHash.Length];

    Buffer.BlockCopy(timeStamp, 0, headerBytes, 0, timeStamp.Length);
    Buffer.BlockCopy(PrevHash, 0, headerBytes, timeStamp.Length, PrevHash.Length);
    Buffer.BlockCopy(transactionHash, 0, headerBytes, timeStamp.Length + PrevHash.Length, transactionHash.Length);

    byte[] hash = sha.ComputeHash(headerBytes);

    return hash;

}
    public int Height { get; set; }
    public Int64 TimeStamp { get; set; }
    public byte[] PrevHash { get; set; }
    public byte[] Hash { get; set; }
    public Transaction[] Transactions{ get; set; }
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