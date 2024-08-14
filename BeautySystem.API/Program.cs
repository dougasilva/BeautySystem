using BeautySystem.Application.Mappings;
using BeautySystem.Infra.IoC.Classes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Injeção de Dependência
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

//Swagger
builder.Services.AddInfraStructureSwagger();

//AutoMapper
builder.Services.AddAutoMapper(typeof(EntitiesToDTOMappingProfile));

//FluentValidation
builder.Services.AddFluentValidationServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
