using Hubtel.Wallets.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Hubtel.Wallets.Api.BusinessLayer
{
    public interface IWalletRepo
    {
        string Add(Wallet wallet);
        IEnumerable<Wallet> GetAllWallets();
        Wallet GetWalletById(int id);
        string Delete(int id);
    }
}
