using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using FleetingCanvas;
using FleetingCanvas.Shared;

namespace FleetingCanvas.Canvas
{
    public partial class Canvas
    {

        private string? imagePath;

        private void SetImagePath()
        {
            if (!String.IsNullOrWhiteSpace(imagePath))
            {
                //using Image image = Image.Load(this.imagePath);
                "".ToString();
            }
        }
    }
}