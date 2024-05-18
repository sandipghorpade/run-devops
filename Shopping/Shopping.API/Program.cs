using Shopping.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();

        //policy.WithOrigins("http://localhost:8081", "http://localhost:5001")
        //      .AllowAnyMethod()
        //      .AllowAnyHeader();
    });
});
builder.Services.AddControllers();


//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ProductContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("MyPolicy");
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();


