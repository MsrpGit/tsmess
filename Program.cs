using CampusDAO;
using DL.Data;
using EdusyncSecurity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using tsmess.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
builder.Services.AddScoped<IRazorRenderService, RazorRenderService>();
// Add services to the container.
builder.Services.AddRazorPages();

// Register the ConnectionStringResolver
//builder.Services.AddSingleton<ConnectionStringResolver>();
builder.Services.AddScoped<EncryptionService>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddScoped<IDBInterface, DBConnection>();

builder.Services.AddTransient<ITsMessService, TsMessService>();


// Register DbContext with a placeholder connection string (will be replaced dynamically)
//builder.Services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
//{
//    var connectionStringResolver = serviceProvider.GetRequiredService<ConnectionStringResolver>();
//    var connectionString = connectionStringResolver.GetConnectionString();
//    options.UseSqlServer(connectionString.ToString());
//});
//builder.Services.AddDbContext<ApplicationDbContextDbo>(options =>
//    options.UseSqlServer(
//        builder.Configuration.GetConnectionString("AdminConnection")));

//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationDbContextDbo>();

//builder.Services.ConfigureApplicationCookie(options =>
//{
//    options.LoginPath = "/Login";
//    options.AccessDeniedPath = "/AccessDenied";
//});

//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationDbContext>();

//builder.Services.AddRazorPages(options =>
//{
//    //options.Conventions.AuthorizeFolder("/"); // Protect all pages
//    options.Conventions.AllowAnonymousToPage("/Login"); // Allow anonymous access to the Login page
//});



var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

// Use authentication and authorization middleware
app.UseAuthentication();
app.UseAuthorization();

//app.Use(async (context, next) =>
//{
//    var endpoint = context.GetEndpoint();
//    if (endpoint != null &&
//        endpoint.Metadata.GetMetadata<Microsoft.AspNetCore.Authorization.AuthorizeAttribute>() != null &&
//        !context.User.Identity.IsAuthenticated)
//    {
//        context.Response.Redirect("/Login");
//        return;
//    }
//    await next();
//});

app.MapRazorPages();

//app.MapPost("/api/send-sms", async (HttpContext context) =>
//{
//using var reader = new StreamReader(context.Request.Body);
//var body = await reader.ReadToEndAsync();
//var data = System.Text.Json.JsonSerializer.Deserialize<SmsRequest>(body);

//// Generate fake OTP
//var otp = "123456";
//Console.WriteLine($"Sending OTP to: {data.ToMobileNo}");

//return Results.Json(new { success = true, otp });
//});



//app.MapFallbackToPage("/PrincipalDashboard");

app.Run();

//public class SmsRequest
//{
//    public string ToMobileNo { get; set; }
//}