using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;

namespace VB2QLNS.Views.QuaTrinhHopDong
{
	public partial class frmQuanLy : UserControl
	{
		private QuaTrinhHopDongController ctrlQuaTrinhHopDong;
		private int nhanSuId;

		public frmQuanLy(int nhanSuId = 0)
		{
			InitializeComponent();
			this.dgvwQuaTrinhHopDong.ForeColor = System.Drawing.Color.Black;
			ctrlQuaTrinhHopDong = new QuaTrinhHopDongController();
			this.nhanSuId = nhanSuId;
		}

		private void LoadData(DataTable dt)
		{
			dgvwQuaTrinhHopDong.DataSource = dt;
			dgvwQuaTrinhHopDong.Refresh();
			labelStatus.Text = "Có tổng số " + dt.Rows.Count + " bản ghi";
		}

		private void frmQuanLy_Load(object sender, EventArgs e)
		{
			LoadData(ctrlQuaTrinhHopDong.dataAccess.Query(QuaTrinhHopDongModel.TableName + "_FindAllByNhanSu", nhanSuId));
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmNhapLieu frm = new frmNhapLieu(nhanSuId, "Add");
			frm.ShowDialog();
			frmQuanLy_Load(sender, e);
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LoadData(ctrlQuaTrinhHopDong.FindAll());
		}

		private void dgvwQuaTrinhLuong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvwQuaTrinhLuong_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button.Equals(MouseButtons.Right))
			{
				ContextMenuStrip m = new ContextMenuStrip();
				int positionMouseRow = dgvwQuaTrinhHopDong.HitTest(e.X, e.Y).RowIndex;
				if (positionMouseRow >= 0)
				{
					//Image newImage = Image.FromFile("D:\\apple-touch-icon-144x144-precomposed.png");
					dgvwQuaTrinhHopDong.Rows[positionMouseRow].Selected = true;
					m.Items.Add("Sửa").Name = "Edit";
					m.Items.Add("Xóa").Name = "Delete";
				}
				m.Show(dgvwQuaTrinhHopDong, new Point(e.X, e.Y));

				m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
			}
		}

		private void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			frmNhapLieu frm;
			int idRecord = int.Parse(dgvwQuaTrinhHopDong.CurrentRow.Cells[0].Value.ToString());
			switch (e.ClickedItem.Name.ToString())
			{
				case "Edit":
					frm = new frmNhapLieu(idRecord, "Edit", idRecord);
					frm.ShowDialog();
					break;
				case "Delete":
					((ContextMenuStrip)sender).Hide();
					if (MessageBox.Show("Bạn có muốn xóa bản ghi này?", "Thông báo...", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
					{
						ctrlQuaTrinhHopDong.Delete(new QuaTrinhHopDongModel() { Id = idRecord });
					}
					break;
			}
			frmQuanLy_Load(sender, new EventArgs());
		}
	}
}
