using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TN_CSDLPT.views
{
    public partial class CauHoi : DevExpress.XtraEditors.XtraUserControl
    {
        private int idDe;
        private int cauSo;
        private string ndCauHoi;
        private string cauA;
        private string cauB;
        private string cauC;
        private string cauD;
        private string daChon = "";
        private string dapAn = "";


        [Category("Custom Props")]
        public int IDDe
        {
            get { return idDe; }
            set { idDe = value; }
        }

        [Category("Custom Props")]
        public int CauSo
        {
            get { return cauSo; }
            set
            {
                cauSo = value;
                labelSoThuTu.Text = "Câu " + cauSo + ": ";
            }
        }
        //câu hỏi
        [Category("Custom Props")]
        public string NDCauHoi
        {
            get { return ndCauHoi; }
            set
            {
                ndCauHoi = value;
                labelNoiDungCauHoi.Text = ndCauHoi;
            }
        }

        //câu A
        [Category("Custom Props")]
        public string CauA
        {
            get { return cauA; }
            set
            {
                cauA = value;
                radioButtonA.Text = cauA;
            }
        }
        //câu B
        [Category("Custom Props")]
        public string CauB
        {
            get { return cauB; }
            set
            {
                cauB = value;
                radioButtonB.Text = cauB;
            }
        }
        //câu C
        [Category("Custom Props")]
        public string CauC
        {
            get { return cauC; }
            set
            {
                cauC = value;
                radioButtonC.Text = cauC;
            }
        }
        //câu D
        [Category("Custom Props")]
        public string CauD
        {
            get { return cauD; }
            set
            {
                cauD = value;
                radioButtonD.Text = cauD;
            }
        }

        //câu đã chọn
        [Category("Custom Props")]
        public string CauDaChon
        {
            get { return daChon; }
            set { daChon = value; }
        }

        //câu đáp án
        [Category("Custom Props")]
        public string CauDapAn
        {
            get { return dapAn; }
            set { dapAn = value; }
        }
        public CauHoi()
        {
            InitializeComponent();
        }

        private void CauHoi_Load(object sender, EventArgs e)
        {
        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            this.daChon = "A";
            //FormThi.thayDoiChonDapAn(this.CauSo, this.daChon, this.IDDe);
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            this.daChon = "B";
            //FormThi.thayDoiChonDapAn(this.CauSo, this.daChon, this.IDDe);
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            this.daChon = "C";
            //FormThi.thayDoiChonDapAn(this.CauSo, this.daChon, this.IDDe);
        }

        private void radioButtonD_CheckedChanged(object sender, EventArgs e)
        {
            this.daChon = "D";
            //FormThi.thayDoiChonDapAn(this.CauSo, this.daChon, this.IDDe);
        }
    }
}
