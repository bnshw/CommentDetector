using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CommentDetector.Json
{
    public class JsonController
    {
        public static Settings Settings { get; private set; } = JsonSerializer.Deserialize<Settings>(File.ReadAllText("./settings.json"));
    }
}
