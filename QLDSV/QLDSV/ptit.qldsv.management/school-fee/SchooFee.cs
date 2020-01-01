using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLDSV.ptit.qldsv.service;
using System.Diagnostics;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Base;

namespace QLDSV.ptit.qldsv.management.school_fee
{
    public partial class SchooFee : DevExpress.XtraEditors.XtraForm
    {
        public SchooFee()
        {
            InitializeComponent();
        }
        private bool searchResult = true;
        private StudentService studentService = new StudentService();
        private bool actionType = false; // 0: update; 1: insert
        private int lastPosition = 0;
        private void hOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCPHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLDSV);

        }

        private void SchooFee_Load(object sender, EventArgs e)
        {
            //dS_QLDSV.EnforceConstraints = false;
            initUiInvalidStudent(false);
            initAction(false); // dissable all action refer to hocphi
            dateTo.Enabled = false;
            dateTo.Value = dateFrom.Value.AddYears(1);
            txtMaSV.Visible = true;
            txtNienKhoa.Text = dateFrom.Value.Year + "-" + dateTo.Value.Year;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maSV = txtKeyword.Text;
            searchHocPhiCuaSinhVien(maSV);
            getHocPhiSinhVien(maSV);
            
            if(searchResult == true)
            {
                initAction(true);
                initUiInvalidStudent(true);
            } else
            {
                initAction(false);
                initUiInvalidStudent(false);
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "", MessageBoxButtons.OK);
            }
        }
        private void searchHocPhiCuaSinhVien(string maSV)
        {
            try
            {
                DataTable dtStudent = HelperCommon.queryDataByOneCondition("SINHVIEN", "MASV", maSV);
                BindingSource bdsStudent = new BindingSource();
                bdsStudent.DataSource = dtStudent;
                string maLop = studentService.getClassId(bdsStudent);
                string hoTen = studentService.getFullname(bdsStudent);
                string gender = studentService.getGender(bdsStudent) == true ? "Nam" : "Nữ";
                initStudentInfo(maSV, hoTen, maLop, gender);
                txtMaSV.Text = maSV;
                searchResult = true;
                if(maLop == "" || hoTen == "")
                {
                    searchResult = false;
                    
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "", MessageBoxButtons.OK);
                Debug.Print(ex.StackTrace);
                searchResult = false;
                return;
            }
        }
        private void getHocPhiSinhVien(string maSV)
        {
            try
            {
                dS_QLDSV.EnforceConstraints = false;
                this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOCPHITableAdapter.Fill(this.dS_QLDSV.HOCPHI, maSV);
                int rowCount = hOCPHIBindingSource.Count;
                if (rowCount > 0)
                {
                    btnUpdate.Enabled = true;
                }
            } catch(Exception ex)
            {
                Debug.Print(ex.StackTrace);
                return;
            }
            
        }
        private void initStudentInfo(string maSV, string fullname, string maLop, string gender)
        {
            lblMaSVInfo.Text = maSV;
            lblFullname.Text = fullname;
            lblClass.Text = maLop;
            lblGender.Text = gender;
        }
        private void initUiInvalidStudent(bool success)
        {
            if(success == false)
            {
                grbStudentInfo.Visible = false;
                grbUpdateSchooFee.Visible = false;
                grbUpdateSchooFee.Enabled = false;
                hOCPHIGridControl.Visible = false;
            } else
            {
                grbStudentInfo.Visible = true;
                grbUpdateSchooFee.Visible = true;
                grbUpdateSchooFee.Enabled = false;
                hOCPHIGridControl.Visible = true;
            }
            
        }
        private void disableInputByActionType()
        {
            if(actionType)
            {
                txtNienKhoa.Visible = false;
                grbNienKhoa.Visible = true;
            } else
            {
                grbNienKhoa.Visible = false;
                txtNienKhoa.Visible = true;
                txtNienKhoa.Enabled = false;
                txtHocKi.Enabled = false;
            }
        }
        private void initAction(bool success)
        {
            if (success == false)
            {
                btnAddNew.Enabled = false;
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                btnHuy.Enabled = false;
            }
            else
            {
                btnAddNew.Enabled = true;
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        private void btnAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                actionType = true;
                hOCPHIBindingSource.AddNew();
                hOCPHIBindingSource.MoveLast();
                lastPosition = hOCPHIBindingSource.Position;
                initAction(false);
                btnSave.Enabled = true;
                btnHuy.Enabled = true;
                disableInputByActionType();
                grbUpdateSchooFee.Enabled = true;
            } catch (Exception ex)
            {
                Debug.Print(ex.StackTrace);
                return;
            }
            
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                grbUpdateSchooFee.Enabled = true;
                lastPosition = hOCPHIBindingSource.Position;
                initAction(false);
                btnSave.Enabled = true;
                btnHuy.Enabled = true;
                disableInputByActionType();
                grbUpdateSchooFee.Enabled = true;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.StackTrace);
                return;
            }
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (actionType)
                {
                    txtNienKhoa.Text = dateFrom.Value.Year+"-" +dateTo.Value.Year;
                }
                if(validateForm())
                {
                    dS_QLDSV.EnforceConstraints = false;
                    txtMaSV.Text = lblMaSVInfo.Text;
                    hOCPHIBindingSource.EndEdit();
                    hOCPHIBindingSource.ResetCurrentItem();
                    this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.hOCPHITableAdapter.Update(this.dS_QLDSV.HOCPHI);
                    hOCPHIBindingSource.Position = lastPosition;
                    initAction(true);
                } else
                {
                    return;
                }
                
            } catch(Exception ex)
            {
                MessageBox.Show("Lưu học phí không thành công.", "", MessageBoxButtons.OK);
                Debug.Print(ex.StackTrace);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                hOCPHIBindingSource.CancelEdit();
                this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOCPHITableAdapter.Fill(this.dS_QLDSV.HOCPHI, lblMaSV.Text);
                initAction(true);
            }
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTo.Value = dateFrom.Value.AddYears(1);
            txtNienKhoa.Text = dateFrom.Value.Year + "-" + dateTo.Value.Year;
        }
        private bool validateForm()
        {
            bool result = true;
            
            try {
                float hocPhi = float.Parse(txtHocPhi.Text);
                float soTienDaDong = float.Parse(txtSoTienDaDong.Text);
                int hocKi = int.Parse(txtHocKi.Text);
                int checkHKy = checkHocKy(hocKi);
                if (hocPhi < 0 || soTienDaDong < 0)
                {
                    result = false;
                    MessageBox.Show("Tiền học phí / Số tiền đã đóng không đúng.", "", MessageBoxButtons.OK);
                }
                if (checkHKy  == 1001 || checkHKy == 1000 || hocKi < checkHKy || hocKi > checkHKy+1)
                {
                    result = false;
                    MessageBox.Show("Học kì không đúng.", "", MessageBoxButtons.OK);
                } 
                if(hocPhi < soTienDaDong)
                {
                    result = false;
                    MessageBox.Show("Số tiền đóng học không vượt quá học phí.", "", MessageBoxButtons.OK);
                }
            } catch(Exception ex)
            {
                Debug.Print(ex.StackTrace);
                result = false;
                MessageBox.Show("Thông tin đóng học phí không chính xác.", "", MessageBoxButtons.OK);

            }
            return result;
        }
        private int checkHocKy(int hocKy)
        {
            int ret = 0;
            string maSV = lblMaSVInfo.Text;
            string nienKhoa = "";
            if(actionType)
            {
                nienKhoa = dateFrom.Value.Year + "-" + dateTo.Value.Year;
            } else
            {
                nienKhoa = txtNienKhoa.Text;
            }
            
            string strLenh = "EXEC SP_KIEMTRAHOCKY @MASV = '"+maSV+"', @NIENKHOA = '"+nienKhoa+"', @HOCKY = "+hocKy;
            SqlDataReader myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader != null && myReader.HasRows)
            {
                while (myReader.Read())
                {
                    ret = myReader.GetInt32(0);
                }
            }
            return ret;
        }
    }
}