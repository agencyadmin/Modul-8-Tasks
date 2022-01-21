namespace Modul_8
{
    public class FilesSystemMy
    {
        public string DiskName { get; set; } = "C";
        public long DiskValue { get; set; } = 512;
        public long DiskFreeSpace { get; set; }

        public FilesSystemMy()
        {
            DiskName = "\\C:";
            DiskValue = 512;

            DiskFreeSpace = 512;
        }
        public FilesSystemMy(string name, long totalSpace, long freeSpace)
        {
            DiskName = name;
            DiskValue = totalSpace;
            DiskFreeSpace = freeSpace;
        }

    }

    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();
        public string MakeNewFolder(string newFolderName)
        {
            Files.Add(newFolderName);
            return "Новая папка создана";
        }
        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();  

        public void CreateFolder(string name)
        {
            Folders.Add(name, new Folder());
        }
    }
}


