var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// 添加静态文件支持
app.UseStaticFiles();

// 添加默认文件支持
app.UseDefaultFiles();

// 添加 API 端点
app.MapGet("/api/chartdata", () =>
{
    var chartData = new
    {
        Labels = new[] { "红色", "蓝色", "黄色", "绿色", "紫色", "橙色" },
        Data = new[] { 12, 19, 3, 5, 2, 3 },
        BackgroundColors = new[]
        {
            "rgba(255, 99, 132, 0.2)",
            "rgba(54, 162, 235, 0.2)",
            "rgba(255, 206, 86, 0.2)",
            "rgba(75, 192, 192, 0.2)",
            "rgba(153, 102, 255, 0.2)",
            "rgba(255, 159, 64, 0.2)"
        },
        BorderColors = new[]
        {
            "rgba(255, 99, 132, 1)",
            "rgba(54, 162, 235, 1)",
            "rgba(255, 206, 86, 1)",
            "rgba(75, 192, 192, 1)",
            "rgba(153, 102, 255, 1)",
            "rgba(255, 159, 64, 1)"
        }
    };
    return Results.Json(chartData);
});

app.Run();
