using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class AppConfig
    {
        public static IConfiguration Configuration { get; private set; }
        static AppConfig()
        {
            Configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Đường dẫn thư mục chứa .exe
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        }

        public static string AppVersion => Configuration["AppVersion"];
        public static string UpdateUrl => Configuration["UpdateUrl"];
        public static string BackupFolder => Environment.ExpandEnvironmentVariables(Configuration["BackupFolder"]);
    }
    
}
