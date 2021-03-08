using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SZC.Alignment;
using SZC.Alignment.Entity;
using SZC.Geometry;
using TriangleNet;
using TriangleNet.Tools;
using TriangleNet.Topology;

namespace MeshExplorer
{
    public partial class QueryHeightForm : Form
    {
        Mesh mMesh;
        TriangleQuadTree tree;
        public QueryHeightForm(Mesh mesh)
        {
            mMesh = mesh;
            tree = new TriangleQuadTree(mMesh);
            InitializeComponent();
        }

        private void Btn_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "线路方案数据库(*.mdb)|*.mdb";
            if(openDlg.ShowDialog()==DialogResult.OK)
            {
                tbx_File.Text = openDlg.FileName;
            }
        }

        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_File.Text)) return;
            RailwayLine pRailLine = new RailwayLine();
            pRailLine.InitFromMDB(tbx_File.Text);
            Point3D pt = pRailLine.mBaseAlignment.GetPointByGhLc(tbx_GhLc.Text,0);
            //TriangleNet.Geometry.Point p = new TriangleNet.Geometry.Point(pt.X, pt.Y);
            
            tbx_Height.Text = tree.QueryHieght(pt.X, pt.Y).ToString();

        }
    }
}
