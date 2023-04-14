using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Sorting_Grid.Data;
using Syncfusion.Blazor;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkVVpHaV5CQmFJfFBmQmlbf1R0c0U3HVdTRHRcQl9iTn5SdENjXHldcHI=;Mgo+DSMBPh8sVXJ0S0J+XE9Af1RBQmJJYVF2R2BJeFRydF9CZ0wgOX1dQl9gSXxScUViW3ledXJRQmY=;ORg4AjUWIQA/Gnt2VVhkQlFaclZJXnxIfkx0RWFab1l6dlVMZFtBNQtUQF1hSn5Rd0JjWH1YcHFTQ2da;MTE0ODAzOEAzMjMwMmUzNDJlMzBJdm9ORm0xaU0rQU9RM0xOTnhQTkh0MWxCYm1NVkFibVMrT0xmVGVVNy84PQ==;MTE0ODAzOUAzMjMwMmUzNDJlMzBSV1NrdVhYK1BVOE1yRDNxNDBSc0xCUWFlQzhiZm5Pc1JSdFk4RWRUZnhFPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtLVmBWf1NpR2NbfE53fldGalhWVAciSV9jS31TdERkWX5cdnRQQWJUVw==;MTE0ODA0MUAzMjMwMmUzNDJlMzBTaWdQV0VrVUtKYXpFS3BKMkpOWkN4eWVXQUttNEhZWTJrL3NXanJaZm04PQ==;MTE0ODA0MkAzMjMwMmUzNDJlMzBJNHRkWkg1SGpxSndoK2NHZEYzeFduRGtCUkZGRmVuSVNKU3pldWlFaGlFPQ==;Mgo+DSMBMAY9C3t2VVhkQlFaclZJXnxIfkx0RWFab1l6dlVMZFtBNQtUQF1hSn5Rd0JjWH1YcHFSTmVa;MTE0ODA0NEAzMjMwMmUzNDJlMzBMTXY2eG1NenpkOUJNZWtnT2hqOWhNUDVSbG1LOEdERmdJeTN2SmpSK3pBPQ==;MTE0ODA0NUAzMjMwMmUzNDJlMzBJNDc0Y2tUdW9Bd290YWZPR0ZYMVVMd0hOcFNhZXMwRWhWeUttZ0pqbG1FPQ==;MTE0ODA0NkAzMjMwMmUzNDJlMzBTaWdQV0VrVUtKYXpFS3BKMkpOWkN4eWVXQUttNEhZWTJrL3NXanJaZm04PQ==");
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
