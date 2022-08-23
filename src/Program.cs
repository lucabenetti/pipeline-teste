var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/first", () =>
{
    return "first";
});

app.MapGet("/second", () =>
{
    return "second";
});

app.MapGet("/third", () =>
{
    return "third";
});

app.MapGet("/quarto", () =>
{
    return "quarto";
});

app.Run();