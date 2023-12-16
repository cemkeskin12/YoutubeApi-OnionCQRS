using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Infrastructure.RedisCache
{
    public class RedisCacheSettings
    {
        public string ConnectionString { get; set; }
        public string InstanceName { get; set; }
    }
}
