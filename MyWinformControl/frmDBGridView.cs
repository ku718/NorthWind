using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinformControl
{
    public partial class frmDBGridView : Form
    {
        private List<Friends> lst;  // 전체 데이터를 담을 컬렉션
        private int pk; // update문과 delete문을 위한 pk를 저장할 변수
        private bool isMobileChange = false;    // 전화번호의 값이 변경되었는지 체크 변수
        private string prevMobile;  // 전화번호가 수정되기 전의 값(전화번호의 값이 변경되었는지 체크하기 위해)


        DetailFriends fef = new DetailFriends(); // 여언습

        public frmDBGridView()
        {
            InitializeComponent();
            this.lst = new List<Friends>();
        }

        private void frmDBGridView_Load(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\C#\MyWinformControl\MyWinformControl\friends.mdf;Integrated Security=True";
            //SqlConnection con = new SqlConnection(connectionString);

            //app.config 파일에 있는 연결문자열 정보를 읽어옴
            //string conStr = ConfigurationManager.ConnectionStrings["SQLConStr"].ConnectionString;
            //SqlConnection con = new SqlConnection(conStr);
            //con.Open();

            //MessageBox.Show(con.Database);
            //con.Close();


            //새로운 컬럼을 추가
            //this.friendView.Columns.Add("no", "번호");
            //this.friendView.Columns.Add("name", "이름");
            //this.friendView.Columns.Add("mobile", "전화번호");
            //this.friendView.Columns.Add("addr", "주소");



            //번호를 안보이게 하려면....
            //friendView.AutoGenerateColumns = false;
            //this.friendView.Columns.Add("name", "이름");
            //this.friendView.Columns.Add("mobile", "전화번호");
            //this.friendView.Columns.Add("addr", "주소");


            DisPlayFriends();
            GetRowCount();

            //DataTable table = new DataTable();
            //table.Columns.Add("ID");
            //table.Columns.Add("PassWord");
            //table.Columns.Add("LoginDate");

            //DataRow row = table.NewRow();
            //row["ID"] = "abc";
            //row["PassWord"] = "1234";
            //row["LoginDate"] = DateTime.Now.ToShortDateString();

            //table.Rows.Add(row);
            //dataGridView1.DataSource = table;

        }


        private DataTable friendsTab;

        private void DisPlayFriends()
        {
            this.lst.Clear();   // DB에서 다시 데이터를 가져오기 위해 컬렉션을 비움
            this.friendView.DataSource = null;  //그리드뷰 데이터 소스도 초기화 해줌

            friendsTab = new DataTable();
            friendsTab.Columns.Add("이름");
            friendsTab.Columns.Add("전화번호");
            friendsTab.Columns.Add("주소");
            friendsTab.Columns.Add("비고");

            string conStr = ConfigurationManager.ConnectionStrings["SQLConStr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetEntryFriends";

                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Friends f = new Friends(Int32.Parse(dr["no"].ToString()), dr["name"].ToString(), dr["mobile"].ToString(), dr["addr"].ToString());

                    // 생성자를 쓰거나 프로퍼티를 사용할 수 있음

                    this.lst.Add(new Friends(Int32.Parse(dr["no"].ToString()), dr["name"].ToString(), dr["mobile"].ToString(), dr["addr"].ToString(), dr["image"].ToString()));



                    DataRow row = friendsTab.NewRow();
                    row["이름"] = dr["name"].ToString();
                    row["전화번호"] = dr["mobile"].ToString();
                    row["주소"] = dr["addr"].ToString();


                    friendsTab.Rows.Add(row);
                }

                dr.Close();
                DBConnection.DBClose(con);

                this.friendView.DataSource = lst;


                this.dataGridView1.DataSource = friendsTab; // 그리드뷰에 컬렉션을 이용한 바인딩


                //바인딩하고 기존 컬럼을 변경
                friendView.Columns[0].HeaderText = "번호";
                friendView.Columns[1].HeaderText = "이름";
                friendView.Columns[2].HeaderText = "전화번호";
                friendView.Columns[3].HeaderText = "주소";
                friendView.Columns[4].HeaderText = "이미지경로";


                //friendView.Columns.RemoveAt(0);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 1) 유저에게 데이터를 입력받는 각 컨트롤에서 유저가 입력한 데이터를 가져와
            // 2) 유효성 검사를 한 후
            // 3) 유효성 검사에 통과한 데이터만 DB에 insert 한다.

            string name = this.txtName.Text.Replace(" ", "").Trim();
            string mobile = this.txtMobile.Text.Replace(" ", "").Trim();
            string addr = this.txtAddr.Text.Trim();
            string image = this.txtImage.Text.Trim();


            if (CheckNull(name, mobile) && CheckUnique(mobile))
            {
                //DB에 insert한다
                //MessageBox.Show("유효성 검사 성공");
                string conStr = ConfigurationManager.ConnectionStrings["SQLConStr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertFriends";

                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("mobile", mobile);
                    cmd.Parameters.AddWithValue("addr", addr);
                    cmd.Parameters.AddWithValue("image", image);


                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("저장 성공!", "주소록", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisPlayFriends();
                        this.txtName.Text = this.txtMobile.Text = this.txtAddr.Text = this.txtImage.Text = "";
                        this.isMobileChange = false;
                        prevMobile = "";
                        this.txtName.Focus();
                    }
                    con.Close();
                }

            }
        }
        private bool CheckUnique(string mobile)
        {
            //2)유효성 검사를 한 후
            bool check = false;

            string conStr = ConfigurationManager.ConnectionStrings["SQLConStr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CheckDuplicateMobile"; // 저장프로시저 명

                // 저장프로시저 파라메터 추가
                cmd.Parameters.AddWithValue("mobileNo", mobile);

                var dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {//중복되는 행이 있다면
                    ControlInit("전화번호가 중복되네요");
                    return check;
                }
                check = true;
            }
            return check;
        }

        private bool CheckNull(string name, string mobile)
        {
            bool check = false;
            //이름과 전화번호 항목이 널인지 검사
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mobile))
            {
                ControlInit("이름과 전화번호는 값을 반드시 입력하셔야 합니다");
                return check;
            }
            else
            {
                check = true;
            }

            return check;
        }

        private void ControlInit(string msg)
        {
            MessageBox.Show(msg, "주소록", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.txtName.Text = this.txtMobile.Text = "";
            this.txtName.Focus();
        }

        private void friendView_Click(object sender, EventArgs e)
        {
            if (this.friendView.SelectedRows.Count > 0)
            {
                this.txtName.Text = this.friendView.SelectedRows[0].Cells[1].Value.ToString();
                this.txtMobile.Text = this.friendView.SelectedRows[0].Cells[2].Value.ToString();
                this.txtAddr.Text = this.friendView.SelectedRows[0].Cells[3].Value.ToString();
                this.txtImage.Text = this.friendView.SelectedRows[0].Cells[4].Value.ToString();
                this.pk = Int32.Parse(this.friendView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string name = this.txtName.Text.Replace(" ", "").Trim();
            string mobile = this.txtMobile.Text.Replace(" ", "").Trim();
            string addr = this.txtAddr.Text.Trim();
            string image = this.txtImage.Text.Trim();

            if (isMobileChange)
            {
                //전화번호까지 수정 되었다 ! => 널 검사, 유니크검사 => 전화번호까지 수정 할 수 있는 쿼리
                if (CheckNull(name, mobile) && CheckUnique(mobile))
                {
                    UpdateProcess(name, mobile, addr, image);
                }
            }
            else
            {
                // 전화번호가 수정 안되었다 ! => 널 검사 => 전화번호까지 수정 할 수 있는 쿼리
                if (CheckNull(name, mobile))
                {
                    UpdateProcess(name, mobile, addr, image);
                }
            }
        }

        private void UpdateProcess(string name, string mobile, string addr, string image)
        {
            string conStr = ConfigurationManager.ConnectionStrings["SQLConStr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ModifyFriends";

                cmd.Parameters.AddWithValue("no", this.pk);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("mobile", mobile);
                cmd.Parameters.AddWithValue("addr", addr);
                cmd.Parameters.AddWithValue("image", image);


                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("수정 성공!", "주소록", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisPlayFriends();
                    this.txtName.Text = this.txtMobile.Text = this.txtAddr.Text = this.txtImage.Text = string.Empty;
                    this.isMobileChange = false;
                    this.prevMobile = "";
                    this.txtName.Focus();
                }
                con.Close();
            }
        }

        private void txtMobile_Click(object sender, EventArgs e)
        {
            this.prevMobile = this.txtMobile.Text;  // 전화번호 텍스트 값을 임시 변수에 저장
        }

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtMobile.Text == this.prevMobile) // 전화번호 값이 수정됨
            {
                this.isMobileChange = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["SQLConStr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteFriends";

                cmd.Parameters.AddWithValue("no", this.pk);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("삭제 성공!", "주소록", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisPlayFriends();
                    this.txtName.Text = this.txtMobile.Text = this.txtAddr.Text = string.Empty;
                    this.isMobileChange = false;
                    this.prevMobile = "";
                    this.txtName.Focus();
                }
                con.Close();
            }
        }

        private void friendView_DoubleClick(object sender, EventArgs e)
        {
            fef.FriendNo = this.pk;
            fef.FriendName = this.txtName.Text;
            fef.FriendMobile = this.txtMobile.Text;
            fef.FriendAddr = this.txtAddr.Text;
            fef.FriendImage = this.txtImage.Text;
            fef.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtImage.Text = this.openFileDialog1.FileName.ToString();
            }
        }
        private void GetRowCount()
        {
            string conStr = ConfigurationManager.ConnectionStrings["SQLConStr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetFriendsCount";

                int cntOfFriends = (int)cmd.ExecuteScalar();
                this.lblCount.Text += cntOfFriends + "명";

            }
        }
    }
}
