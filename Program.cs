var builder = WebApplication.CreateBuilder(args); // �������� ������������ ��� ����������
var app = builder.Build(); // �������� ����������

app.UseStaticFiles(); // ������������� ����������� ������ (html, php, css) ��� ������

app.MapGet("/", () => "������� :3"); // ���������� get-�������
app.MapGet("/omgismagis", () => "��� ��� ��� ������� ��������"); // ��� ���� ���������� get-�������

app.Run(); // ������
