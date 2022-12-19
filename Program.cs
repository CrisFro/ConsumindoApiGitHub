using Newtonsoft.Json;


namespace ConsumindoApiGitHub
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Informe o Usuário: ");
            string user = Console.ReadLine();


            HttpClient client = new HttpClient { BaseAddress = new Uri($"https://api.github.com") };
            client.DefaultRequestHeaders.Add("User-Agent", "MyConsoleApp");


            var response = await client.GetAsync($"users/{user}/repos");


            var content = await response.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<User[]>(content);

            foreach (var item in users)
            {
                Console.WriteLine("Nome: " + item.Name);
                Console.WriteLine("Descrição: " + item.Description);
                Console.WriteLine();asasas

            }

        }

    }

}

