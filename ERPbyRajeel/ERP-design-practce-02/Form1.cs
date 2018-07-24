using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ERP_design_practce_02
{
    public partial class Form1 : Form
    {
        Panel[] pnl = new Panel[15];
        int i;
        int btn_li = 0, btn1 = 0, btn2 = 0, btn3 = 0, btn4 = 0, btn5 = 0, btn6 = 0, btn7 = 0, btn8 = 0
            , btn9 = 0, btn10 = 0, btn11 = 0, btn12 = 0, btn13 = 0;

        TextBox[] tbx_av = new TextBox[20];
        TextBox[] tbx_ac = new TextBox[20];
        Panel[] mainPnl = new Panel[10];

        MyConncs conn = new MyConncs();

        TextBox[] tbx_po = new TextBox[15];
        TextBox[] tbx_so = new TextBox[15];

        int vid_auto = 0, po_ai = 0,grnid_auto=0,POid_auto=0, po_totam = 0,so_totam=0,
            invP_auto=0,cid_auto=0,soid_auto=0,dcid_auto=0,invr_auto=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl[0] = btn_label;
            pnl[1] = btn_av;
            pnl[2] = btn_apv;
            pnl[3] = btn_po;
            pnl[4] = btn_grn;
            pnl[5] = btn_ip;
            pnl[6] = btn_ac;
            pnl[7] = btn_apc;
            pnl[8] = btn_so;
            pnl[9] = btn_dc;
            pnl[10] = btn_ir;
            pnl[11] = btn_lo;

            mainPnl[0] = panel_addvendor;
            mainPnl[1] = panel_approvevendor;
            mainPnl[2] = panel_productOrder;
            mainPnl[3] = panel_grnRecievable;
            mainPnl[4] = panel_invoicePayable;
            mainPnl[5] = panel_addCustomer;
            mainPnl[6] = panel_approveCustomer;
            mainPnl[7] = panel_saleOrder;
            mainPnl[8] = panel_delieveryChallan;
            mainPnl[9] = panel_invoiceRecievable;

            tbx_av[0] = tb_av_vid;
            tbx_av[1] = tb_av_vname;
            tbx_av[2] = tb_av_vcode;
            tbx_av[3] = tb_av_vcity;
            tbx_av[4] = tb_av_ph1;
            tbx_av[5] = tb_av_ph2;
            tbx_av[6] = tb_av_vadd;
            tbx_av[7] = tb_av_cpn;
            tbx_av[8] = tb_av_cpph;
            tbx_av[9] = tb_av_vemail;
            tbx_av[10] = tb_av_vfax;
            tbx_av[11] = tb_av_vgroup;

            tbx_ac[0] = tb_ac_cid;
            tbx_ac[1] = tb_ac_cname;
            tbx_ac[2] = tb_ac_ccode;
            tbx_ac[3] = tb_ac_ccity;
            tbx_ac[4] = tb_ac_ph1;
            tbx_ac[5] = tb_ac_ph2;
            tbx_ac[6] = tb_ac_cadd;
            tbx_ac[7] = tb_ac_cpn;
            tbx_ac[8] = tb_ac_cpph;
            tbx_ac[9] = tb_ac_cemail;
            tbx_ac[10] = tb_ac_cfax;
            tbx_ac[11] = tb_ac_cgroup;

            tbx_po[0] = tb_po_vname;
            tbx_po[1] = tb_po_vcp;
            tbx_po[2] = tb_po_vcph;
            tbx_po[3] = tb_po_prodName;
            tbx_po[4] = tb_po_prodPrice;
            tbx_po[5] = tb_po_prodQty;
            tbx_po[6] = tb_po_prodTP;
            tbx_po[7] = tb_po_totalAmount;
            tbx_po[8] = tb_po_serialNo;
            tbx_po[9] = tb_po_items;

            tbx_so[0] = tb_so_cname;
            tbx_so[1] = tb_so_ccp;
            tbx_so[2] = tb_so_ccph;
            tbx_so[3] = tb_so_prodname;
            tbx_so[4] = tb_so_prodprice;
            tbx_so[5] = tb_so_prodqty;
            tbx_so[6] = tb_so_prodtp;
            tbx_so[7] = tb_so_totalamount;
            tbx_so[8] = tb_so_serialno;
            tbx_so[9] = tb_so_items;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel4_Click(sender, e);

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (btn_li == 0)
            {
                panel12.Location = new Point(364, 173);
                label13.Text = "";
                panel12.Visible = true;
                btn1 = 1;
                for (int l1 = 0; l1 <= 6; l1++)
                {
                    pnl[l1].BackColor = Color.Gray;
                }
                btn_label.BackColor = Color.DimGray;
                main_head.Text = "LOGIN";
                btn_li = 1;
            }
        }


        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            if (btn_li == 0)
                btn_label.BackColor = Color.DimGray;

        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            if (btn_li == 0)
                btn_label.BackColor = Color.Gray;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panel4_MouseEnter(sender, e);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel4_MouseLeave(sender, e);
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            if (btn3 == 0)
            {
                btn_av.BackColor = Color.DimGray;
                
            }
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            if (btn3 == 0)
                btn_av.BackColor = Color.Gray;
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            if (btn4 == 0)
                btn_apv.BackColor = Color.DimGray;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            if (btn4 == 0)
                btn_apv.BackColor = Color.Gray;

        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            if (btn5 == 0)
                btn_po.BackColor = Color.DimGray;

        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            if (btn5 == 0)
                btn_po.BackColor = Color.Gray;

        }

        private void panel9_MouseEnter(object sender, EventArgs e)
        {
            if (btn6 == 0)
                btn_grn.BackColor = Color.DimGray;
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            if (btn6 == 0)
                btn_grn.BackColor = Color.Gray;

        }

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            if (btn7 == 0)
                btn_ip.BackColor = Color.DimGray;
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            if (btn7 == 0)
                btn_ip.BackColor = Color.Gray;

        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            if (btn8 == 0)
                btn_lo.BackColor = Color.DimGray;
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            if (btn8 == 0)
                btn_lo.BackColor = Color.Gray;

        }

        private void panel13_MouseEnter(object sender, EventArgs e)
        {
            panel13.BackColor = Color.DimGray;
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.Gray;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (btn3 == 0)
            {
                main_head.Text = "ADD VENDOR";
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select count(vid) from vendor", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    vid_auto = Convert.ToInt32(dr[0]);
                    ++vid_auto;
                }

                conn.oleDbConnection1.Close();
                tb_av_vid.Text = "VEN" + "-" + vid_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;
                btn2 = 0; btn3 = 1; btn4 = 0; btn5 = 0; btn6 = 0; btn7 = 0; btn8 = 0; btn9 = 0; btn10 = 0; btn11 = 0; btn12 = 0; btn13 = 0;
                for (i = 0; i <= 11; i++)
                {
                    pnl[i].BackColor = Color.Gray;
                }
                for (int mp = 0; mp < 10; mp++)
                {
                    mainPnl[mp].Visible = false;
                }
                panel_addvendor.Visible = true;
                btn_av.BackColor = Color.DimGray;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel_approvevendor.Location = panel_addvendor.Location;
            
            if (btn4 == 0)
            {
                cb_apv_vid.Items.Clear();
                main_head.Text = "APPROVE VENDOR";
                btn2 = 0; btn3 = 0; btn4 = 1; btn5 = 0; btn6 = 0; btn7 = 0; btn8 = 0; btn9 = 0; btn10 = 0; btn11 = 0; btn12 = 0; btn13 = 0;
                for (i = 0; i <= 11; i++)
                {
                    pnl[i].BackColor = Color.Gray;
                }
                for (int mp = 0; mp < 10; mp++)
                {
                    mainPnl[mp].Visible = false;
                }
                panel_approvevendor.Visible = true;
                btn_apv.BackColor = Color.DimGray;

                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select * from vendor where vstatus='inactive'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.cb_apv_vid.Items.Add(dr["vid"].ToString());
                }
                conn.oleDbConnection1.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (btn5 == 0)
            {

                this.dtp_po_POdate.MinDate = System.DateTime.Today;
                this.dtp_po_POdate.MaxDate = System.DateTime.Today;
                this.dtp_po_POdate.Value = System.DateTime.Today;

                this.dtp_po_dueDate.MinDate = System.DateTime.Today;
                this.dtp_po_dueDate.Value = System.DateTime.Today;

                main_head.Text = "PURCHASE ORDER";
                btn2 = 0; btn3 = 0; btn4 = 0; btn5 = 1; btn6 = 0; btn7 = 0; btn8 = 0; btn9 = 0; btn10 = 0; btn11 = 0; btn12 = 0; btn13 = 0;
                for (i = 0; i <= 11; i++)
                {
                    pnl[i].BackColor = Color.Gray;
                }
                for (int mp = 0; mp < 10; mp++)
                {
                    mainPnl[mp].Visible = false;
                }
                panel_productOrder.Visible = true;
                btn_po.BackColor = Color.DimGray;

                panel_productOrder.Location = new Point(144, 44);

                cb_po_vid.Items.Clear();
                cb_po_vdept.Items.Clear();
                conn.oleDbConnection1.Open();
                OleDbCommand cmd1 = new OleDbCommand("select count(poid) from po", conn.oleDbConnection1);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    POid_auto = Convert.ToInt32(dr1[0]);
                    ++POid_auto;
                }
                conn.oleDbConnection1.Close();
                tb_po_poid.Text = "PO" + "-" + POid_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;

                conn.oleDbConnection1.Open();
                OleDbCommand cmd2 = new OleDbCommand("select * from dept", conn.oleDbConnection1);
                OleDbDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    cb_po_vdept.Items.Add(dr2["deptname"].ToString());
                }
                conn.oleDbConnection1.Close();
                //
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (btn6 == 0)
            {
                this.dtp_grn_grndate.MinDate = System.DateTime.Today;
                this.dtp_grn_grndate.MaxDate = System.DateTime.Today;
                this.dtp_grn_grndate.Value = System.DateTime.Today;

                cb_grn_poid.Items.Clear();
                cb_po_vid.Items.Clear();
                cb_po_vdept.Items.Clear();
                conn.oleDbConnection1.Open();
                OleDbCommand cmd1 = new OleDbCommand("select count(sno) from grn", conn.oleDbConnection1);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    grnid_auto = Convert.ToInt32(dr1[0]);
                    ++grnid_auto;
                }
                tb_grn_grnid.Text = "GRN" + "-" + grnid_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;
                conn.oleDbConnection1.Close();

                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select * from po where goodrecieved='no'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.cb_grn_poid.Items.Add(dr["poid"].ToString());
                }
                conn.oleDbConnection1.Close();

                main_head.Text = "GOODS RECIEVING NOTE";
                btn2 = 0; btn3 = 0; btn4 = 0; btn5 = 0; btn6 = 1; btn7 = 0; btn8 = 0; btn9 = 0; btn10 = 0; btn11 = 0; btn12 = 0; btn13 = 0;
                for (i = 0; i <= 11; i++)
                {
                    pnl[i].BackColor = Color.Gray;
                }
                for (int mp = 0; mp < 10; mp++)
                {
                    mainPnl[mp].Visible = false;
                }
                panel_grnRecievable.Visible = true;
                btn_grn.BackColor = Color.DimGray;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (btn8 == 0)
            {
                main_head.Text = "LOGOUT";
                btn2 = 0; btn3 = 0; btn4 = 0; btn5 = 0; btn6 = 0; btn7 = 0; btn8 = 1; btn9 = 0; btn10 = 0; btn11 = 0; btn12 = 0; btn13 = 0;
                for (i = 0; i <= 11; i++)
                {
                    pnl[i].BackColor = Color.Gray;
                }
                for(int mp_lo = 0; mp_lo <= 9; mp_lo++)
                {
                    mainPnl[mp_lo].Visible = false;
                }
                btn_lo.BackColor = Color.DimGray;
                DialogResult diares= MessageBox.Show("Are You Sure You Want To LogOut?","LOGOUT",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (diares == DialogResult.Yes)
                {
                    panel12.Visible = true;
                    btn_lo.BackColor = Color.Gray;
                    main_head.Text = "LOGIN";
                    for (i = 0; i <= 11; i++)
                    {
                        pnl[i].Enabled = false;
                    }
                    linkLabel1.Visible = false;
                    label14.Visible = false;
                    textBox1.Text = ""; textBox2.Text = "";
                    btn_label.Enabled = true;
                    btn_label.BackColor = Color.DimGray;
                    btn_li = 1;
                    button_exit.Visible = true;

                }
                else if (diares == DialogResult.No)
                {
                    btn_lo.BackColor = Color.Gray;
                    btn_lo.Enabled = true;
                    main_head.Text = "To Your Work";
                    btn8 = 0;
                }
            }
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_av_add_MouseEnter(object sender, EventArgs e)
        {
            panel_av_add.BackColor = Color.DimGray;
        }

        private void panel_av_add_MouseLeave(object sender, EventArgs e)
        {
            panel_av_add.BackColor = Color.Gray;
        }

        private void panel_av_add_Click_1(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();

            OleDbCommand cmd = new OleDbCommand("insert into vendor (vid, vname ,vcode,vcity,ph1,ph2,vaddress,cpname,cpph, vemail,vfax,vgroup,vstatus)values(@vid, @vname ,@vcode,@vcity,@ph1,@ph2,@vaddress,@cpname,@cpph,@vemail,@vfax,@vgroup,@vstatus) ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@vid", tb_av_vid.Text);
            cmd.Parameters.AddWithValue("@vname", tb_av_vname.Text);
            cmd.Parameters.AddWithValue("@vcode", tb_av_vcode.Text);
            cmd.Parameters.AddWithValue("@vcity", tb_av_vcity.Text);
            cmd.Parameters.AddWithValue("@ph2", tb_av_ph2.Text);
            cmd.Parameters.AddWithValue("@ph1", tb_av_ph1.Text);
            cmd.Parameters.AddWithValue("@vAdderess", tb_av_vadd.Text);
            cmd.Parameters.AddWithValue("@cpname", tb_av_cpn.Text);
            cmd.Parameters.AddWithValue("@cpph", tb_av_cpph.Text);
            cmd.Parameters.AddWithValue("@vemail", tb_av_vemail.Text);
            cmd.Parameters.AddWithValue("@vfax", tb_av_vfax.Text);
            cmd.Parameters.AddWithValue("@vgroup", tb_av_vgroup.Text);
            cmd.Parameters.AddWithValue("@vstatus", "Inactive");
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();//
            ++vid_auto;

            for (int av = 0; av <= 11; av++)
            {
                tbx_av[av].Text = "";
            }
            tb_av_vid.Text = "VEN" + "-" + vid_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;

            panel_av_add.Enabled = false;
            label_av_add.Enabled = false;

            label45.Visible = true;
        }

        private void panel_apv_ap_Enter(object sender, EventArgs e)
        {

        }

        private void panel_apv_ap_MouseEnter(object sender, EventArgs e)
        {
            panel_apv_ap.BackColor = Color.DimGray;
        }

        private void panel_apv_ap_MouseLeave(object sender, EventArgs e)
        {
            panel_apv_ap.BackColor = Color.Gray;
        }

        private void panel_apv_dis_MouseEnter(object sender, EventArgs e)
        {
            panel_apv_dis.BackColor = Color.DimGray;
        }

        private void panel_apv_dis_MouseLeave(object sender, EventArgs e)
        {
            panel_apv_dis.BackColor = Color.Gray;
        }

        private void cb_apv_vid_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_apv_ap.Enabled = true;
            panel_apv_dis.Enabled = true;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vendor where vid=@vid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@vid", cb_apv_vid.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tb_apv_vname.Text = dr["vname"].ToString();
                tb_apv_vcode.Text = dr["vcode"].ToString();
                tb_apv_vcity.Text = dr["vcity"].ToString();
                tb_apv_ph1.Text = dr["ph2"].ToString();
                tb_apv_ph2.Text = dr["ph1"].ToString();
                tb_apv_vadd.Text = dr["vaddress"].ToString();
                tb_apv_cpn.Text = dr["cpname"].ToString();
                tb_apv_cpph.Text = dr["cpph"].ToString();
                tb_apv_vemail.Text = dr["vemail"].ToString();
                tb_apv_vfax.Text = dr["vfax"].ToString();
                tb_apv_vgroup.Text = dr["vgroup"].ToString();
            }
            conn.oleDbConnection1.Close();
        }

        public void tbx_apv_clear()
        {
            cb_apv_vid.Items.Remove(cb_apv_vid.Text);
            tb_apv_vname.Clear();
            tb_apv_vcode.Clear();
            tb_apv_vcity.Clear();
            tb_apv_ph2.Clear();
            tb_apv_ph1.Clear();
            tb_apv_vadd.Clear();
            tb_apv_cpn.Clear();
            tb_apv_cpph.Clear();
            tb_apv_vemail.Clear();
            tb_apv_vfax.Clear();
            tb_apv_vgroup.Clear();
            cb_apv_vid.Text = "";
        }

        private void label_apv_ap_Click(object sender, EventArgs e)//
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update vendor set vstatus='Active' where vid='" + cb_apv_vid.Text + "'", conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
            MessageBox.Show("Vendor ID : " + cb_apv_vid.Text + "- Approved");
            tbx_apv_clear();
        }

        private void label_apv_dis_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update vendor set vstatus='Disapproved' where vid='" + cb_apv_vid.Text + "'", conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
            MessageBox.Show("Vendor ID : " + cb_apv_vid.Text + "- Disapproved");
            tbx_apv_clear();
        }

        private void panel_av_clear_Click(object sender, EventArgs e)
        {
            for (int av_clear = 1; av_clear <= 11; av_clear++)
            { tbx_av[av_clear].Clear(); }
            panel_av_clear.Enabled = false;
            label43.Enabled = false;
        }

        private void panel_av_clear_MouseEnter(object sender, EventArgs e)
        {
            panel_av_clear.BackColor = Color.DimGray;
        }

        private void panel_av_clear_MouseLeave(object sender, EventArgs e)
        {
            panel_av_clear.BackColor = Color.Gray;
        }

        private void tbx_av_all_TextChanged(object sender, EventArgs e)//
        {
            label45.Visible = false;
            for (int av_all = 1; av_all <= 11; av_all++)
            {
                if (tbx_av[av_all].Text != "")
                {
                    panel_av_clear.Enabled = true;
                    label43.Enabled = true;
                }
                if (tbx_av[1].Text != "" && tbx_av[2].Text != "" && tbx_av[4].Text != "" &&
                    tbx_av[7].Text != "" && tbx_av[8].Text != "")
                {
                    panel_av_add.Enabled = true;
                    label_av_add.Enabled = true;
                }
                if (tbx_av[1].Text == "" || tbx_av[2].Text == "" || tbx_av[4].Text == "" ||
                   tbx_av[7].Text == "" || tbx_av[8].Text == "")
                {
                    panel_av_add.Enabled = false;
                    label_av_add.Enabled = false;
                }
            }
        }
        
        private void cb_po_vdept_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int po_ac = 0; po_ac < 10; po_ac++)
            {
                tbx_po[po_ac].Text = "";
            }
            tbx_po[9].Text = "-------------------------------------------" + Environment.NewLine +
                "Prod ID     Prod Qty    Prod TP" + Environment.NewLine + "-------------------------------------------";
            lbl_po_msg.Text = "";

            cb_po_vid.Items.Clear();
            conn.oleDbConnection1.Open();
            OleDbCommand cmd3 = new OleDbCommand("select * from vendor where vstatus='active'", conn.oleDbConnection1);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                this.cb_po_vid.Items.Add(dr3["vid"].ToString());
            }
            conn.oleDbConnection1.Close();
        }

        private void cb_po_vid_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int po_ac = 0; po_ac < 10; po_ac++)
            {
                tbx_po[po_ac].Text = "";
            }
            tbx_po[9].Text = "-------------------------------------------" + Environment.NewLine +
                "Prod ID     Prod Qty    Prod TP" + Environment.NewLine + "-------------------------------------------";

            cb_po_prodID.Items.Clear();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vendor where vid=@vid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@vid", cb_po_vid.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tb_po_vname.Text = dr["VName"].ToString();
                tb_po_vcp.Text = dr["CPName"].ToString();
                tb_po_vcph.Text = dr["CPPH"].ToString();

            }
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd3 = new OleDbCommand("select * from products", conn.oleDbConnection1);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cb_po_prodID.Items.Add(dr3["pid"].ToString());
            }
            conn.oleDbConnection1.Close();

        }

        private void cb_po_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from products where pid=@pid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@pid", cb_po_prodID.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tb_po_prodName.Text = dr["pname"].ToString();
                tb_po_prodPrice.Text = dr["baseprice"].ToString();

            }
            conn.oleDbConnection1.Close();
        }

        private void tb_po_prodQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int qty = int.Parse(tb_po_prodQty.Text);
                int prodPrice = int.Parse(tb_po_prodPrice.Text);
                int prodTP = qty * prodPrice;
                tb_po_prodTP.Text = prodTP.ToString();
            }
            catch (FormatException)
            {
                tb_po_prodQty.Text = "";
                tb_po_prodTP.Text = "";
            }
            
        }

        private void btn_apc_MouseEnter(object sender, EventArgs e)
        {
            if (btn10 == 0)
                btn_apc.BackColor = Color.DimGray;
        }

        private void btn_apc_MouseLeave(object sender, EventArgs e)
        {
            if (btn10 == 0)
                btn_apc.BackColor = Color.Gray;
        }

        private void btn_so_MouseEnter(object sender, EventArgs e)
        {
            if (btn11 == 0)
                btn_so.BackColor = Color.DimGray;
        }

        private void btn_so_MouseLeave(object sender, EventArgs e)
        {
            if (btn11 == 0)
                btn_so.BackColor = Color.Gray;
        }

        private void btn_dc_MouseEnter(object sender, EventArgs e)
        {
            if (btn12 == 0)
                btn_dc.BackColor = Color.DimGray;
        }

        private void btn_dc_MouseLeave(object sender, EventArgs e)
        {
            if (btn12 == 0)
                btn_dc.BackColor = Color.Gray;
        }

        private void btn_ir_MouseEnter(object sender, EventArgs e)
        {
            if (btn13 == 0)
                btn_ir.BackColor = Color.DimGray;
        }

        private void btn_ir_MouseLeave(object sender, EventArgs e)
        {
            if (btn13 == 0)
                btn_ir.BackColor = Color.Gray;
        }

        private void label41_Click(object sender, EventArgs e)
        {
            if (btn9 == 0)
            {
                main_head.Text = "ADD CUSTOMER";
                btn2 = 0; btn3 = 0; btn4 = 0; btn5 = 0; btn6 = 0; btn7 = 0; btn8 = 0; btn9 = 1; btn10 = 0; btn11 = 0; btn12 = 0; btn13 = 0;
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select count(cid) from customer", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cid_auto = Convert.ToInt32(dr[0]);
                    ++cid_auto;
                }

                conn.oleDbConnection1.Close();
                tb_ac_cid.Text = "CUS" + "-" + cid_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;


                for (i = 0; i <= 11; i++)
                {
                    pnl[i].BackColor = Color.Gray;
                }
                for (int mp = 0; mp < 10; mp++)
                {
                    mainPnl[mp].Visible = false;
                }
                panel_addCustomer.Visible = true;
                btn_ac.BackColor = Color.DimGray;
            }
        }

        private void btn_apc_Click(object sender, EventArgs e)
        {

            if (btn10 == 0)
            {
                main_head.Text = "APPROVE CUSTOMER";
                cb_apc_cid.Items.Clear();
                btn2 = 0; btn3 = 0; btn4 = 0; btn5 = 0; btn6 = 0; btn7 = 0; btn8 = 0; btn9 = 0; btn10 = 1; btn11 = 0; btn12 = 0; btn13 = 0;
                for (i = 0; i <= 11; i++)
                {
                    pnl[i].BackColor = Color.Gray;
                }
                for (int mp = 0; mp < 10; mp++)
                {
                    mainPnl[mp].Visible = false;
                }
                panel_approveCustomer.Visible = true;
                btn_apc.BackColor = Color.DimGray;

                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select * from customer where cstatus='inactive'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.cb_apc_cid.Items.Add(dr["cid"].ToString());
                }
                conn.oleDbConnection1.Close();
            }
        }

        private void btn_so_Click(object sender, EventArgs e)
        {
                this.dtp_so_sodate.MinDate = System.DateTime.Today;
                this.dtp_so_sodate.Value = System.DateTime.Today;
                this.dtp_so_sodate.MaxDate = System.DateTime.Today;

                this.dtp_so_dueDate.MinDate = System.DateTime.Today;
                this.dtp_so_dueDate.Value = System.DateTime.Today;

            if (btn11 == 0)
            {
                main_head.Text = "SELL ORDER";
                btn2 = 0; btn3 = 0; btn4 = 0; btn5 = 0; btn6 = 0; btn7 = 0; btn8 = 0; btn9 = 0; btn10 = 0; btn11 = 1; btn12 = 0; btn13 = 0;
                for (i = 0; i <= 11; i++)
                {
                    pnl[i].BackColor = Color.Gray;
                }
                for (int mp = 0; mp < 10; mp++)
                {
                    mainPnl[mp].Visible = false;
                }
                panel_saleOrder.Visible = true;
                btn_so.BackColor = Color.DimGray;

                cb_so_cid.Items.Clear();
                cb_so_cdept.Items.Clear();
                conn.oleDbConnection1.Open();
                OleDbCommand cmd1 = new OleDbCommand("select count(soid) from so", conn.oleDbConnection1);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    soid_auto = Convert.ToInt32(dr1[0]);
                    ++soid_auto;
                }
                else
                {
                    ++soid_auto;
                }

                conn.oleDbConnection1.Close();
                tb_so_soid.Text = "SO" + "-" + soid_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;

                conn.oleDbConnection1.Open();
                OleDbCommand cmd2 = new OleDbCommand("select * from dept", conn.oleDbConnection1);
                OleDbDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    cb_so_cdept.Items.Add(dr2["deptname"].ToString());
                }
                conn.oleDbConnection1.Close();

            }
        }
        private void btn_dc_Click(object sender, EventArgs e)
        {
            if (btn12 == 0)
            {
                main_head.Text = "DELIEVERY CHALLAN";
                btn2 = 0; btn3 = 0; btn4 = 0; btn5 = 0; btn6 = 0; btn7 = 0; btn8 = 0; btn9 = 0; btn10 = 0; btn11 = 0; btn12 = 1; btn13 = 0;
                for (i = 0; i <= 11; i++)
                {
                    pnl[i].BackColor = Color.Gray;
                }
                for (int mp = 0; mp < 10; mp++)
                {
                    mainPnl[mp].Visible = false;
                }
                panel_delieveryChallan.Visible = true;
                btn_dc.BackColor = Color.DimGray;

                this.dtp_dc_dcdate.MinDate = System.DateTime.Today;
                this.dtp_dc_dcdate.MaxDate = System.DateTime.Today;
                this.dtp_dc_dcdate.Value = System.DateTime.Today;

                cb_dc_soid.Items.Clear();
                cb_so_cid.Items.Clear();
                cb_so_cdept.Items.Clear();
                conn.oleDbConnection1.Open();
                OleDbCommand cmd1 = new OleDbCommand("select count(sno) from so", conn.oleDbConnection1);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    dcid_auto = Convert.ToInt32(dr1[0]);
                    ++dcid_auto;
                }
                else
                {
                    ++dcid_auto;
                }
                tb_dc_dcid.Text = "DC" + "-" + dcid_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;
                conn.oleDbConnection1.Close();

                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select * from so where goodssent='no'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.cb_dc_soid.Items.Add(dr["soid"].ToString());
                }
                conn.oleDbConnection1.Close();

            }
        }

        private void btn_ir_Click(object sender, EventArgs e)
        {
            if (btn13 == 0)
            {
                main_head.Text = "INVOICE RECIEVEABLE";
                btn2 = 0; btn3 = 0; btn4 = 0; btn5 = 0; btn6 = 0; btn7 = 0; btn8 = 0; btn9 = 0; btn10 = 0; btn11 = 0; btn12 = 0; btn13 = 1;
                for (i = 0; i <= 10; i++)
                {
                    pnl[i].BackColor = Color.Gray;
                }
                for (int mp = 0; mp < 10; mp++)
                {
                    mainPnl[mp].Visible = false;
                }
                panel_invoiceRecievable.Visible = true;
                btn_ir.BackColor = Color.DimGray;

                this.dtp_ir_invdate.MinDate = System.DateTime.Today;
                this.dtp_ir_invdate.MaxDate = System.DateTime.Today;
                this.dtp_ir_invdate.Value = System.DateTime.Today;

                cb_ir_dcid.Items.Clear();
                btn2 = 0; btn3 = 0; btn4 = 0; btn5 = 0; btn6 = 0; btn7 = 1; btn8 = 0; btn9 = 0; btn10 = 0; btn11 = 0; btn12 = 0; btn13 = 0;

                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select count(invoiceid) from Invoicerec", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    invr_auto = Convert.ToInt32(dr[0]);
                    ++invr_auto;
                }
                else
                {
                    ++invr_auto;
                }

                conn.oleDbConnection1.Close();
                tb_ir_invid.Text = "INR" + "-" + invr_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;

                conn.oleDbConnection1.Open();
                OleDbCommand cmd1 = new OleDbCommand("select * from dc where status='open'", conn.oleDbConnection1);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    cb_ir_dcid.Items.Add(dr1["dcid"].ToString());
                }
                conn.oleDbConnection1.Close();


            }
        }

        private void tb_po_serialNo_TextChanged(object sender, EventArgs e)
        {
            if (tb_po_totalAmount.Text != "" && tb_po_serialNo.Text != "")
            {
                btn_po_addPO.Enabled = true;
            }
            else
            {
                btn_po_addPO.Enabled = false;
            }
        }

        private void cb_ip_grnid_SelectedIndexChanged(object sender, EventArgs e)
        {
            label82.Visible = false;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from grn where grnid=@grnid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@grnid", cb_ip_grnid.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tb_ip_grndeldate.Text = dr["grdate"].ToString();
                tb_ip_podeldate.Text = dr["ddate"].ToString();
                tb_ip_vname.Text = dr["vname"].ToString();
                tb_ip_poid.Text = dr["poid"].ToString();
                tb_ip_amountpay.Text = dr["amountpayable"].ToString();
            }
            conn.oleDbConnection1.Close();

            btn_ip_create.Enabled = true;

            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from po where poid='"+tb_ip_poid.Text+"'", conn.oleDbConnection1);
            //OleDbCommand cmd1 = new OleDbCommand("select * from po where poid=@poid ", conn.oleDbConnection1);
            //cmd.Parameters.AddWithValue("@poid", tb_ip_poid.Text);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                this.tb_ip_vcp.Text = dr1["VContectPerson"].ToString();
                this.tb_ip_vcph.Text = dr1["vcpph"].ToString();
            }
            conn.oleDbConnection1.Close();

        }

        private void btn_ac_add_Click(object sender, EventArgs e)
        {
            if(tb_apc_ph2.Text=="")
            {
                int z = 0;
                tb_apc_ph2.Text = z.ToString();
            }
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into customer (cid, cname ,ccode,ccity,ph1,ph2,caddress,cpname,cpph, cemail,cfax,cgroup,cstatus)values(@cid, @cname ,@ccode,@ccity,@ph1,@ph2,@caddress,@cpname,@cpph,@cemail,@cfax,@cgroup,@cstatus) ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@cid", tb_ac_cid.Text);
            cmd.Parameters.AddWithValue("@cname", tb_ac_cname.Text);
            cmd.Parameters.AddWithValue("@ccode", tb_ac_ccode.Text);
            cmd.Parameters.AddWithValue("@ccity", tb_ac_ccity.Text);
            cmd.Parameters.AddWithValue("@ph1", int.Parse(tb_ac_ph1.Text));
            cmd.Parameters.AddWithValue("@ph2", tb_ac_ph2.Text);
            cmd.Parameters.AddWithValue("@cAddress", tb_ac_cadd.Text);
            cmd.Parameters.AddWithValue("@cpname", tb_ac_cpn.Text);
            cmd.Parameters.AddWithValue("@cpph", int.Parse(tb_ac_cpph.Text));
            cmd.Parameters.AddWithValue("@cemail", tb_ac_cemail.Text);
            cmd.Parameters.AddWithValue("@cfax", tb_ac_cfax.Text);
            cmd.Parameters.AddWithValue("@cgroup", tb_ac_cgroup.Text);
            cmd.Parameters.AddWithValue("@cstatus", "Inactive");
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            ++cid_auto;

            for (int ac = 0; ac <= 11; ac++)
            {
                tbx_ac[ac].Text = "";
            }
            tb_ac_cid.Text = "CUS" + "-" + cid_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;

            btn_ac_add.Enabled = false;
            btn_ac_allclear.Enabled = false;

            lbl_ac_record.Visible = true;
        }

        private void tb_ac_all_TextChanged(object sender, EventArgs e)
        {
            lbl_ac_record.Visible = false;
            for (int ac_all = 1; ac_all <= 11; ac_all++)
            {
                if (tbx_ac[ac_all].Text != "")
                {
                    btn_ac_allclear.Enabled = true;
                }
                if (tbx_ac[1].Text != "" && tbx_ac[2].Text != "" && tbx_ac[4].Text != "" &&
                    tbx_ac[7].Text != "" && tbx_ac[8].Text != "")
                {
                    btn_ac_add.Enabled = true;
                }
                if (tbx_ac[1].Text == "" || tbx_ac[2].Text == "" || tbx_ac[4].Text == "" ||
                   tbx_ac[7].Text == "" || tbx_ac[8].Text == "")
                {
                    btn_ac_add.Enabled = false;
                }
            }
        }

        private void btn_ac_allclear_Click(object sender, EventArgs e)
        {
            for (int ac_clear = 1; ac_clear <= 11; ac_clear++)
            { tbx_ac[ac_clear].Clear(); }
            btn_ac_allclear.Enabled = false;
        }

        private void cb_apc_cid_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from customer where cid=@cid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@cid", cb_apc_cid.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tb_apc_cname.Text = dr["cname"].ToString();
                tb_apc_ccode.Text = dr["ccode"].ToString();
                tb_apc_ccity.Text = dr["ccity"].ToString();
                tb_apc_ph1.Text = dr["ph1"].ToString();
                tb_apc_ph2.Text = dr["ph2"].ToString();
                tb_apc_cadd.Text = dr["caddress"].ToString();
                tb_apc_cpn.Text = dr["cpname"].ToString();
                tb_apc_cpph.Text = dr["cpph"].ToString();
                tb_apc_cemail.Text = dr["cemail"].ToString();
                tb_apc_cfax.Text = dr["cfax"].ToString();
                tb_apc_cgroup.Text = dr["cgroup"].ToString();
            }
            conn.oleDbConnection1.Close();
            btn_apc_approve.Enabled = true;
            btn_apc_disapp.Enabled = true;
        }

        private void cb_so_cdept_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int so_ac = 0; so_ac < 10; so_ac++)
            {
                tbx_so[so_ac].Text = "";
            }
            tbx_so[9].Text = "-------------------------------------------" + Environment.NewLine +
                "Prod ID     Prod Qty    Prod TP" + Environment.NewLine + "-------------------------------------------";
            lbl_so_msg.Text = "";

            cb_so_cid.Items.Clear();
            conn.oleDbConnection1.Open();
            OleDbCommand cmd3 = new OleDbCommand("select * from customer where cstatus='active'", conn.oleDbConnection1);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                this.cb_so_cid.Items.Add(dr3["cid"].ToString());
            }
            conn.oleDbConnection1.Close();
        }

        private void cb_so_cid_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int so_ac = 0; so_ac < 10; so_ac++)
            {
                tbx_so[so_ac].Text = "";
            }
            tbx_so[9].Text = "-------------------------------------------" + Environment.NewLine +
                "Prod ID     Prod Qty    Prod TP" + Environment.NewLine + "-------------------------------------------";

            cb_so_prodid.Items.Clear();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from customer where cid=@cid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@cid", cb_so_cid.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tb_so_cname.Text = dr["cName"].ToString();
                tb_so_ccp.Text = dr["CPName"].ToString();
                tb_so_ccph.Text = dr["CPPH"].ToString();

            }
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd3 = new OleDbCommand("select * from productsell", conn.oleDbConnection1);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cb_so_prodid.Items.Add(dr3["pid"].ToString());
            }
            conn.oleDbConnection1.Close();
        }

        private void cb_so_prodid_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from productsell where pid=@pid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@pid", cb_so_prodid.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tb_so_prodname.Text = dr["pname"].ToString();
                tb_so_prodprice.Text = dr["baseprice"].ToString();

            }
            conn.oleDbConnection1.Close();
        }

        private void tb_so_prodqty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int qty = int.Parse(tb_so_prodqty.Text);
                int prodPrice = int.Parse(tb_so_prodprice.Text);
                int prodTP = qty * prodPrice;
                tb_so_prodtp.Text = prodTP.ToString();
            }
            catch (FormatException)
            {
                tb_so_prodqty.Text = "";
                tb_so_prodtp.Text = "";
            }
            if (tb_so_prodqty.Text != "")
            {
                btn_so_addItem.Enabled = true;
            }
            else
            {
                btn_so_addItem.Enabled = false;

            }
        }

        private void tb_so_serialno_TextChanged(object sender, EventArgs e)
        {
            if (tb_so_totalamount.Text != "" && tb_so_serialno.Text != "")
            {
                btn_so_addso.Enabled = true;
            }
            else
            {
                btn_so_addso.Enabled = false;
            }
        }

        private void btn_so_addso_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("insert into so (soid, sodate, ddate, status, approve ,cdept, cname, cid, ccontectperson, ccpph, totalamount, sno, goodssent,items) values (@soid, @sodate, @status, @ddate, @approve, @cdept,@cname, @cid, @ccontectperson, @ccpph, @totalamount, @sno, @goodssent,@items)", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@soid", tb_so_soid.Text);
            cmd1.Parameters.AddWithValue("@sodate", dtp_so_sodate);
            cmd1.Parameters.AddWithValue("@ddate", dtp_so_dueDate);
            cmd1.Parameters.AddWithValue("@status", "Open");
            cmd1.Parameters.AddWithValue("@approve", "Approved");
            cmd1.Parameters.AddWithValue("@cdept", cb_so_cdept.Text);
            cmd1.Parameters.AddWithValue("@cname", tbx_so[0].Text);
            cmd1.Parameters.AddWithValue("@cid", cb_so_cid.Text);
            cmd1.Parameters.AddWithValue("@ccontectperson", tbx_so[1].Text);
            cmd1.Parameters.AddWithValue("@ccpph", int.Parse(tbx_so[2].Text));
            cmd1.Parameters.AddWithValue("@totalamount", int.Parse(tbx_so[7].Text));
            cmd1.Parameters.AddWithValue("@sno", tbx_so[8].Text);
            cmd1.Parameters.AddWithValue("@goodssent", "No");
            cmd1.Parameters.AddWithValue("@items", tb_so_items.Text);
            cmd1.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
            lbl_so_msg.Text = "SO Generated Successfully!";

            for (int so_ac = 0; so_ac < 10; so_ac++)
            {
                tbx_so[so_ac].Text = "";
            }
            tbx_so[9].Text = "-------------------------------------------" + Environment.NewLine +
                "Prod ID     Prod Qty    Prod TP" + Environment.NewLine + "-------------------------------------------";
            cb_so_prodid.Items.Clear();
            cb_so_cdept.Text = "";
            cb_so_cid.Items.Clear();
            cb_so_cid.Text = "";

            soid_auto++;
            tb_so_soid.Text = "SO" + "-" + soid_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;

        }

        private void btn_so_allClear_Click(object sender, EventArgs e)
        {
            for (int so_ac = 0; so_ac < 10; so_ac++)
            {
                tbx_so[so_ac].Text = "";
            }
            tbx_so[9].Text = "-------------------------------------------" + Environment.NewLine +
                "Prod ID     Prod Qty    Prod TP" + Environment.NewLine + "-------------------------------------------";
            cb_so_prodid.Items.Clear();
            cb_so_cdept.Text = "";
            cb_so_cid.Items.Clear(); ;
            cb_so_cid.Text = "";
            lbl_so_msg.Text = "";
            so_totam = 0;
            btn_so_addso.Enabled = false;
        }

        private void cb_dc_soid_SelectedIndexChanged(object sender, EventArgs e)
        {
            label133.Text = "";
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from so where soid=@soid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@soid", cb_dc_soid.Text);
            OleDbDataReader dr = cmd.ExecuteReader(); 
            if (dr.Read())
            {
                tb_dc_sodate.Text = dr["sodate"].ToString();
                tb_dc_duedate.Text = dr["ddate"].ToString();
                tb_dc_cname.Text = dr["cname"].ToString();
                tb_dc_ccp.Text = dr["cContectPerson"].ToString();
                tb_dc_ccph.Text = dr["ccpph"].ToString();
                tb_dc_orderitem.Text = dr["items"].ToString();
                tb_dc_amo.Text = dr["totalamount"].ToString();
            }
            conn.oleDbConnection1.Close();

            btn_dc_add.Enabled = true;

        }

        private void btn_dc_add_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("insert into dc (dcid,dcdate,ddate, cname,soid,status,amountrecievable) values (@dcid,@dcdate, @ddate ,@cname,@soid,@status,@amountrecievable)", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@dcid", tb_dc_dcid.Text);
            cmd1.Parameters.AddWithValue("@dcdate", dtp_dc_dcdate);
            cmd1.Parameters.AddWithValue("@ddate", tb_dc_duedate.Text);
            cmd1.Parameters.AddWithValue("@cname", tb_dc_cname.Text);
            cmd1.Parameters.AddWithValue("@soid", cb_dc_soid.Text);
            cmd1.Parameters.AddWithValue("@status", "open");
            cmd1.Parameters.AddWithValue("@amountrecievable", int.Parse(tb_dc_amo.Text));
            cmd1.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd2 = new OleDbCommand("update so set status = 'close' where soid = '" + cb_dc_soid.Text + "'", conn.oleDbConnection1);
            cmd2.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd3 = new OleDbCommand("update so set goodssent = 'yes' where soid = '" + cb_dc_soid.Text + "'", conn.oleDbConnection1);
            cmd3.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            cb_dc_soid.Items.Remove(cb_dc_soid.Text);
            tb_dc_sodate.Text = "";
            tb_dc_duedate.Text = "";
            cb_dc_soid.Text = "";
            tb_dc_cname.Text = "";
            tb_dc_ccp.Text = "";
            tb_dc_ccph.Text = "";
            tb_dc_orderitem.Text = "";
            label133.Text = "DC Added Succesfully!!";

            dcid_auto++;
            tb_dc_dcid.Text = "DC" + "-" + dcid_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;

            btn_dc_add.Enabled = false;
        }

        private void btn_ir_create_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("insert into invoicerec(invoiceid,soid,customername,contectperson,cpph,sodeldate,dcdldate,invcredate,amountrec,dcid) values(@invoiceid,@soid,@customername,@contectperson,@cpph,@sodeldate,@dcdldate,@invcredate,@amountrec,@dcid);", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@invoiceid", tb_ir_invid.Text);
            cmd1.Parameters.AddWithValue("@soid", tb_ir_soid.Text);
            cmd1.Parameters.AddWithValue("@customername", tb_ir_cname.Text);
            cmd1.Parameters.AddWithValue("@contectperson", tb_ir_ccp.Text);
            cmd1.Parameters.AddWithValue("@cpph", int.Parse(tb_ir_ccph.Text));
            cmd1.Parameters.AddWithValue("@sodeldate", tb_ir_sodeldate.Text);
            cmd1.Parameters.AddWithValue("@dcdldate", tb_ir_dcdeldate.Text);
            cmd1.Parameters.AddWithValue("@invcredate", dtp_ir_invdate);
            cmd1.Parameters.AddWithValue("@amountrec", int.Parse(tb_ir_amountrec.Text));
            cmd1.Parameters.AddWithValue("@dcid", cb_ir_dcid.Text);
            cmd1.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd2 = new OleDbCommand("update dc set status = 'close' where dcid = '" + cb_ir_dcid.Text + "'", conn.oleDbConnection1);
            cmd2.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            label82.Visible = true;

            cb_ir_dcid.Items.Remove(cb_ir_dcid.Text);
            ++invr_auto;
            tb_ir_invid.Text = "INR" + "-" + invr_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;
            tb_ir_soid.Text = "";
            tb_ir_sodeldate.Clear();
            tb_ir_dcdeldate.Clear();
            tb_ir_ccp.Clear();
            tb_ir_ccph.Clear();
            tb_ir_cname.Clear();
            tb_ir_amountrec.Clear();
            cb_ir_dcid.Text = "";
            label_ir_create.Visible = true;


            btn_ir_create.Enabled = false;
        }

        private void cb_ir_dcid_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_ir_create.Visible = false;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from dc where dcid=@dcid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@dcid", cb_ir_dcid.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tb_ir_dcdeldate.Text = dr["dcdate"].ToString();
                tb_ir_sodeldate.Text = dr["ddate"].ToString();
                tb_ir_cname.Text = dr["cname"].ToString();
                tb_ir_soid.Text = dr["soid"].ToString();
                tb_ir_amountrec.Text = dr["amountrecievable"].ToString();
            }
            conn.oleDbConnection1.Close();

            btn_ir_create.Enabled = true;

            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from so where soid='" + tb_ir_soid.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                this.tb_ir_ccp.Text = dr1["cContectPerson"].ToString();
                this.tb_ir_ccph.Text = dr1["ccpph"].ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void NumericTextBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_so_addItem_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("insert into soproducts (soid,sid,sname, sqty) values (@soid,@sid, @sname ,@sqty)", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@soid", tb_so_soid.Text);
            cmd1.Parameters.AddWithValue("@sid", cb_so_prodid.Text);
            cmd1.Parameters.AddWithValue("@sname", tb_so_prodname.Text);
            cmd1.Parameters.AddWithValue("@sqty", tb_so_prodqty.Text);
            cmd1.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            tb_so_items.Text += cb_so_prodid.Text + "          " + tb_so_prodqty.Text + "        " + tb_so_prodtp.Text + Environment.NewLine;

            so_totam += int.Parse(tb_so_prodtp.Text);
            tb_so_totalamount.Text = so_totam.ToString();

            cb_so_prodid.Items.Remove(cb_so_prodid.Text);
            btn_so_addItem.Enabled = false;
            cb_so_prodid.Text = "";
            tb_so_prodname.Text = "";
            tb_so_prodprice.Text = "";
            tb_so_prodqty.Text = "";
            tb_so_serialno.Text = System.DateTime.Today.Year.ToString() + System.DateTime.Today.DayOfYear.ToString() + soid_auto.ToString();
            
        }

        public void tbx_apc_clear()
        {
            cb_apc_cid.Items.Remove(cb_apc_cid.Text);
            tb_apc_cname.Clear();
            tb_apc_ccode.Clear();
            tb_apc_ccity.Clear();
            tb_apc_ph2.Clear();
            tb_apc_ph1.Clear();
            tb_apc_cadd.Clear();
            tb_apc_cpn.Clear();
            tb_apc_cpph.Clear();
            tb_apc_cemail.Clear();
            tb_apc_cfax.Clear();
            tb_apc_cgroup.Clear();
            cb_apc_cid.Text = "";
        }

        private void btn_apc_approve_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update Customer set cstatus='Active' where cid='" + cb_apc_cid.Text + "'", conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
            MessageBox.Show("Customer ID : " + cb_apc_cid.Text + " - Approved");
            tbx_apc_clear();
        }

        private void btn_apc_disapp_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update Customer set cstatus='Disapproved' where cid='" + cb_apc_cid.Text + "'", conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
            MessageBox.Show("Customer ID : " + cb_apc_cid.Text + " - Disapproved");
            tbx_apc_clear();
        }

        private void btn_ip_create_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("insert into invoicepay(invoiceid,poid,vendorname,contectperson,cpph,podeldate,grndldate,invcredate,amountpay,grnid) values(@invoiceid,@poid,@vendorname,@contectperson,@cpph,@podeldate,@grndldate,@invcredate,@amountpay,@grnid);", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@invoiceid", tb_ip_invid.Text);
            cmd1.Parameters.AddWithValue("@poid", tb_ip_poid.Text);
            cmd1.Parameters.AddWithValue("@vendorname", tb_ip_vname.Text);
            cmd1.Parameters.AddWithValue("@contectperson", tb_ip_vcp.Text);
            cmd1.Parameters.AddWithValue("@cpph", int.Parse(tb_ip_vcph.Text));
            cmd1.Parameters.AddWithValue("@podeldate", tb_ip_podeldate.Text);
            cmd1.Parameters.AddWithValue("@grndldate", tb_ip_grndeldate.Text);
            cmd1.Parameters.AddWithValue("@invcredate", dtp_ip_invdate);
            cmd1.Parameters.AddWithValue("@amountpay", int.Parse(tb_ip_amountpay.Text));
            cmd1.Parameters.AddWithValue("@grnid", cb_ip_grnid.Text);
            cmd1.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd2 = new OleDbCommand("update grn set status = 'close' where grnid = '" + cb_ip_grnid.Text + "'", conn.oleDbConnection1);
            cmd2.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            label82.Visible = true;

            cb_ip_grnid.Items.Remove(cb_ip_grnid.Text);
            ++invP_auto;
            tb_ip_invid.Text = "INP" + "-" + invP_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;
            tb_ip_poid.Text = "";
            tb_ip_podeldate.Clear();
            tb_ip_grndeldate.Clear();
            tb_ip_vcp.Clear();
            tb_ip_vcph.Clear();
            tb_ip_vname.Clear();
            tb_ip_amountpay.Clear();
            cb_ip_grnid.Text = "";


            btn_ip_create.Enabled = false;
        }

        private void cb_grn_poid_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label70.Text = ""; 
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from po where poid=@poid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@poid", cb_grn_poid.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tb_grn_podate.Text = dr["podate"].ToString();
                tb_grn_duedate.Text = dr["ddate"].ToString();
                tb_grn_vname.Text = dr["vname"].ToString();
                tb_grn_vcp.Text = dr["VContectPerson"].ToString();
                tb_grn_vcph.Text = dr["vcpph"].ToString();
                tb_grn_orderitem.Text = dr["items"].ToString();
                tb_grn_amo.Text = dr["totalamount"].ToString();
            }
            conn.oleDbConnection1.Close();

            btn_grn_add.Enabled = true;
            
        }

        private void btn_grn_add_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("insert into grn (grnid,grdate,ddate, vname,poid,status,amountpayable) values (@grnid,@grdate, @ddate ,@vname,@poid,@status,@amountpayable)", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@grnid", tb_grn_grnid.Text);
            cmd1.Parameters.AddWithValue("@grdate", dtp_grn_grndate);
            cmd1.Parameters.AddWithValue("@ddate", tb_grn_duedate.Text);
            cmd1.Parameters.AddWithValue("@vname", tb_grn_vname.Text);
            cmd1.Parameters.AddWithValue("@poid", cb_grn_poid.Text);
            cmd1.Parameters.AddWithValue("@status", "open");
            cmd1.Parameters.AddWithValue("@amountpayable", int.Parse(tb_grn_amo.Text));
            cmd1.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd2 = new OleDbCommand("update po set status = 'close' where poid = '" + cb_grn_poid.Text + "'", conn.oleDbConnection1);
            cmd2.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd3 = new OleDbCommand("update po set goodrecieved = 'yes' where poid = '" + cb_grn_poid.Text + "'", conn.oleDbConnection1);
            cmd3.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            cb_grn_poid.Items.Remove(cb_grn_poid.Text);
            tb_grn_podate.Text = "";
            tb_grn_duedate.Text = "";
            cb_grn_poid.Text = "";
            tb_grn_vname.Text = "";
            tb_grn_vcp.Text = "";
            tb_grn_vcph.Text = "";
            tb_grn_orderitem.Text = "";
            label70.Text = "GRN Added Succesfully!!";

            grnid_auto++;
            tb_grn_grnid.Text = "GRN" + "-" + grnid_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;

            btn_grn_add.Enabled = false;
        }

        private void btn_po_addItem_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("insert into poproducts (poid,pid,pname, pqty) values (@poid,@pid, @pname ,@pqty)", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@poid", tb_po_poid.Text);
            cmd1.Parameters.AddWithValue("@pid", cb_po_prodID.Text);
            cmd1.Parameters.AddWithValue("@pname", tb_po_prodName.Text);
            cmd1.Parameters.AddWithValue("@pqty", tb_po_prodQty.Text);
            cmd1.ExecuteNonQuery();
            conn.oleDbConnection1.Close();

            tb_po_items.Text += cb_po_prodID.Text + "          " + tb_po_prodQty.Text + "        " + tb_po_prodTP.Text + Environment.NewLine;

            po_totam += int.Parse(tb_po_prodTP.Text);
            tb_po_totalAmount.Text = po_totam.ToString();

            cb_po_prodID.Items.Remove(cb_po_prodID.Text);
            btn_po_addItem.Enabled = false;
            cb_po_prodID.Text = "";
            tb_po_prodName.Text = "";
            tb_po_prodPrice.Text = "";
            tb_po_prodQty.Text = "";

            tb_po_serialNo.Text = System.DateTime.Today.Year.ToString() + System.DateTime.Today.DayOfYear.ToString() + POid_auto.ToString();
        }

        private void btn_po_allClear_Click(object sender, EventArgs e)
        {
            for (int po_ac = 0; po_ac < 10; po_ac++)
            {
                tbx_po[po_ac].Text = "";
            }
            tbx_po[9].Text = "-------------------------------------------" + Environment.NewLine +
                "Prod ID     Prod Qty    Prod TP" + Environment.NewLine + "-------------------------------------------";
            cb_po_prodID.Items.Clear();
            cb_po_vdept.Text = "";
            cb_po_vid.Items.Clear();;
            cb_po_vid.Text = "";
            lbl_po_msg.Text = "";
            po_totam = 0;
        }

        private void btn_po_addPO_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("insert into po (poid, podate, ddate, status, approve ,vdept, vname, vid, vcontectperson, vcpph, totalamount, sno, goodrecieved,items) values (@poid, @podate, @status, @ddate, @approve, @vdept,@vname, @vid, @vcontectperson, @vcpph, @totalamount, @sno, @goodrecieved,@items)", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@poid", tb_po_poid.Text);
            cmd1.Parameters.AddWithValue("@podate", dtp_po_POdate);
            cmd1.Parameters.AddWithValue("@ddate", dtp_po_dueDate);
            cmd1.Parameters.AddWithValue("@status", "Open");
            cmd1.Parameters.AddWithValue("@approve", "Approved");
            cmd1.Parameters.AddWithValue("@vdept", cb_po_vdept.Text);
            cmd1.Parameters.AddWithValue("@vname", tbx_po[0].Text);
            cmd1.Parameters.AddWithValue("@vid", cb_po_vid.Text);
            cmd1.Parameters.AddWithValue("@Vcontectperson", tbx_po[1].Text);
            cmd1.Parameters.AddWithValue("@vcpph", int.Parse(tbx_po[2].Text));
            cmd1.Parameters.AddWithValue("@totalamount", int.Parse(tbx_po[7].Text));
            cmd1.Parameters.AddWithValue("@sno", tbx_po[8].Text);
            cmd1.Parameters.AddWithValue("@goodrecieved", "No");
            cmd1.Parameters.AddWithValue("@items", tb_po_items.Text);
            cmd1.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
            lbl_po_msg.Text = "PO Generated Successfully!";

            for (int po_ac = 0; po_ac < 10; po_ac++)
            {
                tbx_po[po_ac].Text = "";
            }
            tbx_po[9].Text = "-------------------------------------------" + Environment.NewLine +
                "Prod ID     Prod Qty    Prod TP" + Environment.NewLine + "-------------------------------------------";
            cb_po_prodID.Items.Clear();
            cb_po_vdept.Text = "";
            cb_po_vid.Items.Clear();
            cb_po_vid.Text = "";

            POid_auto++;
            tb_po_poid.Text = "PO" + "-" + POid_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;

        }

        private void btn_ac_MouseEnter(object sender, EventArgs e)
        {
            if (btn9 == 0)
                btn_ac.BackColor = Color.DimGray;
        }

        private void btn_ac_MouseLeave(object sender, EventArgs e)
        {
            if (btn9 == 0)
                btn_ac.BackColor = Color.Gray;
        }

        private void tb_po_totalAmount_TextChanged(object sender, EventArgs e)
        {
            if (tb_po_totalAmount.Text != "" && tb_po_serialNo.Text!="")
            {
                btn_po_addPO.Enabled = true;
            }
            else
            {
                btn_po_addPO.Enabled = false;
            }
        }

        private void tb_po_prodTP_TextChanged(object sender, EventArgs e)
        {
            if (tb_po_prodTP.Text != "" && tb_po_prodTP.Text != "0")
            {
                btn_po_addItem.Enabled = true;
            }
            else
            {
                btn_po_addItem.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (btn7 == 0)
            {
                this.dtp_ip_invdate.MinDate = System.DateTime.Today;
                this.dtp_ip_invdate.MaxDate = System.DateTime.Today;
                dtp_ip_invdate.Value = dtp_ip_invdate.MinDate;

                cb_ip_grnid.Items.Clear();
                main_head.Text = "INVOICE PAYABLE";
                btn2 = 0; btn3 = 0; btn4 = 0; btn5 = 0; btn6 = 0; btn7 = 1; btn8 = 0; btn9 = 0; btn10 = 0; btn11 = 0; btn12 = 0; btn13 = 0;

                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select count(invoiceid) from InvoicePay", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    invP_auto = Convert.ToInt32(dr[0]);
                    ++invP_auto;
                }
                else
                {
                    ++invP_auto;
                }

                conn.oleDbConnection1.Close();
                tb_ip_invid.Text = "INP" + "-" + invP_auto + "-" + System.DateTime.Today.DayOfYear + System.DateTime.Today.Year;

                conn.oleDbConnection1.Open();
                OleDbCommand cmd1 = new OleDbCommand("select * from grn where status='open'", conn.oleDbConnection1);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    cb_ip_grnid.Items.Add(dr1["grnid"].ToString());
                }
                conn.oleDbConnection1.Close();

                for (i = 0; i <= 11; i++)
                {
                    pnl[i].BackColor = Color.Gray;
                }
                for (int mp = 0; mp < 10; mp++)
                {
                    mainPnl[mp].Visible = false;
                }
                panel_invoicePayable.Visible = true;
                btn_ip.BackColor = Color.DimGray;
            }
        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            panel14.BackColor = Color.DimGray;
            label12.ForeColor = SystemColors.ScrollBar;
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = Color.DimGray;
            panel14.BackColor = SystemColors.ScrollBar;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hint : README.TXT");
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            try
            {
                conn.oleDbConnection1.Open();

                OleDbCommand cmd = new OleDbCommand("select * from users where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Login Successfully");
                    panel12.Visible = false;
                    main_head.Text = "To Your Work";

                    for (i = 0; i < 12; i++)
                    {
                        pnl[i].Enabled = true;
                    }
                    pnl[0].Enabled = false;
                    btn_label.BackColor = Color.Gray;
                    button_exit.Visible = false;
                }
                else
                {
                    linkLabel1.Visible = true;
                    label14.Visible = true;
                    textBox1.Text = ""; textBox2.Text = "";
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                panel13.Enabled = true;
            }
            else
            {
                panel13.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ((textBox2.Text != "") && (textBox1.Text != ""))
            {
                panel13.Enabled = true;
            }
            else
            {
                panel13.Enabled = false;
            }
        }
    }
}
