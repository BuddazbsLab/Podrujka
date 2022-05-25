

namespace Podrujka
{
    internal class WorkingWithFile : IWorkingWithFile
    {
        private readonly string? _pathOwnerId;
        private readonly string? _pathDate;
        private List<List<string>> _storageOwnerId;


        public WorkingWithFile()
        {
            _pathOwnerId = "ID.txt";
            _pathDate = "Date.txt";
            _storageOwnerId = new List<List<string>>();
        }

        public string? PathOwnerId => _pathOwnerId;
        public string? PathDate => _pathDate;

        public List<List<string>> StorageOwnerId
        {
            get => _storageOwnerId;
            set => _storageOwnerId = value;
        }


        public void AddInStorage()
        {
            var list = new List<string>() { PathOwnerId, PathDate };

            for (int i = 0; i < list.Count; i++)
            {
                List<string> item = File.ReadAllLines(list[i]).ToList();
                StorageOwnerId.Add(item);

            }
        }
    }
}
