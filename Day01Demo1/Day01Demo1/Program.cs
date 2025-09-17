using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Khi vào trang chủ ("/") sẽ hiện dòng chữ
app.MapGet("/", () => "Hello World - Lê Đoàn Quốc Văn - 2210900078");

app.Run();

