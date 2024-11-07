using Farmacia.DataContext;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region AREA_RESERVADA_A_AUTHENTICACAO

//var secretKey = Encoding.ASCII.GetBytes("");

//builder.Services.AddAuthentication(x =>
//{
//    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer(x =>
//{
//    x.RequireHttpsMetadata = false;
//    x.SaveToken = true;
//    //PARAMETROS DE VALIDA플O DO TOKEN
//    x.TokenValidationParameters = new TokenValidationParameters
//    {
//        //VALIDA플O DA CHAVE DE ASSINATURA DO EMISSOR
//        ValidateIssuerSigningKey = true,
//        //CHAVE DE ASSINATURA DO EMISSOR
//        IssuerSigningKey = new SymmetricSecurityKey(secretKey),
//        //VALIDA플O DO EMISSOR
//        ValidateIssuer = false,
//        //VALIDA플O DA AUDIENCIA
//        ValidateAudience = false
//    };
//});

#endregion

builder.Services.AddDbContext<MyDataContext>(opt => opt.UseMySQL("datasource=127.0.0.1;username=root;password=;database=farmacia"));

builder.Services.AddScoped<MyDataContext, MyDataContext>();

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
