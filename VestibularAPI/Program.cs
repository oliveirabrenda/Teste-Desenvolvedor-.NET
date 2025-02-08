using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VestibularAPI.config;
using VestibularAPI.infraestructure.model;
using VestibularAPI.infraestructure.model.context;
using VestibularAPI.infraestructure.repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Contexto de dados adicionado a aplicação
builder.Services.AddDbContext<VestibularContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();

builder.Services.AddSingleton(mapper);
builder.Services.AddScoped<ICandidatoRepository, CandidatoRepository>();
builder.Services.AddScoped<ICursoRepository, CursoRepository>();
builder.Services.AddScoped<IInscricaoRepository, InscricaoRepository>();
builder.Services.AddScoped<IProcessoSeletivoRepository, ProcessoSeletivoRepository>();

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
