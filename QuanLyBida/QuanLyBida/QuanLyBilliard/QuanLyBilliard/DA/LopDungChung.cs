using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBilliard.DA
{
    class LopDungChung
    {
        SqlConnection _con = null;
        public LopDungChung()
        {
            _con = new SqlConnection();

            _con.ConnectionString = ConfigurationManager.ConnectionStrings["tenketnoi"].ConnectionString;
            //_con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYBIDA;Integrated Security=True";

        }
        /// <summary>
        /// Mở kết nối, cho phép các SqlCommand thay đổi dữ liệu của csdl
        /// </summary>
        public void open()
        {
            if (_con.State != System.Data.ConnectionState.Open)
            {
                _con.Open();
            }
        }

        /// <summary>
        /// Đóng kết nối, không cho phép các SqlCommand thay đổi dữ liệu của csdl
        /// </summary>
        public void close()
        {
            if (_con.State != System.Data.ConnectionState.Closed)
            {
                _con.Close();
            }
        }

        /// <summary>
        /// Truyền vào 1 câu sql như select thì sẽ return về 1 datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable getDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Trả về số dòng thay đổi, nếu số dòng lớn hơn 0 thì gần như được coi là thành công nếu câu sql không sai
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, _con);
            int result = cmd.ExecuteNonQuery();
            close();
            return result;
        }


        /// <summary>
        /// Trả về kiểu object của một giá trị đơn, nếu muốn dùng kiểu khác thì ép kiểu sang mà làm
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, _con);
            object result = cmd.ExecuteScalar();
            close();
            return result;
        }
    }
}
