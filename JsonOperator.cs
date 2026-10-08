using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace LaboratoryChecker
{
    internal class JsonOperator
    {
        public async Task JsonSerialization(string path, Laboratory laboratory)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Laboratory>(fs, laboratory);
            }
        }
    }
}
