var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddCors(options => options.AddPolicy("All", 
    build => build.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()));

var app = builder.Build();
app.MapControllers();
app.UseCors("All");
app.Run();