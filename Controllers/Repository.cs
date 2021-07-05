
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Highfield.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Highfield.Controllers;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Highfield.Controllers
{
public class Repository{

private static readonly HttpClient client = new HttpClient();

public async static Task<List<UserEntity>> GetUserEntities()
{
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
    client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

    var streamTask = client.GetStreamAsync("https://recruitment.highfieldqualifications.com/api/test");
    var userEntities = await JsonSerializer.DeserializeAsync<List<UserEntity>>(await streamTask);
    
    return userEntities;
}

public async Task<List<UserEntity>> ProcessUserEntities(){
   var x = await GetUserEntities();
   return x;
}

public List<AgePlusTwenty> ProcessAges(List<UserEntity> userEntities){
            List<AgePlusTwenty> agesPlusTwenty = new List<AgePlusTwenty>();

            foreach(var user in userEntities){
                AgePlusTwenty age = new AgePlusTwenty();
                
                age.userId = user.id;
                //TimeSpan difference = DateTime.Today - user.dob;

                age.originalAge = DateTime.Today.Year - user.dob.Year;
                if(user.dob.Month > DateTime.Today.Month){
                    age.originalAge--;
                }
                else if(user.dob.Month == DateTime.Today.Month && user.dob.Day > DateTime.Today.Day){
                    age.originalAge--;
                }

                age.agePlusTwenty = age.originalAge + 20;

                agesPlusTwenty.Add(age);
            }

            return agesPlusTwenty;
        }

        public List<TopColours> ProcessColours(List<UserEntity> userEntities){
           List<TopColours> topColours = new List<TopColours>();

           //var colourNames = userEntities.Select(x => x.favouriteColour).Distinct().ToList();

           var groups = userEntities.GroupBy(x => x.favouriteColour);

           foreach(var group in groups){
              topColours.Add(new TopColours(){
                 colour = group.Key,
                 count = group.Count()
              });
           }

           return topColours;
        }

}
}