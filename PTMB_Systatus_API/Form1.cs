using Newtonsoft.Json;
using PTMB_Systatus_API.Data.DataSet;
using PTMB_Systatus_API.Model.Implement.SQL;
using PTMB_Systatus_API.Model.Implement.Systatus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTMB_Systatus_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewSysStatus_Button_Click(object sender, EventArgs e)
        {
            SysStatus_Controller SysStatus_controller = SysStatus_Controller.getInstance();

            SysStatus_controller.CheckIn(TakeTestData1());

            ConsoleLog.Text += string.Format("{0}\r\n", SysStatus_controller.FeedBackMsg);



        }

        private void getAllInfo_Button_Click(object sender, EventArgs e)
        {
            SysStatus_Controller SysStatus_controller = SysStatus_Controller.getInstance();
            List<SysStatusInfo> list_sysstausinfo = SysStatus_controller.GetAllInformation(getCurrentData_Ckey_Textbox.Text.ToString(), Company.PTMB);
            ConsoleLog.Text += string.Format("{0}\r\n結果如下：\r\n{1}", SysStatus_controller.FeedBackMsg,JsonConvert.SerializeObject(list_sysstausinfo));
        }

        private void getSpecificInfo_Button_Click(object sender, EventArgs e)
        {
            SysStatus_Controller SysStatus_controller = SysStatus_Controller.getInstance();
            List<SubSysStatusInfo> list_subsysinfo = SysStatus_controller.GetSpecificInformation(getCurrentData_Ckey_Textbox.Text.ToString(), Company.PTMB, getCurrentData_SysNo_Textbox.Text.ToString());

            if (SysStatus_controller.isSuccess)
            {
                getData_Flow.Text = list_subsysinfo[0].SubSysNo;
                getData_Status.Text = Enum.Parse(typeof(SubSysStatus), list_subsysinfo[0].SubsysStatus.ToString()).ToString();
                getData_SysNo.Text = getCurrentData_SysNo_Textbox.Text;
                getData_UpdateTime.Text = list_subsysinfo[0].UpdateTime.ToString();
            }


            ConsoleLog.Text += string.Format("{0}\r\n", SysStatus_controller.FeedBackMsg);
        }

        private void getOverExcuteCurrentData_button_Click(object sender, EventArgs e)
        {
            SysStatus_Controller SysStatus_controller = SysStatus_Controller.getInstance();
            ExcuteOverCurrentSubAndSubSysInfo currentInfo = SysStatus_controller.GetCurrentInfo(getOverExcuteCurrentData_Ckey_textbox.Text, (Company)Enum.Parse(typeof(Company), getOverExcuteCurrentData_Company_textbox.Text));

            if (SysStatus_controller.isSuccess)
            {
                getOverExcuteCurrentData_Ckeys_Label.Text = getOverExcuteCurrentData_Ckey_textbox.Text;
                getOverExcuteCurrentData_Company_Label.Text = getOverExcuteCurrentData_Company_textbox.Text;
                getOverExcuteCurrentData_SysNo_Label.Text = Enum.Parse(typeof(DefaultSystemNo),currentInfo.SysNo).ToString();
                getOverExcuteCurrentData_Status_Label.Text = currentInfo.SubsysStatus.ToString();
                getOverExcuteCurrentData_UpdateTime_Label.Text = currentInfo.UpdateTime.ToString();
                getOverExcuteCurrentData_Flow_Label.Text = currentInfo.SubSysNo.ToString();
                getOverExcuteCurrentData_Operator_Label.Text = currentInfo.Operator.ToString();
            }


            ConsoleLog.Text += string.Format("{0}\r\n", SysStatus_controller.FeedBackMsg);
        }

        #region 範例資料

        private DataSetCheckInData TakeTestData()
        {
            DataSetCheckInData dataSetCheckInData = new DataSetCheckInData();
            dataSetCheckInData.C_Keys = register_CKey_Textbox.Text;
            dataSetCheckInData.SysStatus = SysStatus.Done;
            dataSetCheckInData.SysNo = DefaultSystemNo.LY002;
            dataSetCheckInData.Company = Company.PTMB.ToString();

            dataSetCheckInData.subsys_info = new List<SubSysStatusInfo>();
            SubSysStatusInfo subsys_info_signle = new SubSysStatusInfo();
            subsys_info_signle.SubsysStatus = SubSysStatus.Done;
            subsys_info_signle.SysNo = dataSetCheckInData.SysNo;
            subsys_info_signle.UpdateTime = DateTime.Now.ToString();
            subsys_info_signle.SubSysNo = register_SubSysNo_Textox.Text;
            subsys_info_signle.Operator = register_Operator_textbox.Text;
            dataSetCheckInData.subsys_info.Add(subsys_info_signle);



            return dataSetCheckInData;
        }
        private DataSetCheckInData TakeTestData1()
        {
            DataSetCheckInData dataSetCheckInData = new DataSetCheckInData();
            dataSetCheckInData.C_Keys = register_CKey_Textbox.Text;
            dataSetCheckInData.SysStatus = SysStatus.Ing;
            dataSetCheckInData.SysNo = DefaultSystemNo.CH002;
            dataSetCheckInData.Company = Company.PTMB.ToString();

            dataSetCheckInData.subsys_info = new List<SubSysStatusInfo>();
            SubSysStatusInfo subsys_info_signle = new SubSysStatusInfo();
            subsys_info_signle.SubsysStatus = SubSysStatus.ing;
            subsys_info_signle.SysNo = dataSetCheckInData.SysNo;
            subsys_info_signle.SubSysNo = register_SubSysNo_Textox.Text;
            subsys_info_signle.Operator = register_Operator_textbox.Text;
            subsys_info_signle.UpdateTime = DateTime.Now.ToString();
            subsys_info_signle.ExtendsInfo = new Imp();
            dataSetCheckInData.subsys_info.Add(subsys_info_signle);

            return dataSetCheckInData;
        }

        

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ExcuteOverCurrentSubSysInfo time_info;
            SysStatus_Controller sysStatus_Controller = SysStatus_Controller.getInstance();
            if(GetExcuteTime_SysNo.Text != "")
            {
                time_info = sysStatus_Controller.GetSysNoExcuteTime(GetExcuteTime_Ckey.Text, (Company)Enum.Parse(typeof(Company), GetExcuteTime_Company.Text),(DefaultSystemNo)Enum.Parse(typeof(DefaultSystemNo), GetExcuteTime_SysNo.Text));
            }
            else
            {
                time_info = sysStatus_Controller.GetExcuteTime(GetExcuteTime_Ckey.Text, (Company)Enum.Parse(typeof(Company), GetExcuteTime_Company.Text));
            }
            ConsoleLog.Text += JsonConvert.SerializeObject(time_info);
        }
    }
    public class Imp : ExtendsData
    {
        public string ss { get; set; }
    }
}
