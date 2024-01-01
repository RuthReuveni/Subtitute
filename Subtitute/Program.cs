using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SubtituteBL;
using SubtituteDL;
using SubtituteDL.Models;
using SubtituteDTO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapping));
builder.Services.AddScoped<ILessonBL, LessonBL>();
builder.Services.AddScoped <ILessonDL, LessonDL>();
builder.Services.AddScoped<ILookUpBL, LookUpBL>();
builder.Services.AddScoped<ILookUpDL, LookUpDL>();
builder.Services.AddScoped<IRequestBL, RequestBL>();
builder.Services.AddScoped<IRequestDL, RequestDL>();
builder.Services.AddScoped<ISchoolBL, SchoolBL>();
builder.Services.AddScoped<ISchoolDL, SchoolDL>();
builder.Services.AddScoped<ISpecializationSubTtreqBL, SpecializationSubTtreqBL>();
builder.Services.AddScoped<ISpecializationSubTtreqDL, SpecializationSubTtreqDL>();
builder.Services.AddScoped<ISpesializitionSubTtBL, SpesializitionSubTtBL>();
builder.Services.AddScoped<ISpesializitionSubTtDL, SpesializitionSubTtDL>();
builder.Services.AddScoped<ISubTtBL, SubTtBL>();
builder.Services.AddScoped<ISubTtDL, SubTtDL>();
builder.Services.AddScoped<ISubTtschoolBL, SubTtschoolBL>();
builder.Services.AddScoped<ISubTtschoolDL, SubTtschoolDL>();
builder.Services.AddScoped<ITeacherBL, TeacherBL>();
builder.Services.AddScoped<ITeacherDL, TeacherDL>();
builder.Services.AddDbContext<SubstituteDbContext>(options =>
    options.UseSqlServer("Server=DESKTOP-R5RADSP;Database=substituteDB;Trusted_Connection=True;encrypt=false;"));

var app = builder.Build();
app.UseCors();
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
