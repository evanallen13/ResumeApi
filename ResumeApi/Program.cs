using ResumeApi.path;
using ResumeApi.src;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// Default 
app.MapGet("/", () => "Hello World");

// Certifications 
var certification = new Certification();
app.MapGet("/certification", () => certification.GetCerts());
app.MapGet("/certification/{id}", (int id) => certification.GetCert(id));

// Jobs 
var job = new Job();
app.MapGet("/job", () => job.GetJobs());
app.MapGet("/job/{id}", (Guid id) => job.GetJobs(id));

// Skills 

// Projects
var project = new Project();
app.MapGet("/project", () => project.GetProject());
app.MapGet("/project/{id}", (Guid id) => project.GetProject(id));

// Education
var education = new Education();
app.MapGet("/education", () => education.GetEducation());
app.MapGet("/education/{id}", (Guid id) => education.GetEducation(id));

app.Run();