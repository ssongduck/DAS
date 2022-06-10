using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
namespace SmartDas
{
    public class LabelPrint
    {

        public Image barImg
        {
            get { return _barImg; }
            set { _barImg = value; }
        }

        private Image _barImg;

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;

        string[] _values = null;
        string ctype = "1";
        string _creprint = "";

        public LabelPrint(bool bFull)
        {
            printDialog1 = new System.Windows.Forms.PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            pageSetupDialog1 = new PageSetupDialog();

            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Location = new System.Drawing.Point(66, 87);
            this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
            this.printPreviewDialog1.Name = "미리보기";
            this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
            this.printPreviewDialog1.Visible = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.AllowOrientation = false;
            this.pageSetupDialog1.Document = this.printDocument1;



            if (bFull)
            {
                this.printDocument1.DefaultPageSettings.Margins.Left = 0; //마진 처리 40/100 인치
                this.printDocument1.DefaultPageSettings.Margins.Right = 30;
                this.printDocument1.DefaultPageSettings.Margins.Top = 0;
                this.printDocument1.DefaultPageSettings.Margins.Bottom = 20;

            }
            else
            {
                this.printDocument1.DefaultPageSettings.Margins.Left = 40; //마진 처리 40/100 인치
                this.printDocument1.DefaultPageSettings.Margins.Right = 80;
                this.printDocument1.DefaultPageSettings.Margins.Top = 60;
                this.printDocument1.DefaultPageSettings.Margins.Bottom = 80;
            }

            this.printDialog1.PrinterSettings.FromPage = 0;
            this.printDialog1.PrinterSettings.ToPage = 0;


        }

        public void print(string ptype, string[] values)
        {
            print(ptype, values, false, false);
        }

        public void print(string ptype, string[] values, bool breprint)
        {
            print(ptype, values, breprint, false);
        }

        public void print(string ptype, string[] values, bool breprint, bool bpreview)
        {
            _values = values;
            ctype = ptype;
            _creprint = (breprint ? "[재발행] " : "");
            //   bpreview = true;

            if (bpreview)
            {
                printPreviewDialog1.ShowDialog();

            }
            else
            {
                this.printDialog1.AllowSomePages = false;
                //if (this.printDialog1.ShowDialog() == DialogResult.OK)
                {
                    //  this.printDocument1.DefaultPageSettings.Landscape = pl == "Y" ? true : false;

                    this.printDocument1.Print();
                }
            }
        }

        int lotPrnCnt = 2;

        void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Database db;
            db = DatabaseFactory.CreateDatabase();
            SqlConnection conn = (SqlConnection)db.CreateConnection();
            try
            {
                DataRow dr = db.ExecuteDataSet(CommandType.Text, "SELECT  LotPrnCnt  FROM TBM0600 	 WHERE WorkCenterCode  ='" + Common.SelectedWorkCenter.Code + "'").Tables[0].Rows[0];
                lotPrnCnt = Convert.ToInt32(dr["LotPrnCnt"]);
            }
            catch { }
            if (ctype == "주조")
            {
                report1(e.Graphics, e.MarginBounds);
            }
            else if (ctype == "가공" || ctype == "")
            {
                report2(e.Graphics, e.MarginBounds);
            }
            else if (ctype == "함침")
            {
                report3(e.Graphics, e.MarginBounds);
            }
            else if (ctype == "사상")
            {
                report4(e.Graphics, e.MarginBounds);
            }
            else if (ctype == "VBODY")
            {
                report5(e.Graphics, e.MarginBounds);
            }
            else if (ctype == "금형")
            {
                report6(e.Graphics, e.MarginBounds);
            }

            e.HasMorePages = false; //인쇄 완료
        }

        void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (printDocument1.PrinterSettings.IsValid == false)
            {
                e.Cancel = true;
                return;
            }
            //if (bPreview && ++previewprint % 2 == 0)
            //{
            //    e.Cancel = true;
            //    return;

            //}

            try
            {
                //this.printDocument1.DefaultPageSettings.Margins.Left = (int)(this.printDocument1.DefaultPageSettings.Margins.Left / 2.54);
                //this.printDocument1.DefaultPageSettings.Margins.Right = (int)(this.printDocument1.DefaultPageSettings.Margins.Right / 2.54);
                //this.printDocument1.DefaultPageSettings.Margins.Top = (int)(this.printDocument1.DefaultPageSettings.Margins.Top / 2.54);
                //this.printDocument1.DefaultPageSettings.Margins.Bottom = (int)(this.printDocument1.DefaultPageSettings.Margins.Bottom / 2.54);
            }
            catch { }
        }

        void report1(Graphics gp, Rectangle marginRect)
        {
            int pages = 2;
            try
            {
                pages = lotPrnCnt;// Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["prnPage"]);
            }
            catch { }
            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile("3of9_new.ttf");//"Code3x-hans4u.ttf");//("FREE3OF9.ttf");
            Font fontbarcode = new Font(privateFonts.Families[0], 18f);
            Font fontbarcode1 = new Font(privateFonts.Families[0], 36f);

            for (int i = 0; i < pages; i++)
            {
                if (string.IsNullOrEmpty(_values[18]) || _values[18] == "SK1")
                {
                    #region TODO : 이런 로직은 버려야함
                    if (i == 1)
                    {
                        gp.TranslateTransform(marginRect.Right + marginRect.Left, marginRect.Bottom + marginRect.Top);
                        gp.RotateTransform(180);
                    }
                    int Y = marginRect.Y + 15;

                    //★★★ 2D바코드변경(로고변경, 2D변경)
                    Image image = Image.FromFile("Logo-s.png");
                    Rectangle destRect = new Rectangle(marginRect.X + 50, Y + 10, 120, 35);  // marginRect.X, Y, 120, 35
                    gp.DrawImage(image, destRect);
                    Rectangle fRect = new Rectangle(marginRect.X - 10, Y + 5, 55, 50);
                    gp.DrawImage(_barImg, fRect);
                    Rectangle rRect = new Rectangle(marginRect.X + marginRect.Width - 45, Y + 5, 55, 50);
                    gp.DrawImage(_barImg, rRect);


                    Font font = new Font("굴림체", 18, FontStyle.Bold);
                    Font font1 = new Font("굴림체", 10, FontStyle.Bold);
                    Font font2 = new Font("굴림체", 15, FontStyle.Bold);
                    Font font3 = new Font("HY견고딕", 43, FontStyle.Bold);
                    Font font4 = new Font("HY견고딕", 15, FontStyle.Bold);
                    Font font5 = new Font("HY견고딕", 18, FontStyle.Bold);
                    Font font6 = new Font("HY견고딕", 22, FontStyle.Bold);
                    Font lot_font = new Font("굴림체", 36, FontStyle.Bold); //fontbarcode1 -> lot_font 로 변경(barcode를 lot number로 변경)
                    SolidBrush brushText = new SolidBrush(Color.Black);
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    int hi = (int)(gp.MeasureString("123", font, 100, sf).Height) + 5;

                    RectangleF rectf = new RectangleF(marginRect.X, Y, marginRect.Width, hi);

                    //gp.DrawString((i==0?_values[5]:"사상"), font, brushText, rectf, sf);
                    //if (Common.gsPlantCode == "SK1")
                    //    gp.DrawString("(" + (i == 0 ? ctype : "사상") + ") LOT카드", font, brushText, rectf, sf);
                    //else
                    gp.DrawString("(" + ctype + ") LOT카드", font, brushText, rectf, sf);
                    sf.Alignment = StringAlignment.Far;
                    int wi = (int)(gp.MeasureString(_values[0], fontbarcode).Width) + 100;

                    //2D로트변경 - [재발행] 위치변경
                    rectf = new RectangleF(marginRect.X + marginRect.Width - wi - 50, Y + 30, wi, 20); //marginRect.X + marginRect.Width - wi, Y + 9, wi, 20

                    gp.DrawString(_creprint + _values[0], font1, brushText, rectf, sf);
                    rectf.Offset(0, 17);

                    //★★★ 2D바코드변경(1D바코드 제거)
                    //gp.DrawString("*" + _values[0] + "*", fontbarcode, brushText, rectf, sf);

                    Y += hi + 20;
                    int ihi = marginRect.Height / 2;
                    int botMargin = 10;
                    int shi = 55;
                    int nhi = 10;
                    Pen pen = new Pen(Color.Black, 1);   // ---------------> 테두리 굵기 
                    Rectangle rect = new Rectangle(marginRect.X, Y, marginRect.Width, ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                    gp.DrawRectangle(pen, rect);
                    gp.DrawLine(pen, marginRect.X, Y + shi, marginRect.Width / 2 + marginRect.X, Y + shi);
                    gp.DrawLine(pen, marginRect.X, Y + shi * 2, marginRect.Width + marginRect.X, Y + shi * 2);
                    gp.DrawLine(pen, marginRect.X, Y + shi * 3, marginRect.Width + marginRect.X, Y + shi * 3);
                    gp.DrawLine(pen, marginRect.X, Y + shi * 4, marginRect.Width + marginRect.X, Y + shi * 4);
                    gp.DrawLine(pen, marginRect.X, Y + shi * 5, marginRect.Width + marginRect.X, Y + shi * 5);
                    gp.DrawLine(pen, marginRect.X, Y + shi * 6, marginRect.Width + marginRect.X, Y + shi * 6);

                    gp.DrawLine(pen, marginRect.X + 110, Y, marginRect.X + 110, Y + ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                    gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y, marginRect.X + marginRect.Width / 2, Y + shi * 2);

                    //★★★ 2D바코드변경(shi * 3 → shi * 4)
                    gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y + shi * 3, marginRect.X + marginRect.Width / 2, Y + shi * 6);

                    gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 2);
                    gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 5, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 6);

                    font = new Font("굴림체", 22, FontStyle.Regular);
                    sf.Alignment = StringAlignment.Center;
                    rectf.X = marginRect.X + 1;
                    rectf.Y = Y + nhi + 3;
                    rectf.Width = 110;
                    rectf.Height = (int)(gp.MeasureString("1", font).Height) + 5;
                    gp.DrawString("차 종", font, brushText, rectf, sf);
                    rectf.Y = Y + shi + nhi + 3;
                    gp.DrawString("품 번", font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 2 + nhi + 3;
                    gp.DrawString("품 명", font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 3 + nhi + 3;
                    gp.DrawString("수 량", font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 4 + nhi + 3;
                    gp.DrawString("주/야", font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 5 + nhi + 3;
                    gp.DrawString("일 시", font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 6 + nhi + 3;
                    gp.DrawString("Lot No", font, brushText, rectf, sf);

                    rectf.X = marginRect.X + marginRect.Width / 2 + 1;
                    rectf.Y = Y + nhi + 28;
                    gp.DrawString("형 번", font, brushText, rectf, sf);
                    //rectf.Y = Y + shi * 4 + nhi + 3;
                    //gp.DrawString("작업장", font, brushText, rectf, sf);

                    //rectf.X = marginRect.X + marginRect.Width / 2 + 3;
                    //rectf.Y = Y + shi + 18;
                    //if (i == 0)
                    //{
                    //    rectf.Y = Y + shi * 4 + nhi + 5;
                    //    gp.DrawString(_values[10], font5, brushText, rectf, sf);
                    //}

                    rectf.Y = Y + shi * 5 + nhi + 3;
                    gp.DrawString("작업자", font, brushText, rectf, sf);

                    sf.Alignment = StringAlignment.Near;
                    rectf.X = marginRect.X + 120;
                    rectf.Y = Y + nhi + 3;
                    rectf.Width = marginRect.Width - 110;// marginRect.Width / 2 - 110;
                    gp.DrawString(_values[1], font, brushText, rectf, sf);
                    //  string[] vals = new string[] { "1234567890ASDF", "A6GF1", "SK-14", "45321-26001-20", "COVER-RAR(주조)", "주조", "360EA", "0EA", "A-200EA", "B-160EA", "A-윤주노", "B-곽호걸", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "B-#1", "사상", "12345678901234567890asdfg" };

                    rectf.Y = Y + shi + nhi + 7;
                    gp.DrawString(_values[3], font4, brushText, rectf, sf);
                    rectf.Y = Y + shi * 2 + nhi + 3;
                    gp.DrawString(_values[4], font6, brushText, rectf, sf);
                    //if (i == 0)
                    //{
                    //    rectf.Y = Y + shi * 3 + nhi;
                    //    gp.DrawString(_values[6], font, brushText, rectf, sf);
                    //}
                    rectf.Y = Y + shi * 3 + nhi + 3;
                    gp.DrawString(_values[6], font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 4 + nhi + 3;
                    gp.DrawString(_values[8], font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 4 + nhi + 3;
                    gp.DrawString(_values[9], font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 5 + nhi + 7;
                    gp.DrawString(_values[12], font2, brushText, rectf, sf);
                    //if (i == 0)
                    //{
                    //   rectf.Y = Y + shi * 6 + nhi + 5;
                    //   gp.DrawString(_values[14], font, brushText, rectf, sf);
                    //}
                    // -----------------------> 차공정 : 사상 항목 제외
                    //rectf.Y = Y + shi * 7 + nhi + 10;
                    //wi = (int)(gp.MeasureString(_values[15], fontbarcode).Width) + 100;
                    //rectf.Width = wi;
                    //gp.DrawString("*" + _values[15] + "*", fontbarcode, brushText, rectf, sf);
                    //// rectf.X += wi;
                    //rectf.Y = Y + shi * 7 + nhi + 39;
                    //// wi = (int)(gp.MeasureString(_values[15], font1).Width) + 2;
                    //sf.Alignment = StringAlignment.Near;
                    //gp.DrawString(_values[15], font1, brushText, rectf, sf);

                    rectf.Y = Y + shi * 6 + nhi - 5;
                    wi = (int)(gp.MeasureString(_values[0], lot_font).Width) + 150;
                    //wi = (int)(gp.MeasureString(_values[0], fontbarcode1).Width) + 150;2016.06.23 by PWR 바코드 -> LOT NUMBER 수정 
                    rectf.Width = wi;
                    rectf.Height += 20;
                    gp.DrawString("*" + _values[0] + "*", lot_font, brushText, rectf, sf);
                    //gp.DrawString("*" + _values[0] + "*", fontbarcode1, brushText, rectf, sf);2016.06.23 by PWR 바코드 -> LOT NUMBER 수정 

                    sf.Alignment = StringAlignment.Near;

                    rectf.X = marginRect.X + marginRect.Width / 2 + 35;
                    rectf.Y = Y + shi * 3 + 18;
                    wi = (int)(gp.MeasureString(_values[3], fontbarcode).Width) + 150;
                    rectf.Width = wi;

                    //★★★ 2D바코드변경(1D바코드 제거)
                    gp.DrawString("*" + _values[0] + "*", fontbarcode, brushText, rectf, sf);
                    //gp.DrawString("*" + _values[3] + "*", fontbarcode, brushText, rectf, sf); 2016.06.23 by PWR 품번바코드 -> LOT 바코드 수정 

                    rectf.X = marginRect.X + marginRect.Width / 2 + 3;
                    rectf.Y = Y + shi + 18;
                    if (i == 0)
                    {
                        rectf.Y = Y + shi * 4 + nhi + 5;
                        gp.DrawString(_values[10], font5, brushText, rectf, sf);
                    } // 작업장명

                    rectf.X = marginRect.X + marginRect.Width / 2 + 120;
                    rectf.Y = Y + 0 + nhi + 17;
                    gp.DrawString(_values[2], font3, brushText, rectf, sf);
                    //rectf.Y = Y + shi * 2 + nhi;
                    //gp.DrawString((i == 0 ? _values[5] : "사상"), font, brushText, rectf, sf);
                    // ----------------------> 공정명 : 주조 항목 제외

                    if (i == 0)
                    {
                        rectf.Y = Y + shi * 3 + nhi;
                        gp.DrawString(_values[7], font, brushText, rectf, sf);
                    }

                    rectf.Y = Y + shi * 4 + nhi + 3;
                    gp.DrawString(_values[11], font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 5 + nhi + 3;
                    gp.DrawString(_values[13], font, brushText, rectf, sf);

                    #endregion
                }
                else
                {
                    if (i == 0)
                    {
                        int Y = marginRect.Y + 15;


                        //2D바코드변경
                        Image image = Image.FromFile("Logo-s.png");
                        Rectangle destRect = new Rectangle(marginRect.X + 50, Y + 10, 120, 35);  // marginRect.X, Y, 120, 35
                        gp.DrawImage(image, destRect);
                        Rectangle fRect = new Rectangle(marginRect.X - 10, Y + 5, 55, 50);
                        gp.DrawImage(_barImg, fRect);
                        Rectangle rRect = new Rectangle(marginRect.X + marginRect.Width - 45, Y + 5, 55, 50);
                        gp.DrawImage(_barImg, rRect);


                        Font font = new Font("굴림체", 18, FontStyle.Bold);
                        SolidBrush brushText = new SolidBrush(Color.Black);
                        StringFormat sf = new StringFormat();
                        sf.Alignment = StringAlignment.Center;
                        int hi = (int)(gp.MeasureString("123", font, 100, sf).Height) + 5;

                        RectangleF rectf = new RectangleF(marginRect.X, Y, marginRect.Width, hi);

                        //gp.DrawString((i==0?_values[5]:"사상"), font, brushText, rectf, sf);
                        //if (Common.gsPlantCode == "SK1")
                        //    gp.DrawString("(" + (i == 0 ? ctype : "사상") + ") LOT카드", font, brushText, rectf, sf);
                        //else
                        gp.DrawString("(" + ctype + ") LOT카드", font, brushText, rectf, sf);
                        sf.Alignment = StringAlignment.Far;
                        int wi = (int)(gp.MeasureString(_values[0], fontbarcode).Width) + 100;

                        //★★★ 2D바코드변경(재발행 위치변경)
                        rectf = new RectangleF(marginRect.X + marginRect.Width - wi - 50, Y + 30, wi, 20); //marginRect.X + marginRect.Width - wi, Y + 9, wi, 20

                        Font font1 = new Font("굴림체", 10, FontStyle.Bold);
                        Font font2 = new Font("굴림체", 15, FontStyle.Bold);
                        Font font3 = new Font("HY견고딕", 43, FontStyle.Bold);
                        Font font4 = new Font("HY견고딕", 15, FontStyle.Bold);
                        Font font5 = new Font("HY견고딕", 18, FontStyle.Bold);
                        Font font6 = new Font("HY견고딕", 22, FontStyle.Bold);
                        Font lot_font = new Font("굴림체", 36, FontStyle.Bold);    //fontbarcode1 -> lot_font 로 변경(barcode를 lot number로 변경)
                        gp.DrawString(_creprint + _values[0], font1, brushText, rectf, sf);
                        rectf.Offset(0, 17);

                        //★★★ 2D바코드변경(1D바코드 제거)
                        //gp.DrawString("*" + _values[0] + "*", fontbarcode, brushText, rectf, sf);

                        Y += hi + 20;
                        int ihi = marginRect.Height / 2;
                        int botMargin = 10;
                        int shi = 55;
                        int nhi = 10;
                        Pen pen = new Pen(Color.Black, 1);   // ---------------> 테두리 굵기 
                        Rectangle rect = new Rectangle(marginRect.X, Y, marginRect.Width, ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                        gp.DrawRectangle(pen, rect);
                        gp.DrawLine(pen, marginRect.X, Y + shi, marginRect.Width / 2 + marginRect.X, Y + shi);
                        gp.DrawLine(pen, marginRect.X, Y + shi * 2, marginRect.Width + marginRect.X, Y + shi * 2);
                        gp.DrawLine(pen, marginRect.X, Y + shi * 3, marginRect.Width + marginRect.X, Y + shi * 3);
                        gp.DrawLine(pen, marginRect.X, Y + shi * 4, marginRect.Width + marginRect.X, Y + shi * 4);
                        gp.DrawLine(pen, marginRect.X, Y + shi * 5, marginRect.Width + marginRect.X, Y + shi * 5);
                        gp.DrawLine(pen, marginRect.X, Y + shi * 6, marginRect.Width + marginRect.X, Y + shi * 6);

                        gp.DrawLine(pen, marginRect.X + 110, Y, marginRect.X + 110, Y + ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                        gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y, marginRect.X + marginRect.Width / 2, Y + shi * 2);

                        //★★★ 2D바코드변경(세로라인변경) shi * 3 → shi * 4
                        gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y + shi * 3, marginRect.X + marginRect.Width / 2, Y + shi * 6);

                        gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 2);
                        gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 5, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 6);

                        font = new Font("굴림체", 22, FontStyle.Regular);
                        sf.Alignment = StringAlignment.Center;
                        rectf.X = marginRect.X + 1;
                        rectf.Y = Y + nhi + 3;
                        rectf.Width = 110;
                        rectf.Height = (int)(gp.MeasureString("1", font).Height) + 5;
                        gp.DrawString("차 종", font, brushText, rectf, sf);
                        rectf.Y = Y + shi + nhi + 3;
                        gp.DrawString("품 번", font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 2 + nhi + 3;
                        gp.DrawString("품 명", font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 3 + nhi + 3;
                        gp.DrawString("수 량", font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 4 + nhi + 3;
                        gp.DrawString("주/야", font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 5 + nhi + 3;
                        gp.DrawString("일 시", font, brushText, rectf, sf);
                        //rectf.Y = Y + shi * 6 + nhi + 5;
                        //gp.DrawString("차공정", font, brushText, rectf, sf);
                        // ------------------> 차공정 항목 제외
                        rectf.Y = Y + shi * 6 + nhi + 3;
                        gp.DrawString("Lot No", font, brushText, rectf, sf);

                        rectf.X = marginRect.X + marginRect.Width / 2 + 1;
                        rectf.Y = Y + nhi + 28;
                        gp.DrawString("형 번", font, brushText, rectf, sf);
                        //rectf.Y = Y + shi * 2 + nhi + 2;
                        //gp.DrawString("공정명", font, brushText, rectf, sf);
                        // ---------------> 공정명 항목 제외
                        //rectf.Y = Y + shi * 3 + nhi + 2;
                        //gp.DrawString("불 량", font, brushText, rectf, sf);
                        // ---------------> 불량 항목 제외
                        //rectf.Y = Y + shi * 4 + nhi + 3;
                        //gp.DrawString("작업장", font, brushText, rectf, sf);

                        rectf.Y = Y + shi * 5 + nhi + 3;
                        gp.DrawString("작업자", font, brushText, rectf, sf);

                        sf.Alignment = StringAlignment.Near;
                        rectf.X = marginRect.X + 120;
                        rectf.Y = Y + nhi + 3;
                        rectf.Width = marginRect.Width - 110;// marginRect.Width / 2 - 110;
                        gp.DrawString(_values[1], font, brushText, rectf, sf);
                        //  string[] vals = new string[] { "1234567890ASDF", "A6GF1", "SK-14", "45321-26001-20", "COVER-RAR(주조)", "주조", "360EA", "0EA", "A-200EA", "B-160EA", "A-윤주노", "B-곽호걸", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "B-#1", "사상", "12345678901234567890asdfg" };

                        rectf.Y = Y + shi + nhi + 7;
                        gp.DrawString(_values[3], font4, brushText, rectf, sf);
                        rectf.Y = Y + shi * 2 + nhi + 3;
                        gp.DrawString(_values[4], font6, brushText, rectf, sf);
                        //if (i == 0)
                        //{
                        //    rectf.Y = Y + shi * 3 + nhi;
                        //    gp.DrawString(_values[6], font, brushText, rectf, sf);
                        //}
                        rectf.Y = Y + shi * 3 + nhi + 3;
                        gp.DrawString(_values[6], font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 4 + nhi + 3;
                        gp.DrawString(_values[8], font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 4 + nhi + 3;
                        gp.DrawString(_values[9], font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 5 + nhi + 7;
                        gp.DrawString(_values[12], font2, brushText, rectf, sf);
                        //if (i == 0)
                        //{
                        //   rectf.Y = Y + shi * 6 + nhi + 5;
                        //   gp.DrawString(_values[14], font, brushText, rectf, sf);
                        //}
                        // -----------------------> 차공정 : 사상 항목 제외
                        //rectf.Y = Y + shi * 7 + nhi + 10;
                        //wi = (int)(gp.MeasureString(_values[15], fontbarcode).Width) + 100;
                        //rectf.Width = wi;
                        //gp.DrawString("*" + _values[15] + "*", fontbarcode, brushText, rectf, sf);
                        //// rectf.X += wi;
                        //rectf.Y = Y + shi * 7 + nhi + 39;
                        //// wi = (int)(gp.MeasureString(_values[15], font1).Width) + 2;
                        //sf.Alignment = StringAlignment.Near;
                        //gp.DrawString(_values[15], font1, brushText, rectf, sf);

                        rectf.Y = Y + shi * 6 + nhi - 5;
                        wi = (int)(gp.MeasureString(_values[0], lot_font).Width) + 150;
                        //wi = (int)(gp.MeasureString(_values[0], fontbarcode1).Width) + 150; 2016.06.23 by PWR 바코드 -> LOT NUMBER 수정 
                        rectf.Width = wi;
                        rectf.Height += 20;
                        gp.DrawString("*" + _values[0] + "*", lot_font, brushText, rectf, sf);
                        //gp.DrawString("*" + _values[0] + "*", fontbarcode1, brushText, rectf, sf);2016.06.23 by PWR 바코드 -> LOT NUMBER 수정 

                        sf.Alignment = StringAlignment.Near;

                        rectf.X = marginRect.X + marginRect.Width / 2 + 35;
                        rectf.Y = Y + shi * 3 + 18;
                        wi = (int)(gp.MeasureString(_values[3], fontbarcode).Width) + 150;
                        rectf.Width = wi;

                        //★★★ 2D바코드변경(1D바코드 제거)
                        gp.DrawString("*" + _values[0] + "*", fontbarcode, brushText, rectf, sf);


                        rectf.X = marginRect.X + marginRect.Width / 2 + 3;
                        rectf.Y = Y + shi + 18;
                        if (i == 0)
                        {
                            rectf.Y = Y + shi * 4 + nhi + 5;
                            gp.DrawString(_values[10], font5, brushText, rectf, sf);
                        } // 작업장명 


                        rectf.X = marginRect.X + marginRect.Width / 2 + 120;
                        rectf.Y = Y + 0 + nhi + 17;
                        gp.DrawString(_values[2], font3, brushText, rectf, sf);
                        //rectf.Y = Y + shi * 2 + nhi;
                        //gp.DrawString((i == 0 ? _values[5] : "사상"), font, brushText, rectf, sf);
                        // ----------------------> 공정명 : 주조 항목 제외

                        if (i == 0)
                        {
                            rectf.Y = Y + shi * 3 + nhi;
                            gp.DrawString(_values[7], font, brushText, rectf, sf);
                        }

                        rectf.Y = Y + shi * 4 + nhi + 3;
                        gp.DrawString(_values[11], font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 5 + nhi + 3;
                        gp.DrawString(_values[13], font, brushText, rectf, sf);
                        //if (i == 0 && pages == 2)
                        //{
                        //   pen = new Pen(Color.LightGray, 1);
                        //   gp.DrawLine(pen, 0, marginRect.Y + marginRect.Height / 2, marginRect.X + marginRect.Width + marginRect.Right, marginRect.Y + marginRect.Height / 2);
                        //}
                        // -------------------> page 나눔선 주석처리 
                    }
                    /*
                    else
                    {
                       gp.TranslateTransform(marginRect.Right + marginRect.Left, marginRect.Bottom + marginRect.Top);
                       gp.RotateTransform(180);

                       int Y = marginRect.Y + 15;
                       Font font = new Font("굴림체", 80, FontStyle.Bold); 

                       SolidBrush brushText = new SolidBrush(Color.Black);
                       StringFormat sf = new StringFormat();
                       sf.Alignment = StringAlignment.Center;
                       int hi = (int)(gp.MeasureString(string.Empty, font, 100, sf).Height) + 5;

                       Y += hi + 20;
                       int ihi = marginRect.Height / 2;
                       int botMargin = 10;
                       Pen pen = new Pen(Color.Black, 3);
                       Rectangle rect = new Rectangle(marginRect.X, Y, marginRect.Width, ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                       gp.DrawRectangle(pen, rect);

                       gp.ResetTransform();

                       Font font1 = new Font("굴림체", 30, FontStyle.Bold);  

                       Rectangle rect1 = new Rectangle(5, 650, 450, 500);
                       gp.DrawString(_values[3], font1, brushText, rect1, sf);

                       Rectangle rect2 = new Rectangle(5, 650, 1300, 500);
                       gp.DrawString(_values[6], font1, brushText, rect2, sf);

                       Rectangle rect3 = new Rectangle(marginRect.X, 810, marginRect.Width, 500);
                       gp.DrawString(_values[2], font, brushText, rect3, sf);                  
                    }
                    */
                    // --------------------> 2번째 page 형번찍는 부분 주석처리
                }
            }
        }

        void report2(Graphics gp, Rectangle marginRect)
        {
            int pages = 2;
            try
            {
                pages = lotPrnCnt;// Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["prnPage"]);
            }
            catch { }
            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile("3of9_new.ttf");//"Code3x-hans4u.ttf");//("FREE3OF9.ttf");
            Font fontbarcode = new Font(privateFonts.Families[0], 18f); //18f
            Font fontbarcode1 = new Font(privateFonts.Families[0], 36f);
            Font fontbarcode2 = new Font(privateFonts.Families[0], 13f); // 2020.09.18:추가
            for (int i = 0; i < pages; i++)
            {
                if (i == 1)
                {
                    gp.TranslateTransform(marginRect.Right + marginRect.Left, marginRect.Bottom + marginRect.Top);
                    gp.RotateTransform(180);
                }
                int Y = marginRect.Y + 25;


                //★★★ 2D바코드변경(로고변경, 2D변경)
                Image image = Image.FromFile("Logo-s.png");
                Rectangle destRect = new Rectangle(marginRect.X + 50, Y + 10, 120, 35);  // marginRect.X, Y, 120, 35
                gp.DrawImage(image, destRect);
                Rectangle fRect = new Rectangle(marginRect.X - 10, Y + 5, 55, 50);
                gp.DrawImage(_barImg, fRect);
                Rectangle rRect = new Rectangle(marginRect.X + marginRect.Width - 45, Y + 5, 55, 50);
                gp.DrawImage(_barImg, rRect);


                Font font = new Font("굴림체", 18, FontStyle.Bold);
                Font lot_font = new Font("굴림체", 36, FontStyle.Bold);  //fontbarcode1 -> lot_font 로 변경(barcode를 lot number로 변경)
                SolidBrush brushText = new SolidBrush(Color.Black);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                int hi = (int)(gp.MeasureString("123", font, 100, sf).Height) + 5;

                RectangleF rectf = new RectangleF(marginRect.X, Y, marginRect.Width, hi);
                if (_values[0].Substring(6, 2) == "46" || _values[0].Substring(6, 2) == "4A" || _values[0].Substring(6, 2) == "4B") // vbody
                {
                    ctype = (i == 0 ? "출하" : "검수"); //
                }
                gp.DrawString("(" + ctype + ") LOT카드", font, brushText, rectf, sf);


                sf.Alignment = StringAlignment.Far;
                int wi = (int)(gp.MeasureString(_values[0], fontbarcode).Width) + 100;

                //2D로트 변경
                rectf = new RectangleF(marginRect.X + marginRect.Width - wi - 50, Y + 30, wi, 20); //marginRect.X + marginRect.Width - wi, Y + 9, wi, 20

                Font font1 = new Font("굴림체", 10, FontStyle.Bold);
                gp.DrawString(_creprint + _values[0], font1, brushText, rectf, sf);
                rectf.Offset(0, 16);

                //★★★ 2D바코드변경(1D제거)
                //gp.DrawString("*" + _values[0] + "*", fontbarcode, brushText, rectf, sf);

                Y += hi + 20;
                int ihi = marginRect.Height / 2;
                int botMargin = 10;
                int shi = 55;
                int nhi = 10;
                Pen pen = new Pen(Color.Black, 1);
                Rectangle rect = new Rectangle(marginRect.X, Y, marginRect.Width, ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                gp.DrawRectangle(pen, rect);
                gp.DrawLine(pen, marginRect.X, Y + shi, marginRect.Width + marginRect.X, Y + shi);
                gp.DrawLine(pen, marginRect.X, Y + shi * 2, marginRect.Width + marginRect.X, Y + shi * 2);
                gp.DrawLine(pen, marginRect.X, Y + shi * 3, marginRect.Width + marginRect.X, Y + shi * 3);
                gp.DrawLine(pen, marginRect.X, Y + shi * 4, marginRect.Width + marginRect.X, Y + shi * 4);
                gp.DrawLine(pen, marginRect.X, Y + shi * 5, marginRect.Width + marginRect.X, Y + shi * 5);
                gp.DrawLine(pen, marginRect.X, Y + shi * 6, marginRect.Width + marginRect.X, Y + shi * 6);
                //  gp.DrawLine(pen, marginRect.X, Y + shi * 7, marginRect.Width + marginRect.X, Y + shi * 7);

                gp.DrawLine(pen, marginRect.X + 110, Y, marginRect.X + 110, Y + ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                gp.DrawLine(pen, marginRect.X + (marginRect.Width / 2) + 95, Y + shi, (marginRect.X + marginRect.Width / 2) + 95, Y + shi * 1); //+30, +35, +15, +15 : +95 // 2020.09.18:추가
                gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y + shi * 3, marginRect.X + marginRect.Width / 2, Y + shi * 6);
                gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 4, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 6);
                //gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y, marginRect.X + marginRect.Width / 2, Y + shi * 6);
                //gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y, marginRect.X + marginRect.Width / 2 + 110, Y + shi); //07.18 by 박우리 - LotCard Line변경

                font = new Font("굴림체", 22, FontStyle.Regular);
                font1 = new Font("HY견고딕", 30, FontStyle.Bold);
                Font font2 = new Font("굴림체", 15, FontStyle.Bold);
                Font font3 = new Font("HY견고딕", 22, FontStyle.Bold);
                Font font4 = new Font("HY헤드라인M", 22, FontStyle.Bold);
                Font font5 = new Font("HY견고딕", 13, FontStyle.Bold);

                sf.Alignment = StringAlignment.Center;
                rectf.X = marginRect.X + 1;
                rectf.Y = Y + nhi + 4;
                rectf.Width = 110;
                rectf.Height = (int)(gp.MeasureString("1", font).Height) + 5;
                gp.DrawString("차 종", font, brushText, rectf, sf);
                rectf.Y = Y + shi + nhi + 4;
                gp.DrawString("품 번", font, brushText, rectf, sf);
                rectf.Y = Y + shi * 2 + nhi + 4;
                gp.DrawString("품 명", font, brushText, rectf, sf);
                rectf.Y = Y + shi * 3 + nhi + 4;
                gp.DrawString("수 량", font, brushText, rectf, sf);
                rectf.Y = Y + shi * 4 + nhi + 4;
                gp.DrawString("주/야", font, brushText, rectf, sf);
                rectf.Y = Y + shi * 5 + nhi + 4;
                gp.DrawString("일 시", font, brushText, rectf, sf);
                rectf.Y = Y + shi * 6 + nhi + 4;
                gp.DrawString("Lot No", font, brushText, rectf, sf);
                //  rectf.Y = Y + shi * 7 + nhi;
                //  gp.DrawString("작업지시서", font, brushText, rectf, sf);

                rectf.X = marginRect.X + marginRect.Width / 2 + 1;

                //rectf.Y = Y + nhi;
                //gp.DrawString("고객사", font, brushText, rectf, sf); // 07.18 by 박우리 - 고객사 항목 삭제
                //rectf.Y = Y + shi * 2 + nhi;
                //gp.DrawString("공정명", font, brushText, rectf, sf); // 07.18 by 박우리 - 공정명 항목 삭제
                //rectf.Y = Y + shi * 3 + nhi + 4;
                //gp.DrawString("작업장", font, brushText, rectf, sf);

                rectf.Y = Y + shi * 4 + nhi + 4;
                gp.DrawString("작업자", font, brushText, rectf, sf);
                rectf.Y = Y + shi * 5 + nhi + 4;
                gp.DrawString("검사필", font, brushText, rectf, sf);

                sf.Alignment = StringAlignment.Near;
                //rectf.X = marginRect.X + 113;
                rectf.X = marginRect.X + 120;
                rectf.Y = Y + nhi - 3;
                rectf.Width = marginRect.Width - 110;// marginRect.Width / 2 - 110;
                gp.DrawString(_values[15], font1, brushText, rectf, sf); // 17.07.19 By 박우리 - 차종이름으로 변경
                //  string[] vals = new string[] { "1234567890ASDF", "A6GF1", "SK-14", "45321-26001-20", "COVER-RAR(주조)", "주조", "360EA", "0EA", "A-200EA", "B-160EA", "A-윤주노", "B-곽호걸", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "B-#1", "사상", "12345678901234567890asdfg" };

                rectf.Y = Y + shi + nhi + 5;
                gp.DrawString(_values[3], font4, brushText, rectf, sf);
                rectf.Y = Y + shi * 2 + nhi + 3;
                gp.DrawString(_values[4], font3, brushText, rectf, sf);
                rectf.Y = Y + shi * 3 + nhi + 4;
                gp.DrawString(_values[6], font, brushText, rectf, sf);
                rectf.Y = Y + shi * 4 + nhi + 4;
                gp.DrawString(_values[8], font, brushText, rectf, sf);
                rectf.Y = Y + shi * 4 + nhi + 4;
                gp.DrawString(_values[9], font, brushText, rectf, sf);
                rectf.Y = Y + shi * 5 + nhi + 7;
                gp.DrawString(_values[12], font2, brushText, rectf, sf);

                rectf.Y = Y + shi * 6 + nhi - 6;
                wi = (int)(gp.MeasureString(_values[0], lot_font).Width) + 150;
                //wi = (int)(gp.MeasureString(_values[0], fontbarcode1).Width) + 150; 2016.06.23 by PWR 바코드 -> LOT NUMBER 수정
                rectf.Width = wi;
                rectf.Height += 20;
                gp.DrawString("*" + _values[0] + "*", lot_font, brushText, rectf, sf);
                //gp.DrawString("*" + _values[0] + "*", fontbarcode1, brushText, rectf, sf);2016.06.23 by PWR 바코드 -> LOT NUMBER 수정


                sf.Alignment = StringAlignment.Near;

                rectf.X = marginRect.X + marginRect.Width / 2 + 120;  //35(원위치), 50(위치맞음), 90, 120 // 2020.09.18:추가
                rectf.Y = Y + shi + 18;
                wi = (int)(gp.MeasureString(_values[3], fontbarcode).Width) + 150;
                rectf.Width = wi;

                //★★★ 2D바코드변경
                gp.DrawString("*" + _values[0] + "*", fontbarcode2, brushText, rectf, sf);
                //gp.DrawString("*" + _values[3] + "*", fontbarcode, brushText, rectf, sf); 2016.06.23 by PWR 품번바코드 -> LOT 바코드 수정


                rectf.X = marginRect.X + marginRect.Width / 2 + 3;
                rectf.Y = Y + shi + 18;
                rectf.Y = Y + shi * 3 + nhi + 9;
                gp.DrawString(_values[16], font5, brushText, rectf, sf); // 17.10.13 제품군->작업장으로 변경


                rectf.X = marginRect.X + marginRect.Width / 2 + 110;
                rectf.Y = Y + 0 + nhi + 4;
                gp.DrawString(_values[2], font, brushText, rectf, sf);
                //rectf.Y = Y + shi * 2 + nhi;
                //gp.DrawString(_values[5], font, brushText, rectf, sf); // 07.18 by 박우리 - 공정명데이터 항목 삭제
                //rectf.Y = Y + shi * 3 + nhi + 9;
                //gp.DrawString(_values[16], font5, brushText, rectf, sf); // 17.07.19 By 박우리 - 발행번호_values[7] -> 제품군명_values[16]으로 변경
                rectf.Y = Y + shi * 4 + nhi + 4;
                gp.DrawString(_values[10], font, brushText, rectf, sf);
                rectf.Y = Y + shi * 4 + nhi + 4;
                gp.DrawString(_values[11], font, brushText, rectf, sf);
                //    rectf.Y = Y + shi * 6 + nhi;
                //     gp.DrawString(_values[13], font, brushText, rectf, sf);

                /*
                if (pages == 1)
                {
                    if (i == 0)
                    {
                        gp.TranslateTransform(marginRect.Right + marginRect.Left, marginRect.Bottom + marginRect.Top);
                        gp.RotateTransform(180);

                        Y = marginRect.Y + 15;
                        font = new Font("HY견고딕", 35, FontStyle.Bold);

                        brushText = new SolidBrush(Color.Black);
                        sf = new StringFormat();
                        sf.Alignment = StringAlignment.Center;
                        hi = (int)(gp.MeasureString(string.Empty, font, 100, sf).Height) + 5;

                        Y += hi + 20;
                        ihi = marginRect.Height / 2;
                        botMargin = 10;
                        pen = new Pen(Color.Black, 3);
                        rect = new Rectangle(marginRect.X, Y, marginRect.Width, ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                        gp.DrawRectangle(pen, rect);

                        gp.ResetTransform();

                        font1 = new Font("굴림체", 30, FontStyle.Bold);

                        Rectangle rect1 = new Rectangle(5, 650, 450, 500);
                        gp.DrawString(_values[3], font1, brushText, rect1, sf);

                        Rectangle rect2 = new Rectangle(5, 650, 1300, 500);
                        gp.DrawString(_values[6], font1, brushText, rect2, sf);

                        Rectangle rect3 = new Rectangle(marginRect.X, 870, marginRect.Width, 500);
                        gp.DrawString(_values[4], font, brushText, rect3, sf);

                        Rectangle rect4 = new Rectangle(marginRect.X, 770, marginRect.Width, 500);
                        gp.DrawString(_values[15], font, brushText, rect4, sf);
                    }
                }
                if (i == 0 && pages == 2)
                {
                   pen = new Pen(Color.LightGray, 1);
                   gp.DrawLine(pen, 0, marginRect.Y + marginRect.Height / 2, marginRect.X + marginRect.Width + marginRect.Right, marginRect.Y + marginRect.Height / 2);
                }
                */
                // ----------------------------> 가공 2번째 page 제외
            }
        }

        void report3(Graphics gp, Rectangle marginRect)
        {
            int pages = 2;
            try
            {
                pages = lotPrnCnt;// Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["prnPage"]);
            }
            catch { }
            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile("3of9_new.ttf");//"Code3x-hans4u.ttf");//("FREE3OF9.ttf");
            Font fontbarcode = new Font(privateFonts.Families[0], 18f);
            Font fontbarcode1 = new Font(privateFonts.Families[0], 36f);
            for (int i = 0; i < pages; i++)
            {
                if (i == 1)
                {
                    gp.TranslateTransform(marginRect.Right + marginRect.Left, marginRect.Bottom + marginRect.Top);
                    gp.RotateTransform(180);
                }
                int Y = marginRect.Y + 15;

                //★★★ 2D바코드변경(로고변경, 2D변경)
                Image image = Image.FromFile("Logo-s.png");
                Rectangle destRect = new Rectangle(marginRect.X + 50, Y + 10, 120, 35);  // marginRect.X, Y, 120, 35
                gp.DrawImage(image, destRect);
                Rectangle fRect = new Rectangle(marginRect.X - 10, Y + 5, 55, 50);
                gp.DrawImage(_barImg, fRect);
                Rectangle rRect = new Rectangle(marginRect.X + marginRect.Width - 45, Y + 5, 55, 50);
                gp.DrawImage(_barImg, rRect);


                Font font = new Font("굴림체", 28, FontStyle.Bold);
                Font font1 = new Font("굴림체", 10, FontStyle.Bold);
                Font font2 = new Font("굴림체", 15, FontStyle.Bold);
                Font font3 = new Font("HY견고딕", 20, FontStyle.Bold);
                Font font4 = new Font("굴림체", 16, FontStyle.Regular);
                Font font5 = new Font("HY견고딕", 15, FontStyle.Bold);
                SolidBrush brushText = new SolidBrush(Color.Black);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                int hi = (int)(gp.MeasureString("123", font, 100, sf).Height) + 5;

                RectangleF rectf = new RectangleF(marginRect.X, Y - 10, marginRect.Width, hi);

                //gp.DrawString((i==0?_values[5]:"사상"), font, brushText, rectf, sf);
                if (_values[9] == "")
                    gp.DrawString("(함침) 대기", font, brushText, rectf, sf);
                else
                    gp.DrawString("(함침) 완료", font, brushText, rectf, sf);


                sf.Alignment = StringAlignment.Far;
                int wi = (int)(gp.MeasureString(_values[0], fontbarcode).Width) + 100;

                //★★★ 2D바코드변경(재발행 위치변경)
                rectf = new RectangleF(marginRect.X + marginRect.Width - wi - 50, Y + 33, wi, 25); //marginRect.X + marginRect.Width - wi, Y + 12, wi, 25

                gp.DrawString(_creprint + _values[0], font1, brushText, rectf, sf);
                rectf.Offset(0, 17);

                //★★★ 2D바코드변경(1D제거)
                //gp.DrawString("*" + _values[0] + "*", fontbarcode, brushText, rectf, sf);


                Y += hi + 20;
                int ihi = marginRect.Height / 2;
                int botMargin = 20;
                int shi = 70;
                int nhi = 25;
                Pen pen = new Pen(Color.Black, 1);
                Rectangle rect = new Rectangle(marginRect.X, Y, marginRect.Width, ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                gp.DrawRectangle(pen, rect);
                gp.DrawLine(pen, marginRect.X, Y + shi, marginRect.Width + marginRect.X, Y + shi);
                gp.DrawLine(pen, marginRect.X, Y + shi * 2, marginRect.Width + marginRect.X, Y + shi * 2);
                gp.DrawLine(pen, marginRect.X, Y + shi * 3, marginRect.Width + marginRect.X, Y + shi * 3);
                gp.DrawLine(pen, marginRect.X, Y + shi * 4, marginRect.Width + marginRect.X, Y + shi * 4);
                //gp.DrawLine(pen, marginRect.X, Y + shi * 5+5, marginRect.Width + marginRect.X, Y + shi * 5+5);
                //gp.DrawLine(pen, marginRect.X, Y + shi * 6+5, marginRect.Width + marginRect.X, Y + shi * 6+5);
                //gp.DrawLine(pen, marginRect.X, Y + shi * 7+5, marginRect.Width + marginRect.X, Y + shi * 7+5);

                gp.DrawLine(pen, marginRect.X + 110, Y, marginRect.X + 110, Y + ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                //gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y, marginRect.X + marginRect.Width / 2, Y + ihi - (marginRect.Y + 5 + hi + 20) - botMargin);

                //★★★ 2D바코드변경(세로라인 변경)
                gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y, marginRect.X + marginRect.Width / 2, Y + shi * 2);

                gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y + shi * 3, marginRect.X + marginRect.Width / 2, Y + ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y, marginRect.X + marginRect.Width / 2 + 110, Y + shi);
                gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 4, marginRect.X + marginRect.Width / 2 + 110, Y + ihi - (marginRect.Y + 5 + hi + 20) - botMargin);

                font = new Font("굴림체", 17, FontStyle.Regular);
                sf.Alignment = StringAlignment.Center;
                rectf.X = marginRect.X + 1;
                rectf.Y = Y + nhi;
                rectf.Width = 110;
                rectf.Height = (int)(gp.MeasureString("1", font).Height) + 5;
                gp.DrawString("차 종", font, brushText, rectf, sf);
                rectf.Y = Y + shi + nhi;
                gp.DrawString("품 번", font, brushText, rectf, sf);
                rectf.Y = Y + shi * 2 + nhi;
                gp.DrawString("품 명", font, brushText, rectf, sf);
                rectf.Y = Y + shi * 3 + nhi;
                gp.DrawString("수 량", font, brushText, rectf, sf);
                rectf.Y = Y + shi * 4 + nhi + 3;
                gp.DrawString("일 시", font, brushText, rectf, sf);

                rectf.X = marginRect.X + marginRect.Width / 2 + 1;
                rectf.Y = Y + nhi;
                if (_values[9] != "")
                    gp.DrawString("투입정보", font, brushText, rectf, sf);
                //rectf.Y = Y + shi * 2 + nhi;
                //gp.DrawString("공정명", font, brushText, rectf, sf);
                // --------------------> 공정명 제외
                //rectf.Y = Y + shi * 3 + nhi;
                //gp.DrawString("작업장", font, brushText, rectf, sf);
                rectf.Y = Y + shi * 4 + nhi + 3;
                gp.DrawString("작업자", font, brushText, rectf, sf);

                sf.Alignment = StringAlignment.Near;
                rectf.X = marginRect.X + 120;
                rectf.Y = Y + nhi;
                rectf.Width = marginRect.Width - 110;// marginRect.Width / 2 - 110;
                gp.DrawString(_values[1], font, brushText, rectf, sf);
                //    string[] vals = new string[] { lotNo, CarType, itemcode, ItemName, "함침", qty, LotCnt,mdt.ToString("yyyy-MM-dd HH:mm:ss"), Worker };

                rectf.Y = Y + shi + nhi;
                gp.DrawString(_values[2], font5, brushText, rectf, sf);
                rectf.Y = Y + shi * 2 + nhi - 2;
                gp.DrawString(_values[3], font3, brushText, rectf, sf);
                rectf.Y = Y + shi * 3 + nhi;
                gp.DrawString(_values[5], font, brushText, rectf, sf);
                rectf.Y = Y + shi * 4 + nhi + 3;
                gp.DrawString(_values[7], font4, brushText, rectf, sf);
                //if (i == 0)
                //{
                //    rectf.Y = Y + shi * 6 + nhi + 5;
                //    gp.DrawString(_values[14], font, brushText, rectf, sf);
                //}
                //rectf.Y = Y + shi * 7 + nhi+10;
                //wi = (int)(gp.MeasureString(_values[15], fontbarcode).Width) + 100;
                //rectf.Width = wi;
                //gp.DrawString("*"+_values[15]+"*", fontbarcode, brushText, rectf, sf);
                //// rectf.X += wi;
                //rectf.Y = Y + shi * 7 + nhi+39;
                //// wi = (int)(gp.MeasureString(_values[15], font1).Width) + 2;
                //sf.Alignment = StringAlignment.Near;
                //gp.DrawString(_values[15], font1, brushText, rectf, sf);

                sf.Alignment = StringAlignment.Near;
                rectf.X = marginRect.X + marginRect.Width / 2 + 120;
                if (_values[9] != "")
                {
                    rectf.Y = Y + 12;
                    gp.DrawString(_values[9], font2, brushText, rectf, sf);
                    rectf.Y = Y + 37;
                    gp.DrawString(_values[10], font2, brushText, rectf, sf);
                }
                rectf.X = marginRect.X + marginRect.Width / 2 + 33;
                rectf.Y = Y + shi + nhi;
                wi = (int)(gp.MeasureString(_values[2], fontbarcode).Width) + 150;
                rectf.Width = wi;

                //★★★ 2D바코드변경(1D제거))
                gp.DrawString("*" + _values[0] + "*", fontbarcode, brushText, rectf, sf);
                //gp.DrawString("*" + _values[2] + "*", fontbarcode, brushText, rectf, sf); 2016.06.23 by PWR 품번바코드 -> LOT 바코드 수정


                rectf.X = marginRect.X + marginRect.Width / 2 + 120;
                // rectf.Y = Y + 0 + nhi;
                // gp.DrawString(_values[2], font, brushText, rectf, sf);
                //rectf.Y = Y + shi * 2 + nhi;
                //gp.DrawString(_values[4], font, brushText, rectf, sf);
                // --------------> 공정명 : 함침 제외

                rectf.Y = Y + shi * 4 + nhi + 3;
                gp.DrawString(_values[8], font, brushText, rectf, sf);

                rectf.X = marginRect.X + marginRect.Width / 2 + 3;
                rectf.Y = Y + shi + 18;
                rectf.Y = Y + shi * 3 + nhi - 3;
                gp.DrawString(_values[6], font3, brushText, rectf, sf);

                if (i == 0 && pages == 2)
                {
                    pen = new Pen(Color.LightGray, 1);
                    gp.DrawLine(pen, 0, marginRect.Y + marginRect.Height / 2, marginRect.X + marginRect.Width + marginRect.Right, marginRect.Y + marginRect.Height / 2);
                }
            }
        }

        void report4(Graphics gp, Rectangle marginRect)
        {
            int pages = 2;

            try
            {
                pages = lotPrnCnt;// Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["prnPage"]);
            }
            catch { }
            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile("3of9_new.ttf");//"Code3x-hans4u.ttf");//("FREE3OF9.ttf");
            Font fontbarcode = new Font(privateFonts.Families[0], 18f);
            Font fontbarcode1 = new Font(privateFonts.Families[0], 36f);

            for (int i = 0; i < pages; i++)
            {
                if (string.IsNullOrEmpty(_values[19]) || _values[19] == "SK1")
                {
                    #region TODO : 이런 로직은 진짜 싫다

                    if (i == 1)
                    {
                        gp.TranslateTransform(marginRect.Right + marginRect.Left, marginRect.Bottom + marginRect.Top);
                        gp.RotateTransform(180);
                    }
                    int Y = marginRect.Y + 15;

                    //2D로트 변경
                    Image image = Image.FromFile("Logo-s.png");
                    Rectangle destRect = new Rectangle(marginRect.X + 50, Y + 10, 120, 35);  // marginRect.X, Y, 120, 35
                    gp.DrawImage(image, destRect);
                    Rectangle fRect = new Rectangle(marginRect.X - 10, Y + 5, 55, 50);
                    gp.DrawImage(_barImg, fRect);
                    Rectangle rRect = new Rectangle(marginRect.X + marginRect.Width - 45, Y + 5, 55, 50);
                    gp.DrawImage(_barImg, rRect);


                    Font font = new Font("굴림체", 18, FontStyle.Bold);
                    Font font1 = new Font("굴림체", 10, FontStyle.Bold);
                    Font font2 = new Font("굴림체", 16, FontStyle.Regular);
                    Font font3 = new Font("HY견고딕", 33, FontStyle.Bold);
                    Font font4 = new Font("HY견고딕", 17, FontStyle.Bold);
                    Font font5 = new Font("HY견고딕", 15, FontStyle.Bold);
                    Font lot_font = new Font("굴림체", 36, FontStyle.Bold);  //fontbarcode1 -> lot_font 로 변경(barcode를 lot number로 변경)
                    SolidBrush brushText = new SolidBrush(Color.Black);
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    int hi = (int)(gp.MeasureString("123", font, 100, sf).Height) + 5;

                    RectangleF rectf = new RectangleF(marginRect.X, Y, marginRect.Width, hi);

                    //gp.DrawString((i==0?_values[5]:"사상"), font, brushText, rectf, sf);
                    gp.DrawString("(" + (i == 0 ? ctype : "사상") + ") LOT카드", font, brushText, rectf, sf);

                    sf.Alignment = StringAlignment.Far;
                    int wi = (int)(gp.MeasureString(_values[0], fontbarcode).Width) + 100;

                    //2D로트 변경
                    rectf = new RectangleF(marginRect.X + marginRect.Width - wi - 50, Y + 30, wi, 20); //marginRect.X + marginRect.Width - wi, Y + 9, wi, 20

                    gp.DrawString(_creprint + _values[0], font1, brushText, rectf, sf);
                    rectf.Offset(0, 17);
                    //gp.DrawString("*" + _values[0] + "*", fontbarcode, brushText, rectf, sf);



                    Y += hi + 20;
                    int ihi = marginRect.Height / 2;
                    int botMargin = 10;
                    int shi = 47;
                    int nhi = 10;
                    Pen pen = new Pen(Color.Black, 1);
                    Rectangle rect = new Rectangle(marginRect.X, Y, marginRect.Width, ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                    gp.DrawRectangle(pen, rect);
                    gp.DrawLine(pen, marginRect.X, Y + shi, marginRect.Width + marginRect.X, Y + shi);
                    gp.DrawLine(pen, marginRect.X, Y + shi * 2, marginRect.Width + marginRect.X, Y + shi * 2);
                    gp.DrawLine(pen, marginRect.X, Y + shi * 3, marginRect.Width + marginRect.X, Y + shi * 3);
                    gp.DrawLine(pen, marginRect.X, Y + shi * 4, marginRect.Width + marginRect.X, Y + shi * 4);
                    gp.DrawLine(pen, marginRect.X, Y + shi * 5, marginRect.Width + marginRect.X, Y + shi * 5);
                    gp.DrawLine(pen, marginRect.X, Y + shi * 6, marginRect.Width + marginRect.X, Y + shi * 6);
                    gp.DrawLine(pen, marginRect.X, Y + shi * 7 + 5, marginRect.Width + marginRect.X, Y + shi * 7 + 5);

                    gp.DrawLine(pen, marginRect.X + 110, Y, marginRect.X + 110, Y + ihi - (marginRect.Y + 5 + hi + 20) - botMargin);

                    //2D로트 변경
                    gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y, marginRect.X + marginRect.Width / 2, Y + shi * 2); 

                    gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y + shi * 3, marginRect.X + marginRect.Width / 2, Y + shi * 6);
                    gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y, marginRect.X + marginRect.Width / 2 + 110, Y + shi);
                    gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 3, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 4);
                    gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 5, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 6);

                    font = new Font("굴림체", 17, FontStyle.Regular);
                    sf.Alignment = StringAlignment.Center;
                    rectf.X = marginRect.X + 1;
                    rectf.Y = Y + nhi + 2;
                    rectf.Width = 110;
                    rectf.Height = (int)(gp.MeasureString("1", font).Height) + 5;
                    gp.DrawString("차 종", font, brushText, rectf, sf);
                    rectf.Y = Y + shi + nhi + 2;
                    gp.DrawString("품 번", font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 2 + nhi + 2;
                    gp.DrawString("품 명", font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 3 + nhi + 2;
                    gp.DrawString("수 량", font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 4 + nhi + 2;
                    gp.DrawString("주/야", font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 5 + nhi + 2;
                    gp.DrawString("일 시", font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 6 + nhi + 5;
                    gp.DrawString("투입정보", font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 7 + nhi + 9;
                    gp.DrawString("Lot No", font, brushText, rectf, sf);

                    rectf.X = marginRect.X + marginRect.Width / 2 + 1;
                    rectf.Y = Y + nhi + 2;
                    gp.DrawString("형 번", font, brushText, rectf, sf);
                    //rectf.Y = Y + shi * 2 + nhi;
                    //gp.DrawString("공정명", font, brushText, rectf, sf);
                    // ---------------> 사상 Lot Card 공정명 제외
                    rectf.Y = Y + shi * 3 + nhi + 2;
                    gp.DrawString("불 량", font, brushText, rectf, sf);
                    //rectf.Y = Y + shi * 4 + nhi + 2;
                    //gp.DrawString("작업장", font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 5 + nhi + 2;
                    gp.DrawString("작업자", font, brushText, rectf, sf);

                    sf.Alignment = StringAlignment.Near;
                    rectf.X = marginRect.X + 120;
                    rectf.Y = Y + nhi + 2;
                    rectf.Width = marginRect.Width - 110;// marginRect.Width / 2 - 110;
                    gp.DrawString(_values[1], font, brushText, rectf, sf);
                    //  string[] vals = new string[] { "1234567890ASDF", "A6GF1", "SK-14", "45321-26001-20", "COVER-RAR(주조)", "주조", "360EA", "0EA", "A-200EA", "B-160EA", "A-윤주노", "B-곽호걸", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "B-#1", "사상", "12345678901234567890asdfg" };

                    rectf.Y = Y + shi + nhi + 4;
                    gp.DrawString(_values[3], font5, brushText, rectf, sf);
                    rectf.Y = Y + shi * 2 + nhi + 2;
                    gp.DrawString(_values[4], font4, brushText, rectf, sf);
                    //if (i == 0)
                    //{
                    //    rectf.Y = Y + shi * 3 + nhi;
                    //    gp.DrawString(_values[6], font, brushText, rectf, sf);
                    //}

                    rectf.Y = Y + shi * 3 + nhi + 2;
                    gp.DrawString(_values[6], font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 4 + nhi + 2;
                    gp.DrawString(_values[8], font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 4 + nhi + 2;
                    gp.DrawString(_values[9], font, brushText, rectf, sf);
                    rectf.Y = Y + shi * 5 + nhi + 2;
                    gp.DrawString(_values[12], font2, brushText, rectf, sf);
                    //if (i == 0)
                    //{
                    rectf.Width = marginRect.Width - 110;
                    rectf.Y = Y + shi * 6 + nhi + 5;
                    gp.DrawString(_values[18], font, brushText, rectf, sf);
                    //}
                    //rectf.Y = Y + shi * 7 + nhi + 10;
                    //wi = (int)(gp.MeasureString(_values[15], fontbarcode).Width) + 100;
                    //rectf.Width = wi;
                    //gp.DrawString("*" + _values[15] + "*", fontbarcode, brushText, rectf, sf);
                    //// rectf.X += wi;
                    //rectf.Y = Y + shi * 7 + nhi + 39;
                    //// wi = (int)(gp.MeasureString(_values[15], font1).Width) + 2;
                    //sf.Alignment = StringAlignment.Near;
                    //gp.DrawString(_values[15], font1, brushText, rectf, sf);
                    rectf.Y = Y + shi * 7 + nhi - 3;
                    wi = (int)(gp.MeasureString(_values[0], lot_font).Width) + 150;
                    //wi = (int)(gp.MeasureString(_values[0], fontbarcode1).Width) + 150; 2016.06.23 by PWR 바코드 -> LOT NUMBER 수정
                    rectf.Width = wi;
                    rectf.Height += 20;
                    gp.DrawString("*" + _values[0] + "*", lot_font, brushText, rectf, sf);
                    //gp.DrawString("*" + _values[0] + "*", fontbarcode1, brushText, rectf, sf);2016.06.23 by PWR 바코드 -> LOT NUMBER 수정

                    sf.Alignment = StringAlignment.Near;

                    rectf.X = marginRect.X + marginRect.Width / 2 + 33;
                    rectf.Y = Y + shi + 14;
                    wi = (int)(gp.MeasureString(_values[3], fontbarcode).Width) + 150;
                    rectf.Width = wi;

                    //2D로트 변경
                    gp.DrawString("*" + _values[0] + "*", fontbarcode, brushText, rectf, sf);
                    //gp.DrawString("*" + _values[3] + "*", fontbarcode, brushText, rectf, sf); 2016.06.23 by PWR 품번바코드 -> LOT 바코드 수정


                    rectf.X = marginRect.X + marginRect.Width / 2 + 120;
                    rectf.Y = Y + 0 + nhi - 7;
                    gp.DrawString(_values[2], font3, brushText, rectf, sf);
                    //rectf.Y = Y + shi * 2 + nhi;
                    //gp.DrawString((i == 0 ? _values[5] : "사상"), font, brushText, rectf, sf);
                    // -----------------> 공정명 - 사상 제외 
                    //if (i == 0)
                    //{
                    rectf.Y = Y + shi * 3 + nhi + 2;
                    gp.DrawString(_values[7], font, brushText, rectf, sf);
                    //}

                    //if (i == 0)
                    //{
                    //    rectf.Y = Y + shi * 3 + nhi;
                    //    gp.DrawString(_values[6], font, brushText, rectf, sf);
                    //}

                    rectf.Y = Y + shi * 4 + nhi + 2;
                    gp.DrawString(_values[11], font4, brushText, rectf, sf);
                    rectf.Y = Y + shi * 5 + nhi + 2;
                    gp.DrawString(_values[13], font, brushText, rectf, sf);

                    rectf.X = marginRect.X + marginRect.Width / 2 + 3;
                    rectf.Y = Y + shi + 18;
                    if (i == 0)
                    {
                        rectf.Y = Y + shi * 4 + nhi + 2;
                        gp.DrawString(_values[10], font4, brushText, rectf, sf);
                    } // 작업장

                    //if (i == 0 && pages == 2)
                    //{
                    //   pen = new Pen(Color.LightGray, 1);
                    //   gp.DrawLine(pen, 0, marginRect.Y + marginRect.Height / 2, marginRect.X + marginRect.Width + marginRect.Right, marginRect.Y + marginRect.Height / 2);
                    //}

                    #endregion

                }
                else
                {
                    if (i == 0)
                    {
                        int Y = marginRect.Y + 15;


                        //2d변경 수정
                        Image image = Image.FromFile("Logo-s.png");
                        Rectangle destRect = new Rectangle(marginRect.X + 50, Y + 10, 120, 35);  // marginRect.X, Y, 120, 35
                        gp.DrawImage(image, destRect);
                        Rectangle fRect = new Rectangle(marginRect.X - 10, Y + 5, 55, 50);
                        gp.DrawImage(_barImg, fRect);
                        Rectangle rRect = new Rectangle(marginRect.X + marginRect.Width - 45, Y + 5, 55, 50);
                        gp.DrawImage(_barImg, rRect);

                        Font font = new Font("굴림체", 18, FontStyle.Bold);
                        Font font1 = new Font("굴림체", 10, FontStyle.Bold);
                        Font font2 = new Font("굴림체", 16, FontStyle.Regular);
                        Font font3 = new Font("HY견고딕", 33, FontStyle.Bold);
                        Font font4 = new Font("HY견고딕", 17, FontStyle.Bold);
                        Font font5 = new Font("HY견고딕", 15, FontStyle.Bold);
                        Font lot_font = new Font("굴림체", 36, FontStyle.Bold); //fontbarcode1 -> lot_font 로 변경(barcode를 lot number로 변경)
                        SolidBrush brushText = new SolidBrush(Color.Black);
                        StringFormat sf = new StringFormat();
                        sf.Alignment = StringAlignment.Center;
                        int hi = (int)(gp.MeasureString("123", font, 100, sf).Height) + 5;

                        RectangleF rectf = new RectangleF(marginRect.X, Y, marginRect.Width, hi);

                        //gp.DrawString((i==0?_values[5]:"사상"), font, brushText, rectf, sf);
                        gp.DrawString("(" + (i == 0 ? ctype : "사상") + ") LOT카드", font, brushText, rectf, sf);

                        sf.Alignment = StringAlignment.Far;
                        int wi = (int)(gp.MeasureString(_values[0], fontbarcode).Width) + 100;

                        //2d변경 수정
                        rectf = new RectangleF(marginRect.X + marginRect.Width - wi - 50, Y + 30, wi, 20); //marginRect.X + marginRect.Width - wi, Y + 9, wi, 20

                        gp.DrawString(_creprint + _values[0], font1, brushText, rectf, sf);
                        rectf.Offset(0, 17);

                        //gp.DrawString("*" + _values[0] + "*", fontbarcode, brushText, rectf, sf);

                        Y += hi + 20;
                        int ihi = marginRect.Height / 2;
                        int botMargin = 10;
                        int shi = 47;
                        int nhi = 10;
                        Pen pen = new Pen(Color.Black, 1);
                        Rectangle rect = new Rectangle(marginRect.X, Y, marginRect.Width, ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                        gp.DrawRectangle(pen, rect);
                        gp.DrawLine(pen, marginRect.X, Y + shi, marginRect.Width + marginRect.X, Y + shi);
                        gp.DrawLine(pen, marginRect.X, Y + shi * 2, marginRect.Width + marginRect.X, Y + shi * 2);
                        gp.DrawLine(pen, marginRect.X, Y + shi * 3, marginRect.Width + marginRect.X, Y + shi * 3);
                        gp.DrawLine(pen, marginRect.X, Y + shi * 4, marginRect.Width + marginRect.X, Y + shi * 4);
                        gp.DrawLine(pen, marginRect.X, Y + shi * 5, marginRect.Width + marginRect.X, Y + shi * 5);
                        gp.DrawLine(pen, marginRect.X, Y + shi * 6, marginRect.Width + marginRect.X, Y + shi * 6);
                        gp.DrawLine(pen, marginRect.X, Y + shi * 7 + 5, marginRect.Width + marginRect.X, Y + shi * 7 + 5);

                        gp.DrawLine(pen, marginRect.X + 110, Y, marginRect.X + 110, Y + ihi - (marginRect.Y + 5 + hi + 20) - botMargin);

                        //2d변경 수정
                        gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y, marginRect.X + marginRect.Width / 2, Y + shi *2); // Y + shi * 2

                        gp.DrawLine(pen, marginRect.X + marginRect.Width / 2, Y + shi * 3, marginRect.X + marginRect.Width / 2, Y + shi * 6);
                        gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y, marginRect.X + marginRect.Width / 2 + 110, Y + shi);
                        gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 3, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 4);
                        gp.DrawLine(pen, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 5, marginRect.X + marginRect.Width / 2 + 110, Y + shi * 6);

                        font = new Font("굴림체", 17, FontStyle.Regular);
                        sf.Alignment = StringAlignment.Center;
                        rectf.X = marginRect.X + 1;
                        rectf.Y = Y + nhi + 2;
                        rectf.Width = 110;
                        rectf.Height = (int)(gp.MeasureString("1", font).Height) + 5;
                        gp.DrawString("차 종", font, brushText, rectf, sf);
                        rectf.Y = Y + shi + nhi + 2;
                        gp.DrawString("품 번", font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 2 + nhi + 2;
                        gp.DrawString("품 명", font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 3 + nhi + 2;
                        gp.DrawString("수 량", font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 4 + nhi + 2;
                        gp.DrawString("주/야", font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 5 + nhi + 2;
                        gp.DrawString("일 시", font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 6 + nhi + 5;
                        gp.DrawString("투입정보", font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 7 + nhi + 9;
                        gp.DrawString("Lot No", font, brushText, rectf, sf);

                        rectf.X = marginRect.X + marginRect.Width / 2 + 1;
                        rectf.Y = Y + nhi + 2;
                        gp.DrawString("형 번", font, brushText, rectf, sf);
                        //rectf.Y = Y + shi * 2 + nhi;
                        //gp.DrawString("공정명", font, brushText, rectf, sf);
                        // ---------------> 사상 Lot Card 공정명 제외
                        rectf.Y = Y + shi * 3 + nhi + 2;
                        gp.DrawString("불 량", font, brushText, rectf, sf);
                        //rectf.Y = Y + shi * 4 + nhi + 2;
                        //gp.DrawString("작업장", font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 5 + nhi + 2;
                        gp.DrawString("작업자", font, brushText, rectf, sf);

                        sf.Alignment = StringAlignment.Near;
                        rectf.X = marginRect.X + 120;
                        rectf.Y = Y + nhi + 2;
                        rectf.Width = marginRect.Width - 110;// marginRect.Width / 2 - 110;
                        gp.DrawString(_values[1], font, brushText, rectf, sf);
                        //  string[] vals = new string[] { "1234567890ASDF", "A6GF1", "SK-14", "45321-26001-20", "COVER-RAR(주조)", "주조", "360EA", "0EA", "A-200EA", "B-160EA", "A-윤주노", "B-곽호걸", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "B-#1", "사상", "12345678901234567890asdfg" };

                        rectf.Y = Y + shi + nhi + 4;
                        gp.DrawString(_values[3], font5, brushText, rectf, sf);
                        rectf.Y = Y + shi * 2 + nhi + 2;
                        gp.DrawString(_values[4], font4, brushText, rectf, sf);
                        //if (i == 0)
                        //{
                        //    rectf.Y = Y + shi * 3 + nhi;
                        //    gp.DrawString(_values[6], font, brushText, rectf, sf);
                        //}

                        rectf.Y = Y + shi * 3 + nhi + 2;
                        gp.DrawString(_values[6], font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 4 + nhi + 2;
                        gp.DrawString(_values[8], font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 4 + nhi + 2;
                        gp.DrawString(_values[9], font, brushText, rectf, sf);
                        rectf.Y = Y + shi * 5 + nhi + 2;
                        gp.DrawString(_values[12], font2, brushText, rectf, sf);
                        //if (i == 0)
                        //{
                        rectf.Width = marginRect.Width - 110;
                        rectf.Y = Y + shi * 6 + nhi + 5;
                        gp.DrawString(_values[18], font, brushText, rectf, sf);
                        //}
                        //rectf.Y = Y + shi * 7 + nhi + 10;
                        //wi = (int)(gp.MeasureString(_values[15], fontbarcode).Width) + 100;
                        //rectf.Width = wi;
                        //gp.DrawString("*" + _values[15] + "*", fontbarcode, brushText, rectf, sf);
                        //// rectf.X += wi;
                        //rectf.Y = Y + shi * 7 + nhi + 39;
                        //// wi = (int)(gp.MeasureString(_values[15], font1).Width) + 2;
                        //sf.Alignment = StringAlignment.Near;
                        //gp.DrawString(_values[15], font1, brushText, rectf, sf);
                        rectf.Y = Y + shi * 7 + nhi - 3;
                        wi = (int)(gp.MeasureString(_values[0], lot_font).Width) + 150;
                        //wi = (int)(gp.MeasureString(_values[0], fontbarcode1).Width) + 150; 2016.06.23 by PWR 바코드 -> LOT NUMBER 수정
                        rectf.Width = wi;
                        rectf.Height += 20;
                        gp.DrawString("*" + _values[0] + "*", lot_font, brushText, rectf, sf);
                        //gp.DrawString("*" + _values[0] + "*", fontbarcode1, brushText, rectf, sf);2016.06.23 by PWR 바코드 -> LOT NUMBER 수정

                        sf.Alignment = StringAlignment.Near;

                        rectf.X = marginRect.X + marginRect.Width / 2 + 33;
                        rectf.Y = Y + shi + 14;
                        wi = (int)(gp.MeasureString(_values[3], fontbarcode).Width) + 150;
                        rectf.Width = wi;

                        //2D로트 변경
                        gp.DrawString("*" + _values[0] + "*", fontbarcode, brushText, rectf, sf);
                        //gp.DrawString("*" + _values[3] + "*", fontbarcode, brushText, rectf, sf); 2016.06.23 by PWR 품번바코드 -> LOT 바코드 수정

                        rectf.X = marginRect.X + marginRect.Width / 2 + 120;
                        rectf.Y = Y + 0 + nhi - 7;
                        gp.DrawString(_values[2], font3, brushText, rectf, sf);
                        //rectf.Y = Y + shi * 2 + nhi;
                        //gp.DrawString((i == 0 ? _values[5] : "사상"), font, brushText, rectf, sf);
                        // -----------------> 공정명 - 사상 제외 
                        //if (i == 0)
                        //{
                        rectf.Y = Y + shi * 3 + nhi + 2;
                        gp.DrawString(_values[7], font, brushText, rectf, sf);
                        //}

                        //if (i == 0)
                        //{
                        //    rectf.Y = Y + shi * 3 + nhi;
                        //    gp.DrawString(_values[6], font, brushText, rectf, sf);
                        //}

                        rectf.Y = Y + shi * 4 + nhi + 2;
                        gp.DrawString(_values[11], font4, brushText, rectf, sf);
                        rectf.Y = Y + shi * 5 + nhi + 2;
                        gp.DrawString(_values[13], font, brushText, rectf, sf);

                        rectf.X = marginRect.X + marginRect.Width / 2 + 3;
                        rectf.Y = Y + shi + 18;
                        if (i == 0)
                        {
                            rectf.Y = Y + shi * 4 + nhi + 2;
                            gp.DrawString(_values[10], font4, brushText, rectf, sf);
                        } // 작업장

                        //if (i == 0 && pages == 2)
                        //{
                        //   pen = new Pen(Color.LightGray, 1);
                        //   gp.DrawLine(pen, 0, marginRect.Y + marginRect.Height / 2, marginRect.X + marginRect.Width + marginRect.Right, marginRect.Y + marginRect.Height / 2);
                        //}
                    }
                    /*
                    else
                    {
                       gp.TranslateTransform(marginRect.Right + marginRect.Left, marginRect.Bottom + marginRect.Top);
                       gp.RotateTransform(180);

                       int Y = marginRect.Y + 15;
                       Font font = new Font("굴림체", 80, FontStyle.Bold);

                       SolidBrush brushText = new SolidBrush(Color.Black);
                       StringFormat sf = new StringFormat();
                       sf.Alignment = StringAlignment.Center;
                       int hi = (int)(gp.MeasureString(string.Empty, font, 100, sf).Height) + 5;

                       Y += hi + 20;
                       int ihi = marginRect.Height / 2;
                       int botMargin = 10;
                       Pen pen = new Pen(Color.Black, 3);
                       Rectangle rect = new Rectangle(marginRect.X, Y, marginRect.Width, ihi - (marginRect.Y + 5 + hi + 20) - botMargin);
                       gp.DrawRectangle(pen, rect);

                       gp.ResetTransform();

                       Font font1 = new Font("굴림체", 30, FontStyle.Bold);

                       Rectangle rect1 = new Rectangle(5, 650, 450, 500);
                       gp.DrawString(_values[3], font1, brushText, rect1, sf);

                       Rectangle rect2 = new Rectangle(5, 650, 1300, 500);
                       gp.DrawString(_values[6], font1, brushText, rect2, sf);

                       Rectangle rect3 = new Rectangle(marginRect.X, 810, marginRect.Width, 500);
                       gp.DrawString(_values[2], font, brushText, rect3, sf);
                    }
                    */
                    // -----------------------------------> 서산 사상 2번째 page 형번 제외
                }
            }
        }

        void report5(Graphics gp, Rectangle marginRect)
        {
            gp.TranslateTransform(marginRect.Width, 0);
            gp.RotateTransform(90);


            int mgX = 20;
            int mgY = 20;

            int H_W = marginRect.Height / 2;
            int H_H = marginRect.Width / 2;
            int R_W = marginRect.Height / 2 - mgY * 2;
            int R_H = marginRect.Width / 2 - mgX * 2;

            int X_L = marginRect.Y + mgY;
            int X_R = marginRect.Y + H_W + mgY;
            int Y_T = marginRect.X + mgX;
            int Y_B = marginRect.X + H_H + mgX;
            int X_L1 = X_L;

            Pen pen = new Pen(Color.LightGray, 1);
            //gp.DrawLine(pen, 0, marginRect.Y + H_H, marginRect.X + marginRect.Width + marginRect.Right, marginRect.Y + H_H);
            //gp.DrawLine(pen, marginRect.Y + H_W, 0, marginRect.Y + H_W, marginRect.X + marginRect.Width + marginRect.Right);

            for (int i = 0; i < 4; i++)
            {
                if (_values[i] == "")
                {
                    break;
                }
                if (i == 1)
                {
                    X_L = X_R;
                }
                if (i == 2)
                {
                    X_L = X_L1;
                    Y_T = Y_B;
                }
                if (i == 3)
                {
                    X_L = X_R;
                    Y_T = Y_B;
                }

                //Image image = Image.FromFile("ci_page.png");
                //Rectangle destRect = new Rectangle(X_L, Y_T, 120, 35);
                //gp.DrawImage(image, destRect);


                //★★★ 2D바코드변경(로고변경, 2D변경)
                Image image = Image.FromFile("Logo-s.png");
                Rectangle destRect = new Rectangle(X_L, Y_T, 120, 35);  // marginRect.X, Y, 120, 35
                gp.DrawImage(image, destRect);
                Rectangle fRect = new Rectangle(marginRect.X - 10, Y_T + 5, 55, 50);
                gp.DrawImage(_barImg, fRect);
                Rectangle rRect = new Rectangle(marginRect.X + marginRect.Width - 45, Y_T + 5, 55, 50);
                gp.DrawImage(_barImg, rRect);


                Font fontH = new Font("굴림체", 18, FontStyle.Bold);
                SolidBrush brushText = new SolidBrush(Color.Black);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                int hi = (int)(gp.MeasureString("123", fontH, 100, sf).Height) + 5;
                RectangleF rectf = new RectangleF(X_L, Y_T, R_W, hi);
                //  gp.DrawString("(" + _values[12] + ") LOT카드", fontH, brushText, rectf, sf);
                gp.DrawString("LOT카드", fontH, brushText, rectf, sf);

                System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
                privateFonts.AddFontFile("3of9_new.ttf");//"Code3x-hans4u.ttf");//("FREE3OF9.ttf");
                Font fontbarcode = new Font(privateFonts.Families[0], 18f);

                sf.Alignment = StringAlignment.Far;
                int wi = (int)(gp.MeasureString(_values[i], fontbarcode).Width) + 150;

                rectf = new RectangleF(X_L, Y_T + 10, R_W, 20);
                Font font1 = new Font("굴림체", 10, FontStyle.Bold);
                gp.DrawString(_creprint + _values[i], font1, brushText, rectf, sf);
                rectf.Offset(0, 17);

                //★★★ 2D바코드변경(1D제거)
                //gp.DrawString("*" + _values[i] + "*", fontbarcode, brushText, rectf, sf);

                int shi = 38;
                int chi = 55;

                pen = new Pen(Color.Black, 3);
                Rectangle rect = new Rectangle(X_L, Y_T + chi, R_W, R_H - chi);
                gp.DrawRectangle(pen, rect);
                gp.DrawLine(pen, X_L, Y_T + chi + shi, X_L + R_W, Y_T + chi + shi);
                gp.DrawLine(pen, X_L, Y_T + chi + shi * 2, X_L + R_W, Y_T + chi + shi * 2);
                gp.DrawLine(pen, X_L, Y_T + chi + shi * 3, X_L + R_W, Y_T + chi + shi * 3);
                gp.DrawLine(pen, X_L, Y_T + chi + shi * 4, X_L + R_W, Y_T + chi + shi * 4);
                gp.DrawLine(pen, X_L, Y_T + chi + shi * 5, X_L + R_W, Y_T + chi + shi * 5);
                gp.DrawLine(pen, X_L, Y_T + chi + shi * 6, X_L + R_W, Y_T + chi + shi * 6);
                gp.DrawLine(pen, X_L, Y_T + chi + shi * 7, X_L + R_W, Y_T + chi + shi * 7);
                gp.DrawLine(pen, X_L + 120, Y_T + chi, X_L + 120, Y_T + R_H);

                int nhi = 5;
                Font font = new Font("굴림체", 14, FontStyle.Bold);
                sf.Alignment = StringAlignment.Center;
                rectf.X = X_L + 1;
                rectf.Y = Y_T + chi + nhi;
                rectf.Width = 120;
                rectf.Height = (int)(gp.MeasureString("1", font).Height) + 5;
                gp.DrawString("차 종", font, brushText, rectf, sf);
                rectf.Offset(0, shi);
                gp.DrawString("품 번", font, brushText, rectf, sf);
                rectf.Offset(0, shi);
                gp.DrawString("품 명", font, brushText, rectf, sf);
                rectf.Offset(0, shi);
                gp.DrawString("수 량", font, brushText, rectf, sf);
                rectf.Offset(0, shi);
                gp.DrawString("주/야", font, brushText, rectf, sf);
                rectf.Offset(0, shi);
                gp.DrawString("일 시", font, brushText, rectf, sf);
                rectf.Offset(0, shi);
                gp.DrawString("작업자", font, brushText, rectf, sf);
                rectf.Offset(0, shi);
                gp.DrawString("발행번호", font, brushText, rectf, sf);

                sf.Alignment = StringAlignment.Near;
                rectf.X = X_L + 123;
                rectf.Y = Y_T + chi + nhi;
                rectf.Width = R_W - 124;
                gp.DrawString(_values[13], font, brushText, rectf, sf);
                rectf.Offset(0, shi);
                gp.DrawString(_values[14], font, brushText, rectf, sf);
                // wi = (int)(gp.MeasureString(_values[15], fontbarcode).Width) + 150;
                // rectf.Width = wi;
                sf.Alignment = StringAlignment.Far;
                gp.DrawString("*" + _values[14] + "*", fontbarcode, brushText, rectf, sf);
                sf.Alignment = StringAlignment.Near;
                rectf.Offset(0, shi);
                gp.DrawString(_values[15], font, brushText, rectf, sf);
                rectf.Offset(0, shi);
                gp.DrawString(_values[4 + i], font, brushText, rectf, sf); //수량
                rectf.Offset(0, shi);
                gp.DrawString(_values[16], font, brushText, rectf, sf);
                rectf.Offset(0, shi);
                gp.DrawString(_values[17], font, brushText, rectf, sf);
                rectf.Offset(0, shi);
                gp.DrawString(_values[18], font, brushText, rectf, sf);
                rectf.Offset(0, shi);
                gp.DrawString(_values[19] + " #" + _values[8 + i], font, brushText, rectf, sf);

            }

        }

        void report6(Graphics gp, Rectangle marginRect)
        {

            int Y = marginRect.Y + 15;

            Font font = new Font("굴림체", 14, FontStyle.Regular);
            SolidBrush brushText = new SolidBrush(Color.Black);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            int hi = (int)(gp.MeasureString("123", font, 100, sf).Height) + 5;

            RectangleF rect = new RectangleF(marginRect.X, Y, marginRect.Width, hi);
            string[] avars = _values[0].Split('|');

            foreach (string cv in avars)
            {
                gp.DrawString(cv, font, brushText, rect, sf);
                rect.Y += 30;
            }

        }
    }

}