using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_HieuSach
{
    public class clsKetNoi
    {
        public static string strconn = @"Data Source=DESKTOP-G0CL6RO\SQLEXPRESS;Initial Catalog=QL_HieuSach;Integrated Security=True";
        public static SqlConnection conn;
        public static SqlConnection Getconnection()
        {
            SqlConnection con = new SqlConnection(strconn);
            return con;
        }

        public static void Open()
        {
                if (Getconnection().State == ConnectionState.Closed)
                    Getconnection().Open();
        }
        public static void Close()
        {
           
                if (Getconnection().State == ConnectionState.Open)
                    Getconnection().Close();
        }
        // lấy danh sách sách
        public static DataTable LayDanhSach()
        {
            DataTable dt = new DataTable();
            Open();
            SqlCommand cmd = new SqlCommand("sp_SACH_GetByAll", Getconnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Close();
            return dt;
        }
        //thêm sách
        public static bool ThemSach(string TenSach, string SoTrang, string LanXuatBanThu, string NamXB)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_Sach_ThemSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TenSach", TenSach));
            cmd.Parameters.Add(new SqlParameter("@SoTrang", SoTrang));
            cmd.Parameters.Add(new SqlParameter("@LanTaiBanThu", LanXuatBanThu));
            cmd.Parameters.Add(new SqlParameter("@NamXB", NamXB));
            cmd.ExecuteNonQuery();
            Close();
            return true;
        }
        // sửa sách
        public static bool SuaSach(string MaSach,string TenSach, string SoTrang, string LanXuatBanThu, string NamXB)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_SACH_UpdateSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSach", MaSach));
            cmd.Parameters.Add(new SqlParameter("@TenSach", TenSach));
            cmd.Parameters.Add(new SqlParameter("@SoTrang", SoTrang));
            cmd.Parameters.Add(new SqlParameter("@LanTaiBanThu", LanXuatBanThu));
            cmd.Parameters.Add(new SqlParameter("@NamXB", NamXB));
            cmd.ExecuteNonQuery();
            Close();
            return true;
        }
        //xóa sách
        public static bool XoaSach(string MaSach)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_SACH_DeleteSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSach", MaSach));
            cmd.ExecuteNonQuery();
            Close();
            return true;
        }
        // lấy danh sách tác giả
        public static DataTable LayDanhSachTG()
        {
            DataTable dt = new DataTable();
            Open();
            SqlCommand cmd = new SqlCommand("sp_TACGIA_GetByAll", Getconnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Close();
            return dt;
        }
        public static bool ThemTacGia(string TenTacGia, string QuocTich, string GioiTinh)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_TACGIA_ThemSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TenTacGia", TenTacGia));
            cmd.Parameters.Add(new SqlParameter("@QuocTich", QuocTich));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", GioiTinh));
            cmd.ExecuteNonQuery();
            Close();
            return true;
        }
        public static bool SuaTacGia(string MaTacGia, string TenTacGia, string QuocTich, string GioiTinh)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_TACGIA_UpdateSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaTacGia", MaTacGia));
            cmd.Parameters.Add(new SqlParameter("@TenTacGia", TenTacGia));
            cmd.Parameters.Add(new SqlParameter("@QuocTich", QuocTich));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", GioiTinh));
            cmd.ExecuteNonQuery();
            Close();
            return true;
        }
        public static bool XoaTacGia(string MaTacGia)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_TACGIA_DeleteSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaTacGia", MaTacGia));
            cmd.ExecuteNonQuery();
            Close();
            return true;
        }
        // tìm kiếm 
        public static DataTable TimKiem(string TacGia, string NamXB)
        {
            DataTable dt = new DataTable();
            Open();
            SqlCommand cmd = new SqlCommand("sp_SACH_TimKiemTheoNamXBTenSach", Getconnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TenTacGia", TacGia));
            cmd.Parameters.Add(new SqlParameter("@NamXB", NamXB));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Close();
            return dt;
        }
    }
}
