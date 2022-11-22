using CalculaorAPI.Calculator.Middleware;

namespace CalculaorAPI.Services
{
    public class Calculate
    {
        public string OperationType { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public async Task<double> Execute()
        {
            if (double.TryParse(Param1, out double num1) && double.TryParse(Param2, out double num2))
            {
                TaskCompletionSource<double> tcs = new TaskCompletionSource<double>();
                if (OperationType == "Add")
                {
                    await Task.Run(() =>
                     {
                         double result = num1 + num2;
                         //set the result to TaskCompletionSource
                         tcs.SetResult(result);
                     });
                }
                else if (OperationType == "Subtract")
                {
                    await Task.Run(() =>
                        {
                            double result = num1 - num2;
                            //set the result to TaskCompletionSource
                            tcs.SetResult(result);
                        });
                }

                else if (OperationType == "Multiply")
                {
                    await Task.Run(() =>
                         {
                             double result = num1 * num2;
                             //set the result to TaskCompletionSource
                             tcs.SetResult(result);
                         });
                }

                else if (OperationType == "Divide")
                {
                    await Task.Run(() =>
                    {
                        double result = num1 / num2;
                        //set the result to TaskCompletionSource
                        tcs.SetResult(result);
                    });
                }
                return await tcs.Task;
            }
            else
                throw new ApiException("invalid input");

        }
    }
}

