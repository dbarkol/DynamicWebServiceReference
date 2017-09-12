//----------------------------------------------------------------------------------
// Microsoft - Urban Insights Proof of Concept for File Repository
//
// Copyright (c) Microsoft Corporation. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
//----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zohan.ClientSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a web reference
            var svc = new SomeService.SomeService();

            // Check to see if there is an environment variable available
            // for the web reference and updated it accordingly.
            var endpoint = Environment.GetEnvironmentVariable("SysQueEndpoint");
            if (!string.IsNullOrEmpty(endpoint))
            {                
                Console.WriteLine("Environment variable: {0}", endpoint);
                svc.Url = endpoint;
            }

            // Call the service and output the results
            var pingResult = svc.PingTest();
            Console.WriteLine("Service ping: {0}", pingResult);

            // Cleanup
            Console.WriteLine("Press <enter> to exit.");
            Console.ReadLine();
        }
    }
}
