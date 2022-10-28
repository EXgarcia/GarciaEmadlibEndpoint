//Elizar Garcia
//10-26-22
//Mini challenge #5 Madlib
//in this challenge we will make a madlib.
//Peer Review: Andrea Burr: i like how it runs i think his story should be longer but overall good code/story


using Microsoft.AspNetCore.Mvc;

namespace GarciaEmadlib.Controllers;

[ApiController]
[Route("[controller]")]
public class MadController : ControllerBase
{
   [HttpGet]
   [Route ("mad/{adjectiveone}/{vehicleOne}/{colorOne}/{nounOne}/{verbOne}/{city}/{adjectiveTwo}/{timeYear}/{favSong}/{place}")]

   public string madLib(string adjectiveOne, string vehicleOne, string colorOne, string nounOne, string verbOne, string city, string adjectiveTwo, string timeYear, string favSong, string place)
   {
    return ($" In my {adjectiveOne} new {vehicleOne} with a {colorOne} finish, with my favorite {nounOne} on my mimd, I {verbOne} through the empty steets of {city}. With the {adjectiveTwo} weather of {timeYear} I listen to {favSong} as I finally reach {place}. ");
   }

}