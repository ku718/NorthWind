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
    public partial class FrmDataSetCRUD : Form
    {
        private SqlDataAdapter adapter;
        private DataSet friendsSet;
        private DataTable friendsTable;
        private Friends tempFriend;

        public FrmDataSetCRUD()
        {
            InitializeComponent();
        }

        private void FrmDataSetCRUD_Load(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["SQLConStr"].ConnectionString;
            string selectCommand = "Select *from dbo.friends";

            adapter = new SqlDataAdapter(selectCommand, conStr);

            // insert, update, delete 문을 생성하는 메서드
            BuildCommand();


            friendsSet = new DataSet();
            adapter.Fill(friendsSet, "tblFriends");

            UpdateGridView();
        }

        /// <summary>
        /// insert, update, delete 커맨드를 생성
        /// </summary>
        private void BuildCommand()
        {
            SqlConnection con = adapter.SelectCommand.Connection;

            // insert
            adapter.InsertCommand = con.CreateCommand();
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.CommandText = "InsertFriends";
            AddParameter(adapter.InsertCommand, "name", "mobile", "addr");

            // update
            adapter.UpdateCommand = con.CreateCommand();
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adapter.UpdateCommand.CommandText = "ModifyFriends";
            AddParameter(adapter.UpdateCommand,"no", "name", "mobile", "addr");


            // delete
            adapter.DeleteCommand = con.CreateCommand();
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
            adapter.DeleteCommand.CommandText = "DeleteFriends";
            AddParameter(adapter.DeleteCommand, "no");


        }

        //params 키워드 : 가변인자 배열 (매개변수의 수가 변할 때 그 매개변수의 수 만큼의 배열이 만들어져 매개변수의 값이 배열로 넘겨져 온다.)
        private void AddParameter(SqlCommand cmd, params string[] cols)
        {
            foreach (string item in cols)
            {
                if (item =="no")
                {
                    cmd.Parameters.Add("@" + item, SqlDbType.Int, 0, item); 
                }
                else
                {
                    cmd.Parameters.Add("@" + item, SqlDbType.NVarChar, 0, item);
                }

            }
        }

        private void UpdateGridView()
        {
            friendsSet.Clear();
            adapter.Fill(friendsSet,"tblFriends");

            friendsTable = friendsSet.Tables["tblFriends"];
            this.gviewFriends.DataSource = null;

            //friendsTable.Columns.RemoveAt(0);
            gviewFriends.DataSource = friendsTable;
        }

        private void gviewFriends_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dt = friendsSet.Tables["tblFriends"].Rows[e.RowIndex];
            lblNum.Text = dt["no"].ToString();
            txtName.Text = dt["name"].ToString();
            txtAddr.Text = dt["addr"].ToString();
            txtPhone.Text = dt["mobile"].ToString();

            tempFriend = new Friends
            {
                No = Int32.Parse(lblNum.Text),
                Name = txtName.Text,
                Mobile = txtPhone.Text,
                Add = txtAddr.Text
            };

            btnUpdate.Enabled = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow newFriend = friendsTable.NewRow();
            newFriend["name"] = txtName.Text.Trim().Replace(" ", "");
            newFriend["mobile"] = txtPhone.Text.Trim().Replace(" ", "");
            newFriend["addr"] = txtAddr.Text.Trim();

            friendsTable.Rows.Add(newFriend);   //새로 만들어진 DataRow를 DataTable에 넣기

            try
            {
                adapter.Update(friendsSet, "tblFriends");
                MessageBox.Show("친구 저장이 되었습니다");
                friendsSet.AcceptChanges(); // commit

                UpdateGridView();

                ClearFields();
            }
            catch (SqlException)
            {
                friendsSet.RejectChanges(); // rollback
                MessageBox.Show("친구 저장에 실패 했습니다");
            }
        }
        private void ClearFields()
        {
            this.txtAddr.Text = this.txtPhone.Text = this.txtName.Text = String.Empty;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 업데이트 버튼을 누른 시점의 현재 라벨과 텍스트박스에서 친구 객체 만듬
            Friends modiFriend = new Friends
            {
                No = Int32.Parse(lblNum.Text),
                Name = txtName.Text,
                Mobile = txtPhone.Text,
                Add = txtAddr.Text
            };
            if (!tempFriend.Equals(modiFriend))
            {
                // update문 수행
                //MessageBox.Show("update가 실행 되어야 합니다");
                var index = gviewFriends.CurrentRow.Index;
                DataRow targetRow = friendsTable.Rows[index];

                targetRow.BeginEdit();  //변경된 사항이 있는지 추적
                targetRow["no"] = lblNum.Text;
                targetRow["name"] = txtName.Text;
                targetRow["mobile"] = txtPhone.Text;
                targetRow["addr"] = txtAddr.Text;
                targetRow.EndEdit();    // ----------------------------


                // 변경된 데이타셋 가져옴
                DataSet changeSet = friendsSet.GetChanges(DataRowState.Modified);

                if (changeSet.HasErrors)
                {
                    MessageBox.Show("수정된 내용에 에러가 있습니다");
                }
                else
                {
                    try
                    {
                        adapter.Update(changeSet, "tblFriends");
                        friendsSet.AcceptChanges(); //commit
                        MessageBox.Show("수정완료");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("수정이 완료 되지 못했습니다");
                        friendsSet.RejectChanges(); // rollback
                    }
                }
            }
            else
            {
                MessageBox.Show("업데이트 할 필요가 없다 !");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = gviewFriends.CurrentRow.Index;
            DataRow targetRow = friendsTable.Rows[index];

            targetRow.Delete();
            try
            {
                adapter.Update(friendsSet, "tblFriends");
                friendsSet.AcceptChanges(); // commit
                UpdateGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("삭제 실패");
                friendsSet.RejectChanges(); // rollback
            }
        }
    }
}
