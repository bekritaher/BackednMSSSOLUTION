using Backend_Mss.Data;
using Backend_Mss.Models;
using digiPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend_Mss.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : Controller 
    {
        private readonly MpayDbContext mpayDbContext;

        public ServiceController(MpayDbContext mpayDbContext)
        {
            this.mpayDbContext= mpayDbContext;
        }


        [HttpPost]
        [Route("GetMerchants")]

        public async Task<IActionResult> GetALLMerchants([FromBody] Commercant commercant)
        {
            try
            {
                //         var merchants = await digiproDbContext.Commercantsmaster.ToListAsync();
                var commercants = await mpayDbContext.Merchants.FirstOrDefaultAsync(x => (x.Msisdn_merchant == commercant.msisdn) & (x.Imei_merchant == commercant.imei) & (x.ClientBankcodeMerchant == commercant.bankcode) & (x.Code_canal_merchant == commercant.code_canal) & (x.Code_app_merchant == commercant.code_app));

                if (commercants != null)
                {

                    var test = await mpayDbContext.Merchants.FirstOrDefaultAsync(x => (x.Status_merchant == "Bloqué"));

                    if (test != null)
                    {
                        return Ok(commercants);
                    }
                    return BadRequest("Merchant Bloqué");

                }
                return BadRequest("Merchant not exist");
            }
            catch (Exception)
            {
                return BadRequest("Error retrieving data from the database");
            }


        }

        [HttpPost]
        [Route("GetSubscribers")]

        public async Task<IActionResult> GetSubscribers([FromBody] Commercant commercant)
        {
            try
            {
                //         var merchants = await digiproDbContext.Commercantsmaster.ToListAsync();
                var commercants = await mpayDbContext.Subscribers.FirstOrDefaultAsync(x => (x.Msisdn_subscriber == commercant.msisdn) & (x.imei_subscriber == commercant.imei) & (x.Client_bankcode_subscriber == commercant.bankcode) & (x.code_canal_subscriber == commercant.code_canal) & (x.code_app_subscriber == commercant.code_app));

                if (commercants != null)
                {

                    var test = await mpayDbContext.Subscribers_verifications.FirstOrDefaultAsync(x => (x.Msisdn_sub_verification == commercant.msisdn) & (x.Imei_sub_verification == commercant.imei) & (x.Client_bankcode_sub_verification == commercant.bankcode) & (x.CodeCanalSubVerification == commercant.code_canal) & (x.Code_app_sub_verification == commercant.code_app));

                    if (test != null)
                    {
                        var verif = await mpayDbContext.Subscribers.FirstOrDefaultAsync(x => (x.Statussubscriber.Equals("Bloqué")));

                        if ((commercants.Statussubscriber.Equals("Inscrit")) || (commercants.Statussubscriber.Equals("Enregistré")))
                        {
//                            test.Otp_status_sub_verification = "Inscrit";
                            return Ok("OTP_G_OK");

                        }
                        return Ok("NOK "+ commercants.Statussubscriber);

                    }
                    return Ok("Subscriber Not fils ");

                }
                return Ok("Subscriber not exist");
            }
            catch (Exception)
            {
                return Ok("Error retrieving data from the database");
            }


        }

























        //[HttpGet]
        //[Route("GetMerchants")]

        //public async Task<IActionResult> GetALLMerchants()
        //{
        //    var merchants = await mpayDbContext.Merchants.ToListAsync();
        //    return Ok(merchants);
        //} 
        //[HttpGet]
        //[Route("GetMerchants_tpe")]

        ////public Merchent Post([FormBody] Merchant merchant)
        ////{
        ////    var merchants = await mpayDbContext.Merchants_tpes.ToListAsync();
        ////    return Ok(merchants);
        ////}


        //[HttpGet]
        //[Route("GetSubscribers")]

        //public async Task<IActionResult> GetALLSubscribers()
        //{
        //    var merchants = await mpayDbContext.Subscribers.ToListAsync();
        //    return Ok(merchants);
        //}
        //[HttpGet]
        //[Route("GetSubscribers_operations")]

        //public async Task<IActionResult> GetALLSubscribers_operations()
        //{
        //    var merchants = await mpayDbContext.Subscribers_operations.ToListAsync();
        //    return Ok(merchants);
        //}


        //[HttpGet]
        //[Route("GetSubscribers_verifications")]

        //public async Task<IActionResult> GetALLSubscribers_verifications()
        //{
        //    var merchants = await mpayDbContext.Subscribers_verifications.ToListAsync();
        //    return Ok(merchants);
        //}






        //[HttpPost]
        //public async Task<IActionResult> GetMerchant([FromRoute] Guid id)
        //{
        //    var merchant = await mpayDbContext.Subscribers_verifications.FirstOrDefaultAsync(x => x.Msisdn_sub_verification == id);
        //    if (merchant != null)
        //    {
        //        return Ok(merchant);
        //    }
        //    return NotFound("merchant not found");
        //}

        //[HttpPost]
        //public async Task<IActionResult> AddMerchant([FromRoute] Subscriber_verification Subscriber_verification)
        //{
        //    var em= await mpayDbContext.Subscribers_verifications.AddAsync(Subscriber_verification);
        //    await mpayDbContext.SaveChangesAsync();
        //    return NotFound("merchant not found");
        //}


    }
}
