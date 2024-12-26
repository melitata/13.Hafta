using Dependency_Injection.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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


                            public partial class Program
                            {
                                public static void Main(string[] args)
                                {
                                    var builder = WebApplication.CreateBuilder(args);

                                    builder.Services.AddControllers();
                                    builder.Services.AddControllers();

                                    builder.Services.AddScoped<ITeacher, Teacher>(provider =>
                                        new Teacher("Ahmet", "Yýlmaz"));
                                    builder.Services.AddScoped<ClassRoom>();

                                    var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
                                }
                            }

