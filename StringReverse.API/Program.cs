using StringReverse.API.Abstractions;
using StringReverse.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpsRedirection(options => options.HttpsPort = 8010);
builder.Services.AddCors(o => o.AddPolicy("MyPolicy", x =>
{
    x.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
}));
builder.Services.AddScoped<ITextService, TextService>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.MapControllers();
app.UseHttpsRedirection();
app.Run("https://localhost:8010");
