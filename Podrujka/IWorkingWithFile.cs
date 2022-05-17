
namespace Podrujka
{
    internal interface IWorkingWithFile
    {
        string? PathDate { get; }
        string? PathOwnerId { get; }
        List<List<string>> StorageOwnerId { get; set; }

        void AddInStorage();
    }
}