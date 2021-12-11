var builder = WebApplication.CreateBuilder(args); //������� ����������� ����������(������)

#region ��������� ����������� ���������� - ����������� �����������
//�������� �������
var services = builder.Services; //��������� �������� ������ ����������
services.AddControllersWithViews(); // ���������� ��������� MVC
#endregion

var app = builder.Build(); //������ ������ ���� ����������(������ ����������)

// �������� ���������� �� ����� ������������
//var configuration = app.Configuration;
//var greetings = configuration["CustomGreetings"];

//�������� ��������� �������� ����������
#region ���������������� ��������� ��������� �������� ����������
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); //����������, ������� ��������� ������������� ��� ������
}

app.UseRouting(); //���������� ������� �������������

//app.MapGet("/", () => app.Configuration["CustomGreetings"]);
app.MapGet("/throw", () => { throw new ApplicationException("������ � ���������!"); });

//app.MapDefaultControllerRoute(); //��������� ��������� �������� ���������� �������� MVC
//������� - ������, ������� �� ������ � �������� ������ ��������

app.MapControllerRoute(
    name: "default",
    pattern: "/{controller=Home}/{action=Index}/{id?}");

#endregion

app.Run(); //���������� �������� � �������� ��������� �������� �������

