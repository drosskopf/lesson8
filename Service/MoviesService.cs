using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace webapp
{
    public class MoviesService:IMoviesService
    {
        // private string URL { get; set; }
        // public MoviesService(string url)
        // {
        //     URL = url;
        // }

        public async Task<Movie> Get(string id)
        {

            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync($"http://www.omdbapi.com/?i={id}");
                return JsonConvert.DeserializeObject<Movie>(response);
            }
        }
    }
}