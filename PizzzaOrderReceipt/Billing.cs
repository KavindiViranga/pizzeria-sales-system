using PizzzaOrderReceipt;
using System.Drawing.Configuration;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace PizzaOrderReceipt
{
    public partial class Billing : Form
    {
        Functions Con;

        PrintDocument printDocument1 = new PrintDocument();
        PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        public Billing()
        {
            Con = new Functions();
            InitializeComponent();

            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();
            this.Hide();
        }
        int Key = 0;
        int Price = 0;

        private void GetPrice(int Key)
        {
            string Pizza = "";
            if (Key == 1)
            {
                Pizza = "Small";
            }
            else if (Key == 2)
            {
                Pizza = "Medium";
            }
            else if (Key == 3)
            {
                Pizza = "Large";
            }
            else if (Key == 4)
            {
                Pizza = "Extra Large";
            }

            string Query = "select * from PizzaTbl where Item = '{0}'";
            Query = string.Format(Query, Pizza);
            Price = Convert.ToInt32(Con.GetData(Query).Rows[0][1].ToString());


        }
        int n = 0;
        string Items;
        private void OrderBtn_Click(object sender, EventArgs e)
        {

            OrderBtn.BackColor = Color.Green;

            if (SmallBtn.Checked == true)
            {
                Key = 1;
                Items = "Small Pizza";
            }
            else if (MediumBtn.Checked == true)
            {
                Key = 2;
                Items = "Medium Pizza";
            }
            else if (LargeBtn.Checked == true)
            {
                Key = 3;
                Items = "Large Pizza";
            }
            else if (ExtraLargeBtn.Checked == true)
            {
                Key = 4;
                Items = "Extra Large Pizza";
            }

            GetPrice(Key);

            int Qty = Convert.ToInt32(QtyTb.Text);
            int total = Qty * Price;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(BillDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = Items;
            newRow.Cells[2].Value = Price;
            newRow.Cells[3].Value = QtyTb.Text;
            newRow.Cells[4].Value = total;
            BillDGV.Rows.Add(newRow);
            n++;
            GrdTotal = GrdTotal + total;
            GrdTotalLbl.Text = "Rs " + GrdTotal;

            System.Windows.Forms.Timer revertColorTimer = new System.Windows.Forms.Timer();
            revertColorTimer.Interval = 500; // 500 milliseconds (adjust as needed)
            revertColorTimer.Tick += (s, args) =>
            {
                OrderBtn.BackColor = Color.OrangeRed; // Revert to the default color
                revertColorTimer.Stop();
            };

            revertColorTimer.Start();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {

            PrintBtn.BackColor = Color.Green;

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("pprnm", 285, 600);
            using (PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog())
            {
                printPreviewDialog.Document = printDocument1;
                if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            System.Windows.Forms.Timer revertColorTimer = new System.Windows.Forms.Timer();
            revertColorTimer.Interval = 500; 
            revertColorTimer.Tick += (s, args) =>
            {
                PrintBtn.BackColor = Color.OrangeRed; 
                revertColorTimer.Stop();
            };

            revertColorTimer.Start();



        }

        int prodid, prodprice, prodqty, tottal, pos = 70;
        string prodname;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public int GrdTotal { get; private set; }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {            {
                e.Graphics.DrawString("# Pizza City #", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(90,15));
                e.Graphics.DrawString("Receipt", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(115, 35));
                e.Graphics.DrawString("Id    Product         Price      Quantity    Total", new Font("Century Gothic", 9, FontStyle.Bold), Brushes.Red, new Point(25,pos));
                pos = pos + 25;
      
                foreach(DataGridViewRow row in BillDGV.Rows)
                {
                    prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                    prodname = "" + row.Cells["Column2"].Value;
                    prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                    prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                    tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                    e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(25, pos));
                    e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                    e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(130, pos));
                    e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(190, pos));
                    e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(243, pos));
                    pos = pos + 20;
                }

                e.Graphics.DrawString("Grand Total: Rs" + GrdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos+50));
                e.Graphics.DrawString("***************PIZZA***************", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
                BillDGV.Rows.Clear();
                BillDGV.Refresh();
                pos = 100;
                GrdTotal = 0;
                n = 0;
            }

        }


        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login1 obj = new Login1();
            obj.Show();
            this.Hide();
        }

    }
}
