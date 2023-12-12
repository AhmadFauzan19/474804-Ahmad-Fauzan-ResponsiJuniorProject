using Npgsql;
using System.Data;

namespace Responsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=Perusahaan";
        public static NpgsqlConnection conn = new NpgsqlConnection(connectionString: "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=Perusahaan");
        public DataTable dt;
        public static NpgsqlCommand cmd;
        public string sql = null;
        private DataGridViewRow r;

        public void btnLoaddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = @"select 
		id_karyawan, 
		nama, 
		departemen.nama_dep
	from karyawan
	join departemen
	on departemen.id_dep = karyawan.id_dep";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from kr_insert(:_nama,:_id_dep);";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", txtNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", txtDep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    txtNama = txtDep = null;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error" + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Data karyawan berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from kr_update(:_id_karyawan,:_nama,:_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", txtNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", txtDep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    txtNama = txtDep = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error:" + ex.Message, "Update FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Data karyawan berhasil diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris data yang akan diupdate", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Yakin" + r.Cells["_nama"].Value.ToString() + "+", "Hapus data berhasil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = @"select * from kr_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data karyawan berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnLoad.PerformClick();
                        txtNama = txtDep = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error:" + ex.Message, "Delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Data karyawan berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                txtNama.Text = r.Cells["_nama"].Value.ToString();
                txtDep.Text = r.Cells["_id_dep"].Value.ToString();
            }
        }
    }
}