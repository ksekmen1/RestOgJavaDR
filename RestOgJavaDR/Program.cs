using Microsoft.EntityFrameworkCore;
using RestOgJavaDR.Models;

using RestOgJavaDR;
using RestOgJavaDR.Repository;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowAll",
                              policy =>
                              {
                                  policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                              });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

bool useSql = true;
if (useSql) {
    var optionsBuilder = new DbContextOptionsBuilder<KRDBContext>();
    optionsBuilder.UseSqlServer(Secrets.ConnectionString);
    KRDBContext context = new KRDBContext(optionsBuilder.Options);
    builder.Services.AddSingleton<IRecordsRepository>(
        new RecordsRepoDb(context));
}
else
{
    builder.Services.AddSingleton<IRecordsRepository>
        (new RecordsRepository());
}



builder.Services.AddSwaggerGen(c => {
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    c.IgnoreObsoleteActions();
    c.IgnoreObsoleteProperties();
    c.CustomSchemaIds(type => type.FullName);
});



var app = builder.Build();


// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowAll");

app.MapControllers();

app.Run();
