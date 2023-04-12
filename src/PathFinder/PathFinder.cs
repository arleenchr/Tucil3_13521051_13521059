using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.GraphViewerGdi;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.Core.ProjectionSolver;
using System.IO;

namespace PathFinder
{
    public partial class PathFinder : Form
    {
        public PathFinder()
        {
            InitializeComponent();
        }



        private void visualize(object sender, EventArgs e)
        {
            //create a viewer object
            GViewer viewer = new GViewer();
            //create a graph object  
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            // Generate map
            FileReader reader = new FileReader();
            Graph filegraph = reader.readFile(textBoxFile.Text);
            Vertex start, end;
            if (textBoxStart.Text == "")
            {
                start = filegraph.vertices[0];
            }
            else
            {
                start = filegraph.getVertex(textBoxStart.Text);
                if (start.locName == "notfound")
                {
                    labelNotif.Text = "Start/End not valid.";
                    return;
                }
            }
            if (textBoxEnd.Text == "")
            {
                end = filegraph.vertices[1];
            }
            else
            {
                end = filegraph.getVertex(textBoxEnd.Text);
                if (end.locName == "notfound")
                {
                    labelNotif.Text = "Start/End not valid.";
                    return;
                }
            }
            labelNotif.Text = "";
            listPlaces.Items.Clear();

            // isi textboxt dengan tempat
            for(int i = 0; i < filegraph.vertices.Count; i++)
            {
                listPlaces.Items.Add(filegraph.vertices[i].locName);
            }
            if (buttonUCS.Checked == true)
            {
                List<VertexPathCost> neigh;
                UCS u = new UCS(filegraph, start, end);
                u.UCSSolver();
                if (u.solution.Count == 0)
                {
                    labelNotif.Text = "No solution found";
                    return;
                }
                labelNotif.Text = "Distance: " + u.distance.ToString() + " m";

                // buat graf dari history
                Node nodestart = new Node(u.history[0].Item1.vertex.locName + " (" + u.history[0].Item1.cost.ToString() + ")");
                nodestart.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Yellow;
                if (u.solution.Count == 1)
                {
                    graph.AddNode(nodestart);
                }
                Node currentNode = nodestart;
                
                for (int i = 0; i < u.history.Count-1; i++)
                {
                    neigh = u.history[i].Item2;
                    // buat node tiap tetangga
                    for (int j = 0; j < neigh.Count; j++)
                    {
                        Microsoft.Msagl.Drawing.Node node = new Microsoft.Msagl.Drawing.Node(neigh[j].vertex.locName + " (" + neigh[j].cost.ToString() + ")");
                        graph.AddEdge(currentNode.Id, "", node.Id);
                    }
                    // cari current node selanjutnya
                    IEnumerable<Microsoft.Msagl.Drawing.Node> matchingNodes = graph.Nodes.Where(node => node.LabelText.Contains(u.history[i + 1].Item1.vertex.locName + " (" + u.history[i + 1].Item1.cost.ToString() + ")"));
                    foreach (Microsoft.Msagl.Drawing.Node node in matchingNodes)
                    {
                        currentNode = node;
                    }
                    //currentNode = graph.FindNode(u.history[i + 1].Item1.vertex.locName + " (" + u.history[i + 1].Item1.cost.ToString() + ")");
                    
                }

                // warnai solusi
                for (int i = 0; i < u.solution.Count-1; i++)
                {
                    IEnumerable<Microsoft.Msagl.Drawing.Node> matchingNodes = graph.Nodes.Where(node => node.LabelText.Contains(u.solution[i + 1].vertex.locName + " (" + u.solution[i + 1].cost.ToString() + ")"));
                    foreach (Microsoft.Msagl.Drawing.Node node in matchingNodes)
                    {
                        node.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Yellow;
                    }
                }

                IEnumerable<Microsoft.Msagl.Drawing.Node> matchingNodes2 = graph.Nodes.Where(node => node.LabelText.Contains(start.locName));
                foreach (Microsoft.Msagl.Drawing.Node node in matchingNodes2)
                {
                    node.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Yellow;
                }

                IEnumerable<Microsoft.Msagl.Drawing.Node> matchingNodes3 = graph.Nodes.Where(node => node.LabelText.Contains(end.locName + " (" + u.distance.ToString() +")"));
                foreach (Microsoft.Msagl.Drawing.Node node in matchingNodes3)
                {
                    node.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Yellow;
                }

            }
            if (buttonA.Checked == true)
            {
                labelNotif.Text = "";
                List<Vertex> neigh;
                Astar a = new Astar(filegraph, start, end);
                a.AstarSolver();
                if (a.solution.Count == 0)
                {
                    labelNotif.Text = "No solution found";
                    return;
                }
                labelNotif.Text = "Distance: " + a.distance.ToString() + " m";
                Microsoft.Msagl.Drawing.Node nodestart = new Microsoft.Msagl.Drawing.Node(1.ToString() + " " + a.solution[0].vertex.locName);
                if (a.solution.Count == 1)
                {
                    graph.AddNode(nodestart);
                }
                nodestart.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Yellow;
                Microsoft.Msagl.Drawing.Node currentNode = nodestart;
                for (int i = 0; i < a.solution.Count - 1; i++)
                {
                    // buat node tiap tetangga
                    neigh = filegraph.getNeighbour(a.solution[i].vertex);
                    for (int j = 0; j < neigh.Count; j++)
                    {
                        Microsoft.Msagl.Drawing.Node node = new Microsoft.Msagl.Drawing.Node((i + 2).ToString() + " " + neigh[j].locName);
                        graph.AddEdge(currentNode.Id, "", node.Id);
                    }
                    // current node menjadi solusi elemen selanjutnya
                    IEnumerable<Microsoft.Msagl.Drawing.Node> matchingNodes = graph.Nodes.Where(node => node.LabelText.Contains(a.solution[i + 1].vertex.locName));
                    foreach (Microsoft.Msagl.Drawing.Node node in matchingNodes)
                    {
                        currentNode = node;
                    }
                    currentNode.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Yellow;
                }

                IEnumerable<Microsoft.Msagl.Drawing.Node> matchingNodes2 = graph.Nodes.Where(node => node.LabelText.Contains(1.ToString() + " " + start.locName));
                foreach (Microsoft.Msagl.Drawing.Node node in matchingNodes2)
                {
                    node.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Yellow;
                }
            }


            //bind the graph to the viewer  
            viewer.Graph = graph;
            //associate the viewer with the form  
            panel1.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(viewer);
            panel1.ResumeLayout();
        }

        private void buttonVisualize_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            visualize(sender,e);
        }

        private void button_generate(object sender, EventArgs e)
        {
            try
            {
                listPlaces.Items.Clear();
                labelNotif.Text = "";
                FileReader reader = new FileReader();
                Graph filegraph = reader.readFile(textBoxFile.Text);
                // isi textboxt dengan tempat
                for (int i = 0; i < filegraph.vertices.Count; i++)
                {
                    listPlaces.Items.Add(filegraph.vertices[i].locName);
                }
            }
            catch (FileNotFoundException)
            {
                labelNotif.Text = "File Not Found.";
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxFile.Text = ofd.FileName;
            }
        }
    }
}