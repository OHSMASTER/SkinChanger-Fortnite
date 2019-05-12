using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000030 RID: 48
[DesignerGenerated]
public partial class PhoneItForm : Form
{
	// Token: 0x0600050C RID: 1292 RVA: 0x00009DF9 File Offset: 0x00007FF9
	public PhoneItForm()
	{
		this.InitializeComponent();
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x0001C794 File Offset: 0x0001A994
	[DebuggerNonUserCode]
	protected virtual void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.icontainer_0 != null)
			{
				PhoneItForm.smethod_0(this.icontainer_0);
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x0600050F RID: 1295 RVA: 0x00009E07 File Offset: 0x00008007
	// (set) Token: 0x06000510 RID: 1296 RVA: 0x00009E0F File Offset: 0x0000800F
	internal virtual Control0 FormSkin1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000511 RID: 1297 RVA: 0x00009E18 File Offset: 0x00008018
	// (set) Token: 0x06000512 RID: 1298 RVA: 0x00009E20 File Offset: 0x00008020
	internal virtual RichTextBox FlatTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000513 RID: 1299 RVA: 0x00009E29 File Offset: 0x00008029
	// (set) Token: 0x06000514 RID: 1300 RVA: 0x0001CF64 File Offset: 0x0001B164
	internal virtual Control6 FlatButton3
	{
		[CompilerGenerated]
		get
		{
			return this._FlatButton3;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler_ = new EventHandler(this.method_2);
			Control6 flatButton = this._FlatButton3;
			if (flatButton != null)
			{
				PhoneItForm.smethod_15(flatButton, eventHandler_);
			}
			this._FlatButton3 = value;
			flatButton = this._FlatButton3;
			if (flatButton != null)
			{
				PhoneItForm.smethod_16(flatButton, eventHandler_);
			}
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000515 RID: 1301 RVA: 0x00009E31 File Offset: 0x00008031
	// (set) Token: 0x06000516 RID: 1302 RVA: 0x00009E39 File Offset: 0x00008039
	internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000517 RID: 1303 RVA: 0x00009E42 File Offset: 0x00008042
	// (set) Token: 0x06000518 RID: 1304 RVA: 0x00009E4A File Offset: 0x0000804A
	internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000519 RID: 1305 RVA: 0x00009E53 File Offset: 0x00008053
	// (set) Token: 0x0600051A RID: 1306 RVA: 0x00009E5B File Offset: 0x0000805B
	internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x0600051B RID: 1307 RVA: 0x00009E64 File Offset: 0x00008064
	// (set) Token: 0x0600051C RID: 1308 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
	internal virtual Control6 FlatButton2
	{
		[CompilerGenerated]
		get
		{
			return this._FlatButton2;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler_ = new EventHandler(this.method_1);
			Control6 flatButton = this._FlatButton2;
			if (flatButton != null)
			{
				PhoneItForm.smethod_15(flatButton, eventHandler_);
			}
			this._FlatButton2 = value;
			flatButton = this._FlatButton2;
			if (flatButton != null)
			{
				PhoneItForm.smethod_16(flatButton, eventHandler_);
			}
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x0600051D RID: 1309 RVA: 0x00009E6C File Offset: 0x0000806C
	// (set) Token: 0x0600051E RID: 1310 RVA: 0x0001CFEC File Offset: 0x0001B1EC
	internal virtual Control6 FlatButton1
	{
		[CompilerGenerated]
		get
		{
			return this._FlatButton1;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler_ = new EventHandler(this.method_0);
			Control6 flatButton = this._FlatButton1;
			if (flatButton != null)
			{
				PhoneItForm.smethod_15(flatButton, eventHandler_);
			}
			this._FlatButton1 = value;
			flatButton = this._FlatButton1;
			if (flatButton != null)
			{
				PhoneItForm.smethod_16(flatButton, eventHandler_);
			}
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x0600051F RID: 1311 RVA: 0x00009E74 File Offset: 0x00008074
	// (set) Token: 0x06000520 RID: 1312 RVA: 0x0001D030 File Offset: 0x0001B230
	internal virtual BackgroundWorker BackgroundWorker_0
	{
		[CompilerGenerated]
		get
		{
			return this.backgroundWorker_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler doWorkEventHandler_ = new DoWorkEventHandler(this.method_3);
			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				PhoneItForm.smethod_17(backgroundWorker, doWorkEventHandler_);
			}
			this.backgroundWorker_0 = value;
			backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				PhoneItForm.smethod_18(backgroundWorker, doWorkEventHandler_);
			}
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000521 RID: 1313 RVA: 0x00009E7C File Offset: 0x0000807C
	// (set) Token: 0x06000522 RID: 1314 RVA: 0x0001D074 File Offset: 0x0001B274
	internal virtual BackgroundWorker BackgroundWorker_1
	{
		[CompilerGenerated]
		get
		{
			return this.backgroundWorker_1;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler doWorkEventHandler_ = new DoWorkEventHandler(this.method_4);
			BackgroundWorker backgroundWorker = this.backgroundWorker_1;
			if (backgroundWorker != null)
			{
				PhoneItForm.smethod_17(backgroundWorker, doWorkEventHandler_);
			}
			this.backgroundWorker_1 = value;
			backgroundWorker = this.backgroundWorker_1;
			if (backgroundWorker != null)
			{
				PhoneItForm.smethod_18(backgroundWorker, doWorkEventHandler_);
			}
		}
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x00009E84 File Offset: 0x00008084
	private void method_0(object sender, EventArgs e)
	{
		PhoneItForm.smethod_19(this.BackgroundWorker_0);
		PhoneItForm.smethod_20(this.FlatButton1, false);
		PhoneItForm.smethod_20(this.FlatButton2, false);
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x00009EA9 File Offset: 0x000080A9
	private void method_1(object sender, EventArgs e)
	{
		PhoneItForm.smethod_19(this.BackgroundWorker_1);
		PhoneItForm.smethod_20(this.FlatButton1, false);
		PhoneItForm.smethod_20(this.FlatButton2, false);
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x00009ECE File Offset: 0x000080CE
	private void method_2(object sender, EventArgs e)
	{
		PhoneItForm.smethod_21(this, false);
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
	private void method_3(object sender, DoWorkEventArgs e)
	{
		if (PhoneItForm.smethod_22(Class11.MySettings_0.PakPath, "1", false) != 0)
		{
			try
			{
				PhoneItForm.smethod_24(Class11.MySettings_0.PakPath, "pakchunk0-WindowsClient.pak");
				string string_ = PhoneItForm.smethod_24(Class11.MySettings_0.PakPath, "pakchunk0_s1-WindowsClient.pak");
				Stream stream_ = PhoneItForm.smethod_25(string_);
				try
				{
					foreach (long long_ in GClass21.smethod_0(stream_, 0, 50000000L, GClass13.byte_0))
					{
						PhoneItForm.smethod_26(stream_);
						BinaryWriter binaryWriter_ = PhoneItForm.smethod_28(PhoneItForm.smethod_27(string_, FileMode.Open, FileAccess.ReadWrite));
						PhoneItForm.smethod_30(PhoneItForm.smethod_29(binaryWriter_), long_, SeekOrigin.Begin);
						PhoneItForm.smethod_31(binaryWriter_, GClass13.byte_1);
						PhoneItForm.smethod_32(binaryWriter_);
						PhoneItForm.smethod_34(this.FlatTextBox1, PhoneItForm.smethod_24(PhoneItForm.smethod_33(this.FlatTextBox1), "\r\nEMOTE ADDED! (01/02)"));
					}
				}
				finally
				{
					List<long>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				Stream stream_2 = PhoneItForm.smethod_25(string_);
				try
				{
					foreach (long long_2 in GClass21.smethod_0(stream_2, 0, 50000000L, GClass13.byte_2))
					{
						PhoneItForm.smethod_26(stream_2);
						BinaryWriter binaryWriter_2 = PhoneItForm.smethod_28(PhoneItForm.smethod_27(string_, FileMode.Open, FileAccess.ReadWrite));
						PhoneItForm.smethod_30(PhoneItForm.smethod_29(binaryWriter_2), long_2, SeekOrigin.Begin);
						PhoneItForm.smethod_31(binaryWriter_2, GClass13.byte_3);
						PhoneItForm.smethod_32(binaryWriter_2);
						PhoneItForm.smethod_34(this.FlatTextBox1, PhoneItForm.smethod_24(PhoneItForm.smethod_33(this.FlatTextBox1), "\r\nEMOTE ADDED! (02/02)"));
					}
				}
				finally
				{
					List<long>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				Class11.MySettings_0.PhoneItEnabled = "True";
				PhoneItForm.smethod_35(Class11.MySettings_0);
				PhoneItForm.smethod_20(this.FlatButton1, false);
				PhoneItForm.smethod_20(this.FlatButton2, true);
				PhoneItForm.smethod_23("Done!", MsgBoxStyle.OkOnly, null);
				return;
			}
			catch (Exception exception_)
			{
				PhoneItForm.smethod_36(exception_);
				PhoneItForm.smethod_34(this.FlatTextBox1, PhoneItForm.smethod_24(PhoneItForm.smethod_33(this.FlatTextBox1), "ERROR!"));
				PhoneItForm.smethod_37();
				return;
			}
		}
		PhoneItForm.smethod_23("Please Choose your Pak Folder in the Settings Tab!", MsgBoxStyle.Critical, "System");
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x0001D318 File Offset: 0x0001B518
	private void method_4(object sender, DoWorkEventArgs e)
	{
		if (PhoneItForm.smethod_22(Class11.MySettings_0.PakPath, "1", false) == 0)
		{
			PhoneItForm.smethod_23("Please Choose your Pak Folder in the Settings Tab!", MsgBoxStyle.Critical, "System");
		}
		else
		{
			try
			{
				PhoneItForm.smethod_24(Class11.MySettings_0.PakPath, "pakchunk0-WindowsClient.pak");
				string string_ = PhoneItForm.smethod_24(Class11.MySettings_0.PakPath, "pakchunk0_s1-WindowsClient.pak");
				Stream stream_ = PhoneItForm.smethod_25(string_);
				try
				{
					foreach (long long_ in GClass21.smethod_0(stream_, 0, 50000000L, GClass13.byte_1))
					{
						PhoneItForm.smethod_26(stream_);
						BinaryWriter binaryWriter_ = PhoneItForm.smethod_28(PhoneItForm.smethod_27(string_, FileMode.Open, FileAccess.ReadWrite));
						PhoneItForm.smethod_30(PhoneItForm.smethod_29(binaryWriter_), long_, SeekOrigin.Begin);
						PhoneItForm.smethod_31(binaryWriter_, GClass13.byte_0);
						PhoneItForm.smethod_32(binaryWriter_);
						PhoneItForm.smethod_34(this.FlatTextBox1, PhoneItForm.smethod_24(PhoneItForm.smethod_33(this.FlatTextBox1), "\r\nEMOTE REMOVED! (01/02)"));
					}
				}
				finally
				{
					List<long>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				Stream stream_2 = PhoneItForm.smethod_25(string_);
				try
				{
					foreach (long long_2 in GClass21.smethod_0(stream_2, 0, 50000000L, GClass13.byte_3))
					{
						PhoneItForm.smethod_26(stream_2);
						BinaryWriter binaryWriter_2 = PhoneItForm.smethod_28(PhoneItForm.smethod_27(string_, FileMode.Open, FileAccess.ReadWrite));
						PhoneItForm.smethod_30(PhoneItForm.smethod_29(binaryWriter_2), long_2, SeekOrigin.Begin);
						PhoneItForm.smethod_31(binaryWriter_2, GClass13.byte_2);
						PhoneItForm.smethod_32(binaryWriter_2);
						PhoneItForm.smethod_34(this.FlatTextBox1, PhoneItForm.smethod_24(PhoneItForm.smethod_33(this.FlatTextBox1), "\r\nEMOTE REMOVED! (02/02)"));
					}
				}
				finally
				{
					List<long>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				Class11.MySettings_0.PhoneItEnabled = "False";
				PhoneItForm.smethod_35(Class11.MySettings_0);
				PhoneItForm.smethod_20(this.FlatButton1, true);
				PhoneItForm.smethod_20(this.FlatButton2, false);
				PhoneItForm.smethod_23("Done!", MsgBoxStyle.OkOnly, null);
			}
			catch (Exception exception_)
			{
				PhoneItForm.smethod_36(exception_);
				PhoneItForm.smethod_34(this.FlatTextBox1, PhoneItForm.smethod_24(PhoneItForm.smethod_33(this.FlatTextBox1), "ERROR!"));
				PhoneItForm.smethod_37();
			}
		}
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00009260 File Offset: 0x00007460
	static void smethod_0(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x00007FCE File Offset: 0x000061CE
	static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00009268 File Offset: 0x00007468
	static ComponentResourceManager smethod_2(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00009270 File Offset: 0x00007470
	static RichTextBox smethod_3()
	{
		return new RichTextBox();
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0000927E File Offset: 0x0000747E
	static BackgroundWorker smethod_4()
	{
		return new BackgroundWorker();
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x00009277 File Offset: 0x00007477
	static PictureBox smethod_5()
	{
		return new PictureBox();
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x00009285 File Offset: 0x00007485
	static void smethod_6(Control control_0)
	{
		control_0.SuspendLayout();
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0000928D File Offset: 0x0000748D
	static void smethod_7(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00009295 File Offset: 0x00007495
	static void smethod_8(Control control_0)
	{
		control_0.SuspendLayout();
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x0000929D File Offset: 0x0000749D
	static void smethod_9(Control control_0, Color color_0)
	{
		control_0.BackColor = color_0;
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x000092A6 File Offset: 0x000074A6
	static Control.ControlCollection smethod_10(Control control_0)
	{
		return control_0.Controls;
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x000092AE File Offset: 0x000074AE
	static void smethod_11(Control.ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x000092B7 File Offset: 0x000074B7
	static void smethod_12(Control control_0, DockStyle dockStyle_0)
	{
		control_0.Dock = dockStyle_0;
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x000092C0 File Offset: 0x000074C0
	static Font smethod_13(string string_0, float float_0)
	{
		return new Font(string_0, float_0);
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x000092C9 File Offset: 0x000074C9
	static void smethod_14(Control control_0, Font font_0)
	{
		control_0.Font = font_0;
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x000092D2 File Offset: 0x000074D2
	static void smethod_15(Control control_0, EventHandler eventHandler_0)
	{
		control_0.Click -= eventHandler_0;
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x000092DB File Offset: 0x000074DB
	static void smethod_16(Control control_0, EventHandler eventHandler_0)
	{
		control_0.Click += eventHandler_0;
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x000092E4 File Offset: 0x000074E4
	static void smethod_17(BackgroundWorker backgroundWorker_2, DoWorkEventHandler doWorkEventHandler_0)
	{
		backgroundWorker_2.DoWork -= doWorkEventHandler_0;
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x000092ED File Offset: 0x000074ED
	static void smethod_18(BackgroundWorker backgroundWorker_2, DoWorkEventHandler doWorkEventHandler_0)
	{
		backgroundWorker_2.DoWork += doWorkEventHandler_0;
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x000092F6 File Offset: 0x000074F6
	static void smethod_19(BackgroundWorker backgroundWorker_2)
	{
		backgroundWorker_2.RunWorkerAsync();
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x000092FE File Offset: 0x000074FE
	static void smethod_20(Control control_0, bool bool_0)
	{
		control_0.Enabled = bool_0;
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00009307 File Offset: 0x00007507
	static void smethod_21(Control control_0, bool bool_0)
	{
		control_0.Visible = bool_0;
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00009310 File Offset: 0x00007510
	static int smethod_22(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0000931A File Offset: 0x0000751A
	static MsgBoxResult smethod_23(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00007FE0 File Offset: 0x000061E0
	static string smethod_24(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00009324 File Offset: 0x00007524
	static FileStream smethod_25(string string_0)
	{
		return File.OpenRead(string_0);
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x0000932C File Offset: 0x0000752C
	static void smethod_26(Stream stream_0)
	{
		stream_0.Close();
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00009334 File Offset: 0x00007534
	static FileStream smethod_27(string string_0, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		return File.Open(string_0, fileMode_0, fileAccess_0);
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0000933E File Offset: 0x0000753E
	static BinaryWriter smethod_28(Stream stream_0)
	{
		return new BinaryWriter(stream_0);
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00009346 File Offset: 0x00007546
	static Stream smethod_29(BinaryWriter binaryWriter_0)
	{
		return binaryWriter_0.BaseStream;
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x0000934E File Offset: 0x0000754E
	static long smethod_30(Stream stream_0, long long_0, SeekOrigin seekOrigin_0)
	{
		return stream_0.Seek(long_0, seekOrigin_0);
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00009358 File Offset: 0x00007558
	static void smethod_31(BinaryWriter binaryWriter_0, byte[] byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00009361 File Offset: 0x00007561
	static void smethod_32(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Close();
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00009369 File Offset: 0x00007569
	static string smethod_33(RichTextBox richTextBox_0)
	{
		return richTextBox_0.Text;
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00009371 File Offset: 0x00007571
	static void smethod_34(RichTextBox richTextBox_0, string string_0)
	{
		richTextBox_0.Text = string_0;
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x0000912C File Offset: 0x0000732C
	static void smethod_35(ApplicationSettingsBase applicationSettingsBase_0)
	{
		applicationSettingsBase_0.Save();
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00008E01 File Offset: 0x00007001
	static void smethod_36(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x0000937A File Offset: 0x0000757A
	static void smethod_37()
	{
		ProjectData.ClearProjectError();
	}

	// Token: 0x04000135 RID: 309
	private IContainer icontainer_0;

	// Token: 0x0400013E RID: 318
	[CompilerGenerated]
	[AccessedThroughProperty("BackgroundWorker1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private BackgroundWorker backgroundWorker_0;

	// Token: 0x0400013F RID: 319
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorker2")]
	private BackgroundWorker backgroundWorker_1;
}
