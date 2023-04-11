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
                UCS ucs = new UCS(filegraph, start, end);
                ucs.UCSSolver();

            }
            if (buttonA.Checked == true)
            {
                List<Vertex> neigh;
                Astar a = new Astar(filegraph, start, end);
                a.search();
                for(int i = 0; i < a.solution.Count-1; i++)
                {
                    graph.AddEdge(a.solution[i].locName, a.solution[i + 1].locName);
                    neigh = filegraph.getNeighbour(a.solution[i]);
                    for(int j = 0; j < neigh.Count; j++)
                    {
                        graph.AddEdge(a.solution[i].locName, neigh[i].locName);
                        /*
                        if (graph.FindNode(neigh[i].locName) == null)
                        {
                            graph.AddEdge(a.solution[i].locName, neigh[i].locName);
                        }
                        else
                        {
                            graph.AddEdge(a.solution[i].locName, neigh[i].locName + " ");
                        }*/
                    }
                }
                graph.FindNode(start.locName).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Yellow;
                graph.FindNode(end.locName).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Yellow;
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
