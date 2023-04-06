using Application.Contract.Departments;
using Application.Contract.Empolyees;
using Application.Features.Departments.Command.CreateDepartment;
using Infrastructre.Departments;
using Infrastructre.Employees;
using Microsoft.EntityFrameworkCore;
using MyDBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<TaskDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("AmanDbConnectionString")));


builder.Services.AddMediatR(config =>
{ config.RegisterServicesFromAssembly(typeof(CreateDepartmentCommant).Assembly); });





/// ingect
///
//

builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options =>
{
    options.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
    //.AllowCredentials();

});
app.UseAuthorization();

app.MapControllers();

app.Run();
