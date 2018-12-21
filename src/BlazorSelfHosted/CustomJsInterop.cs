using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSelfHosted
{
    public class CustomJsInterop
    {
        public static Task<string> Alert(string text)
        {
            // showPrompt is implemented in wwwroot/exampleJsInterop.js
            return JSRuntime.Current.InvokeAsync<string>(
                "customjscode.alert", text);
        }
    }
}
