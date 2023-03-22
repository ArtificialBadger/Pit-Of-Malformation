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
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Jpeg;

namespace FleetingCanvas.Canvas
{
    public partial class Canvas
    {
        private string? imageSource;

        private async Task LoadFile(InputFileChangeEventArgs e)
        {
            //var buffer = new byte[e.File.Size];
            //await e.File.OpenReadStream(maxAllowedSize: 10000000).ReadAsync(buffer);

            using var image = await Image.LoadAsync(e.File.OpenReadStream(maxAllowedSize: 10000000));

            int width = 100;
            int height = 100;
            image.Mutate(x => x.Resize(width, height));

            var raw = image.ToBase64String(PngFormat.Instance);

            imageSource = raw;
        }
    }
}