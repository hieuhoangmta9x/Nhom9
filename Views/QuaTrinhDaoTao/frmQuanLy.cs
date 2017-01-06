using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;

namespace VB2QLNS.Views.QuaTrinhDaoTao
{
	public partial class frmQuanLy : UserControl
	{
		private QuaTrinhDaoTaoController ctrlQuaTrinhDaoTao;
		private int nhanSuId;
		public frmQuanLy(int nhanSuId = 0)
		{
			InitializeComponent();
			this.dgvwQuaTrinhDaoTao.ForeColor = System.Drawing.Color.Black;
			ctrlQuaTrinhDaoTao = new QuaTrinhDaoTaoController();
			this.nhanSuId = nhanSuId;
		}

		private void LoadData(DataTable dt)
		{
			dgvwQuaTrinhDaoTao.DataSource = dt;
			dgvwQuaTrinhDaoTao.Refresh();
			labelStatus.Text = "Có tổng số " + dt.Rows.Count + " bản ghi";
		}

		private void frmQuanLy_Load(object sender, EventArgs e)
		{
			LoadData(ctrlQuaTrinhDaoTao.dataAccess.Query(QuaTrinhDaoTaoModel.TableName + "_FindAllByNhanSu", nhanSuId));
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmNhapLieu frm = new frmNhapLieu(nhanSuId, "Add");
			frm.ShowDialog();
			frmQuanLy_Load(sender, e);
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LoadData(ctrlQuaTrinhDaoTao.FindAll());
		}

		private void dgvwQuaTrinhDaoTao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvwQuaTrinhDaoTao_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button.Equals(MouseButtons.Right))
			{
				ContextMenuStrip m = new ContextMenuStrip();
				int positionMouseRow = dgvwQuaTrinhDaoTao.HitTest(e.X, e.Y).RowIndex;
				if (positionMouseRow >= 0)
				{
					//Image newImage = Image.FromFile("D:\\apple-touch-icon-144x144-precomposed.png");
					dgvwQuaTrinhDaoTao.Rows[positionMouseRow].Selected = true;
					m.Items.Add("Sửa").Name = "Edit";
					m.Items.Add("Xóa").Name = "Delete";
				}
				m.Show(dgvwQuaTrinhDaoTao, new Point(e.X, e.Y));

				m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
			}
		}

		private void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			frmNhapLieu frm;
			int idRecord = int.Parse(dgvwQuaTrinhDaoTao.CurrentRow.Cells[0].Value.ToString());
			switch (e.ClickedItem.Name.ToString())
			{
				case "Edit":
					frm = new frmNhapLieu(nhanSuId, "Edit", idRecord);
					frm.ShowDialog();
					break;
				case "Delete":
					((ContextMenuStrip)sender).Hide();
					if (MessageBox.Show("Bạn có muốn xóa bản ghi này?", "Thông báo...", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
					{
						ctrlQuaTrinhDaoTao.Delete(new QuaTrinhDaoTaoModel() { Id = idRecord });
					}
					break;
			}
			frmQuanLy_Load(sender, new EventArgs());
		}
	}
}
