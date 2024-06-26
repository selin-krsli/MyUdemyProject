﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapiApiConsume.Models;
using System.Net.Http.Headers;
namespace RapiApiConsume.Controllers
{
    public class SearchLocationIDController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            if (!string.IsNullOrEmpty(cityName))
            {
                List<BookingApiLocationSearchViewModel> bookingApiLocationSearchViewModels = new List<BookingApiLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
                    Headers =
                        {
                            { "x-rapidapi-key", "0c7bcff7d3mshd438c2089848288p14ff09jsnf4858bfacfc5" },
                            { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
                        },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    bookingApiLocationSearchViewModels = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
                    return View(bookingApiLocationSearchViewModels.Take(1).ToList());
                }
            }
            //şehir bilgisi girilmediği durumda default olarak Paris gelecek.
            else
            {
                List<BookingApiLocationSearchViewModel> bookingApiLocationSearchViewModels = new List<BookingApiLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=Paris&locale=en-gb"),
                    Headers =
                            {
                                { "x-rapidapi-key", "0c7bcff7d3mshd438c2089848288p14ff09jsnf4858bfacfc5" },
                                { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
                            },
                                        };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    bookingApiLocationSearchViewModels = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
                    return View(bookingApiLocationSearchViewModels.Take(1).ToList());
                }
            }

        }
    }
}
