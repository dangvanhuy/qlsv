using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Database
    {
        private string connetionString = "server=PC; database = QLSV; integrated security = True";
        private SqlConnection conn = new SqlConnection();
        private DataTable dt;
        private SqlCommand cmd;
        
        public Database()
        {
            try
            {
                // conn = new SqlConnection(connetionString);
                conn.ConnectionString = connetionString;
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("kết nối không thành công" + ex.Message);
            }
        }
        public DataTable SelectData(string sql,List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);// noi dung sql
                cmd.CommandType = CommandType.StoredProcedure;//set cmm type cho cmd
                foreach(var para in lstPara)//gán tham số cho cmd
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                return dt;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu" + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataRow Select(string sql)
        {
            try { 
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt= new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            
            } catch (Exception ex)
            {
            MessageBox.Show("Lỗi load thông tin"+ ex.Message);
                return null;
            } 
            finally { 
                  conn.Close(); 
            }
        }
        public int ExeCute(string sql, List<CustomParameter> lstPara)
        {
            try {
                conn.Open();
                cmd = new SqlCommand(sql,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;// trả về kết quả
            }
            catch(Exception ex) { 
            MessageBox.Show("Lỗi thực thi câu lệnh "+ ex.Message);
                return -100;
            }finally { 
                conn.Close(); }
        }
    }
}
