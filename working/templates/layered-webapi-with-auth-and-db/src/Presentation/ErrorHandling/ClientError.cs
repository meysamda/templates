using System.Collections.Generic;

namespace $safeprojectname$.Presentation.ErrorHandling
{
    // 4xx series erros (except 400)
    public class ClientError
    {
        public string Key { get; set; }
        public IEnumerable<string> Values { get; set; }
    }
}