using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreSample.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotNetCoreSample.Entities;
using DotNetCoreSample.Models;

namespace DotNetCoreSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public OrdersController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            using(var db = new MyEntityContext())
            {
                var orders = db.UserItems
                    .Select(s => new Order
                    {
                        OrderId = s.UserItemId,
                        UserId = s.UserId,
                        Name = s.User.Firstname + " " + s.User.Lastname,
                        ItemId = s.ItemId,
                        Item = s.Item.Name,
                        Quantity = s.Quantity
                    })
                    .ToList();
                return orders;
            }
        }
    }
}
