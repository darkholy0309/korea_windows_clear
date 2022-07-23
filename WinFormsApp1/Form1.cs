namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Size = new Size(640, 300);
            //http://blog.naver.com/akkril/30115018429
            button1.Text = "all";
            button2.Text = "bank";
            button3.Text = "vaccine";
            button4.Text = "p2p";
            button5.Text = "delete";
            button6.Text = "open";
            button1.Location = new Point(20, 20);
            button2.Location = new Point(110, 20);
            button3.Location = new Point(200, 20);
            button4.Location = new Point(290, 20);
            button5.Location = new Point(380, 20);
            button6.Location = new Point(470, 20);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Location = new Point(20, 60);
            listView1.Size = new Size(580, 180);
            listView1.Columns.Add(null, 250);
            listView1.Columns.Add(null, 310);
            label1.Location = new Point(560, 20);
            label1.Font = new Font("dotum", 14);
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            main();
        }

        void main()
        {
            if (Convert.ToInt32(Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\microsoft\\windows nt\\currentversion").GetValue("currentbuild")) < 22000)
            {
                MessageBox.Show("windows 11 update 21H2" + Environment.NewLine + "윈도우 업데이트 필요");
            }
            bank();
            bank_all_setup();
            bank_copy();
            hometax();
            ipin();
            vaccine();
            util();
            p2p();
            label1.Text = listView1.Items.Count + "개";
        }

        void bank()//9
        {
            if (Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\ahnlab\\safe transaction") == null)
            { }
            else if (Directory.Exists(Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\ahnlab\\safe transaction").GetValue("installpath").ToString()))
            {
                string[] a = new string[2];
                a[0] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\ahnlab\\safe transaction").GetValue("productname").ToString();
                a[1] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\ahnlab\\safe transaction").GetValue("installpath").ToString();
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\initech\\inisafe web ex client"))
            {
                string[] a = new string[2];
                a[0] = "INISAFE CrossWeb EX";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\initech\\inisafe web ex client";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\raonsecure\\touchen nxkey"))
            {
                string[] a = new string[2];
                a[0] = "TouchEn nxKey with E2E for 32bit";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\raonsecure\\touchen nxkey";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\raonsecure\\touchen nxkey"))
            {
                string[] a = new string[2];
                a[0] = "TouchEn nxKey with E2E for 64bit";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\raonsecure\\touchen nxkey";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\softforum\\xecureweb\\anysign\\dll\\anysign4pc.exe"))
            {
                string[] a = new string[2];
                a[0] = "AnySign4PC";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\softforum\\xecureweb\\anysign";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\incainternet\\nprotect online security"))
            {
                string[] a = new string[2];
                a[0] = "nProtect Online Security";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\incainternet\\nprotect online security";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\wizvera\\delfino-g3"))
            {
                string[] a = new string[2];
                a[0] = "Delfino G3 (x86)";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\wizvera\\delfino-g3";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\ipinside_lws\\i3gproc.exe"))
            {
                string[] a = new string[2];
                a[0] = "IPinside LWS Agent";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\ipinside_lws";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\iniline\\crossex\\crossex\\crossexservice.exe"))
            {
                string[] a = new string[2];
                a[0] = "iniLINE CrossEX Service";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\iniline\\crossex\\crossex";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
        }

        void bank_all_setup()
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\wizvera\\veraport20"))
            {
                string[] a = new string[2];
                a[0] = "Veraport(보안모듈 관리 프로그램) G3";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\wizvera\\veraport20";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\wizvera\\veraport20"))
            {
                string[] a = new string[2];
                a[0] = "Veraport(보안모듈 관리 프로그램) G3 x64";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\wizvera\\veraport20";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\wizvera\\common\\wpmsvc"))
            {
                string[] a = new string[2];
                a[0] = "WIZVERA Process Manager";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\wizvera\\common\\wpmsvc";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
        }

        void bank_copy()
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\crosscert\\unisigncrsv3"))
            {
                string[] a = new string[2];
                a[0] = "CROSSCERT UniCRSV3";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\crosscert\\unisigncrsv3";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\keysharp\\kscertrelay\\kscertrelay.exe"))
            {
                string[] a = new string[2];
                a[0] = "KeySharp CertRelay";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\keysharp\\kscertrelay";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
        }

        void hometax()
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\dreamsecurity\\magicline4nx"))
            {
                string[] a = new string[2];
                a[0] = "MagicLine4NX";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\dreamsecurity\\magicline4nx";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\raonsecure\\touchen nxfirewall"))
            {
                string[] a = new string[2];
                a[0] = "TouchEn nxFirewall32";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\raonsecure\\touchen nxfirewall";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
        }

        void ipin()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\vestcert\\vestcert.exe"))
            {
                string[] a = new string[2];
                a[0] = "VestCert";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\vestcert";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
        }

        void vaccine()
        {
            if (Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\estsoft\\alyac") == null)
            { }
            else if (Directory.Exists(Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\estsoft\\alyac").GetValue("rootdir").ToString()))
            {
                string[] a = new string[2];
                a[0] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\estsoft\\alyac").GetValue("product").ToString();
                a[1] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\estsoft\\alyac").GetValue("rootdir").ToString();
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\ahnlab\\v3lite4") == null)
            { }
            else if (Directory.Exists(Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\ahnlab\\v3lite4").GetValue("installpath").ToString()))
            {
                string[] a = new string[2];
                a[0] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\ahnlab\\v3lite4").GetValue("productname").ToString();
                a[1] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\ahnlab\\v3lite4").GetValue("installpath").ToString();
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\nhn corporation\\navervaccine") == null)
            { }
            else if (Directory.Exists(Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\nhn corporation\\navervaccine").GetValue("installdir").ToString()))
            {
                string[] a = new string[2];
                a[0] = "네이버 백신";
                a[1] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Default).OpenSubKey("software\\nhn corporation\\navervaccine").GetValue("installdir").ToString();
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
        }

        void util()
        {
            if (Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\estsoft\\alzip") == null)
            { }
            else if (Directory.Exists(Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\estsoft\\alzip").GetValue("rootdir").ToString()))
            {
                string[] a = new string[2];
                a[0] = "알집";
                a[1] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\estsoft\\alzip").GetValue("rootdir").ToString();
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\estsoft\\alupdate") == null)
            { }
            else if (Directory.Exists(Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\estsoft\\alupdate").GetValue("rootdir").ToString()))
            {
                string[] a = new string[2];
                a[0] = "알툴즈 업데이트";
                a[1] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\estsoft\\alupdate").GetValue("rootdir").ToString();
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\gom\\gomhelper") == null)
            { }
            else if (Directory.Exists(Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\gom\\gomhelper").GetValue("programfolder").ToString()))
            {
                string[] a = new string[2];
                a[0] = "곰헬퍼";
                a[1] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\gom\\gomhelper").GetValue("programfolder").ToString();
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\gretech\\gomplayer") == null)
            { }
            else if (Directory.Exists(Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\gretech\\gomplayer").GetValue("programfolder").ToString()))
            {
                string[] a = new string[2];
                a[0] = "곰플레이어";
                a[1] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\gretech\\gomplayer").GetValue("programfolder").ToString();
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\utorrent web"))
            {
                string[] a = new string[2];
                a[0] = "uTorrent Web";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\utorrent web";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\estsoft\\alcapture") == null)
            { }
            else if (Directory.Exists(Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\estsoft\\alcapture").GetValue("rootdir").ToString()))
            {
                string[] a = new string[2];
                a[0] = "알캡처";
                a[1] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\estsoft\\alcapture").GetValue("rootdir").ToString();
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\estsoft\\alsong") == null)
            { }
            else if (Directory.Exists(Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\estsoft\\alsong").GetValue("rootdir").ToString()))
            {
                string[] a = new string[2];
                a[0] = "알송";
                a[1] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\estsoft\\alsong").GetValue("rootdir").ToString();
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\gretech\\gomaudio") == null)
            { }
            else if (Directory.Exists(Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\gretech\\gomaudio").GetValue("programfolder").ToString()))
            {
                string[] a = new string[2];
                a[0] = "곰오디오";
                a[1] = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32).OpenSubKey("software\\gretech\\gomaudio").GetValue("programfolder").ToString();
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\1gram"))
            {
                string[] a = new string[2];
                a[0] = "1gram player";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\1gram";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\systrans"))
            {
                string[] a = new string[2];
                a[0] = "sysTrans";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\systrans";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\hantools\\hancaptureplus"))
            {
                string[] a = new string[2];
                a[0] = "한캡쳐플러스";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\hantools\\hancaptureplus";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\hantools\\hancapture"))
            {
                string[] a = new string[2];
                a[0] = "한캡쳐";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\hantools\\hancapture";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\clipdown"))
            {
                string[] a = new string[2];
                a[0] = "CLIPDOWN";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\clipdown";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Path.GetPathRoot(Environment.SystemDirectory) + "\\tubedown"))
            {
                string[] a = new string[2];
                a[0] = "TubeDown";
                a[1] = "c:\\tubedown";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\afreeca"))
            {
                string[] a = new string[2];
                a[0] = "아프리카TV";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\afreeca";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\kakaoliveagent"))
            {
                string[] a = new string[2];
                a[0] = "라이브 에이전트";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\kakaoliveagent";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\cacaoencoder\\cacaoencoder.exe"))
            {
                string[] a = new string[2];
                a[0] = "CacaoEncoder";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\cacaoencoder";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Path.GetPathRoot(Environment.SystemDirectory) + "\\nia"))
            {
                string[] a = new string[2];
                a[0] = "NIASpeedMeter";
                a[1] = "c:\\nia";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\ktspeedclient"))
            {
                string[] a = new string[2];
                a[0] = "KTSpeedClient";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\ktspeedclient";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\skbinternetspeed"))
            {
                string[] a = new string[2];
                a[0] = "SKBSpeedMeter";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\skbinternetspeed";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
        }

        void p2p()//34
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\nat service\\natsvc.exe"))
            {
                string[] a = new string[2];
                a[0] = "NAT Service";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\nat service";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\etms ondisk\\ondisk_winsvc.exe"))
            {
                string[] a = new string[2];
                a[0] = "ONDISK UP-DOWN";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\etms ondisk";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\etms kdisk\\kdisk_winsvc.exe"))
            {
                string[] a = new string[2];
                a[0] = "KDISK UP-DOWN";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\etms kdisk";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\smanager\\smmgr.exe"))
            {
                string[] a = new string[2];
                a[0] = "SManager";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\smanager";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filemaru.com\\filemaruprocessormanager.exe"))
            {
                string[] a = new string[2];
                a[0] = "파일마루";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filemaru.com";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\ssadafile\\ssadafilelauncher.exe"))
            {
                string[] a = new string[2];
                a[0] = "SsadaFile";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\ssadafile";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filebogo.com\\filebogodown.exe"))
            {
                string[] a = new string[2];
                a[0] = "파일보고";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filebogo.com";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\v_service\\v_service.exe"))
            {
                string[] a = new string[2];
                a[0] = "v_service";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\v_service";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filemong\\filemonglauncher.exe"))
            {
                string[] a = new string[2];
                a[0] = "FileMong";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filemong";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\jjinpl.com\\jjinpllauncher.exe"))
            {
                string[] a = new string[2];
                a[0] = "jjinpl";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\jjinpl.com";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\yesfile\\yesfileservice.exe"))
            {
                string[] a = new string[2];
                a[0] = "예스파일";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\yesfile";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\xtorengine\\xtorengine.exe"))
            {
                string[] a = new string[2];
                a[0] = "XTorEngine";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\xtorengine";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\todisk.com\\todiskdown.exe"))
            {
                string[] a = new string[2];
                a[0] = "투디스크";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\todisk.com";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\smartfile\\smartfilesrv.exe"))
            {
                string[] a = new string[2];
                a[0] = "스마트파일";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\smartfile";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\applefiles\\applefileservice.exe"))
            {
                string[] a = new string[2];
                a[0] = "애플파일";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\applefiles";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filesun.com\\filesunlauncher.exe"))
            {
                string[] a = new string[2];
                a[0] = "FileSun";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filesun.com";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\dodofile\\dodofile.exe"))
            {
                string[] a = new string[2];
                a[0] = "도도파일 프로그램";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\dodofile";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filecast\\filecast_clientdown.exe"))
            {
                string[] a = new string[2];
                a[0] = "파일캐스트";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filecast";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\wedisk\\wediskservice.exe"))
            {
                string[] a = new string[2];
                a[0] = "Wedisk Plug-in";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\wedisk";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filenori\\filenoriservice.exe"))
            {
                string[] a = new string[2];
                a[0] = "FileNori Plug-in";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filenori";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\bigfile\\bigfileservice.exe"))
            {
                string[] a = new string[2];
                a[0] = "빅파일 클라이언트";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\bigfile";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\sharebox\\shareboxservice.exe"))
            {
                string[] a = new string[2];
                a[0] = "쉐어박스";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\sharebox";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\pdpopx\\pdpop_nanoomidown.exe"))
            {
                string[] a = new string[2];
                a[0] = "PDPOP";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\pdpopx";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\ccdnservice\\ccdnservice.exe"))
            {
                string[] a = new string[2];
                a[0] = "CCDNService";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\ccdnservice";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\exbc\\exbcsvc.exe"))
            {
                string[] a = new string[2];
                a[0] = "확장된 브라우저 컨트롤러";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\exbc";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\filecity\\cb_service\\filecity_cb_service.exe"))
            {
                string[] a = new string[2];
                a[0] = "파일시티";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\filecity";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\megafile\\megafilelauncher.exe"))
            {
                string[] a = new string[2];
                a[0] = "Megafile";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\megafile";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\tple\\tple_downagent.exe"))
            {
                string[] a = new string[2];
                a[0] = "Tple Download";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\tple";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\clubnex.co.kr\\clubnexlauncher.exe"))
            {
                string[] a = new string[2];
                a[0] = "Clubnex";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\clubnex.co.kr";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\iztel\\iztel_down.exe"))
            {
                string[] a = new string[2];
                a[0] = "IZTEL";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\iztel";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\tomatopang\\pang.exe"))
            {
                string[] a = new string[2];
                a[0] = "토마토팡";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\tomatopang";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\lottofile\\lottofile.exe"))
            {
                string[] a = new string[2];
                a[0] = "로또파일";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\lottofile";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\fileis\\fileisservice.exe"))
            {
                string[] a = new string[2];
                a[0] = "파일이즈";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\fileis";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filekuki\\filekukiservice.exe"))
            {
                string[] a = new string[2];
                a[0] = "파일쿠키 업/다운로더";
                a[1] = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\filekuki";
                ListViewItem listviewitem = new ListViewItem(a);
                listView1.Items.Add(listviewitem);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "explorer";
                process.StartInfo.Arguments = listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text;
                process.Start();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "cmd";
            process.StartInfo.Arguments = "/c" + string.Empty.PadLeft(1) + "appwiz.cpl";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            p2p();
            label1.Text = listView1.Items.Count + "개";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            vaccine();
            label1.Text = listView1.Items.Count + "개";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bank();
            bank_all_setup();
            bank_copy();
            hometax();
            ipin();
            label1.Text = listView1.Items.Count + "개";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bank();
            bank_all_setup();
            bank_copy();
            hometax();
            ipin();
            vaccine();
            util();
            p2p();
            label1.Text = listView1.Items.Count + "개";
        }
    }
}