using OrientedGraph;
using OrientedGraph.GraphException;
namespace GraphTesting
{
    public partial class MainForm : Form
    {
        IGraph<int,int> graph;


        public MainForm()
        {
            InitializeComponent();
            createGraph.Checked = true;
            graphType.SelectedIndex = 0; 
        }

        private void execute_Click(object sender, EventArgs e)
        {
            try
            {
                if (createGraph.Checked)
                {
                    switch (graphType.SelectedIndex)
                    {
                        case 0:
                            graph = new ArrayGraph<int, int>(10);
                            break;
                        case 1:
                            graph = new LinkedGraph<int, int>();
                            break;
                        default:
                            break;
                    }

                    checkGreater.Enabled = true;
                    findGreater.Enabled = true;
                    increaseBy.Enabled = true;
                    checkAllGreater.Enabled = true;
                    addNode.Enabled = true;
                    changeNode.Enabled = true;
                    deleteNode.Enabled = true;
                    breadthFirst.Enabled = true;
                    depthFirst.Enabled = true;
                    dijkstra.Enabled = true;
                    turnUnmutable.Enabled = true;
                    DrawNodes();
                    return;
                }

                if (checkGreater.Checked)
                {
                    int num;
                    if (Int32.TryParse(checkGreaterNum.Text, out num))
                    {
                        MessageBox.Show(GraphUtils<int, int>.Exists(graph, (node) => node.NodeInfo > num).ToString());
                    }
                    else
                    {
                        MessageBox.Show("Не удается преобразовать в число.");
                    }
                    return;
                }

                if (findGreater.Checked)
                {
                    int num;
                    if (Int32.TryParse(findGreaterNum.Text, out num))
                    {
                        LinkedGraph<int, int> result = (LinkedGraph<int, int>)GraphUtils<int, int>.FindAll(graph, (node) => node.NodeInfo > num, GraphUtils<int, int>.LinkedGraphConstructorDelegate);
                        string str = "";
                        foreach (int info in result)
                        {
                            str += info + " ";
                        }

                        MessageBox.Show(str);

                    }
                    else
                    {
                        MessageBox.Show("Не удается преобразовать в число.");
                    }
                    return;
                }

                if (increaseBy.Checked)
                {
                    int num;
                    if (Int32.TryParse(increaseByNum.Text, out num))
                    {
                        GraphUtils<int, int>.ForEach(graph, (node) => node.NodeInfo += num);
                    }
                    else
                    {
                        MessageBox.Show("Не удается преобразовать в число.");

                    }
                    DrawNodes();
                    return;
                }

                if (checkAllGreater.Checked)
                {
                    int num;
                    if (Int32.TryParse(checkAllGreaterNum.Text, out num))
                    {
                        MessageBox.Show(GraphUtils<int, int>.CheckForAll(graph, (node) => node.NodeInfo > num).ToString());
                    }
                    else
                    {
                        MessageBox.Show("Не удается преобразовать в число.");
                    }
                    return;
                }

                if (breadthFirst.Checked)
                {
                    if (Int32.TryParse(breadthFirstNum.Text, out int nodeId))
                    {
                        try
                        {
                            List<IGraphNode<int>> list = graph.Nodes.ToList();
                            list.RemoveAll((node) => node == null);

                            string order = "";
                            GraphUtils<int, int>.BreadthFirstSearch(graph, list[nodeId], (node) => { order += list.IndexOf(node) + " - "; return false; });

                            MessageBox.Show(order);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("ID узла не корректен");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удается преобразовать в число.");
                    }
                }

                if (depthFirst.Checked)
                {
                    if (Int32.TryParse(depthFirstNum.Text, out int nodeId))
                    {
                        try
                        {
                            List<IGraphNode<int>> list = graph.Nodes.ToList();
                            list.RemoveAll((node) => node == null);

                            string order = "";
                            GraphUtils<int, int>.DepthFirstSearch(graph, list[nodeId], (node) => { order += list.IndexOf(node) + " - "; return false; });

                            MessageBox.Show(order);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("ID узла не корректен");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удается преобразовать в число.");
                    }
                }

                if (dijkstra.Checked)
                {
                    if (Int32.TryParse(dijkstraNum1.Text, out int startId) && Int32.TryParse(dijkstraNum2.Text, out int endId))
                    {
                        try
                        {
                            List<IGraphNode<int>> list = graph.Nodes.ToList();
                            list.RemoveAll((node) => node == null);

                            int? result = GraphUtils<int, int>.Dijkstra(graph, list[startId], list[endId]);

                            MessageBox.Show(result != null ? result.ToString() : "Нет пути");
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("ID узла не корректен");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удается преобразовать в число.");
                    }
                }

                if (turnUnmutable.Checked)
                {
                    graph = new UnmutableGraph<int, int>(graph);
                }

                if (addNode.Checked)
                {
                    NodeVisualizer visualizer = new NodeVisualizer(StartOption.Add);
                    if (visualizer.ShowDialog() == DialogResult.OK)
                    {
                        graph.AddNode(visualizer.nodeInformation);
                        DrawNodes();
                    }
                }

                if (changeNode.Checked)
                {
                    int num;
                    if (Int32.TryParse(changeNodeNum.Text, out num))
                    {
                        try
                        {
                            List<IGraphNode<int>> list = graph.Nodes.ToList();
                            list.RemoveAll((node) => node == null);
                            NodeVisualizer visualizer = new NodeVisualizer(StartOption.Edit) { nodeId = num, nodeInformation = list[num].NodeInfo };
                            visualizer.UpdateInfo();
                            if (visualizer.ShowDialog() == DialogResult.OK)
                            {
                                list[num].NodeInfo = visualizer.nodeInformation;
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("ID узла не корректен");
                        }
                        DrawNodes();
                    }
                    else
                    {
                        MessageBox.Show("Не удается преобразовать в число.");
                    }
                }

                if (deleteNode.Checked)
                {
                    NodeVisualizer visualizer = new NodeVisualizer(StartOption.Delete);
                    if (visualizer.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            List<IGraphNode<int>> list = graph.Nodes.ToList();
                            list.RemoveAll((node) => node == null);
                            graph.RemoveNode(list[visualizer.nodeId]);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("ID узла не корректен");
                        }
                        DrawNodes();
                    }
                }
            }
            catch (UnmutableGraphChangeException)
            {
                MessageBox.Show("Попытка изменения имутабельного графа");
            }

            
        }

        private void DrawNodes()
        {
            List<IGraphNode<int>> list = graph.Nodes.ToList();
            list.RemoveAll((node) => node == null);

            nodeList.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                nodeList.Items.Add($"{i}: {list[i].NodeInfo}");
            }

            if (list.Count != linkGrid.ColumnCount)
            {
                linkGrid.Columns.Clear();
                linkGrid.Rows.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    linkGrid.Columns.Add($"{i}", $"{i}");
                    linkGrid.Columns[i].Width = 35;
                    linkGrid.Rows.Add();
                    linkGrid.Rows[i].HeaderCell.Value = i.ToString();
                    linkGrid.Rows[i].Height = 35;
                }

            }

            for (int i = 0; i < linkGrid.ColumnCount; i++)
            {
                for (int j = 0; j < linkGrid.ColumnCount; j++)
                {
                    linkGrid.Rows[i].Cells[j].Value = graph.HasLink(list[i], list[j], out int link) && link!=0? link : null;                   
                }
            }
        }

        private void linkGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool hasLink = linkGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null;
            if (!Int32.TryParse(linkGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out int link))
            {
                linkGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
            }
            

            List<IGraphNode<int>> list = graph.Nodes.ToList();
            list.RemoveAll((node) => node == null);
            try
            {
                graph.AddLink(list[e.RowIndex], list[e.ColumnIndex], link);
            }
            catch (UnmutableGraphChangeException)
            {
                MessageBox.Show("Попытка изменения имутабельного графа");
            }

            DrawNodes();
        }
    }
}