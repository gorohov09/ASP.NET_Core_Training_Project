var builder = WebApplication.CreateBuilder(args);

//�������� �������
var services = builder.Services;
services.AddControllersWithViews(); // ���������� ��������� MVC

var app = builder.Build();

// �������� ���������� �� ����� ������������
//var configuration = app.Configuration;
//var greetings = configuration["CustomGreetings"];

//�������� ��������� �������� ����������

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); //����������, ������� ��������� ������������� ��� ������
}

app.UseRouting(); //���������� ������� �������������

//app.MapGet("/", () => app.Configuration["CustomGreetings"]);
app.MapGet("/throw", () => { throw new ApplicationException("������ � ���������!"); });

app.MapDefaultControllerRoute(); //��������� ��������� �������� ���������� �������� MVC



app.Run();

