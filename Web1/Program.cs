using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder();

var app = builder.Build();

app.UseStaticFiles();   // ��������� ��������� ����������� ������

app.Run(async (context) => await context.Response.WriteAsync("Hello World"));

app.Run();