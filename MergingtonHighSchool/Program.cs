using MergingtonHighSchool.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Enable serving static files
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "wwwroot";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Serve static files
app.UseStaticFiles();
app.UseSpaStaticFiles();

app.UseAuthorization();

app.MapControllers();

// Redirect root to index.html
app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();
