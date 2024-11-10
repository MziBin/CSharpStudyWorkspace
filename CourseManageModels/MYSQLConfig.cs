using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManageModels
{
    public class MYSQLConfig
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool Pooling { get; set; }
        public int MinPoolSize { get; set; }
        public int MaxPoolSize { get; set; }
        public int ConnectionLifetime { get; set; }

        public string GetConnectionString()
        {
            return $"Server={Server};Database={Database};User={User};Password={Password};Pooling={Pooling};Min Pool Size={MinPoolSize};Max Pool Size={MaxPoolSize};Connection Lifetime={ConnectionLifetime}";
        }
    }
}
