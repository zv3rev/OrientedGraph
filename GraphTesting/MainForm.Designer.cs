namespace GraphTesting
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.linkGrid = new System.Windows.Forms.DataGridView();
            this.actions = new System.Windows.Forms.GroupBox();
            this.turnUnmutable = new System.Windows.Forms.RadioButton();
            this.dijkstraNum2 = new System.Windows.Forms.TextBox();
            this.dijkstraNum1 = new System.Windows.Forms.TextBox();
            this.dijkstra = new System.Windows.Forms.RadioButton();
            this.depthFirst = new System.Windows.Forms.RadioButton();
            this.depthFirstNum = new System.Windows.Forms.TextBox();
            this.breadthFirstNum = new System.Windows.Forms.TextBox();
            this.breadthFirst = new System.Windows.Forms.RadioButton();
            this.changeNodeNum = new System.Windows.Forms.TextBox();
            this.addNode = new System.Windows.Forms.RadioButton();
            this.changeNode = new System.Windows.Forms.RadioButton();
            this.deleteNode = new System.Windows.Forms.RadioButton();
            this.graphType = new System.Windows.Forms.ComboBox();
            this.checkAllGreaterNum = new System.Windows.Forms.TextBox();
            this.increaseByNum = new System.Windows.Forms.TextBox();
            this.findGreaterNum = new System.Windows.Forms.TextBox();
            this.checkGreaterNum = new System.Windows.Forms.TextBox();
            this.checkAllGreater = new System.Windows.Forms.RadioButton();
            this.increaseBy = new System.Windows.Forms.RadioButton();
            this.findGreater = new System.Windows.Forms.RadioButton();
            this.checkGreater = new System.Windows.Forms.RadioButton();
            this.createGraph = new System.Windows.Forms.RadioButton();
            this.nodeList = new System.Windows.Forms.ListView();
            this.execute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.linkGrid)).BeginInit();
            this.actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkGrid
            // 
            this.linkGrid.AllowUserToAddRows = false;
            this.linkGrid.AllowUserToDeleteRows = false;
            this.linkGrid.AllowUserToResizeColumns = false;
            this.linkGrid.AllowUserToResizeRows = false;
            this.linkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linkGrid.Location = new System.Drawing.Point(12, 12);
            this.linkGrid.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.linkGrid.Name = "linkGrid";
            this.linkGrid.RowHeadersWidth = 50;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.linkGrid.RowTemplate.Height = 29;
            this.linkGrid.ShowEditingIcon = false;
            this.linkGrid.Size = new System.Drawing.Size(426, 427);
            this.linkGrid.TabIndex = 0;
            this.linkGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.linkGrid_CellEndEdit);
            // 
            // actions
            // 
            this.actions.Controls.Add(this.turnUnmutable);
            this.actions.Controls.Add(this.dijkstraNum2);
            this.actions.Controls.Add(this.dijkstraNum1);
            this.actions.Controls.Add(this.dijkstra);
            this.actions.Controls.Add(this.depthFirst);
            this.actions.Controls.Add(this.depthFirstNum);
            this.actions.Controls.Add(this.breadthFirstNum);
            this.actions.Controls.Add(this.breadthFirst);
            this.actions.Controls.Add(this.changeNodeNum);
            this.actions.Controls.Add(this.addNode);
            this.actions.Controls.Add(this.changeNode);
            this.actions.Controls.Add(this.deleteNode);
            this.actions.Controls.Add(this.graphType);
            this.actions.Controls.Add(this.checkAllGreaterNum);
            this.actions.Controls.Add(this.increaseByNum);
            this.actions.Controls.Add(this.findGreaterNum);
            this.actions.Controls.Add(this.checkGreaterNum);
            this.actions.Controls.Add(this.checkAllGreater);
            this.actions.Controls.Add(this.increaseBy);
            this.actions.Controls.Add(this.findGreater);
            this.actions.Controls.Add(this.checkGreater);
            this.actions.Controls.Add(this.createGraph);
            this.actions.Location = new System.Drawing.Point(748, 4);
            this.actions.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.actions.Name = "actions";
            this.actions.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.actions.Size = new System.Drawing.Size(309, 400);
            this.actions.TabIndex = 1;
            this.actions.TabStop = false;
            this.actions.Text = "Действия";
            // 
            // turnUnmutable
            // 
            this.turnUnmutable.AutoSize = true;
            this.turnUnmutable.Enabled = false;
            this.turnUnmutable.Location = new System.Drawing.Point(4, 281);
            this.turnUnmutable.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.turnUnmutable.Name = "turnUnmutable";
            this.turnUnmutable.Size = new System.Drawing.Size(191, 24);
            this.turnUnmutable.TabIndex = 21;
            this.turnUnmutable.Text = "Сделать имутабельным";
            this.turnUnmutable.UseVisualStyleBackColor = true;
            // 
            // dijkstraNum2
            // 
            this.dijkstraNum2.Location = new System.Drawing.Point(252, 251);
            this.dijkstraNum2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dijkstraNum2.Name = "dijkstraNum2";
            this.dijkstraNum2.Size = new System.Drawing.Size(57, 27);
            this.dijkstraNum2.TabIndex = 20;
            // 
            // dijkstraNum1
            // 
            this.dijkstraNum1.Location = new System.Drawing.Point(189, 251);
            this.dijkstraNum1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dijkstraNum1.Name = "dijkstraNum1";
            this.dijkstraNum1.Size = new System.Drawing.Size(57, 27);
            this.dijkstraNum1.TabIndex = 19;
            // 
            // dijkstra
            // 
            this.dijkstra.AutoSize = true;
            this.dijkstra.Enabled = false;
            this.dijkstra.Location = new System.Drawing.Point(4, 251);
            this.dijkstra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dijkstra.Name = "dijkstra";
            this.dijkstra.Size = new System.Drawing.Size(167, 24);
            this.dijkstra.TabIndex = 18;
            this.dijkstra.Text = "Алгоритм Дийкстры";
            this.dijkstra.UseVisualStyleBackColor = true;
            // 
            // depthFirst
            // 
            this.depthFirst.AutoSize = true;
            this.depthFirst.Enabled = false;
            this.depthFirst.Location = new System.Drawing.Point(6, 219);
            this.depthFirst.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.depthFirst.Name = "depthFirst";
            this.depthFirst.Size = new System.Drawing.Size(153, 24);
            this.depthFirst.TabIndex = 17;
            this.depthFirst.Text = "Обход в глубину с";
            this.depthFirst.UseVisualStyleBackColor = true;
            // 
            // depthFirstNum
            // 
            this.depthFirstNum.Location = new System.Drawing.Point(189, 219);
            this.depthFirstNum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.depthFirstNum.Name = "depthFirstNum";
            this.depthFirstNum.Size = new System.Drawing.Size(120, 27);
            this.depthFirstNum.TabIndex = 16;
            // 
            // breadthFirstNum
            // 
            this.breadthFirstNum.Location = new System.Drawing.Point(189, 188);
            this.breadthFirstNum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.breadthFirstNum.Name = "breadthFirstNum";
            this.breadthFirstNum.Size = new System.Drawing.Size(120, 27);
            this.breadthFirstNum.TabIndex = 15;
            // 
            // breadthFirst
            // 
            this.breadthFirst.AutoSize = true;
            this.breadthFirst.Enabled = false;
            this.breadthFirst.Location = new System.Drawing.Point(6, 189);
            this.breadthFirst.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.breadthFirst.Name = "breadthFirst";
            this.breadthFirst.Size = new System.Drawing.Size(153, 24);
            this.breadthFirst.TabIndex = 14;
            this.breadthFirst.Text = "Обход в ширину с";
            this.breadthFirst.UseVisualStyleBackColor = true;
            // 
            // changeNodeNum
            // 
            this.changeNodeNum.Location = new System.Drawing.Point(148, 339);
            this.changeNodeNum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.changeNodeNum.Name = "changeNodeNum";
            this.changeNodeNum.Size = new System.Drawing.Size(120, 27);
            this.changeNodeNum.TabIndex = 13;
            // 
            // addNode
            // 
            this.addNode.AutoSize = true;
            this.addNode.Enabled = false;
            this.addNode.Location = new System.Drawing.Point(4, 309);
            this.addNode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addNode.Name = "addNode";
            this.addNode.Size = new System.Drawing.Size(128, 24);
            this.addNode.TabIndex = 12;
            this.addNode.Text = "Добавить узел";
            this.addNode.UseVisualStyleBackColor = true;
            // 
            // changeNode
            // 
            this.changeNode.AutoSize = true;
            this.changeNode.Enabled = false;
            this.changeNode.Location = new System.Drawing.Point(6, 340);
            this.changeNode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.changeNode.Name = "changeNode";
            this.changeNode.Size = new System.Drawing.Size(130, 24);
            this.changeNode.TabIndex = 11;
            this.changeNode.Text = "Изменить узел";
            this.changeNode.UseVisualStyleBackColor = true;
            // 
            // deleteNode
            // 
            this.deleteNode.AutoSize = true;
            this.deleteNode.Enabled = false;
            this.deleteNode.Location = new System.Drawing.Point(6, 371);
            this.deleteNode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.deleteNode.Name = "deleteNode";
            this.deleteNode.Size = new System.Drawing.Size(117, 24);
            this.deleteNode.TabIndex = 10;
            this.deleteNode.Text = "Удалить узел";
            this.deleteNode.UseVisualStyleBackColor = true;
            // 
            // graphType
            // 
            this.graphType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.graphType.FormattingEnabled = true;
            this.graphType.Items.AddRange(new object[] {
            "на массиве",
            "на списке"});
            this.graphType.Location = new System.Drawing.Point(189, 25);
            this.graphType.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.graphType.Name = "graphType";
            this.graphType.Size = new System.Drawing.Size(120, 28);
            this.graphType.TabIndex = 9;
            // 
            // checkAllGreaterNum
            // 
            this.checkAllGreaterNum.Location = new System.Drawing.Point(189, 157);
            this.checkAllGreaterNum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkAllGreaterNum.Name = "checkAllGreaterNum";
            this.checkAllGreaterNum.Size = new System.Drawing.Size(120, 27);
            this.checkAllGreaterNum.TabIndex = 8;
            // 
            // increaseByNum
            // 
            this.increaseByNum.Location = new System.Drawing.Point(189, 123);
            this.increaseByNum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.increaseByNum.Name = "increaseByNum";
            this.increaseByNum.Size = new System.Drawing.Size(120, 27);
            this.increaseByNum.TabIndex = 7;
            // 
            // findGreaterNum
            // 
            this.findGreaterNum.Location = new System.Drawing.Point(189, 90);
            this.findGreaterNum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.findGreaterNum.Name = "findGreaterNum";
            this.findGreaterNum.Size = new System.Drawing.Size(120, 27);
            this.findGreaterNum.TabIndex = 6;
            // 
            // checkGreaterNum
            // 
            this.checkGreaterNum.Location = new System.Drawing.Point(189, 58);
            this.checkGreaterNum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkGreaterNum.Name = "checkGreaterNum";
            this.checkGreaterNum.Size = new System.Drawing.Size(120, 27);
            this.checkGreaterNum.TabIndex = 5;
            // 
            // checkAllGreater
            // 
            this.checkAllGreater.AutoSize = true;
            this.checkAllGreater.Enabled = false;
            this.checkAllGreater.Location = new System.Drawing.Point(6, 157);
            this.checkAllGreater.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkAllGreater.Name = "checkAllGreater";
            this.checkAllGreater.Size = new System.Drawing.Size(130, 24);
            this.checkAllGreater.TabIndex = 4;
            this.checkAllGreater.Text = "Все ли больше";
            this.checkAllGreater.UseVisualStyleBackColor = true;
            // 
            // increaseBy
            // 
            this.increaseBy.AutoSize = true;
            this.increaseBy.Enabled = false;
            this.increaseBy.Location = new System.Drawing.Point(6, 123);
            this.increaseBy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.increaseBy.Name = "increaseBy";
            this.increaseBy.Size = new System.Drawing.Size(121, 24);
            this.increaseBy.TabIndex = 3;
            this.increaseBy.Text = "Увеличить на";
            this.increaseBy.UseVisualStyleBackColor = true;
            // 
            // findGreater
            // 
            this.findGreater.AutoSize = true;
            this.findGreater.Enabled = false;
            this.findGreater.Location = new System.Drawing.Point(6, 92);
            this.findGreater.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.findGreater.Name = "findGreater";
            this.findGreater.Size = new System.Drawing.Size(128, 24);
            this.findGreater.TabIndex = 2;
            this.findGreater.Text = "Найти больше";
            this.findGreater.UseVisualStyleBackColor = true;
            // 
            // checkGreater
            // 
            this.checkGreater.AutoSize = true;
            this.checkGreater.Enabled = false;
            this.checkGreater.Location = new System.Drawing.Point(6, 59);
            this.checkGreater.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkGreater.Name = "checkGreater";
            this.checkGreater.Size = new System.Drawing.Size(135, 24);
            this.checkGreater.TabIndex = 1;
            this.checkGreater.Text = "Есть ли больше";
            this.checkGreater.UseVisualStyleBackColor = true;
            // 
            // createGraph
            // 
            this.createGraph.AutoSize = true;
            this.createGraph.Location = new System.Drawing.Point(6, 29);
            this.createGraph.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.createGraph.Name = "createGraph";
            this.createGraph.Size = new System.Drawing.Size(119, 24);
            this.createGraph.TabIndex = 0;
            this.createGraph.Text = "Создать граф";
            this.createGraph.UseVisualStyleBackColor = true;
            // 
            // nodeList
            // 
            this.nodeList.Location = new System.Drawing.Point(444, 12);
            this.nodeList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nodeList.Name = "nodeList";
            this.nodeList.Size = new System.Drawing.Size(296, 425);
            this.nodeList.TabIndex = 2;
            this.nodeList.UseCompatibleStateImageBehavior = false;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(906, 411);
            this.execute.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(116, 28);
            this.execute.TabIndex = 5;
            this.execute.Text = "Выполнить";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 451);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.nodeList);
            this.Controls.Add(this.actions);
            this.Controls.Add(this.linkGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.linkGrid)).EndInit();
            this.actions.ResumeLayout(false);
            this.actions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView linkGrid;
        private GroupBox actions;
        private ComboBox graphType;
        private TextBox checkAllGreaterNum;
        private TextBox increaseByNum;
        private TextBox findGreaterNum;
        private TextBox checkGreaterNum;
        private RadioButton checkAllGreater;
        private RadioButton increaseBy;
        private RadioButton findGreater;
        private RadioButton checkGreater;
        private RadioButton createGraph;
        private ListView nodeList;
        private Button execute;
        private RadioButton addNode;
        private RadioButton changeNode;
        private RadioButton deleteNode;
        private TextBox changeNodeNum;
        private RadioButton breadthFirst;
        private TextBox breadthFirstNum;
        private RadioButton depthFirst;
        private TextBox depthFirstNum;
        private TextBox dijkstraNum2;
        private TextBox dijkstraNum1;
        private RadioButton dijkstra;
        private RadioButton turnUnmutable;
    }
}