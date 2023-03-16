namespace PTMB_Systatus_API
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.register_NewSysStatus_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.register_CKey_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.register_SubSysNo_Textox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.register_Operator_textbox = new System.Windows.Forms.TextBox();
            this.getAllInfo_Button = new System.Windows.Forms.Button();
            this.getSpecificInfo_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurrentStatus_groupbox = new System.Windows.Forms.GroupBox();
            this.Cuttent_Status = new System.Windows.Forms.GroupBox();
            this.getData_UpdateTime = new System.Windows.Forms.Label();
            this.getData_Status = new System.Windows.Forms.Label();
            this.getData_Flow = new System.Windows.Forms.Label();
            this.getData_SysNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.getCurrentData_Ckey_Textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.getCurrentData_Company_Textbox = new System.Windows.Forms.TextBox();
            this.getCurrentData_SysNo_Textbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConsoleLog = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.getOverExcuteCurrentData_Operator_Label = new System.Windows.Forms.Label();
            this.getOverExcuteCurrentData_UpdateTime_Label = new System.Windows.Forms.Label();
            this.getOverExcuteCurrentData_Status_Label = new System.Windows.Forms.Label();
            this.getOverExcuteCurrentData_Flow_Label = new System.Windows.Forms.Label();
            this.getOverExcuteCurrentData_Ckeys_Label = new System.Windows.Forms.Label();
            this.getOverExcuteCurrentData_Company_Label = new System.Windows.Forms.Label();
            this.getOverExcuteCurrentData_SysNo_Label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.getOverExcuteCurrentData_button = new System.Windows.Forms.Button();
            this.getOverExcuteCurrentData_Ckey_textbox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.getOverExcuteCurrentData_Company_textbox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.GetExcuteTime_SysNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GetExcuteTime_Ckey = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.GetExcuteTime_Company = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.CurrentStatus_groupbox.SuspendLayout();
            this.Cuttent_Status.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // register_NewSysStatus_Button
            // 
            this.register_NewSysStatus_Button.Location = new System.Drawing.Point(59, 136);
            this.register_NewSysStatus_Button.Name = "register_NewSysStatus_Button";
            this.register_NewSysStatus_Button.Size = new System.Drawing.Size(75, 23);
            this.register_NewSysStatus_Button.TabIndex = 0;
            this.register_NewSysStatus_Button.Text = "新增狀態";
            this.register_NewSysStatus_Button.UseVisualStyleBackColor = true;
            this.register_NewSysStatus_Button.Click += new System.EventHandler(this.NewSysStatus_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "C_Keys";
            // 
            // register_CKey_Textbox
            // 
            this.register_CKey_Textbox.Location = new System.Drawing.Point(74, 25);
            this.register_CKey_Textbox.Name = "register_CKey_Textbox";
            this.register_CKey_Textbox.Size = new System.Drawing.Size(100, 22);
            this.register_CKey_Textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "SubSysNo";
            // 
            // register_SubSysNo_Textox
            // 
            this.register_SubSysNo_Textox.Location = new System.Drawing.Point(73, 62);
            this.register_SubSysNo_Textox.Name = "register_SubSysNo_Textox";
            this.register_SubSysNo_Textox.Size = new System.Drawing.Size(100, 22);
            this.register_SubSysNo_Textox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operator";
            // 
            // register_Operator_textbox
            // 
            this.register_Operator_textbox.Location = new System.Drawing.Point(73, 99);
            this.register_Operator_textbox.Name = "register_Operator_textbox";
            this.register_Operator_textbox.Size = new System.Drawing.Size(100, 22);
            this.register_Operator_textbox.TabIndex = 3;
            // 
            // getAllInfo_Button
            // 
            this.getAllInfo_Button.Location = new System.Drawing.Point(56, 128);
            this.getAllInfo_Button.Name = "getAllInfo_Button";
            this.getAllInfo_Button.Size = new System.Drawing.Size(129, 23);
            this.getAllInfo_Button.TabIndex = 4;
            this.getAllInfo_Button.Text = "獲得所有執行狀態";
            this.getAllInfo_Button.UseVisualStyleBackColor = true;
            this.getAllInfo_Button.Click += new System.EventHandler(this.getAllInfo_Button_Click);
            // 
            // getSpecificInfo_Button
            // 
            this.getSpecificInfo_Button.Location = new System.Drawing.Point(56, 165);
            this.getSpecificInfo_Button.Name = "getSpecificInfo_Button";
            this.getSpecificInfo_Button.Size = new System.Drawing.Size(129, 23);
            this.getSpecificInfo_Button.TabIndex = 4;
            this.getSpecificInfo_Button.Text = "獲得子系統執行狀態";
            this.getSpecificInfo_Button.UseVisualStyleBackColor = true;
            this.getSpecificInfo_Button.Click += new System.EventHandler(this.getSpecificInfo_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.register_NewSysStatus_Button);
            this.groupBox1.Controls.Add(this.register_CKey_Textbox);
            this.groupBox1.Controls.Add(this.register_Operator_textbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.register_SubSysNo_Textox);
            this.groupBox1.Location = new System.Drawing.Point(20, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增案件狀態";
            // 
            // CurrentStatus_groupbox
            // 
            this.CurrentStatus_groupbox.Controls.Add(this.Cuttent_Status);
            this.CurrentStatus_groupbox.Controls.Add(this.label4);
            this.CurrentStatus_groupbox.Controls.Add(this.getAllInfo_Button);
            this.CurrentStatus_groupbox.Controls.Add(this.getCurrentData_Ckey_Textbox);
            this.CurrentStatus_groupbox.Controls.Add(this.getSpecificInfo_Button);
            this.CurrentStatus_groupbox.Controls.Add(this.label7);
            this.CurrentStatus_groupbox.Controls.Add(this.label5);
            this.CurrentStatus_groupbox.Controls.Add(this.getCurrentData_Company_Textbox);
            this.CurrentStatus_groupbox.Controls.Add(this.getCurrentData_SysNo_Textbox);
            this.CurrentStatus_groupbox.Location = new System.Drawing.Point(17, 6);
            this.CurrentStatus_groupbox.Name = "CurrentStatus_groupbox";
            this.CurrentStatus_groupbox.Size = new System.Drawing.Size(429, 194);
            this.CurrentStatus_groupbox.TabIndex = 6;
            this.CurrentStatus_groupbox.TabStop = false;
            this.CurrentStatus_groupbox.Text = "獲取目前狀態";
            // 
            // Cuttent_Status
            // 
            this.Cuttent_Status.Controls.Add(this.getData_UpdateTime);
            this.Cuttent_Status.Controls.Add(this.getData_Status);
            this.Cuttent_Status.Controls.Add(this.getData_Flow);
            this.Cuttent_Status.Controls.Add(this.getData_SysNo);
            this.Cuttent_Status.Controls.Add(this.label12);
            this.Cuttent_Status.Controls.Add(this.label10);
            this.Cuttent_Status.Controls.Add(this.label8);
            this.Cuttent_Status.Controls.Add(this.label6);
            this.Cuttent_Status.Location = new System.Drawing.Point(209, 25);
            this.Cuttent_Status.Name = "Cuttent_Status";
            this.Cuttent_Status.Size = new System.Drawing.Size(214, 146);
            this.Cuttent_Status.TabIndex = 5;
            this.Cuttent_Status.TabStop = false;
            this.Cuttent_Status.Text = "目前執行狀態";
            // 
            // getData_UpdateTime
            // 
            this.getData_UpdateTime.AutoSize = true;
            this.getData_UpdateTime.Location = new System.Drawing.Point(90, 115);
            this.getData_UpdateTime.Name = "getData_UpdateTime";
            this.getData_UpdateTime.Size = new System.Drawing.Size(103, 12);
            this.getData_UpdateTime.TabIndex = 0;
            this.getData_UpdateTime.Text = "getData_UpdateTime";
            // 
            // getData_Status
            // 
            this.getData_Status.AutoSize = true;
            this.getData_Status.Location = new System.Drawing.Point(90, 86);
            this.getData_Status.Name = "getData_Status";
            this.getData_Status.Size = new System.Drawing.Size(73, 12);
            this.getData_Status.TabIndex = 0;
            this.getData_Status.Text = "getData_Status";
            // 
            // getData_Flow
            // 
            this.getData_Flow.AutoSize = true;
            this.getData_Flow.Location = new System.Drawing.Point(90, 52);
            this.getData_Flow.Name = "getData_Flow";
            this.getData_Flow.Size = new System.Drawing.Size(69, 12);
            this.getData_Flow.TabIndex = 0;
            this.getData_Flow.Text = "getData_Flow";
            // 
            // getData_SysNo
            // 
            this.getData_SysNo.AutoSize = true;
            this.getData_SysNo.Location = new System.Drawing.Point(90, 22);
            this.getData_SysNo.Name = "getData_SysNo";
            this.getData_SysNo.Size = new System.Drawing.Size(76, 12);
            this.getData_SysNo.TabIndex = 0;
            this.getData_SysNo.Text = "getData_SysNo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "更新時間";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "處理狀態";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "目前流程";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "子系統";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "C_Keys";
            // 
            // getCurrentData_Ckey_Textbox
            // 
            this.getCurrentData_Ckey_Textbox.Location = new System.Drawing.Point(85, 21);
            this.getCurrentData_Ckey_Textbox.Name = "getCurrentData_Ckey_Textbox";
            this.getCurrentData_Ckey_Textbox.Size = new System.Drawing.Size(100, 22);
            this.getCurrentData_Ckey_Textbox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Company";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "SysNo";
            // 
            // getCurrentData_Company_Textbox
            // 
            this.getCurrentData_Company_Textbox.Location = new System.Drawing.Point(85, 87);
            this.getCurrentData_Company_Textbox.Name = "getCurrentData_Company_Textbox";
            this.getCurrentData_Company_Textbox.Size = new System.Drawing.Size(100, 22);
            this.getCurrentData_Company_Textbox.TabIndex = 3;
            // 
            // getCurrentData_SysNo_Textbox
            // 
            this.getCurrentData_SysNo_Textbox.Location = new System.Drawing.Point(85, 55);
            this.getCurrentData_SysNo_Textbox.Name = "getCurrentData_SysNo_Textbox";
            this.getCurrentData_SysNo_Textbox.Size = new System.Drawing.Size(100, 22);
            this.getCurrentData_SysNo_Textbox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConsoleLog);
            this.groupBox2.Location = new System.Drawing.Point(855, 544);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 164);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "運算結果";
            // 
            // ConsoleLog
            // 
            this.ConsoleLog.Location = new System.Drawing.Point(6, 21);
            this.ConsoleLog.Multiline = true;
            this.ConsoleLog.Name = "ConsoleLog";
            this.ConsoleLog.Size = new System.Drawing.Size(249, 137);
            this.ConsoleLog.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.getOverExcuteCurrentData_button);
            this.groupBox3.Controls.Add(this.getOverExcuteCurrentData_Ckey_textbox);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.getOverExcuteCurrentData_Company_textbox);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 678);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "獲取目前執行狀態";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.getOverExcuteCurrentData_Operator_Label);
            this.groupBox4.Controls.Add(this.getOverExcuteCurrentData_UpdateTime_Label);
            this.groupBox4.Controls.Add(this.getOverExcuteCurrentData_Status_Label);
            this.groupBox4.Controls.Add(this.getOverExcuteCurrentData_Flow_Label);
            this.groupBox4.Controls.Add(this.getOverExcuteCurrentData_Ckeys_Label);
            this.groupBox4.Controls.Add(this.getOverExcuteCurrentData_Company_Label);
            this.groupBox4.Controls.Add(this.getOverExcuteCurrentData_SysNo_Label);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(202, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 606);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "目前執行狀態";
            // 
            // getOverExcuteCurrentData_Operator_Label
            // 
            this.getOverExcuteCurrentData_Operator_Label.AutoSize = true;
            this.getOverExcuteCurrentData_Operator_Label.Location = new System.Drawing.Point(95, 187);
            this.getOverExcuteCurrentData_Operator_Label.Name = "getOverExcuteCurrentData_Operator_Label";
            this.getOverExcuteCurrentData_Operator_Label.Size = new System.Drawing.Size(210, 12);
            this.getOverExcuteCurrentData_Operator_Label.TabIndex = 0;
            this.getOverExcuteCurrentData_Operator_Label.Text = "getOverExcuteCurrentData_Operator_Label";
            // 
            // getOverExcuteCurrentData_UpdateTime_Label
            // 
            this.getOverExcuteCurrentData_UpdateTime_Label.AutoSize = true;
            this.getOverExcuteCurrentData_UpdateTime_Label.Location = new System.Drawing.Point(93, 221);
            this.getOverExcuteCurrentData_UpdateTime_Label.Name = "getOverExcuteCurrentData_UpdateTime_Label";
            this.getOverExcuteCurrentData_UpdateTime_Label.Size = new System.Drawing.Size(226, 12);
            this.getOverExcuteCurrentData_UpdateTime_Label.TabIndex = 0;
            this.getOverExcuteCurrentData_UpdateTime_Label.Text = "getOverExcuteCurrentData_UpdateTime_Label";
            // 
            // getOverExcuteCurrentData_Status_Label
            // 
            this.getOverExcuteCurrentData_Status_Label.AutoSize = true;
            this.getOverExcuteCurrentData_Status_Label.Location = new System.Drawing.Point(95, 155);
            this.getOverExcuteCurrentData_Status_Label.Name = "getOverExcuteCurrentData_Status_Label";
            this.getOverExcuteCurrentData_Status_Label.Size = new System.Drawing.Size(196, 12);
            this.getOverExcuteCurrentData_Status_Label.TabIndex = 0;
            this.getOverExcuteCurrentData_Status_Label.Text = "getOverExcuteCurrentData_Status_Label";
            // 
            // getOverExcuteCurrentData_Flow_Label
            // 
            this.getOverExcuteCurrentData_Flow_Label.AutoSize = true;
            this.getOverExcuteCurrentData_Flow_Label.Location = new System.Drawing.Point(94, 121);
            this.getOverExcuteCurrentData_Flow_Label.Name = "getOverExcuteCurrentData_Flow_Label";
            this.getOverExcuteCurrentData_Flow_Label.Size = new System.Drawing.Size(192, 12);
            this.getOverExcuteCurrentData_Flow_Label.TabIndex = 0;
            this.getOverExcuteCurrentData_Flow_Label.Text = "getOverExcuteCurrentData_Flow_Label";
            // 
            // getOverExcuteCurrentData_Ckeys_Label
            // 
            this.getOverExcuteCurrentData_Ckeys_Label.AutoSize = true;
            this.getOverExcuteCurrentData_Ckeys_Label.Location = new System.Drawing.Point(93, 27);
            this.getOverExcuteCurrentData_Ckeys_Label.Name = "getOverExcuteCurrentData_Ckeys_Label";
            this.getOverExcuteCurrentData_Ckeys_Label.Size = new System.Drawing.Size(198, 12);
            this.getOverExcuteCurrentData_Ckeys_Label.TabIndex = 0;
            this.getOverExcuteCurrentData_Ckeys_Label.Text = "getOverExcuteCurrentData_Ckeys_Label";
            // 
            // getOverExcuteCurrentData_Company_Label
            // 
            this.getOverExcuteCurrentData_Company_Label.AutoSize = true;
            this.getOverExcuteCurrentData_Company_Label.Location = new System.Drawing.Point(94, 57);
            this.getOverExcuteCurrentData_Company_Label.Name = "getOverExcuteCurrentData_Company_Label";
            this.getOverExcuteCurrentData_Company_Label.Size = new System.Drawing.Size(215, 12);
            this.getOverExcuteCurrentData_Company_Label.TabIndex = 0;
            this.getOverExcuteCurrentData_Company_Label.Text = "getOverExcuteCurrentData_Company_Label";
            // 
            // getOverExcuteCurrentData_SysNo_Label
            // 
            this.getOverExcuteCurrentData_SysNo_Label.AutoSize = true;
            this.getOverExcuteCurrentData_SysNo_Label.Location = new System.Drawing.Point(94, 85);
            this.getOverExcuteCurrentData_SysNo_Label.Name = "getOverExcuteCurrentData_SysNo_Label";
            this.getOverExcuteCurrentData_SysNo_Label.Size = new System.Drawing.Size(199, 12);
            this.getOverExcuteCurrentData_SysNo_Label.TabIndex = 0;
            this.getOverExcuteCurrentData_SysNo_Label.Text = "getOverExcuteCurrentData_SysNo_Label";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "公司";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(31, 27);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "單號";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "操作者";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(13, 88);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "子系統編號";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "更新時間";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "處理狀態";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "目前流程";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "C_Keys";
            // 
            // getOverExcuteCurrentData_button
            // 
            this.getOverExcuteCurrentData_button.Location = new System.Drawing.Point(53, 153);
            this.getOverExcuteCurrentData_button.Name = "getOverExcuteCurrentData_button";
            this.getOverExcuteCurrentData_button.Size = new System.Drawing.Size(129, 23);
            this.getOverExcuteCurrentData_button.TabIndex = 4;
            this.getOverExcuteCurrentData_button.Text = "獲得所有執行狀態";
            this.getOverExcuteCurrentData_button.UseVisualStyleBackColor = true;
            this.getOverExcuteCurrentData_button.Click += new System.EventHandler(this.getOverExcuteCurrentData_button_Click);
            // 
            // getOverExcuteCurrentData_Ckey_textbox
            // 
            this.getOverExcuteCurrentData_Ckey_textbox.Location = new System.Drawing.Point(82, 68);
            this.getOverExcuteCurrentData_Ckey_textbox.Name = "getOverExcuteCurrentData_Ckey_textbox";
            this.getOverExcuteCurrentData_Ckey_textbox.Size = new System.Drawing.Size(100, 22);
            this.getOverExcuteCurrentData_Ckey_textbox.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 112);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "Company";
            // 
            // getOverExcuteCurrentData_Company_textbox
            // 
            this.getOverExcuteCurrentData_Company_textbox.Location = new System.Drawing.Point(82, 109);
            this.getOverExcuteCurrentData_Company_textbox.Name = "getOverExcuteCurrentData_Company_textbox";
            this.getOverExcuteCurrentData_Company_textbox.Size = new System.Drawing.Size(100, 22);
            this.getOverExcuteCurrentData_Company_textbox.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 710);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(553, 684);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新增";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CurrentStatus_groupbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(553, 684);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "獲取資訊";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(553, 684);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "獲取目前執行狀態";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.GetExcuteTime_SysNo);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.GetExcuteTime_Ckey);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.GetExcuteTime_Company);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(553, 684);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "獲取執行過程時間";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(116, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 12);
            this.label18.TabIndex = 8;
            this.label18.Text = "SysNo";
            // 
            // GetExcuteTime_SysNo
            // 
            this.GetExcuteTime_SysNo.Location = new System.Drawing.Point(172, 71);
            this.GetExcuteTime_SysNo.Name = "GetExcuteTime_SysNo";
            this.GetExcuteTime_SysNo.Size = new System.Drawing.Size(100, 22);
            this.GetExcuteTime_SysNo.TabIndex = 9;
            this.GetExcuteTime_SysNo.Text = "LF003";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "C_Keys";
            // 
            // GetExcuteTime_Ckey
            // 
            this.GetExcuteTime_Ckey.Location = new System.Drawing.Point(173, 39);
            this.GetExcuteTime_Ckey.Name = "GetExcuteTime_Ckey";
            this.GetExcuteTime_Ckey.Size = new System.Drawing.Size(100, 22);
            this.GetExcuteTime_Ckey.TabIndex = 6;
            this.GetExcuteTime_Ckey.Text = "A121745783_F0001";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(117, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "Company";
            // 
            // GetExcuteTime_Company
            // 
            this.GetExcuteTime_Company.Location = new System.Drawing.Point(173, 105);
            this.GetExcuteTime_Company.Name = "GetExcuteTime_Company";
            this.GetExcuteTime_Company.Size = new System.Drawing.Size(100, 22);
            this.GetExcuteTime_Company.TabIndex = 7;
            this.GetExcuteTime_Company.Text = "PTMB";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GetExcuteTime";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 720);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CurrentStatus_groupbox.ResumeLayout(false);
            this.CurrentStatus_groupbox.PerformLayout();
            this.Cuttent_Status.ResumeLayout(false);
            this.Cuttent_Status.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button register_NewSysStatus_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox register_CKey_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox register_SubSysNo_Textox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox register_Operator_textbox;
        private System.Windows.Forms.Button getAllInfo_Button;
        private System.Windows.Forms.Button getSpecificInfo_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox CurrentStatus_groupbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox getCurrentData_Ckey_Textbox;
        private System.Windows.Forms.GroupBox Cuttent_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox getCurrentData_SysNo_Textbox;
        private System.Windows.Forms.Label getData_UpdateTime;
        private System.Windows.Forms.Label getData_Status;
        private System.Windows.Forms.Label getData_Flow;
        private System.Windows.Forms.Label getData_SysNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox getCurrentData_Company_Textbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ConsoleLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label getOverExcuteCurrentData_UpdateTime_Label;
        private System.Windows.Forms.Label getOverExcuteCurrentData_Status_Label;
        private System.Windows.Forms.Label getOverExcuteCurrentData_Flow_Label;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button getOverExcuteCurrentData_button;
        private System.Windows.Forms.TextBox getOverExcuteCurrentData_Ckey_textbox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox getOverExcuteCurrentData_Company_textbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label getOverExcuteCurrentData_Ckeys_Label;
        private System.Windows.Forms.Label getOverExcuteCurrentData_Company_Label;
        private System.Windows.Forms.Label getOverExcuteCurrentData_SysNo_Label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label getOverExcuteCurrentData_Operator_Label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox GetExcuteTime_Ckey;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox GetExcuteTime_Company;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox GetExcuteTime_SysNo;
    }
}

