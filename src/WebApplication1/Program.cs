using WebApplication1;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var framework = new Framework(app.Services);

framework.RecieveAsync((int a, int b) =>
{
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapPost("/api", async (IAsyncDisposable context) =>
{
    await context.DisposeAsync();
});

await app.RunAsync();
