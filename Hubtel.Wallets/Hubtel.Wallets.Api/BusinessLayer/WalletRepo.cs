using Hubtel.Wallets.Api.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Hubtel.Wallets.Api.BusinessLayer
{
    //This class contains implementation of IWalletRepo.cs
    public class WalletRepo : IWalletRepo   
    {
        string Msg;
        private readonly WalletDbContext walletDb;

        public WalletRepo(WalletDbContext walletDb)
        {
            this.walletDb = walletDb;
        }
        public string Add(Wallet wallet)
        {
            //Check and Prevent User having more than 5 wallets
            int count = walletDb.Wallets.Where(c=>c.UserID == wallet.UserID).ToList().Count();  
            if(count > 5)
            {
                Msg = string.Format("User Cannot Add More Than 5 Wallets");
                return Msg;
            }
            //Check and Save Only First Six Digits of Card Number
            if (wallet.Type.ToLower() == "card")
            {
                string firstSix = wallet.AccountNumber.Substring(0, 6);
                wallet.AccountNumber = firstSix;
            }
            //Check and Prevent Duplicate Wallet Entry
            var walExists =  walletDb.Wallets.FirstOrDefault(c => c.AccountNumber == wallet.AccountNumber);   
            if(walExists != null)
            {
                Msg = string.Format("Wallet Already Exists");
                return Msg;
            }
            else
            {
                wallet.CreatedAt = DateTime.Now;    
                walletDb.Wallets.Add(wallet);
                walletDb.SaveChanges();
                Msg = string.Format("Wallet Successfully Added");
            }
            return Msg;
        }

        public IEnumerable<Wallet> GetAllWallets()
        {
            return walletDb.Wallets;    
        }

        public string Delete(int id)
        {
            Wallet wallet = walletDb.Wallets.Find(id);
            if (wallet == null)
            {
                
                Msg = string.Format("No Wallet Found With ID: {0}", id);
                return Msg;
            }

            else
            {
                walletDb.Wallets.Remove(wallet);
                walletDb.SaveChanges();
                Msg = "Wallet Successfully Deleted";
            }
             
            return Msg;
        }

        public Wallet GetWalletById(int id)
        {
            return walletDb.Wallets.Find(id);    
        }
    }
}
