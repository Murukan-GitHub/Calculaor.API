class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select the operator from following option");
        Console.WriteLine("1. For Addition Type 1.");
        Console.WriteLine("2. For Subtraction Type 2.");
        Console.WriteLine("3. For Division Type 3.");
        Console.WriteLine("4. For Multiplication Type 4.");
        Console.WriteLine("5. For Exit Type 0.");

        Console.WriteLine("----------------------------------------");
        var option = Console.ReadLine();
        string param1 = "";
        string param2 = "";
        var parameters = new Dictionary<string, string>();
        while (option != "0")
        {
            try
            {
                switch (option)
                {
                    case "1":
                        InputNumbers(out param1, out param2);
                        Console.WriteLine("Add....");
                        parameters = new Dictionary<string, string>() {
                                        { "param1", param1 },
                                        { "param2", param2 },
                                        {"operationType","Add" }
                                        };
                        Console.WriteLine(Add(parameters).Result);
                        break;
                    case "2":
                        InputNumbers(out param1, out param2);
                        Console.WriteLine("Subtract....");
                        parameters = new Dictionary<string, string>() {
                                        { "param1", param1 },
                                        { "param2", param2 },
                                        {"operationType","Subtract" }
                                        };
                        Console.WriteLine(Subtract(parameters).Result);
                        break;
                    case "3":
                        InputNumbers(out param1, out param2);
                        Console.WriteLine("Divide....");
                        parameters = new Dictionary<string, string>() {
                                        { "param1", param1 },
                                        { "param2", param2 },
                                        {"operationType","Divide" }
                                        };
                        Console.WriteLine(Divide(parameters).Result);
                        break;
                    case "4":
                        InputNumbers(out param1, out param2);
                        Console.WriteLine("Multiply....");
                        parameters = new Dictionary<string, string>() {
                                        { "param1", param1 },
                                        { "param2", param2 },
                                        {"operationType","Multiply" }
                                        };
                        Console.WriteLine(Multiply(parameters).Result);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Please enter an option");
            option = Console.ReadLine();
        }



        Console.ReadLine();
    }

    private static void InputNumbers(out string param1, out string param2)
    {
        Console.WriteLine("Please enter first number.");
        param1 = Console.ReadLine();
        Console.WriteLine("Please enter second number.");
        param2 = Console.ReadLine();
    }

    private static async Task<double> Add(Dictionary<string, string> parameters)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:5033/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var baseUrl = "http://localhost:5033/api/calculator/add";
            var url = baseUrl + "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)));


            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return Convert.ToDouble(result);
            }
            else
            {
                return 0;
            }
        }
    }
    private static async Task<double> Subtract(Dictionary<string, string> parameters)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:5033/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var baseUrl = "http://localhost:5033/api/calculator/subtract";
            var url = baseUrl + "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)));


            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return Convert.ToDouble(result);
            }
            else
            {
                return 0;
            }
        }
    }
    private static async Task<double> Multiply(Dictionary<string, string> parameters)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:5033/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var baseUrl = "http://localhost:5033/api/calculator/Multiply";
            var url = baseUrl + "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)));


            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return Convert.ToDouble(result);
            }
            else
            {
                return 0;
            }
        }
    }
    private static async Task<double> Divide(Dictionary<string, string> parameters)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:5033/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var baseUrl = "http://localhost:5033/api/calculator/Divide";
            var url = baseUrl + "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)));


            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return Convert.ToDouble(result);
            }
            else
            {
                return 0;
            }
        }
    }
}