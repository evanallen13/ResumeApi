using ResumeApi.src;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

// Default 
app.MapGet("/", () => "Hello World");

// Certifications 
var certification = new Certification();
app.MapGet("/certifications", () => certification.GetCerts());
app.MapGet("/certifications/{id}", (int id) => certification.GetCert(id));

app.MapGet("/sayHello", () => certification.SayHello());

app.Run();
