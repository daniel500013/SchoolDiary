using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Identity;
using System.Reflection;
using System.Runtime.CompilerServices;
using SchoolDiary.api.Dto;

[assembly: InternalsVisibleTo("SchoolDiary.Tests")]

var builder = WebApplication.CreateBuilder(args);

// Add Sql Server to container
builder.Services.AddDbContext<DiaryDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnectionString")));

// Add services to the container.
builder.Services.AddScoped<AccountService>();
builder.Services.AddScoped<RoleManagerService>();
builder.Services.AddScoped<ParentService>();
builder.Services.AddScoped<ClassService>();
builder.Services.AddScoped<ClassManagerService>();
builder.Services.AddScoped<TeacherService>();
builder.Services.AddScoped<MarkService>();
builder.Services.AddScoped<GradeService>();
builder.Services.AddScoped<ApproveService>();
builder.Services.AddScoped<LessonService>();
builder.Services.AddScoped<SubjectService>();
builder.Services.AddScoped<IPasswordHasher<LoginDto>, PasswordHasher<LoginDto>>();

// Configure JwtData Globaly
var auth = new JwtData();
builder.Configuration.GetSection("Jwt").Bind(auth);
builder.Services.AddSingleton(auth);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "School Diary API", Version = "v2" });

    var securitySchema = new OpenApiSecurityScheme
    {
        Description = "Using the Authorization header with the Bearer scheme.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = "Bearer"
        }
    };

    c.AddSecurityDefinition("Bearer", securitySchema);

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
          {
              { securitySchema, new[] { "Bearer" } }
          });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

// Add Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = "Bearer";
    options.DefaultScheme = "Bearer";
    options.DefaultChallengeScheme = "Bearer";
}).AddJwtBearer(cfg =>
{
    cfg.RequireHttpsMetadata = false;
    cfg.SaveToken = true;
    cfg.Audience = "https://localhost:7167";
    cfg.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = auth.Issuer,
        ValidAudience = auth.Issuer,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(auth.Key)),
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.MapControllers();

app.Run();