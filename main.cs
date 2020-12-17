using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Transaction
{
   public int Id { get; set; }
   public string Sender { set; get; }
   public string Recipient { set; get; }
   public decimal Amount { set; get; }
   public decimal Fee { set; get; }
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

class main{
  static void Main(){
  

  }
}