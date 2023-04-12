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
            Graph filegraph = reader.readFile(textBoxFileName.Text);
            Vertex start, end;
            if (textBoxStart.Text == "")
            {
                start = filegraph.vertices[0];
            }
            else
            {
                start = filegraph.getVertex(textBoxStart.Text);
            }
            if (textBoxEnd.Text == "")
            {
                end = filegraph.vertices[1];
            }
            else
            {
                end = filegraph.getVertex(textBoxEnd.Text);
            }
            if (buttonUCS.Checked == true)
            {
                List<VertexPathCost> neigh;
                UCS u = new UCS(filegraph, start, end);
                u.UCSSolver();

                // buat graf dari history
                Node nodestart = new Node(u.history[0].Item1.vertex.locName + " (" + u.history[0].Item1.cost.ToString() + ")");
                for (int i = 0; i < u.history.Count; i++)
                {
                    neigh = u.history[i].Item2;
                    // buat node tiap tetangga
                    for (int j = 0; j < neigh.Count; j++)
                    {
                        Microsoft.Msagl.Drawing.Node node = new Microsoft.Msagl.Drawing.Node(neigh[j].vertex.locName + " (" + neigh[j]);

                        graph.AddEdge(u.history[i].Item2[j].vertex.locName, "", node.Id);
                    }
                    
                }

            }
            if (buttonA.Checked == true)
            {
                List<Vertex> neigh;
                Astar a = new Astar(filegraph, start, end);
                a.search();
                labelNotif.Text = "Distance: " + a.distance.ToString();
                Microsoft.Msagl.Drawing.Node nodestart = new Microsoft.Msagl.Drawing.Node(1.ToString() + " " + a.solution[0].locName);
                nodestart.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Yellow;
                Microsoft.Msagl.Drawing.Node currentNode = nodestart;
                for (int i = 0; i < a.solution.Count - 1; i++)
                {
                    // buat node tiap tetangga
                    neigh = filegraph.getNeighbour(a.solution[i]);
                    for (int j = 0; j < neigh.Count; j++)
                    {
                        Microsoft.Msagl.Drawing.Node node = new Microsoft.Msagl.Drawing.Node((i + 2).ToString() + " " + neigh[j].locName);
                        graph.AddEdge(currentNode.Id, "", node.Id);
                    }
                    // current node menjadi solusi elemen selanjutnya
                    IEnumerable<Microsoft.Msagl.Drawing.Node> matchingNodes = graph.Nodes.Where(node => node.LabelText.Contains(a.solution[i + 1].locName));
                    foreach (Microsoft.Msagl.Drawing.Node node in matchingNodes)
                    {
                        currentNode = node;
                    }
                    currentNode.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Yellow;
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
    }
}
