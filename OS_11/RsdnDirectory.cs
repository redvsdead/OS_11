using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using FILETIME = System.Runtime.InteropServices.ComTypes.FILETIME;
using System.ComponentModel;

namespace OS_11
{
    class RsdnDirectory
    {
        //формирует путь, требуемый методом FindFirstFile
        private static string MakePath(string path)
        {
            return Path.Combine(path, "*");
        }

        static long size = 0;

        //возвращает список файлов или каталогов, находящихся по заданному пути 
        private static IEnumerable<WIN32_FIND_DATA> GetInternal(string path, bool isGetDirs)
        {
            WIN32_FIND_DATA findData;
            IntPtr findHandle = FindFirstFile(MakePath(path), out findData);
            if (findHandle == INVALID_HANDLE_VALUE)
                throw new Win32Exception(Marshal.GetLastWin32Error());
            try
            {
                do
                    if (isGetDirs ? (findData.dwFileAttributes & FileAttributes.Directory) != 0
                    : (findData.dwFileAttributes & FileAttributes.Directory) == 0)
                    {
                        if (!isGetDirs)
                        {
                            size += (findData.nFileSizeHigh * (1 + (long)MAXWORD)) + findData.nFileSizeLow;
                        }
                        yield return findData;
                    }
                while (FindNextFile(findHandle, out findData));
            }
            finally
            {
                FindClose(findHandle);
            }
        }

        //возвращает список файлов для некоторого пути
        public static IEnumerable<string> GetFiles(string path)
        {
            IEnumerable<string> res = from file in GetInternal(path, false) select file.cFileName;
            return res;
        }

        //возвращает список каталогов для некоторого пути. Функция не перебирает вложенные подкаталоги!
        public static IEnumerable<string> GetDirectories(string path)
        {
            IEnumerable<string> res = from file in GetInternal(path, true) select file.cFileName;
            return res;
        }

        //возвращает список относительных путей ко всем подкаталогам
        public static IEnumerable<string> GetAllDirectories(string path)
        {
            foreach (string subDir in GetDirectories(path))
            {
                if (subDir == ".." || subDir == ".")
                    continue;
                string relativePath = Path.Combine(path, subDir);
                yield return relativePath;
                foreach (string subDir2 in GetAllDirectories(relativePath))
                    yield return subDir2;
            }
        }

        //считаем общий объем файлов
        public static long countSize(string path)
        {
            //long 
            size = 0;
            //для файлов, лежащих в исходной директории
            //size += 
            countDirSize(path);
            IEnumerable<string> dirs = GetAllDirectories(path);
            //для всех файлов во внутренних директориях
            foreach (var dir in dirs)
            {
                //size += 
                countDirSize(dir);                                                                                                                                                                         
            }
            return size;
        }

        //считаем суммарный размер файлов в текущей директории без учета внутренних директорий
        static long countDirSize(string path)
        {
            //long size = 0;
            IEnumerable<WIN32_FIND_DATA> files = GetInternal(path, false);
            foreach (var file in files)
            {
                //size += (file.nFileSizeHigh * (1 + (long)MAXWORD)) + file.nFileSizeLow;
            }
            return size;
        }

        #region Импорт из kernel32

        private const int MAX_PATH = 260;
        private const int MAXWORD = Int32.MaxValue;
        [Serializable]
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        [BestFitMapping(false)]

        private struct WIN32_FIND_DATA
        {
            public FileAttributes dwFileAttributes;
            public FILETIME ftCreationTime;
            public FILETIME ftLastAccessTime;
            public FILETIME ftLastWriteTime;
            public int nFileSizeHigh;
            public int nFileSizeLow;
            public int dwReserved0;
            public int dwReserved1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string cFileName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            public string cAlternate;
        }

        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr FindFirstFile(string lpFileName,
        out WIN32_FIND_DATA lpFindFileData);
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool FindNextFile(IntPtr hFindFile,
        out WIN32_FIND_DATA lpFindFileData);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FindClose(IntPtr hFindFile);
        private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        #endregion
    }
}
