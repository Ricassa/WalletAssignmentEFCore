using Hubtel.Wallets.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Hubtel.Wallets.Api.BusinessLayer
{
    //This interface specifies the operations/methods that are supported by WalletRepo.cs
    
    public interface IWalletRepo
    {
        string Add(Wallet wallet);
        IEnumerable<Wallet> GetAllWallets();
        Wallet GetWalletById(int id);
        string Delete(int id);
    }
}
