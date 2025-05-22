var builder = WebApplication.CreateBuilder(args);

// Web API only
builder.Services.AddControllers();

// Register HttpClient for SteamApiService
builder.Services.AddHttpClient<SteamApiService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

// Maps attribute-routed API endpoints
app.MapControllers();

app.Run();
