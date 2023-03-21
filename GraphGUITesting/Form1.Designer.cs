namespace GraphGUITesting
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkGridView = new System.Windows.Forms.DataGridView();
            this.nodeList = new System.Windows.Forms.ListView();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.Actions = new System.Windows.Forms.GroupBox();
            this.checkGreater = new System.Windows.Forms.RadioButton();
            this.findAllGreater = new System.Windows.Forms.RadioButton();
            this.execute = new System.Windows.Forms.Button();
            this.increaseBy = new System.Windows.Forms.RadioButton();
            this.checkForAllGreater = new System.Windows.Forms.RadioButton();
            this.checkGreaterNum = new System.Windows.Forms.TextBox();
            this.findAllNum = new System.Windows.Forms.TextBox();
            this.increaseByNum = new System.Windows.Forms.TextBox();
            this.checkAllNum = new System.Windows.Forms.TextBox();
            this.createGraph = new System.Windows.Forms.RadioButton();
            this.createOption = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.linkGridView)).BeginInit();
            this.Actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkGridView
            // 
            this.linkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linkGridView.Location = new System.Drawing.Point(12, 12);
            this.linkGridView.Name = "linkGridView";
            this.linkGridView.ReadOnly = true;
            this.linkGridView.RowHeadersWidth = 50;
            this.linkGridView.RowTemplate.Height = 24;
            this.linkGridView.Size = new System.Drawing.Size(541, 541);
            this.linkGridView.TabIndex = 0;
            // 
            // nodeList
            // 
            this.nodeList.HideSelection = false;
            this.nodeList.Location = new System.Drawing.Point(559, 12);
            this.nodeList.Name = "nodeList";
            this.nodeList.Size = new System.Drawing.Size(286, 512);
            this.nodeList.TabIndex = 1;
            this.nodeList.UseCompatibleStateImageBehavior = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(559, 530);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(103, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(742, 530);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(103, 23);
            this.remove.TabIndex = 3;
            this.remove.Text = "Убрать";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // Actions
            // 
            this.Actions.Controls.Add(this.createOption);
            this.Actions.Controls.Add(this.createGraph);
            this.Actions.Controls.Add(this.checkAllNum);
            this.Actions.Controls.Add(this.increaseByNum);
            this.Actions.Controls.Add(this.findAllNum);
            this.Actions.Controls.Add(this.checkGreaterNum);
            this.Actions.Controls.Add(this.checkForAllGreater);
            this.Actions.Controls.Add(this.increaseBy);
            this.Actions.Controls.Add(this.findAllGreater);
            this.Actions.Controls.Add(this.checkGreater);
            this.Actions.Location = new System.Drawing.Point(863, 12);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(293, 512);
            this.Actions.TabIndex = 4;
            this.Actions.TabStop = false;
            this.Actions.Text = "Действия";
            // 
            // checkGreater
            // 
            this.checkGreater.AutoSize = true;
            this.checkGreater.Location = new System.Drawing.Point(6, 47);
            this.checkGreater.Name = "checkGreater";
            this.checkGreater.Size = new System.Drawing.Size(127, 20);
            this.checkGreater.TabIndex = 0;
            this.checkGreater.TabStop = true;
            this.checkGreater.Text = "Есть ли больше";
            this.checkGreater.UseVisualStyleBackColor = true;
            // 
            // findAllGreater
            // 
            this.findAllGreater.AutoSize = true;
            this.findAllGreater.Location = new System.Drawing.Point(6, 75);
            this.findAllGreater.Name = "findAllGreater";
            this.findAllGreater.Size = new System.Drawing.Size(143, 20);
            this.findAllGreater.TabIndex = 1;
            this.findAllGreater.TabStop = true;
            this.findAllGreater.Text = "Найти все больше";
            this.findAllGreater.UseVisualStyleBackColor = true;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(1053, 530);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(103, 23);
            this.execute.TabIndex = 5;
            this.execute.Text = "Выполнить";
            this.execute.UseVisualStyleBackColor = true;
            // 
            // increaseBy
            // 
            this.increaseBy.AutoSize = true;
            this.increaseBy.Location = new System.Drawing.Point(6, 103);
            this.increaseBy.Name = "increaseBy";
            this.increaseBy.Size = new System.Drawing.Size(115, 20);
            this.increaseBy.TabIndex = 2;
            this.increaseBy.TabStop = true;
            this.increaseBy.Text = "Увеличить на";
            this.increaseBy.UseVisualStyleBackColor = true;
            // 
            // checkForAllGreater
            // 
            this.checkForAllGreater.AutoSize = true;
            this.checkForAllGreater.Location = new System.Drawing.Point(6, 131);
            this.checkForAllGreater.Name = "checkForAllGreater";
            this.checkForAllGreater.Size = new System.Drawing.Size(119, 20);
            this.checkForAllGreater.TabIndex = 3;
            this.checkForAllGreater.TabStop = true;
            this.checkForAllGreater.Text = "Все ли больше";
            this.checkForAllGreater.UseVisualStyleBackColor = true;
            // 
            // checkGreaterNum
            // 
            this.checkGreaterNum.Location = new System.Drawing.Point(187, 46);
            this.checkGreaterNum.Name = "checkGreaterNum";
            this.checkGreaterNum.Size = new System.Drawing.Size(100, 22);
            this.checkGreaterNum.TabIndex = 4;
            // 
            // findAllNum
            // 
            this.findAllNum.Location = new System.Drawing.Point(187, 74);
            this.findAllNum.Name = "findAllNum";
            this.findAllNum.Size = new System.Drawing.Size(100, 22);
            this.findAllNum.TabIndex = 5;
            // 
            // increaseByNum
            // 
            this.increaseByNum.Location = new System.Drawing.Point(187, 102);
            this.increaseByNum.Name = "increaseByNum";
            this.increaseByNum.Size = new System.Drawing.Size(100, 22);
            this.increaseByNum.TabIndex = 6;
            // 
            // checkAllNum
            // 
            this.checkAllNum.Location = new System.Drawing.Point(187, 130);
            this.checkAllNum.Name = "checkAllNum";
            this.checkAllNum.Size = new System.Drawing.Size(100, 22);
            this.checkAllNum.TabIndex = 7;
            // 
            // createGraph
            // 
            this.createGraph.AutoSize = true;
            this.createGraph.Location = new System.Drawing.Point(6, 21);
            this.createGraph.Name = "createGraph";
            this.createGraph.Size = new System.Drawing.Size(116, 20);
            this.createGraph.TabIndex = 8;
            this.createGraph.TabStop = true;
            this.createGraph.Text = "Создать граф";
            this.createGraph.UseVisualStyleBackColor = true;
            // 
            // createOption
            // 
            this.createOption.FormattingEnabled = true;
            this.createOption.Items.AddRange(new object[] {
            "на массиве",
            "на списке"});
            this.createOption.Location = new System.Drawing.Point(187, 17);
            this.createOption.Name = "createOption";
            this.createOption.Size = new System.Drawing.Size(100, 24);
            this.createOption.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 565);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.nodeList);
            this.Controls.Add(this.linkGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.linkGridView)).EndInit();
            this.Actions.ResumeLayout(false);
            this.Actions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView linkGridView;
        private System.Windows.Forms.ListView nodeList;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        public System.Windows.Forms.GroupBox Actions;
        private System.Windows.Forms.RadioButton findAllGreater;
        private System.Windows.Forms.RadioButton checkGreater;
        private System.Windows.Forms.RadioButton increaseBy;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.TextBox checkAllNum;
        private System.Windows.Forms.TextBox increaseByNum;
        private System.Windows.Forms.TextBox findAllNum;
        private System.Windows.Forms.TextBox checkGreaterNum;
        private System.Windows.Forms.RadioButton checkForAllGreater;
        private System.Windows.Forms.ComboBox createOption;
        private System.Windows.Forms.RadioButton createGraph;
    }
}

