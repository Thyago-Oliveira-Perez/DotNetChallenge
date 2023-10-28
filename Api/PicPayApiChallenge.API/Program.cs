using Microsoft.EntityFrameworkCore;
using PicPayApiChallenge.Data.Context;
using PicPayApiChallenge.Domain.Services;
using PicPayApiChallenge.Domain.Types;

var builder = WebApplication.CreateBuilder(args);

// Add controllers to the container.
builder.Services.AddControllers();

// Add service to the container.
builder.Services.AddTransient<ITransferService, TransferService>();

// Add data base context to the container.
builder.Services.AddDbContext<PicPayApiChallenge.Data.Context.SqlContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
