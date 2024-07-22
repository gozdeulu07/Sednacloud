using SednaReservationAPI.Persistence;
using SednaReservationAPI.Application;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SednaReservationAPI.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using FluentValidation.AspNetCore;
<<<<<<< Updated upstream
using SednaReservationAPI.Application.Validators.Customer;
using SednaReservationAPI.Application.Validators.Hotel;
using SednaReservationAPI.Application.Validators.Payment;
using SednaReservationAPI.Application.Validators.Reservation;
using SednaReservationAPI.Application.Validators.Review;
using SednaReservationAPI.Application.Validators.Room;
using SednaReservationAPI.Application.Validators.RoomType;
=======
>>>>>>> Stashed changes
using SednaReservationAPI.Application.Validators.AppUser;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer("Admin", options =>
    {
<<<<<<< Updated upstream
        options.TokenValidationParameters = new()
        {
            ValidateAudience = true, // Validates tokens for which site/origin's customer uses token
            ValidateIssuer = true, // Validates tokens for who give this token(api)
            ValidateLifetime = true, // Valides tokens for check lifetime
            ValidateIssuerSigningKey = true, // Valides tokens for if token is our website's

            ValidAudience = builder.Configuration["Token:Audience"],
            ValidIssuer = builder.Configuration["Token:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"]))
        };
    });
builder.Services.AddControllers().AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateAppUserValidator>()
);

=======
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidAudience = builder.Configuration["Token:Audience"],
        ValidIssuer = builder.Configuration["Token:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
        LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires != null ? expires > DateTime.UtcNow : false
    };
});
builder.Configuration.SetBasePath(Directory.GetCurrentDirectory());
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
builder.Services.AddControllers().AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateUserValidator>());
>>>>>>> Stashed changes

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
