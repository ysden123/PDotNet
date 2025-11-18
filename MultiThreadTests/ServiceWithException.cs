using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadTests
{
    internal static class ServiceWithException
    {
        internal static async Task<string> Method1(bool throwException)
        {
            try {
                string? result = await Task<string>.Run(async () =>
                {
                    if (throwException)
                        throw new InvalidOperationException("An error occurred in Method1's task.");
                    return "Hello, World!";
                    
                });
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Method1: exception - {ex}");
                throw;
            }
        }
    }
}
