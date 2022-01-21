namespace Modul_8
{
    public class FilesSystemMy
    {
        public string DiskName { get; set; } = "C";
        public string DiskValue { get; set; } = null;
        public string DiskFreeSpace { get; set; }

        public FilesSystemMy()
        {
            DiskName = "\\C:";
            DiskValue = "512 G";
            DiskFreeSpace = "512 Gb";
        }
    }
}
