

namespace Podrujka
{
    internal class WriteStringInFile : WorkingWithFile
    {
        private readonly string _filePath;

        public WriteStringInFile() => _filePath = "res.txt";

        public string FilePath => _filePath;

        public void Write()
        {
            var list = new List<string>();
            for (int i = 0; i < StorageOwnerId[0].Count; i++)
            {
                
                    list.Add("{" +
                      @"""objectKey"":{" +
                      @$"""id"": {StorageOwnerId[0][i]}," +
                      @"""ownerId"": 928" +
                      @"}," +
                      $@"""objectId"":""{StorageOwnerId[0][i]}-928""," +
                      @$"""time"":""{StorageOwnerId[1][i]}.000Z""" +
                      @"},");
            }
            using var sr = new StreamWriter(FilePath, false);
            for (int i = 0; i < list.Count; i++)
            {
                sr.WriteAsync(list[i]);
            }
        }
    }
}
