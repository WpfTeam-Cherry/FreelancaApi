using Freelancer.Services.Attributes;
using Freelancer.Services.Data;
using Freelancer.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ValueProviders;

namespace Freelancer.Services.Controllers
{
    public class JobsController : BaseApiController
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork();

        //[HttpGet]
        //[ActionName("all")]
        //public IEnumerable<CarModel> GetCategoryAll(
        //    [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        //{
        //    var messageResponse = this.TryExecuteOperation<IEnumerable<CarModel>>(() =>
        //    {
        //        var user = unitOfWork.userRepository.All().Single(x => x.AccessToken == sessionKey);
        //        if (user == null)
        //        {
        //            throw new InvalidOperationException("User has not logged in!");
        //        }

        //        var matchedCars = unitOfWork.carRepository.All();
        //        var carModels = matchedCars.Select(x => new CarModel()
        //        {
        //            Id = x.Id,
        //            Maker = x.Maker,
        //            Model = x.Model,
        //            ProductionYear = x.ProductionYear,
        //            Price = x.Price,
        //            Engine = x.Engine,
        //            Gear = x.Gear,
        //            HP = x.HP,
        //            ImageUrl = x.ImageUrl
        //        });

        //        return carModels;
        //    });

        //    return messageResponse;
        //}









        //[HttpPut]
        //[ActionName("logout")]
        //public HttpResponseMessage Get([FromBody] UserLogoutRequestModel userModel)
        //{
        //    var messageResponse = this.TryExecuteOperation(() =>
        //    {
        //        var user =
        //            this.unitOfWork.userRepository.All()
        //            .SingleOrDefault(user => user.AccessToken == userModel.AccessToken);
        //        if (user == null)
        //        {
        //            throw new ArgumentException("User is missing or not logged in!");
        //        }

        //        user.AccessToken = null;
        //        this.unitOfWork.userRepository.Update(user.Id, user);

        //        return this.Request.CreateResponse(HttpStatusCode.OK);//, user);
        //    });

        //    return messageResponse;
        //}


    }
}
