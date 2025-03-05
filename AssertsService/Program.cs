using AssertsService.Data;
using Microsoft.EntityFrameworkCore;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AssertDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));
builder.Services.AddScoped<IAssertRegisterRepository, AssertRegisterRepository>();
builder.Services.AddScoped<IWorkforceManagementRepository, WorkforceManagementRepository>();
builder.Services.AddScoped<IMunicipalRepository, MunicipalRepository>();
builder.Services.AddScoped<IUserDetailsRepository, UserDetailsRepository>();
builder.Services.AddScoped<IBudgetPlanRepository, BudgetPlanRepository>();
builder.Services.AddScoped<IBudgetApprovalRepository, BudgetApprovalRepository>();
builder.Services.AddScoped<IKeyPerformanceIndicatorRepository, KeyPerformanceIndicatorRepository>();
builder.Services.AddScoped<IComplianceAndRegulatoryRepository, ComplianceAndRegulatoryRepository>();
builder.Services.AddScoped<IRiskManagementandContingencyPlansRepository, RiskManagementandContingencyPlanRepository>();
builder.Services.AddScoped<IQualityPlanandContinuousImprovementRepository, QualityPlanandContinuousImprovementRepository>();
builder.Services.AddScoped<IMaintenanceActivityRepository, MaintenanceActivityRepository>();
builder.Services.AddScoped<IUploadRepository, UploadRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null; // Keeps PascalCase
    });
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

app.UseHttpsRedirection();
app.UseCors("AllowAllOrigins");
app.UseAuthorization();

app.MapControllers();

app.Run();
