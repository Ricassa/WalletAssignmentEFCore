using Hubtel.Wallets.Api.BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;
using Hubtel.Wallets.Api.Models;

namespace Hubtel.Wallets.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WalletController : Controller
    {
        private readonly IWalletRepo _walletRepo;   
        public WalletController(IWalletRepo walletRepo)
        {
            _walletRepo = walletRepo;   
        }

        //API to Get All Wallets
        [HttpGet]
        public IActionResult GetAllWallets()
        {
            try
            {
                var result = _walletRepo.GetAllWallets();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //API to get Wallet By Id
        [Route("getwalletbyid")]
        [HttpGet]
        public IActionResult GetWalletById(int id)
        {
            try
            {
                var result = _walletRepo.GetWalletById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //API to Add A New Wallet
        [HttpPost]
        public IActionResult AddWallet(Wallet newWallet)
        {
            try
            {
                var result = _walletRepo.Add(newWallet);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //API to Delete Wallet
        [Route("deletewallet")]
        [HttpDelete]
        public IActionResult DeleteWallet(int id)
        {
            try
            {
                var result = _walletRepo.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
