using System;
using System.IO;

public class ReadFile
{
    public static void Run()
    {
        string path = "/etc/hostname";  // <-- swap this for /root/root.txt in the CTF
        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            Console.WriteLine("=== FILE CONTENTS ===");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("File not found: " + path);
        }
    }
}
