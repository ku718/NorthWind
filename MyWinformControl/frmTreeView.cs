using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinformControl
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void frmTreeView_Load_1(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode("전국"); // 트리 노드 객체 만들기
            //TreeNode seoul = new TreeNode("서울"); // 트리 노드 객체 만들기
            //TreeNode gyeonggi = new TreeNode("경기"); // 트리 노드 객체 만들기
            //TreeNode ulsan = new TreeNode("울산"); // 트리 노드 객체 만들기
            TreeNode[] area = new TreeNode[3];
            area[0] = new TreeNode("서울특별시");
            area[1] = new TreeNode("경기도");
            area[2] = new TreeNode("울산광역시");
            root.Nodes.AddRange(area);
            TreeNode[] seoul = new TreeNode[2];
            seoul[0] = new TreeNode("금천구");
            seoul[1] = new TreeNode("강남구");
            area[0].Nodes.AddRange(seoul);
            TreeNode[] gyeonggi = new TreeNode[3];
            gyeonggi[0] = new TreeNode("안산시");
            gyeonggi[1] = new TreeNode("안성시");
            gyeonggi[2] = new TreeNode("안양시");
            area[1].Nodes.AddRange(gyeonggi);
            myTreeView.Nodes.Add(root); // 트리 노드 객체를 트리뷰에 동적 생성
            //root.Nodes.Add(seoul);
            //root.Nodes.Add(gyeonggi);
            //root.Nodes.Add(ulsan);

            myTreeView.ExpandAll();     // 트리를 펼친다
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrinMyTreeView(myTreeView.Nodes[0]);
        }

        private void PrinMyTreeView(TreeNode tn)
        {
            this.label1.Text += tn.Text + ", "; // 출력

            foreach (TreeNode item in tn.Nodes)
            {
                PrinMyTreeView(item);
            }
        }
    }
}
