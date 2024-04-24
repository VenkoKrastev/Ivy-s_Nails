using IvysNails.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddApplicationIdentity(builder.Configuration);

builder.Services.AddControllersWithViews(options =>
{
    options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
    options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
});

builder.Services.AddApplicationServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error/500");
    app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{  
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Product}/{action=All}/{id?}");

    endpoints.MapControllerRoute(
        name: "AllProducts",
        pattern: "Product/All/{id}",
        defaults: new { controller = "Product", action = "All" }
    );

    endpoints.MapControllerRoute(
        name: "ShoppingCart",
        pattern: "{controller=Cart}/{action=All}/{id?}");



    endpoints.MapDefaultControllerRoute();
    endpoints.MapRazorPages();
});



await app.RunAsync();
